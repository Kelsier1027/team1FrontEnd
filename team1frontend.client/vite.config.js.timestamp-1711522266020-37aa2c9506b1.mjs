// vite.config.js
import { fileURLToPath, URL } from "node:url";
import { defineConfig } from "file:///C:/Users/asd22/OneDrive/%E6%A1%8C%E9%9D%A2/Vue.new/team1frontend.client/node_modules/vite/dist/node/index.js";
import plugin from "file:///C:/Users/asd22/OneDrive/%E6%A1%8C%E9%9D%A2/Vue.new/team1frontend.client/node_modules/@vitejs/plugin-vue/dist/index.mjs";
import fs from "fs";
import path from "path";
import child_process from "child_process";
import { env } from "process";
import AutoImport from "file:///C:/Users/asd22/OneDrive/%E6%A1%8C%E9%9D%A2/Vue.new/team1frontend.client/node_modules/unplugin-auto-import/dist/vite.js";
import Components from "file:///C:/Users/asd22/OneDrive/%E6%A1%8C%E9%9D%A2/Vue.new/team1frontend.client/node_modules/unplugin-vue-components/dist/vite.js";
import { ElementPlusResolver } from "file:///C:/Users/asd22/OneDrive/%E6%A1%8C%E9%9D%A2/Vue.new/team1frontend.client/node_modules/unplugin-vue-components/dist/resolvers.js";
var __vite_injected_original_import_meta_url = "file:///C:/Users/asd22/OneDrive/%E6%A1%8C%E9%9D%A2/Vue.new/team1frontend.client/vite.config.js";
var baseFolder = env.APPDATA !== void 0 && env.APPDATA !== "" ? `${env.APPDATA}/ASP.NET/https` : `${env.HOME}/.aspnet/https`;
var certificateName = "team1frontend.client";
var certFilePath = path.join(baseFolder, `${certificateName}.pem`);
var keyFilePath = path.join(baseFolder, `${certificateName}.key`);
if (!fs.existsSync(certFilePath) || !fs.existsSync(keyFilePath)) {
  if (0 !== child_process.spawnSync(
    "dotnet",
    [
      "dev-certs",
      "https",
      "--export-path",
      certFilePath,
      "--format",
      "Pem",
      "--no-password"
    ],
    { stdio: "inherit" }
  ).status) {
    throw new Error("Could not create certificate.");
  }
}
var target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` : env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(";")[0] : "https://localhost:7113";
var vite_config_default = defineConfig({
  plugins: [
    plugin(),
    AutoImport({
      resolvers: [ElementPlusResolver()]
    }),
    Components({
      resolvers: [ElementPlusResolver()]
    })
  ],
  resolve: {
    alias: {
      "@": fileURLToPath(new URL("./src", __vite_injected_original_import_meta_url))
    }
  },
  server: {
    proxy: {
      "^/weatherforecast": {
        target,
        secure: false
      }
    },
    port: 5173,
    https: {
      key: fs.readFileSync(keyFilePath),
      cert: fs.readFileSync(certFilePath)
    }
  },
  css: ["https://cdn.jsdelivr.net/npm/vuetify@3.5.8/dist/vuetify-labs.css"]
});
export {
  vite_config_default as default
};
//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAic291cmNlcyI6IFsidml0ZS5jb25maWcuanMiXSwKICAic291cmNlc0NvbnRlbnQiOiBbImNvbnN0IF9fdml0ZV9pbmplY3RlZF9vcmlnaW5hbF9kaXJuYW1lID0gXCJDOlxcXFxVc2Vyc1xcXFxhc2QyMlxcXFxPbmVEcml2ZVxcXFxcdTY4NENcdTk3NjJcXFxcVnVlLm5ld1xcXFx0ZWFtMWZyb250ZW5kLmNsaWVudFwiO2NvbnN0IF9fdml0ZV9pbmplY3RlZF9vcmlnaW5hbF9maWxlbmFtZSA9IFwiQzpcXFxcVXNlcnNcXFxcYXNkMjJcXFxcT25lRHJpdmVcXFxcXHU2ODRDXHU5NzYyXFxcXFZ1ZS5uZXdcXFxcdGVhbTFmcm9udGVuZC5jbGllbnRcXFxcdml0ZS5jb25maWcuanNcIjtjb25zdCBfX3ZpdGVfaW5qZWN0ZWRfb3JpZ2luYWxfaW1wb3J0X21ldGFfdXJsID0gXCJmaWxlOi8vL0M6L1VzZXJzL2FzZDIyL09uZURyaXZlLyVFNiVBMSU4QyVFOSU5RCVBMi9WdWUubmV3L3RlYW0xZnJvbnRlbmQuY2xpZW50L3ZpdGUuY29uZmlnLmpzXCI7aW1wb3J0IHsgZmlsZVVSTFRvUGF0aCwgVVJMIH0gZnJvbSAnbm9kZTp1cmwnO1xyXG5cclxuaW1wb3J0IHsgZGVmaW5lQ29uZmlnIH0gZnJvbSAndml0ZSc7XHJcbmltcG9ydCBwbHVnaW4gZnJvbSAnQHZpdGVqcy9wbHVnaW4tdnVlJztcclxuaW1wb3J0IGZzIGZyb20gJ2ZzJztcclxuaW1wb3J0IHBhdGggZnJvbSAncGF0aCc7XHJcbmltcG9ydCBjaGlsZF9wcm9jZXNzIGZyb20gJ2NoaWxkX3Byb2Nlc3MnO1xyXG5pbXBvcnQgeyBlbnYgfSBmcm9tICdwcm9jZXNzJztcclxuLy9lbGVtZW50XHU2MzA5XHU5NzAwXHU1RjE1XHU1MTY1XHJcbmltcG9ydCBBdXRvSW1wb3J0IGZyb20gJ3VucGx1Z2luLWF1dG8taW1wb3J0L3ZpdGUnXHJcbmltcG9ydCBDb21wb25lbnRzIGZyb20gJ3VucGx1Z2luLXZ1ZS1jb21wb25lbnRzL3ZpdGUnXHJcbmltcG9ydCB7IEVsZW1lbnRQbHVzUmVzb2x2ZXIgfSBmcm9tICd1bnBsdWdpbi12dWUtY29tcG9uZW50cy9yZXNvbHZlcnMnXHJcbi8vIGltcG9ydCBWdWV0aWZ5UGx1Z2luIGZyb20gJ3ZpdGUtcGx1Z2luLXZ1ZXRpZnknO1xyXG5cclxuY29uc3QgYmFzZUZvbGRlciA9XHJcbiAgICBlbnYuQVBQREFUQSAhPT0gdW5kZWZpbmVkICYmIGVudi5BUFBEQVRBICE9PSAnJ1xyXG4gICAgICAgID8gYCR7ZW52LkFQUERBVEF9L0FTUC5ORVQvaHR0cHNgXHJcbiAgICAgICAgOiBgJHtlbnYuSE9NRX0vLmFzcG5ldC9odHRwc2A7XHJcblxyXG5jb25zdCBjZXJ0aWZpY2F0ZU5hbWUgPSAndGVhbTFmcm9udGVuZC5jbGllbnQnO1xyXG5jb25zdCBjZXJ0RmlsZVBhdGggPSBwYXRoLmpvaW4oYmFzZUZvbGRlciwgYCR7Y2VydGlmaWNhdGVOYW1lfS5wZW1gKTtcclxuY29uc3Qga2V5RmlsZVBhdGggPSBwYXRoLmpvaW4oYmFzZUZvbGRlciwgYCR7Y2VydGlmaWNhdGVOYW1lfS5rZXlgKTtcclxuXHJcbmlmICghZnMuZXhpc3RzU3luYyhjZXJ0RmlsZVBhdGgpIHx8ICFmcy5leGlzdHNTeW5jKGtleUZpbGVQYXRoKSkge1xyXG4gICAgaWYgKFxyXG4gICAgICAgIDAgIT09XHJcbiAgICAgICAgY2hpbGRfcHJvY2Vzcy5zcGF3blN5bmMoXHJcbiAgICAgICAgICAgICdkb3RuZXQnLFxyXG4gICAgICAgICAgICBbXHJcbiAgICAgICAgICAgICAgICAnZGV2LWNlcnRzJyxcclxuICAgICAgICAgICAgICAgICdodHRwcycsXHJcbiAgICAgICAgICAgICAgICAnLS1leHBvcnQtcGF0aCcsXHJcbiAgICAgICAgICAgICAgICBjZXJ0RmlsZVBhdGgsXHJcbiAgICAgICAgICAgICAgICAnLS1mb3JtYXQnLFxyXG4gICAgICAgICAgICAgICAgJ1BlbScsXHJcbiAgICAgICAgICAgICAgICAnLS1uby1wYXNzd29yZCcsXHJcbiAgICAgICAgICAgIF0sXHJcbiAgICAgICAgICAgIHsgc3RkaW86ICdpbmhlcml0JyB9XHJcbiAgICAgICAgKS5zdGF0dXNcclxuICAgICkge1xyXG4gICAgICAgIHRocm93IG5ldyBFcnJvcignQ291bGQgbm90IGNyZWF0ZSBjZXJ0aWZpY2F0ZS4nKTtcclxuICAgIH1cclxufVxyXG5cclxuY29uc3QgdGFyZ2V0ID0gZW52LkFTUE5FVENPUkVfSFRUUFNfUE9SVFxyXG4gICAgPyBgaHR0cHM6Ly9sb2NhbGhvc3Q6JHtlbnYuQVNQTkVUQ09SRV9IVFRQU19QT1JUfWBcclxuICAgIDogZW52LkFTUE5FVENPUkVfVVJMU1xyXG4gICAgICAgID8gZW52LkFTUE5FVENPUkVfVVJMUy5zcGxpdCgnOycpWzBdXHJcbiAgICAgICAgOiAnaHR0cHM6Ly9sb2NhbGhvc3Q6NzExMyc7XHJcblxyXG4vLyBodHRwczovL3ZpdGVqcy5kZXYvY29uZmlnL1xyXG5leHBvcnQgZGVmYXVsdCBkZWZpbmVDb25maWcoe1xyXG4gICAgcGx1Z2luczogW1xyXG4gICAgICAgIHBsdWdpbigpLFxyXG4gICAgICAgIEF1dG9JbXBvcnQoe1xyXG4gICAgICAgICAgICByZXNvbHZlcnM6IFtFbGVtZW50UGx1c1Jlc29sdmVyKCldLFxyXG4gICAgICAgIH0pLFxyXG4gICAgICAgIENvbXBvbmVudHMoe1xyXG4gICAgICAgICAgICByZXNvbHZlcnM6IFtFbGVtZW50UGx1c1Jlc29sdmVyKCldLFxyXG4gICAgICAgIH0pLFxyXG4gICAgXSxcclxuICAgIHJlc29sdmU6IHtcclxuICAgICAgICBhbGlhczoge1xyXG4gICAgICAgICAgICAnQCc6IGZpbGVVUkxUb1BhdGgobmV3IFVSTCgnLi9zcmMnLCBpbXBvcnQubWV0YS51cmwpKSxcclxuICAgICAgICB9LFxyXG4gICAgfSxcclxuICAgIHNlcnZlcjoge1xyXG4gICAgICAgIHByb3h5OiB7XHJcbiAgICAgICAgICAgICdeL3dlYXRoZXJmb3JlY2FzdCc6IHtcclxuICAgICAgICAgICAgICAgIHRhcmdldCxcclxuICAgICAgICAgICAgICAgIHNlY3VyZTogZmFsc2UsXHJcbiAgICAgICAgICAgIH0sXHJcbiAgICAgICAgfSxcclxuICAgICAgICBwb3J0OiA1MTczLFxyXG4gICAgICAgIGh0dHBzOiB7XHJcbiAgICAgICAgICAgIGtleTogZnMucmVhZEZpbGVTeW5jKGtleUZpbGVQYXRoKSxcclxuICAgICAgICAgICAgY2VydDogZnMucmVhZEZpbGVTeW5jKGNlcnRGaWxlUGF0aCksXHJcbiAgICAgICAgfSxcclxuICAgIH0sXHJcblxyXG4gICAgY3NzOiBbJ2h0dHBzOi8vY2RuLmpzZGVsaXZyLm5ldC9ucG0vdnVldGlmeUAzLjUuOC9kaXN0L3Z1ZXRpZnktbGFicy5jc3MnXSxcclxufSk7XHJcbiJdLAogICJtYXBwaW5ncyI6ICI7QUFBcVgsU0FBUyxlQUFlLFdBQVc7QUFFeFosU0FBUyxvQkFBb0I7QUFDN0IsT0FBTyxZQUFZO0FBQ25CLE9BQU8sUUFBUTtBQUNmLE9BQU8sVUFBVTtBQUNqQixPQUFPLG1CQUFtQjtBQUMxQixTQUFTLFdBQVc7QUFFcEIsT0FBTyxnQkFBZ0I7QUFDdkIsT0FBTyxnQkFBZ0I7QUFDdkIsU0FBUywyQkFBMkI7QUFYK0wsSUFBTSwyQ0FBMkM7QUFjcFIsSUFBTSxhQUNGLElBQUksWUFBWSxVQUFhLElBQUksWUFBWSxLQUN2QyxHQUFHLElBQUksT0FBTyxtQkFDZCxHQUFHLElBQUksSUFBSTtBQUVyQixJQUFNLGtCQUFrQjtBQUN4QixJQUFNLGVBQWUsS0FBSyxLQUFLLFlBQVksR0FBRyxlQUFlLE1BQU07QUFDbkUsSUFBTSxjQUFjLEtBQUssS0FBSyxZQUFZLEdBQUcsZUFBZSxNQUFNO0FBRWxFLElBQUksQ0FBQyxHQUFHLFdBQVcsWUFBWSxLQUFLLENBQUMsR0FBRyxXQUFXLFdBQVcsR0FBRztBQUM3RCxNQUNJLE1BQ0EsY0FBYztBQUFBLElBQ1Y7QUFBQSxJQUNBO0FBQUEsTUFDSTtBQUFBLE1BQ0E7QUFBQSxNQUNBO0FBQUEsTUFDQTtBQUFBLE1BQ0E7QUFBQSxNQUNBO0FBQUEsTUFDQTtBQUFBLElBQ0o7QUFBQSxJQUNBLEVBQUUsT0FBTyxVQUFVO0FBQUEsRUFDdkIsRUFBRSxRQUNKO0FBQ0UsVUFBTSxJQUFJLE1BQU0sK0JBQStCO0FBQUEsRUFDbkQ7QUFDSjtBQUVBLElBQU0sU0FBUyxJQUFJLHdCQUNiLHFCQUFxQixJQUFJLHFCQUFxQixLQUM5QyxJQUFJLGtCQUNBLElBQUksZ0JBQWdCLE1BQU0sR0FBRyxFQUFFLENBQUMsSUFDaEM7QUFHVixJQUFPLHNCQUFRLGFBQWE7QUFBQSxFQUN4QixTQUFTO0FBQUEsSUFDTCxPQUFPO0FBQUEsSUFDUCxXQUFXO0FBQUEsTUFDUCxXQUFXLENBQUMsb0JBQW9CLENBQUM7QUFBQSxJQUNyQyxDQUFDO0FBQUEsSUFDRCxXQUFXO0FBQUEsTUFDUCxXQUFXLENBQUMsb0JBQW9CLENBQUM7QUFBQSxJQUNyQyxDQUFDO0FBQUEsRUFDTDtBQUFBLEVBQ0EsU0FBUztBQUFBLElBQ0wsT0FBTztBQUFBLE1BQ0gsS0FBSyxjQUFjLElBQUksSUFBSSxTQUFTLHdDQUFlLENBQUM7QUFBQSxJQUN4RDtBQUFBLEVBQ0o7QUFBQSxFQUNBLFFBQVE7QUFBQSxJQUNKLE9BQU87QUFBQSxNQUNILHFCQUFxQjtBQUFBLFFBQ2pCO0FBQUEsUUFDQSxRQUFRO0FBQUEsTUFDWjtBQUFBLElBQ0o7QUFBQSxJQUNBLE1BQU07QUFBQSxJQUNOLE9BQU87QUFBQSxNQUNILEtBQUssR0FBRyxhQUFhLFdBQVc7QUFBQSxNQUNoQyxNQUFNLEdBQUcsYUFBYSxZQUFZO0FBQUEsSUFDdEM7QUFBQSxFQUNKO0FBQUEsRUFFQSxLQUFLLENBQUMsa0VBQWtFO0FBQzVFLENBQUM7IiwKICAibmFtZXMiOiBbXQp9Cg==
