import { fileURLToPath, URL } from 'node:url';

import { defineConfig } from 'vite';
import plugin from '@vitejs/plugin-vue';
import fs from 'fs';
import path from 'path';
import child_process from 'child_process';
import { env } from 'process';
//element按需引入
import AutoImport from 'unplugin-auto-import/vite';
import Components from 'unplugin-vue-components/vite';
import { ElementPlusResolver } from 'unplugin-vue-components/resolvers';
// import VuetifyPlugin from 'vite-plugin-vuetify';

const baseFolder =
    env.APPDATA !== undefined && env.APPDATA !== ''
        ? `${env.APPDATA}/ASP.NET/https`
        : `${env.HOME}/.aspnet/https`;

const certificateName = 'team1frontend.client';
const certFilePath = path.join(baseFolder, `${certificateName}.pem`);
const keyFilePath = path.join(baseFolder, `${certificateName}.key`);

if (!fs.existsSync(certFilePath) || !fs.existsSync(keyFilePath)) {
    if (
        0 !==
        child_process.spawnSync(
            'dotnet',
            [
                'dev-certs',
                'https',
                '--export-path',
                certFilePath,
                '--format',
                'Pem',
                '--no-password',
            ],
            { stdio: 'inherit' }
        ).status
    ) {
        throw new Error('Could not create certificate.');
    }
}

const target = env.ASPNETCORE_HTTPS_PORT
    ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}`
    : env.ASPNETCORE_URLS
    ? env.ASPNETCORE_URLS.split(';')[0]
    : 'https://localhost:7113';

// console.log(keyFilePath, '|||||', certFilePath);
// console.log(target);
// https://vitejs.dev/config/
export default defineConfig({
    plugins: [
        plugin(),
        AutoImport({
            resolvers: [ElementPlusResolver()],
        }),
        Components({
            resolvers: [ElementPlusResolver()],
        }),
    ],
    resolve: {
        alias: {
            '@': fileURLToPath(new URL('./src', import.meta.url)),
        },
    },
    server: {
        proxy: {
            '^/api': {
                // 這裡的設定是將所有以 /api 開頭的請求轉發到目標伺服器，這樣就可以解決跨域問題
                target,
                secure: false, // 這個選項是因為我們使用的是自簽憑證，如果選擇使用正式簽發的憑證，可以將這個選項設置為 true，開發環境下建議設置為 false，可以避免一些不必要的問題，例如以下的問題，如果設置為 true，則會報錯，因為自簽憑證不被信任
            },
        },
        port: 5173,
        https: {
            key: fs.readFileSync(keyFilePath),
            cert: fs.readFileSync(certFilePath),
        },
    },

    css: ['https://cdn.jsdelivr.net/npm/vuetify@3.5.8/dist/vuetify-labs.css'],
});
