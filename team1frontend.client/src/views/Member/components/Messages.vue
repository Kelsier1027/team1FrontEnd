<script setup></script>

<template>
    <div class="board">
        <div class="page-head">
            <h1>訊息管理</h1>
            <ul class="nav nav-tabs page-tab">
                <li data-v-4d88f2f4="" class="active" aria-selected="true">
                    <a data-v-4d88f2f4="" href="#ORDER" data-toggle="tab">
                        KKday 訊息
                        <!----></a
                    >
                </li>
                <li data-v-4d88f2f4="" class="" aria-selected="true">
                    <a data-v-4d88f2f4="" href="#SUPPLIER" data-toggle="tab">
                        商家訊息
                        <!----></a
                    >
                </li>
            </ul>
        </div>
        <div class="tab-content">
            <div aria-labelledby="order-tab" class="tab-pane fade in active">
                <div class="table-head hidden-xs">
                    <div class="row">
                        <div class="col-sm-2">訂單編號</div>
                        <div class="col-sm-4">商品名稱</div>
                        <div class="col-sm-6">訊息內容</div>
                    </div>
                </div>
                <div class="empty-list">
                    <div class="none-title">
                        <img
                            src="https://cdn.kkday.com/pc-web/assets/img/empty_state/msg_list.svg"
                        />
                        <h4 class="text-muted text-center">還沒有訊息</h4>
                    </div>
                </div>
            </div>
        </div>
        <div id="pageBtnGroup"><!----></div>
    </div>
</template>

<style scoped>
@import url(https://cdn.kkday.com/pc-web/pc/dist/css/app.a4e9ad7d127981b7f9f9.css);
</style>
