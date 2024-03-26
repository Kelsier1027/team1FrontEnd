<script setup></script>

<template>
    <div data-v-0129ff9e="" class="board">
        <div data-v-0129ff9e="" class="page-head kk-u-mb-7">
            <h1 data-v-0129ff9e="">訂單管理</h1>
        </div>
        <!---->
        <div data-v-0129ff9e="" class="tab-content">
            <div data-v-0129ff9e="" class="tab-pane fade in active">
                <div
                    data-v-0129ff9e=""
                    class="empty-list kk-u-m-0 kk-u-px-2 kk-u-pt-7 kk-u-pb-5"
                >
                    <div data-v-0129ff9e="" class="none-title">
                        <img
                            data-v-0129ff9e=""
                            src="https://cdn.kkday.com/pc-web/assets/img/empty_state/order_list.svg"
                            alt=""
                        />
                        <h4
                            data-v-0129ff9e=""
                            class="text-muted text-center kk-u-mt-8 kk-u-mb-0"
                        >
                            找不到訂單？可以試著使用其他帳號登入
                        </h4>
                    </div>
                </div>
            </div>
        </div>
        <div
            data-v-0129ff9e=""
            role="dialog"
            class="modal fade modal--basic"
            id="group-order-modal"
        >
            <div class="modal-dialog modal-md">
                <div class="modal-content">
                    <div class="modal-header">
                        <button
                            type="button"
                            data-dismiss="modal"
                            class="close"
                        >
                            <span aria-hidden="true">×</span>
                            <span class="sr-only">Close</span>
                        </button>
                        <h4 class="modal-title">訂單管理</h4>
                        <!---->
                    </div>
                    <div class="modal-body">
                        <div>
                            <div
                                class="group-order-list transportation-railway-order-list"
                            ></div>
                        </div>
                    </div>
                    <!---->
                </div>
            </div>
        </div>
    </div>
</template>

<style scoped>
@import url(https://cdn.kkday.com/pc-web/pc/dist/css/app.a4e9ad7d127981b7f9f9.css);
</style>
