<script setup></script>

<template>
    <div class="board">
        <div class="page-head">
            <h1>解任務，領點數</h1>
            <ul class="nav nav-tabs page-tab">
                <li class="active">
                    <a href="/zh-tw/member/missionlist?tab=AVAILABLE" class="">
                        任務挑戰
                    </a>
                </li>
                <li class="">
                    <a href="/zh-tw/member/missionlist?tab=COMPLETED" class="">
                        已完成
                    </a>
                </li>
            </ul>
        </div>
        <div>
            <div class="table-head hidden-xs">
                <div class="row">
                    <div class="col-sm-4">任務</div>
                    <div class="col-sm-3">任務獎勵</div>
                    <div class="col-sm-2">有效期至</div>
                </div>
            </div>
            <div class="mission-list">
                <div class="mission-list-item">
                    <div class="row">
                        <div class="col-sm-4">
                            <a class="mission-list-item__name">
                                【 App 限定 】贈送 1 位好友100 元折扣碼
                                <img
                                    src="https://cdn.kkday.com/pc-web/assets/img/ic_information_grey.svg"
                                    class="mission-list-item__icon-info"
                            /></a>
                        </div>
                        <div class="col-sm-3">
                            <div class="mission-list-item__reward-point">
                                <img
                                    src="https://cdn.kkday.com/pc-web/assets/img/ic_kkpoint.svg"
                                    class="mission-list-item__reward-point-icon"
                                />300
                            </div>
                        </div>
                        <div class="col-sm-2">2024/06/30</div>
                        <div class="col-sm-3 text-right">
                            <div class="mission-list-item__right">
                                <button
                                    data-gtm-mission-id="49"
                                    data-gtm-mission-status="NEW"
                                    data-gtm-name="mission-button"
                                    class="mission-list-item__action-btn btn btn-ghost btn-ghost--warning"
                                >
                                    接受挑戰
                                </button>
                                <!---->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div style="display: none">
            <div class="empty-list">
                <div class="empty-state text-center none-title">
                    <img
                        src="https://cdn.kkday.com/pc-web/assets/img/empty_state/mission_list.svg"
                    />
                    <h4 class="text-muted">你還沒完成任務呦</h4>
                </div>
            </div>
        </div>
        <div role="dialog" class="modal fade" id="modal-mission-complete">
            <div class="modal-dialog modal-sm">
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
                        <!---->
                        <!---->
                    </div>
                    <div class="modal-body">
                        <div class="text-center">
                            <img
                                src="https://cdn.kkday.com/pc-web/assets/img/kkpoint/ic_recieve_success.svg"
                            />
                            <h4 class="title mt-20">成功入袋！</h4>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <div>
                            <button
                                data-dismiss="modal"
                                class="btn btn-block btn-primary"
                            >
                                我知道了
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div role="dialog" class="modal fade" id="modal-mission-description">
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
                        <h4 class="modal-title">任務詳情</h4>
                        <!---->
                    </div>
                    <!---->
                    <div class="modal-footer">
                        <button data-dismiss="modal" class="btn btn-primary">
                            我知道了
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<style scoped>
/*!
 * Bootstrap v3.3.7 (http://getbootstrap.com)
 * Copyright 2011-2016 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
 */
/*! normalize.css v3.0.3 | MIT License | github.com/necolas/normalize.css */
html {
    font-family: sans-serif;
    -webkit-text-size-adjust: 100%;
    -ms-text-size-adjust: 100%;
}

body {
    margin: 0;
}

article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
main,
menu,
nav,
section,
summary {
    display: block;
}

audio,
canvas,
progress,
video {
    display: inline-block;
    vertical-align: baseline;
}

audio:not([controls]) {
    display: none;
    height: 0;
}

[hidden],
template {
    display: none;
}

a {
    background-color: transparent;
}

a:active,
a:hover {
    outline: 0;
}

abbr[title] {
    border-bottom: 1px dotted;
}

b,
strong {
    font-weight: 700;
}

dfn {
    font-style: italic;
}

h1 {
    margin: 0.67em 0;
    font-size: 2em;
}

mark {
    color: #000;
    background: #ff0;
}

small {
    font-size: 80%;
}

sub,
sup {
    position: relative;
    font-size: 75%;
    line-height: 0;
    vertical-align: baseline;
}

sup {
    top: -0.5em;
}

sub {
    bottom: -0.25em;
}

img {
    border: 0;
}

svg:not(:root) {
    overflow: hidden;
}

figure {
    margin: 1em 40px;
}

hr {
    height: 0;
    -webkit-box-sizing: content-box;
    box-sizing: content-box;
}

pre {
    overflow: auto;
}

code,
kbd,
pre,
samp {
    font-family: monospace, monospace;
    font-size: 1em;
}

button,
input,
optgroup,
select,
textarea {
    margin: 0;
    font: inherit;
    color: inherit;
}

button {
    overflow: visible;
}

button,
select {
    text-transform: none;
}

button,
html input[type='button'],
input[type='reset'],
input[type='submit'] {
    -webkit-appearance: button;
    cursor: pointer;
}

button[disabled],
html input[disabled] {
    cursor: default;
}

button::-moz-focus-inner,
input::-moz-focus-inner {
    padding: 0;
    border: 0;
}

input {
    line-height: normal;
}

input[type='checkbox'],
input[type='radio'] {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    padding: 0;
}

input[type='number']::-webkit-inner-spin-button,
input[type='number']::-webkit-outer-spin-button {
    height: auto;
}

input[type='search'] {
    -webkit-box-sizing: content-box;
    box-sizing: content-box;
    -webkit-appearance: textfield;
}

input[type='search']::-webkit-search-cancel-button,
input[type='search']::-webkit-search-decoration {
    -webkit-appearance: none;
}

fieldset {
    padding: 0.35em 0.625em 0.75em;
    margin: 0 2px;
    border: 1px solid silver;
}

textarea {
    overflow: auto;
}

optgroup {
    font-weight: 700;
}

table {
    border-spacing: 0;
    border-collapse: collapse;
}

td,
th {
    padding: 0;
}

/*! Source: https://github.com/h5bp/html5-boilerplate/blob/master/src/css/main.css */
@media print {
    *,
    :after,
    :before {
        color: #000 !important;
        text-shadow: none !important;
        background: 0 0 !important;
        -webkit-box-shadow: none !important;
        box-shadow: none !important;
    }

    a,
    a:visited {
        text-decoration: underline;
    }

    a[href]:after {
        content: ' (' attr(href) ')';
    }

    abbr[title]:after {
        content: ' (' attr(title) ')';
    }

    a[href^='#']:after,
    a[href^='javascript:']:after {
        content: '';
    }

    blockquote,
    pre {
        border: 1px solid #999;
        page-break-inside: avoid;
    }

    thead {
        display: table-header-group;
    }

    img,
    tr {
        page-break-inside: avoid;
    }

    img {
        max-width: 100% !important;
    }

    h2,
    h3,
    p {
        orphans: 3;
        widows: 3;
    }

    h2,
    h3 {
        page-break-after: avoid;
    }

    .navbar {
        display: none;
    }

    .btn > .caret,
    .dropup > .btn > .caret {
        border-top-color: #000 !important;
    }

    .label {
        border: 1px solid #000;
    }

    .table {
        border-collapse: collapse !important;
    }

    .table td,
    .table th {
        background-color: #fff !important;
    }

    .table-bordered td,
    .table-bordered th {
        border: 1px solid #ddd !important;
    }
}

@font-face {
    font-family: Glyphicons Halflings;
    font-display: swap;
    src: url(https://cdn.kkday.com/pc-web/assets/fonts/glyphicons-halflings-regular.eot);
    src: url(https://cdn.kkday.com/pc-web/assets/fonts/glyphicons-halflings-regular.eot#iefix)
            format('embedded-opentype'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/glyphicons-halflings-regular.woff2)
            format('woff2'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/glyphicons-halflings-regular.woff)
            format('woff'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/glyphicons-halflings-regular.ttf)
            format('truetype'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/glyphicons-halflings-regular.svg#glyphicons_halflingsregular)
            format('svg');
}

.glyphicon {
    position: relative;
    top: 1px;
    display: inline-block;
    font-family: Glyphicons Halflings;
    font-style: normal;
    font-weight: 400;
    line-height: 1;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
}

.glyphicon-asterisk:before {
    content: '*';
}

.glyphicon-plus:before {
    content: '+';
}

.glyphicon-eur:before,
.glyphicon-euro:before {
    content: '€';
}

.glyphicon-minus:before {
    content: '−';
}

.glyphicon-cloud:before {
    content: '☁';
}

.glyphicon-envelope:before {
    content: '✉';
}

.glyphicon-pencil:before {
    content: '✏';
}

.glyphicon-glass:before {
    content: '';
}

.glyphicon-music:before {
    content: '';
}

.glyphicon-search:before {
    content: '';
}

.glyphicon-heart:before {
    content: '';
}

.glyphicon-star:before {
    content: '';
}

.glyphicon-star-empty:before {
    content: '';
}

.glyphicon-user:before {
    content: '';
}

.glyphicon-film:before {
    content: '';
}

.glyphicon-th-large:before {
    content: '';
}

.glyphicon-th:before {
    content: '';
}

.glyphicon-th-list:before {
    content: '';
}

.glyphicon-ok:before {
    content: '';
}

.glyphicon-remove:before {
    content: '';
}

.glyphicon-zoom-in:before {
    content: '';
}

.glyphicon-zoom-out:before {
    content: '';
}

.glyphicon-off:before {
    content: '';
}

.glyphicon-signal:before {
    content: '';
}

.glyphicon-cog:before {
    content: '';
}

.glyphicon-trash:before {
    content: '';
}

.glyphicon-home:before {
    content: '';
}

.glyphicon-file:before {
    content: '';
}

.glyphicon-time:before {
    content: '';
}

.glyphicon-road:before {
    content: '';
}

.glyphicon-download-alt:before {
    content: '';
}

.glyphicon-download:before {
    content: '';
}

.glyphicon-upload:before {
    content: '';
}

.glyphicon-inbox:before {
    content: '';
}

.glyphicon-play-circle:before {
    content: '';
}

.glyphicon-repeat:before {
    content: '';
}

.glyphicon-refresh:before {
    content: '';
}

.glyphicon-list-alt:before {
    content: '';
}

.glyphicon-lock:before {
    content: '';
}

.glyphicon-flag:before {
    content: '';
}

.glyphicon-headphones:before {
    content: '';
}

.glyphicon-volume-off:before {
    content: '';
}

.glyphicon-volume-down:before {
    content: '';
}

.glyphicon-volume-up:before {
    content: '';
}

.glyphicon-qrcode:before {
    content: '';
}

.glyphicon-barcode:before {
    content: '';
}

.glyphicon-tag:before {
    content: '';
}

.glyphicon-tags:before {
    content: '';
}

.glyphicon-book:before {
    content: '';
}

.glyphicon-bookmark:before {
    content: '';
}

.glyphicon-print:before {
    content: '';
}

.glyphicon-camera:before {
    content: '';
}

.glyphicon-font:before {
    content: '';
}

.glyphicon-bold:before {
    content: '';
}

.glyphicon-italic:before {
    content: '';
}

.glyphicon-text-height:before {
    content: '';
}

.glyphicon-text-width:before {
    content: '';
}

.glyphicon-align-left:before {
    content: '';
}

.glyphicon-align-center:before {
    content: '';
}

.glyphicon-align-right:before {
    content: '';
}

.glyphicon-align-justify:before {
    content: '';
}

.glyphicon-list:before {
    content: '';
}

.glyphicon-indent-left:before {
    content: '';
}

.glyphicon-indent-right:before {
    content: '';
}

.glyphicon-facetime-video:before {
    content: '';
}

.glyphicon-picture:before {
    content: '';
}

.glyphicon-map-marker:before {
    content: '';
}

.glyphicon-adjust:before {
    content: '';
}

.glyphicon-tint:before {
    content: '';
}

.glyphicon-edit:before {
    content: '';
}

.glyphicon-share:before {
    content: '';
}

.glyphicon-check:before {
    content: '';
}

.glyphicon-move:before {
    content: '';
}

.glyphicon-step-backward:before {
    content: '';
}

.glyphicon-fast-backward:before {
    content: '';
}

.glyphicon-backward:before {
    content: '';
}

.glyphicon-play:before {
    content: '';
}

.glyphicon-pause:before {
    content: '';
}

.glyphicon-stop:before {
    content: '';
}

.glyphicon-forward:before {
    content: '';
}

.glyphicon-fast-forward:before {
    content: '';
}

.glyphicon-step-forward:before {
    content: '';
}

.glyphicon-eject:before {
    content: '';
}

.glyphicon-chevron-left:before {
    content: '';
}

.glyphicon-chevron-right:before {
    content: '';
}

.glyphicon-plus-sign:before {
    content: '';
}

.glyphicon-minus-sign:before {
    content: '';
}

.glyphicon-remove-sign:before {
    content: '';
}

.glyphicon-ok-sign:before {
    content: '';
}

.glyphicon-question-sign:before {
    content: '';
}

.glyphicon-info-sign:before {
    content: '';
}

.glyphicon-screenshot:before {
    content: '';
}

.glyphicon-remove-circle:before {
    content: '';
}

.glyphicon-ok-circle:before {
    content: '';
}

.glyphicon-ban-circle:before {
    content: '';
}

.glyphicon-arrow-left:before {
    content: '';
}

.glyphicon-arrow-right:before {
    content: '';
}

.glyphicon-arrow-up:before {
    content: '';
}

.glyphicon-arrow-down:before {
    content: '';
}

.glyphicon-share-alt:before {
    content: '';
}

.glyphicon-resize-full:before {
    content: '';
}

.glyphicon-resize-small:before {
    content: '';
}

.glyphicon-exclamation-sign:before {
    content: '';
}

.glyphicon-gift:before {
    content: '';
}

.glyphicon-leaf:before {
    content: '';
}

.glyphicon-fire:before {
    content: '';
}

.glyphicon-eye-open:before {
    content: '';
}

.glyphicon-eye-close:before {
    content: '';
}

.glyphicon-warning-sign:before {
    content: '';
}

.glyphicon-plane:before {
    content: '';
}

.glyphicon-calendar:before {
    content: '';
}

.glyphicon-random:before {
    content: '';
}

.glyphicon-comment:before {
    content: '';
}

.glyphicon-magnet:before {
    content: '';
}

.glyphicon-chevron-up:before {
    content: '';
}

.glyphicon-chevron-down:before {
    content: '';
}

.glyphicon-retweet:before {
    content: '';
}

.glyphicon-shopping-cart:before {
    content: '';
}

.glyphicon-folder-close:before {
    content: '';
}

.glyphicon-folder-open:before {
    content: '';
}

.glyphicon-resize-vertical:before {
    content: '';
}

.glyphicon-resize-horizontal:before {
    content: '';
}

.glyphicon-hdd:before {
    content: '';
}

.glyphicon-bullhorn:before {
    content: '';
}

.glyphicon-bell:before {
    content: '';
}

.glyphicon-certificate:before {
    content: '';
}

.glyphicon-thumbs-up:before {
    content: '';
}

.glyphicon-thumbs-down:before {
    content: '';
}

.glyphicon-hand-right:before {
    content: '';
}

.glyphicon-hand-left:before {
    content: '';
}

.glyphicon-hand-up:before {
    content: '';
}

.glyphicon-hand-down:before {
    content: '';
}

.glyphicon-circle-arrow-right:before {
    content: '';
}

.glyphicon-circle-arrow-left:before {
    content: '';
}

.glyphicon-circle-arrow-up:before {
    content: '';
}

.glyphicon-circle-arrow-down:before {
    content: '';
}

.glyphicon-globe:before {
    content: '';
}

.glyphicon-wrench:before {
    content: '';
}

.glyphicon-tasks:before {
    content: '';
}

.glyphicon-filter:before {
    content: '';
}

.glyphicon-briefcase:before {
    content: '';
}

.glyphicon-fullscreen:before {
    content: '';
}

.glyphicon-dashboard:before {
    content: '';
}

.glyphicon-paperclip:before {
    content: '';
}

.glyphicon-heart-empty:before {
    content: '';
}

.glyphicon-link:before {
    content: '';
}

.glyphicon-phone:before {
    content: '';
}

.glyphicon-pushpin:before {
    content: '';
}

.glyphicon-usd:before {
    content: '';
}

.glyphicon-gbp:before {
    content: '';
}

.glyphicon-sort:before {
    content: '';
}

.glyphicon-sort-by-alphabet:before {
    content: '';
}

.glyphicon-sort-by-alphabet-alt:before {
    content: '';
}

.glyphicon-sort-by-order:before {
    content: '';
}

.glyphicon-sort-by-order-alt:before {
    content: '';
}

.glyphicon-sort-by-attributes:before {
    content: '';
}

.glyphicon-sort-by-attributes-alt:before {
    content: '';
}

.glyphicon-unchecked:before {
    content: '';
}

.glyphicon-expand:before {
    content: '';
}

.glyphicon-collapse-down:before {
    content: '';
}

.glyphicon-collapse-up:before {
    content: '';
}

.glyphicon-log-in:before {
    content: '';
}

.glyphicon-flash:before {
    content: '';
}

.glyphicon-log-out:before {
    content: '';
}

.glyphicon-new-window:before {
    content: '';
}

.glyphicon-record:before {
    content: '';
}

.glyphicon-save:before {
    content: '';
}

.glyphicon-open:before {
    content: '';
}

.glyphicon-saved:before {
    content: '';
}

.glyphicon-import:before {
    content: '';
}

.glyphicon-export:before {
    content: '';
}

.glyphicon-send:before {
    content: '';
}

.glyphicon-floppy-disk:before {
    content: '';
}

.glyphicon-floppy-saved:before {
    content: '';
}

.glyphicon-floppy-remove:before {
    content: '';
}

.glyphicon-floppy-save:before {
    content: '';
}

.glyphicon-floppy-open:before {
    content: '';
}

.glyphicon-credit-card:before {
    content: '';
}

.glyphicon-transfer:before {
    content: '';
}

.glyphicon-cutlery:before {
    content: '';
}

.glyphicon-header:before {
    content: '';
}

.glyphicon-compressed:before {
    content: '';
}

.glyphicon-earphone:before {
    content: '';
}

.glyphicon-phone-alt:before {
    content: '';
}

.glyphicon-tower:before {
    content: '';
}

.glyphicon-stats:before {
    content: '';
}

.glyphicon-sd-video:before {
    content: '';
}

.glyphicon-hd-video:before {
    content: '';
}

.glyphicon-subtitles:before {
    content: '';
}

.glyphicon-sound-stereo:before {
    content: '';
}

.glyphicon-sound-dolby:before {
    content: '';
}

.glyphicon-sound-5-1:before {
    content: '';
}

.glyphicon-sound-6-1:before {
    content: '';
}

.glyphicon-sound-7-1:before {
    content: '';
}

.glyphicon-copyright-mark:before {
    content: '';
}

.glyphicon-registration-mark:before {
    content: '';
}

.glyphicon-cloud-download:before {
    content: '';
}

.glyphicon-cloud-upload:before {
    content: '';
}

.glyphicon-tree-conifer:before {
    content: '';
}

.glyphicon-tree-deciduous:before {
    content: '';
}

.glyphicon-cd:before {
    content: '';
}

.glyphicon-save-file:before {
    content: '';
}

.glyphicon-open-file:before {
    content: '';
}

.glyphicon-level-up:before {
    content: '';
}

.glyphicon-copy:before {
    content: '';
}

.glyphicon-paste:before {
    content: '';
}

.glyphicon-alert:before {
    content: '';
}

.glyphicon-equalizer:before {
    content: '';
}

.glyphicon-king:before {
    content: '';
}

.glyphicon-queen:before {
    content: '';
}

.glyphicon-pawn:before {
    content: '';
}

.glyphicon-bishop:before {
    content: '';
}

.glyphicon-knight:before {
    content: '';
}

.glyphicon-baby-formula:before {
    content: '';
}

.glyphicon-tent:before {
    content: '⛺';
}

.glyphicon-blackboard:before {
    content: '';
}

.glyphicon-bed:before {
    content: '';
}

.glyphicon-apple:before {
    content: '';
}

.glyphicon-erase:before {
    content: '';
}

.glyphicon-hourglass:before {
    content: '⌛';
}

.glyphicon-lamp:before {
    content: '';
}

.glyphicon-duplicate:before {
    content: '';
}

.glyphicon-piggy-bank:before {
    content: '';
}

.glyphicon-scissors:before {
    content: '';
}

.glyphicon-bitcoin:before,
.glyphicon-btc:before,
.glyphicon-xbt:before {
    content: '';
}

.glyphicon-jpy:before,
.glyphicon-yen:before {
    content: '¥';
}

.glyphicon-rub:before,
.glyphicon-ruble:before {
    content: '₽';
}

.glyphicon-scale:before {
    content: '';
}

.glyphicon-ice-lolly:before {
    content: '';
}

.glyphicon-ice-lolly-tasted:before {
    content: '';
}

.glyphicon-education:before {
    content: '';
}

.glyphicon-option-horizontal:before {
    content: '';
}

.glyphicon-option-vertical:before {
    content: '';
}

.glyphicon-menu-hamburger:before {
    content: '';
}

.glyphicon-modal-window:before {
    content: '';
}

.glyphicon-oil:before {
    content: '';
}

.glyphicon-grain:before {
    content: '';
}

.glyphicon-sunglasses:before {
    content: '';
}

.glyphicon-text-size:before {
    content: '';
}

.glyphicon-text-color:before {
    content: '';
}

.glyphicon-text-background:before {
    content: '';
}

.glyphicon-object-align-top:before {
    content: '';
}

.glyphicon-object-align-bottom:before {
    content: '';
}

.glyphicon-object-align-horizontal:before {
    content: '';
}

.glyphicon-object-align-left:before {
    content: '';
}

.glyphicon-object-align-vertical:before {
    content: '';
}

.glyphicon-object-align-right:before {
    content: '';
}

.glyphicon-triangle-right:before {
    content: '';
}

.glyphicon-triangle-left:before {
    content: '';
}

.glyphicon-triangle-bottom:before {
    content: '';
}

.glyphicon-triangle-top:before {
    content: '';
}

.glyphicon-console:before {
    content: '';
}

.glyphicon-superscript:before {
    content: '';
}

.glyphicon-subscript:before {
    content: '';
}

.glyphicon-menu-left:before {
    content: '';
}

.glyphicon-menu-right:before {
    content: '';
}

.glyphicon-menu-down:before {
    content: '';
}

.glyphicon-menu-up:before {
    content: '';
}

*,
:after,
:before {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
}

html {
    -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
}

body {
    font-size: 14px;
    line-height: 1.42857143;
    background-color: #fff;
}

button,
input,
select,
textarea {
    font-family: inherit;
    font-size: inherit;
    line-height: inherit;
}

a {
    color: #337ab7;
}

a:focus,
a:hover {
    color: #23527c;
    text-decoration: underline;
}

a:focus {
    outline: 5px auto -webkit-focus-ring-color;
    outline-offset: -2px;
}

figure {
    margin: 0;
}

img {
    vertical-align: middle;
}

.carousel-inner > .item > a > img,
.carousel-inner > .item > img,
.img-responsive,
.thumbnail > img,
.thumbnail a > img {
    display: block;
    max-width: 100%;
    height: auto;
}

.img-rounded {
    border-radius: 6px;
}

.img-thumbnail {
    display: inline-block;
    max-width: 100%;
    height: auto;
    padding: 4px;
    line-height: 1.42857143;
    background-color: #fff;
    border: 1px solid #ddd;
    border-radius: 4px;
    -webkit-transition: all 0.2s ease-in-out;
    transition: all 0.2s ease-in-out;
}

.img-circle {
    border-radius: 50%;
}

hr {
    margin-top: 20px;
    margin-bottom: 20px;
    border: 0;
    border-top: 1px solid #eee;
}

[role='button'] {
    cursor: pointer;
}

.h1,
.h2,
.h3,
.h4,
.h5,
.h6,
h1,
h2,
h3,
h4,
h5,
h6 {
    font-family: inherit;
    font-weight: 500;
    line-height: 1.1;
    color: inherit;
}

.h1 .small,
.h1 small,
.h2 .small,
.h2 small,
.h3 .small,
.h3 small,
.h4 .small,
.h4 small,
.h5 .small,
.h5 small,
.h6 .small,
.h6 small,
h1 .small,
h1 small,
h2 .small,
h2 small,
h3 .small,
h3 small,
h4 .small,
h4 small,
h5 .small,
h5 small,
h6 .small,
h6 small {
    font-weight: 400;
    line-height: 1;
    color: #777;
}

.h1,
.h2,
.h3,
h1,
h2,
h3 {
    margin-top: 20px;
    margin-bottom: 10px;
}

.h1 .small,
.h1 small,
.h2 .small,
.h2 small,
.h3 .small,
.h3 small,
h1 .small,
h1 small,
h2 .small,
h2 small,
h3 .small,
h3 small {
    font-size: 65%;
}

.h4,
.h5,
.h6,
h4,
h5,
h6 {
    margin-top: 10px;
    margin-bottom: 10px;
}

.h4 .small,
.h4 small,
.h5 .small,
.h5 small,
.h6 .small,
.h6 small,
h4 .small,
h4 small,
h5 .small,
h5 small,
h6 .small,
h6 small {
    font-size: 75%;
}

.h1,
h1 {
    font-size: 36px;
}

.h2,
h2 {
    font-size: 30px;
}

.h3,
h3 {
    font-size: 24px;
}

.h4,
h4 {
    font-size: 18px;
}

.h5,
h5 {
    font-size: 14px;
}

.h6,
h6 {
    font-size: 12px;
}

p {
    margin: 0 0 10px;
}

.lead {
    margin-bottom: 20px;
    font-size: 16px;
    font-weight: 300;
    line-height: 1.4;
}

@media (min-width: 768px) {
    .lead {
        font-size: 21px;
    }
}

.small,
small {
    font-size: 85%;
}

.mark,
mark {
    padding: 0.2em;
    background-color: #fcf8e3;
}

.text-left {
    text-align: left;
}

.text-right {
    text-align: right;
}

.text-center {
    text-align: center;
}

.text-justify {
    text-align: justify;
}

.text-nowrap {
    white-space: nowrap;
}

.text-lowercase {
    text-transform: lowercase;
}

.text-uppercase {
    text-transform: uppercase;
}

.text-capitalize {
    text-transform: capitalize;
}

.text-muted {
    color: #777;
}

.text-primary {
    color: #337ab7;
}

a.text-primary:focus,
a.text-primary:hover {
    color: #286090;
}

.text-success {
    color: #3c763d;
}

a.text-success:focus,
a.text-success:hover {
    color: #2b542c;
}

.text-info {
    color: #31708f;
}

a.text-info:focus,
a.text-info:hover {
    color: #245269;
}

.text-warning {
    color: #8a6d3b;
}

a.text-warning:focus,
a.text-warning:hover {
    color: #66512c;
}

.text-danger {
    color: #a94442;
}

a.text-danger:focus,
a.text-danger:hover {
    color: #843534;
}

.bg-primary {
    color: #fff;
    background-color: #337ab7;
}

a.bg-primary:focus,
a.bg-primary:hover {
    background-color: #286090;
}

.bg-success {
    background-color: #dff0d8;
}

a.bg-success:focus,
a.bg-success:hover {
    background-color: #c1e2b3;
}

.bg-info {
    background-color: #d9edf7;
}

a.bg-info:focus,
a.bg-info:hover {
    background-color: #afd9ee;
}

.bg-warning {
    background-color: #fcf8e3;
}

a.bg-warning:focus,
a.bg-warning:hover {
    background-color: #f7ecb5;
}

.bg-danger {
    background-color: #f2dede;
}

a.bg-danger:focus,
a.bg-danger:hover {
    background-color: #e4b9b9;
}

.page-header {
    padding-bottom: 9px;
    margin: 40px 0 20px;
    border-bottom: 1px solid #eee;
}

ol,
ul {
    margin-top: 0;
    margin-bottom: 10px;
}

ol ol,
ol ul,
ul ol,
ul ul {
    margin-bottom: 0;
}

.list-inline,
.list-unstyled {
    padding-left: 0;
    list-style: none;
}

.list-inline {
    margin-left: -5px;
}

.list-inline > li {
    display: inline-block;
    padding-right: 5px;
    padding-left: 5px;
}

dl {
    margin-top: 0;
    margin-bottom: 20px;
}

dd,
dt {
    line-height: 1.42857143;
}

dt {
    font-weight: 700;
}

dd {
    margin-left: 0;
}

@media (min-width: 768px) {
    .dl-horizontal dt {
        float: left;
        width: 160px;
        overflow: hidden;
        clear: left;
        text-align: right;
        text-overflow: ellipsis;
        white-space: nowrap;
    }

    .dl-horizontal dd {
        margin-left: 180px;
    }
}

abbr[data-original-title],
abbr[title] {
    cursor: help;
    border-bottom: 1px dotted #777;
}

.initialism {
    font-size: 90%;
    text-transform: uppercase;
}

blockquote {
    padding: 10px 20px;
    margin: 0 0 20px;
    font-size: 17.5px;
    border-left: 5px solid #eee;
}

blockquote ol:last-child,
blockquote p:last-child,
blockquote ul:last-child {
    margin-bottom: 0;
}

blockquote .small,
blockquote footer,
blockquote small {
    display: block;
    font-size: 80%;
    line-height: 1.42857143;
    color: #777;
}

blockquote .small:before,
blockquote footer:before,
blockquote small:before {
    content: '— ';
}

.blockquote-reverse,
blockquote.pull-right {
    padding-right: 15px;
    padding-left: 0;
    text-align: right;
    border-right: 5px solid #eee;
    border-left: 0;
}

.blockquote-reverse .small:before,
.blockquote-reverse footer:before,
.blockquote-reverse small:before,
blockquote.pull-right .small:before,
blockquote.pull-right footer:before,
blockquote.pull-right small:before {
    content: '';
}

.blockquote-reverse .small:after,
.blockquote-reverse footer:after,
.blockquote-reverse small:after,
blockquote.pull-right .small:after,
blockquote.pull-right footer:after,
blockquote.pull-right small:after {
    content: ' —';
}

address {
    margin-bottom: 20px;
    font-style: normal;
    line-height: 1.42857143;
}

code,
kbd,
pre,
samp {
    font-family: Menlo, Monaco, Consolas, Courier New, monospace;
}

code {
    color: #c7254e;
    background-color: #f9f2f4;
    border-radius: 4px;
}

code,
kbd {
    padding: 2px 4px;
    font-size: 90%;
}

kbd {
    color: #fff;
    background-color: #333;
    border-radius: 3px;
    -webkit-box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.25);
    box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.25);
}

kbd kbd {
    padding: 0;
    font-size: 100%;
    font-weight: 700;
    -webkit-box-shadow: none;
    box-shadow: none;
}

pre {
    display: block;
    padding: 9.5px;
    margin: 0 0 10px;
    font-size: 13px;
    line-height: 1.42857143;
    color: #333;
    word-break: break-all;
    word-wrap: break-word;
    background-color: #f5f5f5;
    border: 1px solid #ccc;
    border-radius: 4px;
}

pre code {
    padding: 0;
    font-size: inherit;
    color: inherit;
    white-space: pre-wrap;
    background-color: transparent;
    border-radius: 0;
}

.pre-scrollable {
    max-height: 340px;
    overflow-y: scroll;
}

.container {
    padding-right: 15px;
    padding-left: 15px;
    margin-right: auto;
    margin-left: auto;
}

@media (min-width: 768px) {
    .container {
        width: 750px;
    }
}

@media (min-width: 992px) {
    .container {
        width: 970px;
    }
}

@media (min-width: 1200px) {
    .container {
        width: 1170px;
    }
}

.container-fluid {
    padding-right: 15px;
    padding-left: 15px;
    margin-right: auto;
    margin-left: auto;
}

.row {
    margin-right: -15px;
    margin-left: -15px;
}

.col-lg-1,
.col-lg-2,
.col-lg-3,
.col-lg-4,
.col-lg-5,
.col-lg-6,
.col-lg-7,
.col-lg-8,
.col-lg-9,
.col-lg-10,
.col-lg-11,
.col-lg-12,
.col-md-1,
.col-md-2,
.col-md-3,
.col-md-4,
.col-md-5,
.col-md-6,
.col-md-7,
.col-md-8,
.col-md-9,
.col-md-10,
.col-md-11,
.col-md-12,
.col-sm-1,
.col-sm-2,
.col-sm-3,
.col-sm-4,
.col-sm-5,
.col-sm-6,
.col-sm-7,
.col-sm-8,
.col-sm-9,
.col-sm-10,
.col-sm-11,
.col-sm-12,
.col-xs-1,
.col-xs-2,
.col-xs-3,
.col-xs-4,
.col-xs-5,
.col-xs-6,
.col-xs-7,
.col-xs-8,
.col-xs-9,
.col-xs-10,
.col-xs-11,
.col-xs-12 {
    position: relative;
    min-height: 1px;
    padding-right: 15px;
    padding-left: 15px;
}

.col-xs-1,
.col-xs-2,
.col-xs-3,
.col-xs-4,
.col-xs-5,
.col-xs-6,
.col-xs-7,
.col-xs-8,
.col-xs-9,
.col-xs-10,
.col-xs-11,
.col-xs-12 {
    float: left;
}

.col-xs-12 {
    width: 100%;
}

.col-xs-11 {
    width: 91.66666667%;
}

.col-xs-10 {
    width: 83.33333333%;
}

.col-xs-9 {
    width: 75%;
}

.col-xs-8 {
    width: 66.66666667%;
}

.col-xs-7 {
    width: 58.33333333%;
}

.col-xs-6 {
    width: 50%;
}

.col-xs-5 {
    width: 41.66666667%;
}

.col-xs-4 {
    width: 33.33333333%;
}

.col-xs-3 {
    width: 25%;
}

.col-xs-2 {
    width: 16.66666667%;
}

.col-xs-1 {
    width: 8.33333333%;
}

.col-xs-pull-12 {
    right: 100%;
}

.col-xs-pull-11 {
    right: 91.66666667%;
}

.col-xs-pull-10 {
    right: 83.33333333%;
}

.col-xs-pull-9 {
    right: 75%;
}

.col-xs-pull-8 {
    right: 66.66666667%;
}

.col-xs-pull-7 {
    right: 58.33333333%;
}

.col-xs-pull-6 {
    right: 50%;
}

.col-xs-pull-5 {
    right: 41.66666667%;
}

.col-xs-pull-4 {
    right: 33.33333333%;
}

.col-xs-pull-3 {
    right: 25%;
}

.col-xs-pull-2 {
    right: 16.66666667%;
}

.col-xs-pull-1 {
    right: 8.33333333%;
}

.col-xs-pull-0 {
    right: auto;
}

.col-xs-push-12 {
    left: 100%;
}

.col-xs-push-11 {
    left: 91.66666667%;
}

.col-xs-push-10 {
    left: 83.33333333%;
}

.col-xs-push-9 {
    left: 75%;
}

.col-xs-push-8 {
    left: 66.66666667%;
}

.col-xs-push-7 {
    left: 58.33333333%;
}

.col-xs-push-6 {
    left: 50%;
}

.col-xs-push-5 {
    left: 41.66666667%;
}

.col-xs-push-4 {
    left: 33.33333333%;
}

.col-xs-push-3 {
    left: 25%;
}

.col-xs-push-2 {
    left: 16.66666667%;
}

.col-xs-push-1 {
    left: 8.33333333%;
}

.col-xs-push-0 {
    left: auto;
}

.col-xs-offset-12 {
    margin-left: 100%;
}

.col-xs-offset-11 {
    margin-left: 91.66666667%;
}

.col-xs-offset-10 {
    margin-left: 83.33333333%;
}

.col-xs-offset-9 {
    margin-left: 75%;
}

.col-xs-offset-8 {
    margin-left: 66.66666667%;
}

.col-xs-offset-7 {
    margin-left: 58.33333333%;
}

.col-xs-offset-6 {
    margin-left: 50%;
}

.col-xs-offset-5 {
    margin-left: 41.66666667%;
}

.col-xs-offset-4 {
    margin-left: 33.33333333%;
}

.col-xs-offset-3 {
    margin-left: 25%;
}

.col-xs-offset-2 {
    margin-left: 16.66666667%;
}

.col-xs-offset-1 {
    margin-left: 8.33333333%;
}

.col-xs-offset-0 {
    margin-left: 0;
}

@media (min-width: 768px) {
    .col-sm-1,
    .col-sm-2,
    .col-sm-3,
    .col-sm-4,
    .col-sm-5,
    .col-sm-6,
    .col-sm-7,
    .col-sm-8,
    .col-sm-9,
    .col-sm-10,
    .col-sm-11,
    .col-sm-12 {
        float: left;
    }

    .col-sm-12 {
        width: 100%;
    }

    .col-sm-11 {
        width: 91.66666667%;
    }

    .col-sm-10 {
        width: 83.33333333%;
    }

    .col-sm-9 {
        width: 75%;
    }

    .col-sm-8 {
        width: 66.66666667%;
    }

    .col-sm-7 {
        width: 58.33333333%;
    }

    .col-sm-6 {
        width: 50%;
    }

    .col-sm-5 {
        width: 41.66666667%;
    }

    .col-sm-4 {
        width: 33.33333333%;
    }

    .col-sm-3 {
        width: 25%;
    }

    .col-sm-2 {
        width: 16.66666667%;
    }

    .col-sm-1 {
        width: 8.33333333%;
    }

    .col-sm-pull-12 {
        right: 100%;
    }

    .col-sm-pull-11 {
        right: 91.66666667%;
    }

    .col-sm-pull-10 {
        right: 83.33333333%;
    }

    .col-sm-pull-9 {
        right: 75%;
    }

    .col-sm-pull-8 {
        right: 66.66666667%;
    }

    .col-sm-pull-7 {
        right: 58.33333333%;
    }

    .col-sm-pull-6 {
        right: 50%;
    }

    .col-sm-pull-5 {
        right: 41.66666667%;
    }

    .col-sm-pull-4 {
        right: 33.33333333%;
    }

    .col-sm-pull-3 {
        right: 25%;
    }

    .col-sm-pull-2 {
        right: 16.66666667%;
    }

    .col-sm-pull-1 {
        right: 8.33333333%;
    }

    .col-sm-pull-0 {
        right: auto;
    }

    .col-sm-push-12 {
        left: 100%;
    }

    .col-sm-push-11 {
        left: 91.66666667%;
    }

    .col-sm-push-10 {
        left: 83.33333333%;
    }

    .col-sm-push-9 {
        left: 75%;
    }

    .col-sm-push-8 {
        left: 66.66666667%;
    }

    .col-sm-push-7 {
        left: 58.33333333%;
    }

    .col-sm-push-6 {
        left: 50%;
    }

    .col-sm-push-5 {
        left: 41.66666667%;
    }

    .col-sm-push-4 {
        left: 33.33333333%;
    }

    .col-sm-push-3 {
        left: 25%;
    }

    .col-sm-push-2 {
        left: 16.66666667%;
    }

    .col-sm-push-1 {
        left: 8.33333333%;
    }

    .col-sm-push-0 {
        left: auto;
    }

    .col-sm-offset-12 {
        margin-left: 100%;
    }

    .col-sm-offset-11 {
        margin-left: 91.66666667%;
    }

    .col-sm-offset-10 {
        margin-left: 83.33333333%;
    }

    .col-sm-offset-9 {
        margin-left: 75%;
    }

    .col-sm-offset-8 {
        margin-left: 66.66666667%;
    }

    .col-sm-offset-7 {
        margin-left: 58.33333333%;
    }

    .col-sm-offset-6 {
        margin-left: 50%;
    }

    .col-sm-offset-5 {
        margin-left: 41.66666667%;
    }

    .col-sm-offset-4 {
        margin-left: 33.33333333%;
    }

    .col-sm-offset-3 {
        margin-left: 25%;
    }

    .col-sm-offset-2 {
        margin-left: 16.66666667%;
    }

    .col-sm-offset-1 {
        margin-left: 8.33333333%;
    }

    .col-sm-offset-0 {
        margin-left: 0;
    }
}

@media (min-width: 992px) {
    .col-md-1,
    .col-md-2,
    .col-md-3,
    .col-md-4,
    .col-md-5,
    .col-md-6,
    .col-md-7,
    .col-md-8,
    .col-md-9,
    .col-md-10,
    .col-md-11,
    .col-md-12 {
        float: left;
    }

    .col-md-12 {
        width: 100%;
    }

    .col-md-11 {
        width: 91.66666667%;
    }

    .col-md-10 {
        width: 83.33333333%;
    }

    .col-md-9 {
        width: 75%;
    }

    .col-md-8 {
        width: 66.66666667%;
    }

    .col-md-7 {
        width: 58.33333333%;
    }

    .col-md-6 {
        width: 50%;
    }

    .col-md-5 {
        width: 41.66666667%;
    }

    .col-md-4 {
        width: 33.33333333%;
    }

    .col-md-3 {
        width: 25%;
    }

    .col-md-2 {
        width: 16.66666667%;
    }

    .col-md-1 {
        width: 8.33333333%;
    }

    .col-md-pull-12 {
        right: 100%;
    }

    .col-md-pull-11 {
        right: 91.66666667%;
    }

    .col-md-pull-10 {
        right: 83.33333333%;
    }

    .col-md-pull-9 {
        right: 75%;
    }

    .col-md-pull-8 {
        right: 66.66666667%;
    }

    .col-md-pull-7 {
        right: 58.33333333%;
    }

    .col-md-pull-6 {
        right: 50%;
    }

    .col-md-pull-5 {
        right: 41.66666667%;
    }

    .col-md-pull-4 {
        right: 33.33333333%;
    }

    .col-md-pull-3 {
        right: 25%;
    }

    .col-md-pull-2 {
        right: 16.66666667%;
    }

    .col-md-pull-1 {
        right: 8.33333333%;
    }

    .col-md-pull-0 {
        right: auto;
    }

    .col-md-push-12 {
        left: 100%;
    }

    .col-md-push-11 {
        left: 91.66666667%;
    }

    .col-md-push-10 {
        left: 83.33333333%;
    }

    .col-md-push-9 {
        left: 75%;
    }

    .col-md-push-8 {
        left: 66.66666667%;
    }

    .col-md-push-7 {
        left: 58.33333333%;
    }

    .col-md-push-6 {
        left: 50%;
    }

    .col-md-push-5 {
        left: 41.66666667%;
    }

    .col-md-push-4 {
        left: 33.33333333%;
    }

    .col-md-push-3 {
        left: 25%;
    }

    .col-md-push-2 {
        left: 16.66666667%;
    }

    .col-md-push-1 {
        left: 8.33333333%;
    }

    .col-md-push-0 {
        left: auto;
    }

    .col-md-offset-12 {
        margin-left: 100%;
    }

    .col-md-offset-11 {
        margin-left: 91.66666667%;
    }

    .col-md-offset-10 {
        margin-left: 83.33333333%;
    }

    .col-md-offset-9 {
        margin-left: 75%;
    }

    .col-md-offset-8 {
        margin-left: 66.66666667%;
    }

    .col-md-offset-7 {
        margin-left: 58.33333333%;
    }

    .col-md-offset-6 {
        margin-left: 50%;
    }

    .col-md-offset-5 {
        margin-left: 41.66666667%;
    }

    .col-md-offset-4 {
        margin-left: 33.33333333%;
    }

    .col-md-offset-3 {
        margin-left: 25%;
    }

    .col-md-offset-2 {
        margin-left: 16.66666667%;
    }

    .col-md-offset-1 {
        margin-left: 8.33333333%;
    }

    .col-md-offset-0 {
        margin-left: 0;
    }
}

@media (min-width: 1200px) {
    .col-lg-1,
    .col-lg-2,
    .col-lg-3,
    .col-lg-4,
    .col-lg-5,
    .col-lg-6,
    .col-lg-7,
    .col-lg-8,
    .col-lg-9,
    .col-lg-10,
    .col-lg-11,
    .col-lg-12 {
        float: left;
    }

    .col-lg-12 {
        width: 100%;
    }

    .col-lg-11 {
        width: 91.66666667%;
    }

    .col-lg-10 {
        width: 83.33333333%;
    }

    .col-lg-9 {
        width: 75%;
    }

    .col-lg-8 {
        width: 66.66666667%;
    }

    .col-lg-7 {
        width: 58.33333333%;
    }

    .col-lg-6 {
        width: 50%;
    }

    .col-lg-5 {
        width: 41.66666667%;
    }

    .col-lg-4 {
        width: 33.33333333%;
    }

    .col-lg-3 {
        width: 25%;
    }

    .col-lg-2 {
        width: 16.66666667%;
    }

    .col-lg-1 {
        width: 8.33333333%;
    }

    .col-lg-pull-12 {
        right: 100%;
    }

    .col-lg-pull-11 {
        right: 91.66666667%;
    }

    .col-lg-pull-10 {
        right: 83.33333333%;
    }

    .col-lg-pull-9 {
        right: 75%;
    }

    .col-lg-pull-8 {
        right: 66.66666667%;
    }

    .col-lg-pull-7 {
        right: 58.33333333%;
    }

    .col-lg-pull-6 {
        right: 50%;
    }

    .col-lg-pull-5 {
        right: 41.66666667%;
    }

    .col-lg-pull-4 {
        right: 33.33333333%;
    }

    .col-lg-pull-3 {
        right: 25%;
    }

    .col-lg-pull-2 {
        right: 16.66666667%;
    }

    .col-lg-pull-1 {
        right: 8.33333333%;
    }

    .col-lg-pull-0 {
        right: auto;
    }

    .col-lg-push-12 {
        left: 100%;
    }

    .col-lg-push-11 {
        left: 91.66666667%;
    }

    .col-lg-push-10 {
        left: 83.33333333%;
    }

    .col-lg-push-9 {
        left: 75%;
    }

    .col-lg-push-8 {
        left: 66.66666667%;
    }

    .col-lg-push-7 {
        left: 58.33333333%;
    }

    .col-lg-push-6 {
        left: 50%;
    }

    .col-lg-push-5 {
        left: 41.66666667%;
    }

    .col-lg-push-4 {
        left: 33.33333333%;
    }

    .col-lg-push-3 {
        left: 25%;
    }

    .col-lg-push-2 {
        left: 16.66666667%;
    }

    .col-lg-push-1 {
        left: 8.33333333%;
    }

    .col-lg-push-0 {
        left: auto;
    }

    .col-lg-offset-12 {
        margin-left: 100%;
    }

    .col-lg-offset-11 {
        margin-left: 91.66666667%;
    }

    .col-lg-offset-10 {
        margin-left: 83.33333333%;
    }

    .col-lg-offset-9 {
        margin-left: 75%;
    }

    .col-lg-offset-8 {
        margin-left: 66.66666667%;
    }

    .col-lg-offset-7 {
        margin-left: 58.33333333%;
    }

    .col-lg-offset-6 {
        margin-left: 50%;
    }

    .col-lg-offset-5 {
        margin-left: 41.66666667%;
    }

    .col-lg-offset-4 {
        margin-left: 33.33333333%;
    }

    .col-lg-offset-3 {
        margin-left: 25%;
    }

    .col-lg-offset-2 {
        margin-left: 16.66666667%;
    }

    .col-lg-offset-1 {
        margin-left: 8.33333333%;
    }

    .col-lg-offset-0 {
        margin-left: 0;
    }
}

table {
    background-color: transparent;
}

caption {
    padding-top: 8px;
    padding-bottom: 8px;
    color: #777;
}

caption,
th {
    text-align: left;
}

.table {
    width: 100%;
    max-width: 100%;
    margin-bottom: 20px;
}

.table > tbody > tr > td,
.table > tbody > tr > th,
.table > tfoot > tr > td,
.table > tfoot > tr > th,
.table > thead > tr > td,
.table > thead > tr > th {
    padding: 8px;
    line-height: 1.42857143;
    vertical-align: top;
    border-top: 1px solid #ddd;
}

.table > thead > tr > th {
    vertical-align: bottom;
    border-bottom: 2px solid #ddd;
}

.table > caption + thead > tr:first-child > td,
.table > caption + thead > tr:first-child > th,
.table > colgroup + thead > tr:first-child > td,
.table > colgroup + thead > tr:first-child > th,
.table > thead:first-child > tr:first-child > td,
.table > thead:first-child > tr:first-child > th {
    border-top: 0;
}

.table > tbody + tbody {
    border-top: 2px solid #ddd;
}

.table .table {
    background-color: #fff;
}

.table-condensed > tbody > tr > td,
.table-condensed > tbody > tr > th,
.table-condensed > tfoot > tr > td,
.table-condensed > tfoot > tr > th,
.table-condensed > thead > tr > td,
.table-condensed > thead > tr > th {
    padding: 5px;
}

.table-bordered,
.table-bordered > tbody > tr > td,
.table-bordered > tbody > tr > th,
.table-bordered > tfoot > tr > td,
.table-bordered > tfoot > tr > th,
.table-bordered > thead > tr > td,
.table-bordered > thead > tr > th {
    border: 1px solid #ddd;
}

.table-bordered > thead > tr > td,
.table-bordered > thead > tr > th {
    border-bottom-width: 2px;
}

.table-striped > tbody > tr:nth-of-type(odd) {
    background-color: #f9f9f9;
}

.table-hover > tbody > tr:hover {
    background-color: #f5f5f5;
}

table col[class*='col-'] {
    position: static;
    display: table-column;
    float: none;
}

table td[class*='col-'],
table th[class*='col-'] {
    position: static;
    display: table-cell;
    float: none;
}

.table > tbody > tr.active > td,
.table > tbody > tr.active > th,
.table > tbody > tr > td.active,
.table > tbody > tr > th.active,
.table > tfoot > tr.active > td,
.table > tfoot > tr.active > th,
.table > tfoot > tr > td.active,
.table > tfoot > tr > th.active,
.table > thead > tr.active > td,
.table > thead > tr.active > th,
.table > thead > tr > td.active,
.table > thead > tr > th.active {
    background-color: #f5f5f5;
}

.table-hover > tbody > tr.active:hover > td,
.table-hover > tbody > tr.active:hover > th,
.table-hover > tbody > tr:hover > .active,
.table-hover > tbody > tr > td.active:hover,
.table-hover > tbody > tr > th.active:hover {
    background-color: #e8e8e8;
}

.table > tbody > tr.success > td,
.table > tbody > tr.success > th,
.table > tbody > tr > td.success,
.table > tbody > tr > th.success,
.table > tfoot > tr.success > td,
.table > tfoot > tr.success > th,
.table > tfoot > tr > td.success,
.table > tfoot > tr > th.success,
.table > thead > tr.success > td,
.table > thead > tr.success > th,
.table > thead > tr > td.success,
.table > thead > tr > th.success {
    background-color: #dff0d8;
}

.table-hover > tbody > tr.success:hover > td,
.table-hover > tbody > tr.success:hover > th,
.table-hover > tbody > tr:hover > .success,
.table-hover > tbody > tr > td.success:hover,
.table-hover > tbody > tr > th.success:hover {
    background-color: #d0e9c6;
}

.table > tbody > tr.info > td,
.table > tbody > tr.info > th,
.table > tbody > tr > td.info,
.table > tbody > tr > th.info,
.table > tfoot > tr.info > td,
.table > tfoot > tr.info > th,
.table > tfoot > tr > td.info,
.table > tfoot > tr > th.info,
.table > thead > tr.info > td,
.table > thead > tr.info > th,
.table > thead > tr > td.info,
.table > thead > tr > th.info {
    background-color: #d9edf7;
}

.table-hover > tbody > tr.info:hover > td,
.table-hover > tbody > tr.info:hover > th,
.table-hover > tbody > tr:hover > .info,
.table-hover > tbody > tr > td.info:hover,
.table-hover > tbody > tr > th.info:hover {
    background-color: #c4e3f3;
}

.table > tbody > tr.warning > td,
.table > tbody > tr.warning > th,
.table > tbody > tr > td.warning,
.table > tbody > tr > th.warning,
.table > tfoot > tr.warning > td,
.table > tfoot > tr.warning > th,
.table > tfoot > tr > td.warning,
.table > tfoot > tr > th.warning,
.table > thead > tr.warning > td,
.table > thead > tr.warning > th,
.table > thead > tr > td.warning,
.table > thead > tr > th.warning {
    background-color: #fcf8e3;
}

.table-hover > tbody > tr.warning:hover > td,
.table-hover > tbody > tr.warning:hover > th,
.table-hover > tbody > tr:hover > .warning,
.table-hover > tbody > tr > td.warning:hover,
.table-hover > tbody > tr > th.warning:hover {
    background-color: #faf2cc;
}

.table > tbody > tr.danger > td,
.table > tbody > tr.danger > th,
.table > tbody > tr > td.danger,
.table > tbody > tr > th.danger,
.table > tfoot > tr.danger > td,
.table > tfoot > tr.danger > th,
.table > tfoot > tr > td.danger,
.table > tfoot > tr > th.danger,
.table > thead > tr.danger > td,
.table > thead > tr.danger > th,
.table > thead > tr > td.danger,
.table > thead > tr > th.danger {
    background-color: #f2dede;
}

.table-hover > tbody > tr.danger:hover > td,
.table-hover > tbody > tr.danger:hover > th,
.table-hover > tbody > tr:hover > .danger,
.table-hover > tbody > tr > td.danger:hover,
.table-hover > tbody > tr > th.danger:hover {
    background-color: #ebcccc;
}

.table-responsive {
    min-height: 0.01%;
    overflow-x: auto;
}

@media screen and (max-width: 767px) {
    .table-responsive {
        width: 100%;
        margin-bottom: 15px;
        overflow-y: hidden;
        -ms-overflow-style: -ms-autohiding-scrollbar;
        border: 1px solid #ddd;
    }

    .table-responsive > .table {
        margin-bottom: 0;
    }

    .table-responsive > .table > tbody > tr > td,
    .table-responsive > .table > tbody > tr > th,
    .table-responsive > .table > tfoot > tr > td,
    .table-responsive > .table > tfoot > tr > th,
    .table-responsive > .table > thead > tr > td,
    .table-responsive > .table > thead > tr > th {
        white-space: nowrap;
    }

    .table-responsive > .table-bordered {
        border: 0;
    }

    .table-responsive > .table-bordered > tbody > tr > td:first-child,
    .table-responsive > .table-bordered > tbody > tr > th:first-child,
    .table-responsive > .table-bordered > tfoot > tr > td:first-child,
    .table-responsive > .table-bordered > tfoot > tr > th:first-child,
    .table-responsive > .table-bordered > thead > tr > td:first-child,
    .table-responsive > .table-bordered > thead > tr > th:first-child {
        border-left: 0;
    }

    .table-responsive > .table-bordered > tbody > tr > td:last-child,
    .table-responsive > .table-bordered > tbody > tr > th:last-child,
    .table-responsive > .table-bordered > tfoot > tr > td:last-child,
    .table-responsive > .table-bordered > tfoot > tr > th:last-child,
    .table-responsive > .table-bordered > thead > tr > td:last-child,
    .table-responsive > .table-bordered > thead > tr > th:last-child {
        border-right: 0;
    }

    .table-responsive > .table-bordered > tbody > tr:last-child > td,
    .table-responsive > .table-bordered > tbody > tr:last-child > th,
    .table-responsive > .table-bordered > tfoot > tr:last-child > td,
    .table-responsive > .table-bordered > tfoot > tr:last-child > th {
        border-bottom: 0;
    }
}

fieldset {
    min-width: 0;
    margin: 0;
}

fieldset,
legend {
    padding: 0;
    border: 0;
}

legend {
    display: block;
    width: 100%;
    margin-bottom: 20px;
    font-size: 21px;
    line-height: inherit;
    color: #333;
    border-bottom: 1px solid #e5e5e5;
}

label {
    display: inline-block;
    max-width: 100%;
    margin-bottom: 5px;
    font-weight: 700;
}

input[type='search'] {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
}

input[type='checkbox'],
input[type='radio'] {
    margin: 4px 0 0;
    margin-top: 1px\9;
    line-height: normal;
}

input[type='file'] {
    display: block;
}

input[type='range'] {
    display: block;
    width: 100%;
}

select[multiple],
select[size] {
    height: auto;
}

input[type='checkbox']:focus,
input[type='file']:focus,
input[type='radio']:focus {
    outline: 5px auto -webkit-focus-ring-color;
    outline-offset: -2px;
}

output {
    padding-top: 7px;
}

.form-control,
output {
    display: block;
    font-size: 14px;
    line-height: 1.42857143;
    color: #555;
}

.form-control {
    width: 100%;
    height: 34px;
    padding: 6px 12px;
    background-color: #fff;
    background-image: none;
    border: 1px solid #ccc;
    border-radius: 4px;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
    -webkit-transition: border-color 0.15s ease-in-out,
        -webkit-box-shadow 0.15s ease-in-out;
    transition: border-color 0.15s ease-in-out,
        -webkit-box-shadow 0.15s ease-in-out;
    transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
    transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out,
        -webkit-box-shadow 0.15s ease-in-out;
}

.form-control:focus {
    border-color: #66afe9;
    outline: 0;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075),
        0 0 8px rgba(102, 175, 233, 0.6);
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075),
        0 0 8px rgba(102, 175, 233, 0.6);
}

.form-control::-moz-placeholder {
    color: #999;
    opacity: 1;
}

.form-control:-ms-input-placeholder {
    color: #999;
}

.form-control::-webkit-input-placeholder {
    color: #999;
}

.form-control::-ms-expand {
    background-color: transparent;
    border: 0;
}

.form-control[disabled],
.form-control[readonly],
fieldset[disabled] .form-control {
    background-color: #eee;
    opacity: 1;
}

textarea.form-control {
    height: auto;
}

input[type='search'] {
    -webkit-appearance: none;
}

@media screen and (-webkit-min-device-pixel-ratio: 0) {
    input[type='date'].form-control,
    input[type='datetime-local'].form-control,
    input[type='month'].form-control,
    input[type='time'].form-control {
        line-height: 34px;
    }

    .input-group-sm input[type='date'],
    .input-group-sm input[type='datetime-local'],
    .input-group-sm input[type='month'],
    .input-group-sm input[type='time'],
    input[type='date'].input-sm,
    input[type='datetime-local'].input-sm,
    input[type='month'].input-sm,
    input[type='time'].input-sm {
        line-height: 30px;
    }

    .input-group-lg input[type='date'],
    .input-group-lg input[type='datetime-local'],
    .input-group-lg input[type='month'],
    .input-group-lg input[type='time'],
    input[type='date'].input-lg,
    input[type='datetime-local'].input-lg,
    input[type='month'].input-lg,
    input[type='time'].input-lg {
        line-height: 46px;
    }
}

.form-group {
    margin-bottom: 15px;
}

.checkbox,
.radio {
    display: block;
    margin-top: 10px;
    margin-bottom: 10px;
}

.checkbox label,
.radio label {
    min-height: 20px;
    padding-left: 20px;
    margin-bottom: 0;
    font-weight: 400;
    cursor: pointer;
}

.checkbox-inline input[type='checkbox'],
.checkbox input[type='checkbox'],
.radio-inline input[type='radio'],
.radio input[type='radio'] {
    position: absolute;
    margin-top: 4px\9;
    margin-left: -20px;
}

.checkbox + .checkbox,
.radio + .radio {
    margin-top: -5px;
}

.checkbox-inline,
.radio-inline {
    position: relative;
    display: inline-block;
    padding-left: 20px;
    margin-bottom: 0;
    font-weight: 400;
    vertical-align: middle;
    cursor: pointer;
}

.checkbox-inline + .checkbox-inline,
.radio-inline + .radio-inline {
    margin-top: 0;
    margin-left: 10px;
}

.checkbox-inline.disabled,
.checkbox.disabled label,
.radio-inline.disabled,
.radio.disabled label,
fieldset[disabled] .checkbox-inline,
fieldset[disabled] .checkbox label,
fieldset[disabled] .radio-inline,
fieldset[disabled] .radio label,
fieldset[disabled] input[type='checkbox'],
fieldset[disabled] input[type='radio'],
input[type='checkbox'].disabled,
input[type='checkbox'][disabled],
input[type='radio'].disabled,
input[type='radio'][disabled] {
    cursor: not-allowed;
}

.form-control-static {
    min-height: 34px;
    padding-top: 7px;
    padding-bottom: 7px;
    margin-bottom: 0;
}

.form-control-static.input-lg,
.form-control-static.input-sm {
    padding-right: 0;
    padding-left: 0;
}

.input-sm {
    height: 30px;
    padding: 5px 10px;
    font-size: 12px;
    line-height: 1.5;
    border-radius: 3px;
}

select.input-sm {
    height: 30px;
    line-height: 30px;
}

select[multiple].input-sm,
textarea.input-sm {
    height: auto;
}

.form-group-sm .form-control {
    height: 30px;
    padding: 5px 10px;
    font-size: 12px;
    line-height: 1.5;
    border-radius: 3px;
}

.form-group-sm select.form-control {
    height: 30px;
    line-height: 30px;
}

.form-group-sm select[multiple].form-control,
.form-group-sm textarea.form-control {
    height: auto;
}

.form-group-sm .form-control-static {
    height: 30px;
    min-height: 32px;
    padding: 6px 10px;
    font-size: 12px;
    line-height: 1.5;
}

.input-lg {
    height: 46px;
    padding: 10px 16px;
    font-size: 18px;
    line-height: 1.3333333;
}

select.input-lg {
    height: 46px;
    line-height: 46px;
}

select[multiple].input-lg,
textarea.input-lg {
    height: auto;
}

.form-group-lg .form-control {
    height: 46px;
    padding: 10px 16px;
    font-size: 18px;
    line-height: 1.3333333;
    border-radius: 6px;
}

.form-group-lg select.form-control {
    height: 46px;
    line-height: 46px;
}

.form-group-lg select[multiple].form-control,
.form-group-lg textarea.form-control {
    height: auto;
}

.form-group-lg .form-control-static {
    height: 46px;
    min-height: 38px;
    padding: 11px 16px;
    font-size: 18px;
    line-height: 1.3333333;
}

.has-feedback {
    position: relative;
}

.has-feedback .form-control {
    padding-right: 42.5px;
}

.form-control-feedback {
    position: absolute;
    top: 0;
    right: 0;
    z-index: 2;
    display: block;
    width: 34px;
    height: 34px;
    line-height: 34px;
    text-align: center;
    pointer-events: none;
}

.form-group-lg .form-control + .form-control-feedback,
.input-group-lg + .form-control-feedback,
.input-lg + .form-control-feedback {
    width: 46px;
    height: 46px;
    line-height: 46px;
}

.form-group-sm .form-control + .form-control-feedback,
.input-group-sm + .form-control-feedback,
.input-sm + .form-control-feedback {
    width: 30px;
    height: 30px;
    line-height: 30px;
}

.has-success .checkbox,
.has-success .checkbox-inline,
.has-success.checkbox-inline label,
.has-success.checkbox label,
.has-success .control-label,
.has-success .help-block,
.has-success .radio,
.has-success .radio-inline,
.has-success.radio-inline label,
.has-success.radio label {
    color: #3c763d;
}

.has-success .form-control {
    border-color: #3c763d;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
}

.has-success .form-control:focus {
    border-color: #2b542c;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #67b168;
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #67b168;
}

.has-success .input-group-addon {
    color: #3c763d;
    background-color: #dff0d8;
    border-color: #3c763d;
}

.has-success .form-control-feedback {
    color: #3c763d;
}

.has-warning .checkbox,
.has-warning .checkbox-inline,
.has-warning.checkbox-inline label,
.has-warning.checkbox label,
.has-warning .control-label,
.has-warning .help-block,
.has-warning .radio,
.has-warning .radio-inline,
.has-warning.radio-inline label,
.has-warning.radio label {
    color: #8a6d3b;
}

.has-warning .form-control {
    border-color: #8a6d3b;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
}

.has-warning .form-control:focus {
    border-color: #66512c;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #c0a16b;
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #c0a16b;
}

.has-warning .input-group-addon {
    color: #8a6d3b;
    background-color: #fcf8e3;
    border-color: #8a6d3b;
}

.has-warning .form-control-feedback {
    color: #8a6d3b;
}

.has-error .checkbox,
.has-error .checkbox-inline,
.has-error.checkbox-inline label,
.has-error.checkbox label,
.has-error .control-label,
.has-error .help-block,
.has-error .radio,
.has-error .radio-inline,
.has-error.radio-inline label,
.has-error.radio label {
    color: #a94442;
}

.has-error .form-control {
    border-color: #a94442;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
}

.has-error .form-control:focus {
    border-color: #843534;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #ce8483;
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #ce8483;
}

.has-error .input-group-addon {
    color: #a94442;
    border-color: #a94442;
}

.has-error .form-control-feedback {
    color: #a94442;
}

.has-feedback label ~ .form-control-feedback {
    top: 25px;
}

.has-feedback label.sr-only ~ .form-control-feedback {
    top: 0;
}

.help-block {
    display: block;
    margin-top: 5px;
    margin-bottom: 10px;
    color: #737373;
}

@media (min-width: 768px) {
    .form-inline .form-group {
        display: inline-block;
        margin-bottom: 0;
        vertical-align: middle;
    }

    .form-inline .form-control {
        display: inline-block;
        width: auto;
        vertical-align: middle;
    }

    .form-inline .form-control-static {
        display: inline-block;
    }

    .form-inline .input-group {
        display: inline-table;
        vertical-align: middle;
    }

    .form-inline .input-group .form-control,
    .form-inline .input-group .input-group-addon,
    .form-inline .input-group .input-group-btn {
        width: auto;
    }

    .form-inline .input-group > .form-control {
        width: 100%;
    }

    .form-inline .control-label {
        margin-bottom: 0;
        vertical-align: middle;
    }

    .form-inline .checkbox,
    .form-inline .radio {
        display: inline-block;
        margin-top: 0;
        margin-bottom: 0;
        vertical-align: middle;
    }

    .form-inline .checkbox label,
    .form-inline .radio label {
        padding-left: 0;
    }

    .form-inline .checkbox input[type='checkbox'],
    .form-inline .radio input[type='radio'] {
        position: relative;
        margin-left: 0;
    }

    .form-inline .has-feedback .form-control-feedback {
        top: 0;
    }
}

.form-horizontal .checkbox,
.form-horizontal .checkbox-inline,
.form-horizontal .radio,
.form-horizontal .radio-inline {
    padding-top: 7px;
    margin-top: 0;
    margin-bottom: 0;
}

.form-horizontal .checkbox,
.form-horizontal .radio {
    min-height: 27px;
}

.form-horizontal .form-group {
    margin-right: -15px;
    margin-left: -15px;
}

@media (min-width: 768px) {
    .form-horizontal .control-label {
        padding-top: 7px;
        margin-bottom: 0;
        text-align: right;
    }
}

.form-horizontal .has-feedback .form-control-feedback {
    right: 15px;
}

@media (min-width: 768px) {
    .form-horizontal .form-group-lg .control-label {
        padding-top: 11px;
        font-size: 18px;
    }
}

@media (min-width: 768px) {
    .form-horizontal .form-group-sm .control-label {
        padding-top: 6px;
        font-size: 12px;
    }
}

.btn {
    display: inline-block;
    padding: 6px 12px;
    margin-bottom: 0;
    font-size: 14px;
    line-height: 1.42857143;
    text-align: center;
    white-space: nowrap;
    vertical-align: middle;
    -ms-touch-action: manipulation;
    touch-action: manipulation;
    cursor: pointer;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    background-image: none;
    border: 1px solid transparent;
}

.btn.active.focus,
.btn.active:focus,
.btn.focus,
.btn:active.focus,
.btn:active:focus,
.btn:focus {
    outline: 5px auto -webkit-focus-ring-color;
    outline-offset: -2px;
}

.btn.focus,
.btn:focus,
.btn:hover {
    color: #333;
    text-decoration: none;
}

.btn.active,
.btn:active {
    background-image: none;
    outline: 0;
    -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
    box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
}

.btn.disabled,
.btn[disabled],
fieldset[disabled] .btn {
    filter: alpha(opacity=65);
    -webkit-box-shadow: none;
    box-shadow: none;
    opacity: 0.65;
}

a.btn.disabled,
fieldset[disabled] a.btn {
    pointer-events: none;
}

.btn-default {
    color: #333;
    background-color: #fff;
    border-color: #ccc;
}

.btn-default.focus,
.btn-default:focus {
    color: #333;
    background-color: #e6e6e6;
    border-color: #8c8c8c;
}

.btn-default.active,
.btn-default:active,
.btn-default:hover,
.open > .dropdown-toggle.btn-default {
    color: #333;
    background-color: #e6e6e6;
    border-color: #adadad;
}

.btn-default.active.focus,
.btn-default.active:focus,
.btn-default.active:hover,
.btn-default:active.focus,
.btn-default:active:focus,
.btn-default:active:hover,
.open > .dropdown-toggle.btn-default.focus,
.open > .dropdown-toggle.btn-default:focus,
.open > .dropdown-toggle.btn-default:hover {
    color: #333;
    background-color: #d4d4d4;
    border-color: #8c8c8c;
}

.btn-default.active,
.btn-default:active,
.open > .dropdown-toggle.btn-default {
    background-image: none;
}

.btn-default.disabled.focus,
.btn-default.disabled:focus,
.btn-default.disabled:hover,
.btn-default[disabled].focus,
.btn-default[disabled]:focus,
.btn-default[disabled]:hover,
fieldset[disabled] .btn-default.focus,
fieldset[disabled] .btn-default:focus,
fieldset[disabled] .btn-default:hover {
    background-color: #fff;
    border-color: #ccc;
}

.btn-default .badge {
    color: #fff;
    background-color: #333;
}

.btn-primary {
    background-color: #337ab7;
    border-color: #2e6da4;
}

.btn-primary.focus,
.btn-primary:focus {
    color: #fff;
    background-color: #286090;
    border-color: #122b40;
}

.btn-primary.active,
.btn-primary:active,
.btn-primary:hover,
.open > .dropdown-toggle.btn-primary {
    color: #fff;
    background-color: #286090;
    border-color: #204d74;
}

.btn-primary.active.focus,
.btn-primary.active:focus,
.btn-primary.active:hover,
.btn-primary:active.focus,
.btn-primary:active:focus,
.btn-primary:active:hover,
.open > .dropdown-toggle.btn-primary.focus,
.open > .dropdown-toggle.btn-primary:focus,
.open > .dropdown-toggle.btn-primary:hover {
    color: #fff;
    background-color: #204d74;
    border-color: #122b40;
}

.btn-primary.active,
.btn-primary:active,
.open > .dropdown-toggle.btn-primary {
    background-image: none;
}

.btn-primary.disabled.focus,
.btn-primary.disabled:focus,
.btn-primary.disabled:hover,
.btn-primary[disabled].focus,
.btn-primary[disabled]:focus,
.btn-primary[disabled]:hover,
fieldset[disabled] .btn-primary.focus,
fieldset[disabled] .btn-primary:focus,
fieldset[disabled] .btn-primary:hover {
    background-color: #337ab7;
    border-color: #2e6da4;
}

.btn-primary .badge {
    color: #337ab7;
    background-color: #fff;
}

.btn-success {
    color: #fff;
    background-color: #5cb85c;
    border-color: #4cae4c;
}

.btn-success.focus,
.btn-success:focus {
    color: #fff;
    background-color: #449d44;
    border-color: #255625;
}

.btn-success.active,
.btn-success:active,
.btn-success:hover,
.open > .dropdown-toggle.btn-success {
    color: #fff;
    background-color: #449d44;
    border-color: #398439;
}

.btn-success.active.focus,
.btn-success.active:focus,
.btn-success.active:hover,
.btn-success:active.focus,
.btn-success:active:focus,
.btn-success:active:hover,
.open > .dropdown-toggle.btn-success.focus,
.open > .dropdown-toggle.btn-success:focus,
.open > .dropdown-toggle.btn-success:hover {
    color: #fff;
    background-color: #398439;
    border-color: #255625;
}

.btn-success.active,
.btn-success:active,
.open > .dropdown-toggle.btn-success {
    background-image: none;
}

.btn-success.disabled.focus,
.btn-success.disabled:focus,
.btn-success.disabled:hover,
.btn-success[disabled].focus,
.btn-success[disabled]:focus,
.btn-success[disabled]:hover,
fieldset[disabled] .btn-success.focus,
fieldset[disabled] .btn-success:focus,
fieldset[disabled] .btn-success:hover {
    background-color: #5cb85c;
    border-color: #4cae4c;
}

.btn-success .badge {
    color: #5cb85c;
    background-color: #fff;
}

.btn-info {
    color: #fff;
    background-color: #5bc0de;
    border-color: #46b8da;
}

.btn-info.focus,
.btn-info:focus {
    color: #fff;
    background-color: #31b0d5;
    border-color: #1b6d85;
}

.btn-info.active,
.btn-info:active,
.btn-info:hover,
.open > .dropdown-toggle.btn-info {
    color: #fff;
    background-color: #31b0d5;
    border-color: #269abc;
}

.btn-info.active.focus,
.btn-info.active:focus,
.btn-info.active:hover,
.btn-info:active.focus,
.btn-info:active:focus,
.btn-info:active:hover,
.open > .dropdown-toggle.btn-info.focus,
.open > .dropdown-toggle.btn-info:focus,
.open > .dropdown-toggle.btn-info:hover {
    color: #fff;
    background-color: #269abc;
    border-color: #1b6d85;
}

.btn-info.active,
.btn-info:active,
.open > .dropdown-toggle.btn-info {
    background-image: none;
}

.btn-info.disabled.focus,
.btn-info.disabled:focus,
.btn-info.disabled:hover,
.btn-info[disabled].focus,
.btn-info[disabled]:focus,
.btn-info[disabled]:hover,
fieldset[disabled] .btn-info.focus,
fieldset[disabled] .btn-info:focus,
fieldset[disabled] .btn-info:hover {
    background-color: #5bc0de;
    border-color: #46b8da;
}

.btn-info .badge {
    color: #5bc0de;
    background-color: #fff;
}

.btn-warning {
    color: #fff;
    background-color: #f0ad4e;
    border-color: #eea236;
}

.btn-warning.focus,
.btn-warning:focus {
    color: #fff;
    background-color: #ec971f;
    border-color: #985f0d;
}

.btn-warning.active,
.btn-warning:active,
.btn-warning:hover,
.open > .dropdown-toggle.btn-warning {
    color: #fff;
    background-color: #ec971f;
    border-color: #d58512;
}

.btn-warning.active.focus,
.btn-warning.active:focus,
.btn-warning.active:hover,
.btn-warning:active.focus,
.btn-warning:active:focus,
.btn-warning:active:hover,
.open > .dropdown-toggle.btn-warning.focus,
.open > .dropdown-toggle.btn-warning:focus,
.open > .dropdown-toggle.btn-warning:hover {
    color: #fff;
    background-color: #d58512;
    border-color: #985f0d;
}

.btn-warning.active,
.btn-warning:active,
.open > .dropdown-toggle.btn-warning {
    background-image: none;
}

.btn-warning.disabled.focus,
.btn-warning.disabled:focus,
.btn-warning.disabled:hover,
.btn-warning[disabled].focus,
.btn-warning[disabled]:focus,
.btn-warning[disabled]:hover,
fieldset[disabled] .btn-warning.focus,
fieldset[disabled] .btn-warning:focus,
fieldset[disabled] .btn-warning:hover {
    background-color: #f0ad4e;
    border-color: #eea236;
}

.btn-warning .badge {
    color: #f0ad4e;
    background-color: #fff;
}

.btn-danger {
    background-color: #d9534f;
    border-color: #d43f3a;
}

.btn-danger.focus,
.btn-danger:focus {
    color: #fff;
    background-color: #c9302c;
    border-color: #761c19;
}

.btn-danger.active,
.btn-danger:active,
.btn-danger:hover,
.open > .dropdown-toggle.btn-danger {
    color: #fff;
    background-color: #c9302c;
    border-color: #ac2925;
}

.btn-danger.active.focus,
.btn-danger.active:focus,
.btn-danger.active:hover,
.btn-danger:active.focus,
.btn-danger:active:focus,
.btn-danger:active:hover,
.open > .dropdown-toggle.btn-danger.focus,
.open > .dropdown-toggle.btn-danger:focus,
.open > .dropdown-toggle.btn-danger:hover {
    color: #fff;
    background-color: #ac2925;
    border-color: #761c19;
}

.btn-danger.active,
.btn-danger:active,
.open > .dropdown-toggle.btn-danger {
    background-image: none;
}

.btn-danger.disabled.focus,
.btn-danger.disabled:focus,
.btn-danger.disabled:hover,
.btn-danger[disabled].focus,
.btn-danger[disabled]:focus,
.btn-danger[disabled]:hover,
fieldset[disabled] .btn-danger.focus,
fieldset[disabled] .btn-danger:focus,
fieldset[disabled] .btn-danger:hover {
    background-color: #d9534f;
    border-color: #d43f3a;
}

.btn-danger .badge {
    color: #d9534f;
    background-color: #fff;
}

.btn-link {
    font-weight: 400;
    color: #337ab7;
    border-radius: 0;
}

.btn-link,
.btn-link.active,
.btn-link:active,
.btn-link[disabled],
fieldset[disabled] .btn-link {
    background-color: transparent;
    -webkit-box-shadow: none;
    box-shadow: none;
}

.btn-link,
.btn-link:active,
.btn-link:focus,
.btn-link:hover {
    border-color: transparent;
}

.btn-link:focus,
.btn-link:hover {
    color: #23527c;
    text-decoration: underline;
    background-color: transparent;
}

.btn-link[disabled]:focus,
.btn-link[disabled]:hover,
fieldset[disabled] .btn-link:focus,
fieldset[disabled] .btn-link:hover {
    color: #777;
    text-decoration: none;
}

.btn-group-lg > .btn,
.btn-lg {
    padding: 10px 16px;
    font-size: 18px;
    line-height: 1.3333333;
    border-radius: 6px;
}

.btn-group-sm > .btn,
.btn-sm {
    padding: 5px 10px;
    font-size: 12px;
    line-height: 1.5;
    border-radius: 3px;
}

.btn-group-xs > .btn,
.btn-xs {
    padding: 1px 5px;
    font-size: 12px;
    line-height: 1.5;
    border-radius: 3px;
}

.btn-block {
    display: block;
    width: 100%;
}

.btn-block + .btn-block {
    margin-top: 5px;
}

input[type='button'].btn-block,
input[type='reset'].btn-block,
input[type='submit'].btn-block {
    width: 100%;
}

.fade {
    opacity: 0;
    -webkit-transition: opacity 0.15s linear;
    transition: opacity 0.15s linear;
}

.fade.in {
    opacity: 1;
}

.collapse {
    display: none;
}

.collapse.in {
    display: block;
}

tr.collapse.in {
    display: table-row;
}

tbody.collapse.in {
    display: table-row-group;
}

.collapsing {
    position: relative;
    height: 0;
    overflow: hidden;
    -webkit-transition-timing-function: ease;
    transition-timing-function: ease;
    -webkit-transition-duration: 0.35s;
    transition-duration: 0.35s;
    -webkit-transition-property: height, visibility;
    transition-property: height, visibility;
}

.caret {
    display: inline-block;
    width: 0;
    height: 0;
    margin-left: 2px;
    vertical-align: middle;
    border-top: 4px dashed;
    border-top: 4px solid\9;
    border-right: 4px solid transparent;
    border-left: 4px solid transparent;
}

.dropdown,
.dropup {
    position: relative;
}

.dropdown-toggle:focus {
    outline: 0;
}

.dropdown-menu {
    position: absolute;
    top: 100%;
    left: 0;
    z-index: 1000;
    display: none;
    float: left;
    min-width: 160px;
    padding: 5px 0;
    margin: 2px 0 0;
    font-size: 14px;
    text-align: left;
    list-style: none;
    background-color: #fff;
    -webkit-background-clip: padding-box;
    background-clip: padding-box;
    border: 1px solid #ccc;
    border: 1px solid rgba(0, 0, 0, 0.15);
    border-radius: 4px;
    -webkit-box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
    box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
}

.dropdown-menu.pull-right {
    right: 0;
    left: auto;
}

.dropdown-menu .divider {
    height: 1px;
    margin: 9px 0;
    overflow: hidden;
    background-color: #e5e5e5;
}

.dropdown-menu > li > a {
    display: block;
    padding: 3px 20px;
    clear: both;
    font-weight: 400;
    line-height: 1.42857143;
    color: #333;
    white-space: nowrap;
}

.dropdown-menu > li > a:focus,
.dropdown-menu > li > a:hover {
    color: #262626;
    text-decoration: none;
    background-color: #f5f5f5;
}

.dropdown-menu > .active > a,
.dropdown-menu > .active > a:focus,
.dropdown-menu > .active > a:hover {
    color: #fff;
    text-decoration: none;
    background-color: #337ab7;
    outline: 0;
}

.dropdown-menu > .disabled > a,
.dropdown-menu > .disabled > a:focus,
.dropdown-menu > .disabled > a:hover {
    color: #777;
}

.dropdown-menu > .disabled > a:focus,
.dropdown-menu > .disabled > a:hover {
    text-decoration: none;
    cursor: not-allowed;
    background-color: transparent;
    background-image: none;
    filter: progid:DXImageTransform.Microsoft.gradient(enabled=false);
}

.open > .dropdown-menu {
    display: block;
}

.open > a {
    outline: 0;
}

.dropdown-menu-right {
    right: 0;
    left: auto;
}

.dropdown-menu-left {
    right: auto;
    left: 0;
}

.dropdown-header {
    display: block;
    padding: 3px 20px;
    font-size: 12px;
    line-height: 1.42857143;
    color: #777;
    white-space: nowrap;
}

.dropdown-backdrop {
    position: fixed;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    z-index: 990;
}

.pull-right > .dropdown-menu {
    right: 0;
    left: auto;
}

.dropup .caret,
.navbar-fixed-bottom .dropdown .caret {
    content: '';
    border-top: 0;
    border-bottom: 4px dashed;
    border-bottom: 4px solid\9;
}

.dropup .dropdown-menu,
.navbar-fixed-bottom .dropdown .dropdown-menu {
    top: auto;
    bottom: 100%;
    margin-bottom: 2px;
}

@media (min-width: 768px) {
    .navbar-right .dropdown-menu {
        right: 0;
        left: auto;
    }

    .navbar-right .dropdown-menu-left {
        right: auto;
        left: 0;
    }
}

.btn-group,
.btn-group-vertical {
    position: relative;
    display: inline-block;
    vertical-align: middle;
}

.btn-group-vertical > .btn,
.btn-group > .btn {
    position: relative;
    float: left;
}

.btn-group-vertical > .btn.active,
.btn-group-vertical > .btn:active,
.btn-group-vertical > .btn:focus,
.btn-group-vertical > .btn:hover,
.btn-group > .btn.active,
.btn-group > .btn:active,
.btn-group > .btn:focus,
.btn-group > .btn:hover {
    z-index: 2;
}

.btn-group .btn + .btn,
.btn-group .btn + .btn-group,
.btn-group .btn-group + .btn,
.btn-group .btn-group + .btn-group {
    margin-left: -1px;
}

.btn-toolbar {
    margin-left: -5px;
}

.btn-toolbar .btn,
.btn-toolbar .btn-group,
.btn-toolbar .input-group {
    float: left;
}

.btn-toolbar > .btn,
.btn-toolbar > .btn-group,
.btn-toolbar > .input-group {
    margin-left: 5px;
}

.btn-group > .btn:not(:first-child):not(:last-child):not(.dropdown-toggle) {
    border-radius: 0;
}

.btn-group > .btn:first-child {
    margin-left: 0;
}

.btn-group > .btn:first-child:not(:last-child):not(.dropdown-toggle) {
    border-top-right-radius: 0;
    border-bottom-right-radius: 0;
}

.btn-group > .btn:last-child:not(:first-child),
.btn-group > .dropdown-toggle:not(:first-child) {
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
}

.btn-group > .btn-group {
    float: left;
}

.btn-group > .btn-group:not(:first-child):not(:last-child) > .btn {
    border-radius: 0;
}

.btn-group > .btn-group:first-child:not(:last-child) > .btn:last-child,
.btn-group > .btn-group:first-child:not(:last-child) > .dropdown-toggle {
    border-top-right-radius: 0;
    border-bottom-right-radius: 0;
}

.btn-group > .btn-group:last-child:not(:first-child) > .btn:first-child {
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
}

.btn-group .dropdown-toggle:active,
.btn-group.open .dropdown-toggle {
    outline: 0;
}

.btn-group > .btn + .dropdown-toggle {
    padding-right: 8px;
    padding-left: 8px;
}

.btn-group > .btn-lg + .dropdown-toggle {
    padding-right: 12px;
    padding-left: 12px;
}

.btn-group.open .dropdown-toggle {
    -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
    box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
}

.btn-group.open .dropdown-toggle.btn-link {
    -webkit-box-shadow: none;
    box-shadow: none;
}

.btn .caret {
    margin-left: 0;
}

.btn-lg .caret {
    border-width: 5px 5px 0;
}

.dropup .btn-lg .caret {
    border-width: 0 5px 5px;
}

.btn-group-vertical > .btn,
.btn-group-vertical > .btn-group,
.btn-group-vertical > .btn-group > .btn {
    display: block;
    float: none;
    width: 100%;
    max-width: 100%;
}

.btn-group-vertical > .btn-group > .btn {
    float: none;
}

.btn-group-vertical > .btn + .btn,
.btn-group-vertical > .btn + .btn-group,
.btn-group-vertical > .btn-group + .btn,
.btn-group-vertical > .btn-group + .btn-group {
    margin-top: -1px;
    margin-left: 0;
}

.btn-group-vertical > .btn:not(:first-child):not(:last-child) {
    border-radius: 0;
}

.btn-group-vertical > .btn:first-child:not(:last-child) {
    border-top-left-radius: 4px;
    border-top-right-radius: 4px;
    border-bottom-right-radius: 0;
    border-bottom-left-radius: 0;
}

.btn-group-vertical > .btn:last-child:not(:first-child) {
    border-top-left-radius: 0;
    border-top-right-radius: 0;
    border-bottom-right-radius: 4px;
    border-bottom-left-radius: 4px;
}

.btn-group-vertical > .btn-group:not(:first-child):not(:last-child) > .btn {
    border-radius: 0;
}

.btn-group-vertical > .btn-group:first-child:not(:last-child) > .btn:last-child,
.btn-group-vertical
    > .btn-group:first-child:not(:last-child)
    > .dropdown-toggle {
    border-bottom-right-radius: 0;
    border-bottom-left-radius: 0;
}

.btn-group-vertical
    > .btn-group:last-child:not(:first-child)
    > .btn:first-child {
    border-top-left-radius: 0;
    border-top-right-radius: 0;
}

.btn-group-justified {
    display: table;
    width: 100%;
    table-layout: fixed;
    border-collapse: separate;
}

.btn-group-justified > .btn,
.btn-group-justified > .btn-group {
    display: table-cell;
    float: none;
    width: 1%;
}

.btn-group-justified > .btn-group .btn {
    width: 100%;
}

.btn-group-justified > .btn-group .dropdown-menu {
    left: auto;
}

[data-toggle='buttons'] > .btn-group > .btn input[type='checkbox'],
[data-toggle='buttons'] > .btn-group > .btn input[type='radio'],
[data-toggle='buttons'] > .btn input[type='checkbox'],
[data-toggle='buttons'] > .btn input[type='radio'] {
    position: absolute;
    clip: rect(0, 0, 0, 0);
    pointer-events: none;
}

.input-group {
    position: relative;
    display: table;
    border-collapse: separate;
}

.input-group[class*='col-'] {
    float: none;
    padding-right: 0;
    padding-left: 0;
}

.input-group .form-control {
    position: relative;
    z-index: 2;
    float: left;
    width: 100%;
    margin-bottom: 0;
}

.input-group .form-control:focus {
    z-index: 3;
}

.input-group-lg > .form-control,
.input-group-lg > .input-group-addon,
.input-group-lg > .input-group-btn > .btn {
    height: 46px;
    padding: 10px 16px;
    font-size: 18px;
    line-height: 1.3333333;
    border-radius: 6px;
}

select.input-group-lg > .form-control,
select.input-group-lg > .input-group-addon,
select.input-group-lg > .input-group-btn > .btn {
    height: 46px;
    line-height: 46px;
}

select[multiple].input-group-lg > .form-control,
select[multiple].input-group-lg > .input-group-addon,
select[multiple].input-group-lg > .input-group-btn > .btn,
textarea.input-group-lg > .form-control,
textarea.input-group-lg > .input-group-addon,
textarea.input-group-lg > .input-group-btn > .btn {
    height: auto;
}

.input-group-sm > .form-control,
.input-group-sm > .input-group-addon,
.input-group-sm > .input-group-btn > .btn {
    height: 30px;
    padding: 5px 10px;
    font-size: 12px;
    line-height: 1.5;
    border-radius: 3px;
}

select.input-group-sm > .form-control,
select.input-group-sm > .input-group-addon,
select.input-group-sm > .input-group-btn > .btn {
    height: 30px;
    line-height: 30px;
}

select[multiple].input-group-sm > .form-control,
select[multiple].input-group-sm > .input-group-addon,
select[multiple].input-group-sm > .input-group-btn > .btn,
textarea.input-group-sm > .form-control,
textarea.input-group-sm > .input-group-addon,
textarea.input-group-sm > .input-group-btn > .btn {
    height: auto;
}

.input-group-addon,
.input-group-btn,
.input-group .form-control {
    display: table-cell;
}

.input-group-addon:not(:first-child):not(:last-child),
.input-group-btn:not(:first-child):not(:last-child),
.input-group .form-control:not(:first-child):not(:last-child) {
    border-radius: 0;
}

.input-group-addon,
.input-group-btn {
    width: 1%;
    white-space: nowrap;
    vertical-align: middle;
}

.input-group-addon {
    padding: 6px 12px;
    font-size: 14px;
    font-weight: 400;
    line-height: 1;
    color: #555;
    background-color: #eee;
    border: 1px solid #ccc;
}

.input-group-addon.input-sm {
    padding: 5px 10px;
    font-size: 12px;
    border-radius: 3px;
}

.input-group-addon.input-lg {
    padding: 10px 16px;
    font-size: 18px;
    border-radius: 6px;
}

.input-group-addon input[type='checkbox'],
.input-group-addon input[type='radio'] {
    margin-top: 0;
}

.input-group-addon:first-child,
.input-group-btn:first-child > .btn,
.input-group-btn:first-child > .btn-group > .btn,
.input-group-btn:first-child > .dropdown-toggle,
.input-group-btn:last-child > .btn-group:not(:last-child) > .btn,
.input-group-btn:last-child > .btn:not(:last-child):not(.dropdown-toggle),
.input-group .form-control:first-child {
    border-top-right-radius: 0;
    border-bottom-right-radius: 0;
}

.input-group-addon:first-child {
    border-right: 0;
}

.input-group-addon:last-child,
.input-group-btn:first-child > .btn-group:not(:first-child) > .btn,
.input-group-btn:first-child > .btn:not(:first-child),
.input-group-btn:last-child > .btn,
.input-group-btn:last-child > .btn-group > .btn,
.input-group-btn:last-child > .dropdown-toggle,
.input-group .form-control:last-child {
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
}

.input-group-addon:last-child {
    border-left: 0;
}

.input-group-btn {
    font-size: 0;
    white-space: nowrap;
}

.input-group-btn,
.input-group-btn > .btn {
    position: relative;
}

.input-group-btn > .btn + .btn {
    margin-left: -1px;
}

.input-group-btn > .btn:active,
.input-group-btn > .btn:focus,
.input-group-btn > .btn:hover {
    z-index: 2;
}

.input-group-btn:first-child > .btn,
.input-group-btn:first-child > .btn-group {
    margin-right: -1px;
}

.input-group-btn:last-child > .btn,
.input-group-btn:last-child > .btn-group {
    z-index: 2;
    margin-left: -1px;
}

.nav {
    padding-left: 0;
    margin-bottom: 0;
    list-style: none;
}

.nav > li,
.nav > li > a {
    position: relative;
    display: block;
}

.nav > li > a {
    padding: 10px 15px;
}

.nav > li > a:focus,
.nav > li > a:hover {
    text-decoration: none;
    background-color: #eee;
}

.nav > li.disabled > a {
    color: #777;
}

.nav > li.disabled > a:focus,
.nav > li.disabled > a:hover {
    color: #777;
    text-decoration: none;
    cursor: not-allowed;
    background-color: transparent;
}

.nav .open > a,
.nav .open > a:focus,
.nav .open > a:hover {
    background-color: #eee;
    border-color: #337ab7;
}

.nav .nav-divider {
    height: 1px;
    margin: 9px 0;
    overflow: hidden;
    background-color: #e5e5e5;
}

.nav > li > a > img {
    max-width: none;
}

.nav-tabs {
    border-bottom: 1px solid #ddd;
}

.nav-tabs > li {
    float: left;
    margin-bottom: -1px;
}

.nav-tabs > li > a {
    margin-right: 2px;
    line-height: 1.42857143;
    border: 1px solid transparent;
    border-radius: 4px 4px 0 0;
}

.nav-tabs > li > a:hover {
    border-color: #eee #eee #ddd;
}

.nav-tabs > li.active > a,
.nav-tabs > li.active > a:focus,
.nav-tabs > li.active > a:hover {
    color: #555;
    cursor: default;
    background-color: #fff;
    border: 1px solid;
    border-color: #ddd #ddd transparent;
}

.nav-tabs.nav-justified {
    width: 100%;
    border-bottom: 0;
}

.nav-tabs.nav-justified > li {
    float: none;
}

.nav-tabs.nav-justified > li > a {
    margin-bottom: 5px;
    text-align: center;
}

.nav-tabs.nav-justified > .dropdown .dropdown-menu {
    top: auto;
    left: auto;
}

@media (min-width: 768px) {
    .nav-tabs.nav-justified > li {
        display: table-cell;
        width: 1%;
    }

    .nav-tabs.nav-justified > li > a {
        margin-bottom: 0;
    }
}

.nav-tabs.nav-justified > li > a {
    margin-right: 0;
    border-radius: 4px;
}

.nav-tabs.nav-justified > .active > a,
.nav-tabs.nav-justified > .active > a:focus,
.nav-tabs.nav-justified > .active > a:hover {
    border: 1px solid #ddd;
}

@media (min-width: 768px) {
    .nav-tabs.nav-justified > li > a {
        border-bottom: 1px solid #ddd;
        border-radius: 4px 4px 0 0;
    }

    .nav-tabs.nav-justified > .active > a,
    .nav-tabs.nav-justified > .active > a:focus,
    .nav-tabs.nav-justified > .active > a:hover {
        border-bottom-color: #fff;
    }
}

.nav-pills > li {
    float: left;
}

.nav-pills > li > a {
    border-radius: 4px;
}

.nav-pills > li + li {
    margin-left: 2px;
}

.nav-pills > li.active > a,
.nav-pills > li.active > a:focus,
.nav-pills > li.active > a:hover {
    color: #fff;
    background-color: #337ab7;
}

.nav-stacked > li {
    float: none;
}

.nav-stacked > li + li {
    margin-top: 2px;
    margin-left: 0;
}

.nav-justified {
    width: 100%;
}

.nav-justified > li {
    float: none;
}

.nav-justified > li > a {
    margin-bottom: 5px;
    text-align: center;
}

.nav-justified > .dropdown .dropdown-menu {
    top: auto;
    left: auto;
}

@media (min-width: 768px) {
    .nav-justified > li {
        display: table-cell;
        width: 1%;
    }

    .nav-justified > li > a {
        margin-bottom: 0;
    }
}

.nav-tabs-justified {
    border-bottom: 0;
}

.nav-tabs-justified > li > a {
    margin-right: 0;
    border-radius: 4px;
}

.nav-tabs-justified > .active > a,
.nav-tabs-justified > .active > a:focus,
.nav-tabs-justified > .active > a:hover {
    border: 1px solid #ddd;
}

@media (min-width: 768px) {
    .nav-tabs-justified > li > a {
        border-bottom: 1px solid #ddd;
        border-radius: 4px 4px 0 0;
    }

    .nav-tabs-justified > .active > a,
    .nav-tabs-justified > .active > a:focus,
    .nav-tabs-justified > .active > a:hover {
        border-bottom-color: #fff;
    }
}

.tab-content > .tab-pane {
    display: none;
}

.tab-content > .active {
    display: block;
}

.nav-tabs .dropdown-menu {
    margin-top: -1px;
    border-top-left-radius: 0;
    border-top-right-radius: 0;
}

.navbar {
    position: relative;
    min-height: 50px;
    margin-bottom: 20px;
    border: 1px solid transparent;
}

@media (min-width: 768px) {
    .navbar {
        border-radius: 4px;
    }
}

@media (min-width: 768px) {
    .navbar-header {
        float: left;
    }
}

.navbar-collapse {
    padding-right: 15px;
    padding-left: 15px;
    overflow-x: visible;
    -webkit-overflow-scrolling: touch;
    border-top: 1px solid transparent;
    -webkit-box-shadow: inset 0 1px 0 hsla(0, 0%, 100%, 0.1);
    box-shadow: inset 0 1px 0 hsla(0, 0%, 100%, 0.1);
}

.navbar-collapse.in {
    overflow-y: auto;
}

@media (min-width: 768px) {
    .navbar-collapse {
        width: auto;
        border-top: 0;
        -webkit-box-shadow: none;
        box-shadow: none;
    }

    .navbar-collapse.collapse {
        display: block !important;
        height: auto !important;
        padding-bottom: 0;
        overflow: visible !important;
    }

    .navbar-collapse.in {
        overflow-y: visible;
    }

    .navbar-fixed-bottom .navbar-collapse,
    .navbar-fixed-top .navbar-collapse,
    .navbar-static-top .navbar-collapse {
        padding-right: 0;
        padding-left: 0;
    }
}

.navbar-fixed-bottom .navbar-collapse,
.navbar-fixed-top .navbar-collapse {
    max-height: 340px;
}

@media (max-device-width: 480px) and (orientation: landscape) {
    .navbar-fixed-bottom .navbar-collapse,
    .navbar-fixed-top .navbar-collapse {
        max-height: 200px;
    }
}

.container-fluid > .navbar-collapse,
.container-fluid > .navbar-header,
.container > .navbar-collapse,
.container > .navbar-header {
    margin-right: -15px;
    margin-left: -15px;
}

@media (min-width: 768px) {
    .container-fluid > .navbar-collapse,
    .container-fluid > .navbar-header,
    .container > .navbar-collapse,
    .container > .navbar-header {
        margin-right: 0;
        margin-left: 0;
    }
}

.navbar-static-top {
    z-index: 1000;
    border-width: 0 0 1px;
}

@media (min-width: 768px) {
    .navbar-static-top {
        border-radius: 0;
    }
}

.navbar-fixed-bottom,
.navbar-fixed-top {
    position: fixed;
    right: 0;
    left: 0;
    z-index: 1030;
}

@media (min-width: 768px) {
    .navbar-fixed-bottom,
    .navbar-fixed-top {
        border-radius: 0;
    }
}

.navbar-fixed-top {
    top: 0;
    border-width: 0 0 1px;
}

.navbar-fixed-bottom {
    bottom: 0;
    margin-bottom: 0;
    border-width: 1px 0 0;
}

.navbar-brand {
    float: left;
    height: 50px;
    padding: 15px;
    font-size: 18px;
    line-height: 20px;
}

.navbar-brand:focus,
.navbar-brand:hover {
    text-decoration: none;
}

.navbar-brand > img {
    display: block;
}

@media (min-width: 768px) {
    .navbar > .container-fluid .navbar-brand,
    .navbar > .container .navbar-brand {
        margin-left: -15px;
    }
}

.navbar-toggle {
    position: relative;
    float: right;
    padding: 9px 10px;
    margin-top: 8px;
    margin-right: 15px;
    margin-bottom: 8px;
    background-color: transparent;
    background-image: none;
    border: 1px solid transparent;
    border-radius: 4px;
}

.navbar-toggle:focus {
    outline: 0;
}

.navbar-toggle .icon-bar {
    display: block;
    width: 22px;
    height: 2px;
    border-radius: 1px;
}

.navbar-toggle .icon-bar + .icon-bar {
    margin-top: 4px;
}

@media (min-width: 768px) {
    .navbar-toggle {
        display: none;
    }
}

.navbar-nav {
    margin: 7.5px -15px;
}

.navbar-nav > li > a {
    padding-top: 10px;
    padding-bottom: 10px;
    line-height: 20px;
}

@media (max-width: 767px) {
    .navbar-nav .open .dropdown-menu {
        position: static;
        float: none;
        width: auto;
        margin-top: 0;
        background-color: transparent;
        border: 0;
        -webkit-box-shadow: none;
        box-shadow: none;
    }

    .navbar-nav .open .dropdown-menu .dropdown-header,
    .navbar-nav .open .dropdown-menu > li > a {
        padding: 5px 15px 5px 25px;
    }

    .navbar-nav .open .dropdown-menu > li > a {
        line-height: 20px;
    }

    .navbar-nav .open .dropdown-menu > li > a:focus,
    .navbar-nav .open .dropdown-menu > li > a:hover {
        background-image: none;
    }
}

@media (min-width: 768px) {
    .navbar-nav {
        float: left;
        margin: 0;
    }

    .navbar-nav > li {
        float: left;
    }

    .navbar-nav > li > a {
        padding-top: 15px;
        padding-bottom: 15px;
    }
}

.navbar-form {
    padding: 10px 15px;
    margin: 8px -15px;
    border-top: 1px solid transparent;
    border-bottom: 1px solid transparent;
    -webkit-box-shadow: inset 0 1px 0 hsla(0, 0%, 100%, 0.1),
        0 1px 0 hsla(0, 0%, 100%, 0.1);
    box-shadow: inset 0 1px 0 hsla(0, 0%, 100%, 0.1),
        0 1px 0 hsla(0, 0%, 100%, 0.1);
}

@media (min-width: 768px) {
    .navbar-form .form-group {
        display: inline-block;
        margin-bottom: 0;
        vertical-align: middle;
    }

    .navbar-form .form-control {
        display: inline-block;
        width: auto;
        vertical-align: middle;
    }

    .navbar-form .form-control-static {
        display: inline-block;
    }

    .navbar-form .input-group {
        display: inline-table;
        vertical-align: middle;
    }

    .navbar-form .input-group .form-control,
    .navbar-form .input-group .input-group-addon,
    .navbar-form .input-group .input-group-btn {
        width: auto;
    }

    .navbar-form .input-group > .form-control {
        width: 100%;
    }

    .navbar-form .control-label {
        margin-bottom: 0;
        vertical-align: middle;
    }

    .navbar-form .checkbox,
    .navbar-form .radio {
        display: inline-block;
        margin-top: 0;
        margin-bottom: 0;
        vertical-align: middle;
    }

    .navbar-form .checkbox label,
    .navbar-form .radio label {
        padding-left: 0;
    }

    .navbar-form .checkbox input[type='checkbox'],
    .navbar-form .radio input[type='radio'] {
        position: relative;
        margin-left: 0;
    }

    .navbar-form .has-feedback .form-control-feedback {
        top: 0;
    }
}

@media (max-width: 767px) {
    .navbar-form .form-group {
        margin-bottom: 5px;
    }

    .navbar-form .form-group:last-child {
        margin-bottom: 0;
    }
}

@media (min-width: 768px) {
    .navbar-form {
        width: auto;
        padding-top: 0;
        padding-bottom: 0;
        margin-right: 0;
        margin-left: 0;
        border: 0;
        -webkit-box-shadow: none;
        box-shadow: none;
    }
}

.navbar-nav > li > .dropdown-menu {
    margin-top: 0;
    border-top-left-radius: 0;
    border-top-right-radius: 0;
}

.navbar-fixed-bottom .navbar-nav > li > .dropdown-menu {
    margin-bottom: 0;
    border-top-left-radius: 4px;
    border-top-right-radius: 4px;
    border-bottom-right-radius: 0;
    border-bottom-left-radius: 0;
}

.navbar-btn {
    margin-top: 8px;
    margin-bottom: 8px;
}

.navbar-btn.btn-sm {
    margin-top: 10px;
    margin-bottom: 10px;
}

.navbar-btn.btn-xs {
    margin-top: 14px;
    margin-bottom: 14px;
}

.navbar-text {
    margin-top: 15px;
    margin-bottom: 15px;
}

@media (min-width: 768px) {
    .navbar-text {
        float: left;
        margin-right: 15px;
        margin-left: 15px;
    }
}

@media (min-width: 768px) {
    .navbar-left {
        float: left !important;
    }

    .navbar-right {
        float: right !important;
        margin-right: -15px;
    }

    .navbar-right ~ .navbar-right {
        margin-right: 0;
    }
}

.navbar-default {
    background-color: #f8f8f8;
    border-color: #e7e7e7;
}

.navbar-default .navbar-brand {
    color: #777;
}

.navbar-default .navbar-brand:focus,
.navbar-default .navbar-brand:hover {
    color: #5e5e5e;
    background-color: transparent;
}

.navbar-default .navbar-nav > li > a,
.navbar-default .navbar-text {
    color: #777;
}

.navbar-default .navbar-nav > li > a:focus,
.navbar-default .navbar-nav > li > a:hover {
    color: #333;
    background-color: transparent;
}

.navbar-default .navbar-nav > .active > a,
.navbar-default .navbar-nav > .active > a:focus,
.navbar-default .navbar-nav > .active > a:hover {
    color: #555;
    background-color: #e7e7e7;
}

.navbar-default .navbar-nav > .disabled > a,
.navbar-default .navbar-nav > .disabled > a:focus,
.navbar-default .navbar-nav > .disabled > a:hover {
    color: #ccc;
    background-color: transparent;
}

.navbar-default .navbar-toggle {
    border-color: #ddd;
}

.navbar-default .navbar-toggle:focus,
.navbar-default .navbar-toggle:hover {
    background-color: #ddd;
}

.navbar-default .navbar-toggle .icon-bar {
    background-color: #888;
}

.navbar-default .navbar-collapse,
.navbar-default .navbar-form {
    border-color: #e7e7e7;
}

.navbar-default .navbar-nav > .open > a,
.navbar-default .navbar-nav > .open > a:focus,
.navbar-default .navbar-nav > .open > a:hover {
    color: #555;
    background-color: #e7e7e7;
}

@media (max-width: 767px) {
    .navbar-default .navbar-nav .open .dropdown-menu > li > a {
        color: #777;
    }

    .navbar-default .navbar-nav .open .dropdown-menu > li > a:focus,
    .navbar-default .navbar-nav .open .dropdown-menu > li > a:hover {
        color: #333;
        background-color: transparent;
    }

    .navbar-default .navbar-nav .open .dropdown-menu > .active > a,
    .navbar-default .navbar-nav .open .dropdown-menu > .active > a:focus,
    .navbar-default .navbar-nav .open .dropdown-menu > .active > a:hover {
        color: #555;
        background-color: #e7e7e7;
    }

    .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a,
    .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:focus,
    .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:hover {
        color: #ccc;
        background-color: transparent;
    }
}

.navbar-default .navbar-link {
    color: #777;
}

.navbar-default .navbar-link:hover {
    color: #333;
}

.navbar-default .btn-link {
    color: #777;
}

.navbar-default .btn-link:focus,
.navbar-default .btn-link:hover {
    color: #333;
}

.navbar-default .btn-link[disabled]:focus,
.navbar-default .btn-link[disabled]:hover,
fieldset[disabled] .navbar-default .btn-link:focus,
fieldset[disabled] .navbar-default .btn-link:hover {
    color: #ccc;
}

.navbar-inverse {
    background-color: #222;
    border-color: #080808;
}

.navbar-inverse .navbar-brand {
    color: #9d9d9d;
}

.navbar-inverse .navbar-brand:focus,
.navbar-inverse .navbar-brand:hover {
    color: #fff;
    background-color: transparent;
}

.navbar-inverse .navbar-nav > li > a,
.navbar-inverse .navbar-text {
    color: #9d9d9d;
}

.navbar-inverse .navbar-nav > li > a:focus,
.navbar-inverse .navbar-nav > li > a:hover {
    color: #fff;
    background-color: transparent;
}

.navbar-inverse .navbar-nav > .active > a,
.navbar-inverse .navbar-nav > .active > a:focus,
.navbar-inverse .navbar-nav > .active > a:hover {
    color: #fff;
    background-color: #080808;
}

.navbar-inverse .navbar-nav > .disabled > a,
.navbar-inverse .navbar-nav > .disabled > a:focus,
.navbar-inverse .navbar-nav > .disabled > a:hover {
    color: #444;
    background-color: transparent;
}

.navbar-inverse .navbar-toggle {
    border-color: #333;
}

.navbar-inverse .navbar-toggle:focus,
.navbar-inverse .navbar-toggle:hover {
    background-color: #333;
}

.navbar-inverse .navbar-toggle .icon-bar {
    background-color: #fff;
}

.navbar-inverse .navbar-collapse,
.navbar-inverse .navbar-form {
    border-color: #101010;
}

.navbar-inverse .navbar-nav > .open > a,
.navbar-inverse .navbar-nav > .open > a:focus,
.navbar-inverse .navbar-nav > .open > a:hover {
    color: #fff;
    background-color: #080808;
}

@media (max-width: 767px) {
    .navbar-inverse .navbar-nav .open .dropdown-menu > .dropdown-header {
        border-color: #080808;
    }

    .navbar-inverse .navbar-nav .open .dropdown-menu .divider {
        background-color: #080808;
    }

    .navbar-inverse .navbar-nav .open .dropdown-menu > li > a {
        color: #9d9d9d;
    }

    .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:focus,
    .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:hover {
        color: #fff;
        background-color: transparent;
    }

    .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a,
    .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:focus,
    .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:hover {
        color: #fff;
        background-color: #080808;
    }

    .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a,
    .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:focus,
    .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:hover {
        color: #444;
        background-color: transparent;
    }
}

.navbar-inverse .navbar-link {
    color: #9d9d9d;
}

.navbar-inverse .navbar-link:hover {
    color: #fff;
}

.navbar-inverse .btn-link {
    color: #9d9d9d;
}

.navbar-inverse .btn-link:focus,
.navbar-inverse .btn-link:hover {
    color: #fff;
}

.navbar-inverse .btn-link[disabled]:focus,
.navbar-inverse .btn-link[disabled]:hover,
fieldset[disabled] .navbar-inverse .btn-link:focus,
fieldset[disabled] .navbar-inverse .btn-link:hover {
    color: #444;
}

.breadcrumb {
    padding: 8px 15px;
    margin-bottom: 20px;
    list-style: none;
    background-color: #f5f5f5;
    border-radius: 4px;
}

.breadcrumb > li {
    display: inline-block;
}

.breadcrumb > li + li:before {
    padding: 0 5px;
    color: #ccc;
    content: '/ ';
}

.breadcrumb > .active {
    color: #777;
}

.pagination {
    display: inline-block;
    padding-left: 0;
    margin: 20px 0;
    border-radius: 4px;
}

.pagination > li {
    display: inline;
}

.pagination > li > a,
.pagination > li > span {
    position: relative;
    float: left;
    padding: 6px 12px;
    margin-left: -1px;
    line-height: 1.42857143;
    color: #337ab7;
    text-decoration: none;
    background-color: #fff;
    border: 1px solid #ddd;
}

.pagination > li:first-child > a,
.pagination > li:first-child > span {
    margin-left: 0;
    border-top-left-radius: 4px;
    border-bottom-left-radius: 4px;
}

.pagination > li:last-child > a,
.pagination > li:last-child > span {
    border-top-right-radius: 4px;
    border-bottom-right-radius: 4px;
}

.pagination > li > a:focus,
.pagination > li > a:hover,
.pagination > li > span:focus,
.pagination > li > span:hover {
    z-index: 2;
    color: #23527c;
    background-color: #eee;
    border-color: #ddd;
}

.pagination > .active > a,
.pagination > .active > a:focus,
.pagination > .active > a:hover,
.pagination > .active > span,
.pagination > .active > span:focus,
.pagination > .active > span:hover {
    z-index: 3;
    cursor: default;
    background-color: #337ab7;
    border-color: #337ab7;
}

.pagination > .disabled > a,
.pagination > .disabled > a:focus,
.pagination > .disabled > a:hover,
.pagination > .disabled > span,
.pagination > .disabled > span:focus,
.pagination > .disabled > span:hover {
    color: #777;
    cursor: not-allowed;
    background-color: #fff;
    border-color: #ddd;
}

.pagination-lg > li > a,
.pagination-lg > li > span {
    padding: 10px 16px;
    font-size: 18px;
    line-height: 1.3333333;
}

.pagination-lg > li:first-child > a,
.pagination-lg > li:first-child > span {
    border-top-left-radius: 6px;
    border-bottom-left-radius: 6px;
}

.pagination-lg > li:last-child > a,
.pagination-lg > li:last-child > span {
    border-top-right-radius: 6px;
    border-bottom-right-radius: 6px;
}

.pagination-sm > li > a,
.pagination-sm > li > span {
    padding: 5px 10px;
    font-size: 12px;
    line-height: 1.5;
}

.pagination-sm > li:first-child > a,
.pagination-sm > li:first-child > span {
    border-top-left-radius: 3px;
    border-bottom-left-radius: 3px;
}

.pagination-sm > li:last-child > a,
.pagination-sm > li:last-child > span {
    border-top-right-radius: 3px;
    border-bottom-right-radius: 3px;
}

.pager {
    padding-left: 0;
    margin: 20px 0;
    text-align: center;
    list-style: none;
}

.pager li {
    display: inline;
}

.pager li > a,
.pager li > span {
    display: inline-block;
    padding: 5px 14px;
    background-color: #fff;
    border: 1px solid #ddd;
    border-radius: 15px;
}

.pager li > a:focus,
.pager li > a:hover {
    text-decoration: none;
    background-color: #eee;
}

.pager .next > a,
.pager .next > span {
    float: right;
}

.pager .previous > a,
.pager .previous > span {
    float: left;
}

.pager .disabled > a,
.pager .disabled > a:focus,
.pager .disabled > a:hover,
.pager .disabled > span {
    color: #777;
    cursor: not-allowed;
    background-color: #fff;
}

.label {
    display: inline;
    padding: 0.2em 0.6em 0.3em;
    font-size: 75%;
    font-weight: 700;
    line-height: 1;
    color: #fff;
    text-align: center;
    white-space: nowrap;
    vertical-align: baseline;
    border-radius: 0.25em;
}

a.label:focus,
a.label:hover {
    color: #fff;
    text-decoration: none;
    cursor: pointer;
}

.label:empty {
    display: none;
}

.btn .label {
    position: relative;
    top: -1px;
}

.label-default {
    background-color: #777;
}

.label-default[href]:focus,
.label-default[href]:hover {
    background-color: #5e5e5e;
}

.label-primary {
    background-color: #337ab7;
}

.label-primary[href]:focus,
.label-primary[href]:hover {
    background-color: #286090;
}

.label-success {
    background-color: #5cb85c;
}

.label-success[href]:focus,
.label-success[href]:hover {
    background-color: #449d44;
}

.label-info {
    background-color: #5bc0de;
}

.label-info[href]:focus,
.label-info[href]:hover {
    background-color: #31b0d5;
}

.label-warning {
    background-color: #f0ad4e;
}

.label-warning[href]:focus,
.label-warning[href]:hover {
    background-color: #ec971f;
}

.label-danger {
    background-color: #d9534f;
}

.label-danger[href]:focus,
.label-danger[href]:hover {
    background-color: #c9302c;
}

.badge {
    display: inline-block;
    min-width: 10px;
    padding: 3px 7px;
    font-size: 12px;
    font-weight: 700;
    line-height: 1;
    color: #fff;
    text-align: center;
    white-space: nowrap;
    vertical-align: middle;
    background-color: #777;
    border-radius: 10px;
}

.badge:empty {
    display: none;
}

.btn .badge {
    position: relative;
    top: -1px;
}

.btn-group-xs > .btn .badge,
.btn-xs .badge {
    top: 0;
    padding: 1px 5px;
}

a.badge:focus,
a.badge:hover {
    color: #fff;
    text-decoration: none;
    cursor: pointer;
}

.list-group-item.active > .badge,
.nav-pills > .active > a > .badge {
    color: #337ab7;
    background-color: #fff;
}

.list-group-item > .badge {
    float: right;
}

.list-group-item > .badge + .badge {
    margin-right: 5px;
}

.nav-pills > li > a > .badge {
    margin-left: 3px;
}

.jumbotron {
    padding-top: 30px;
    padding-bottom: 30px;
    margin-bottom: 30px;
    background-color: #eee;
}

.jumbotron,
.jumbotron .h1,
.jumbotron h1 {
    color: inherit;
}

.jumbotron p {
    margin-bottom: 15px;
    font-size: 21px;
    font-weight: 200;
}

.jumbotron > hr {
    border-top-color: #d5d5d5;
}

.container-fluid .jumbotron,
.container .jumbotron {
    padding-right: 15px;
    padding-left: 15px;
    border-radius: 6px;
}

.jumbotron .container {
    max-width: 100%;
}

@media screen and (min-width: 768px) {
    .jumbotron {
        padding-top: 48px;
        padding-bottom: 48px;
    }

    .container-fluid .jumbotron,
    .container .jumbotron {
        padding-right: 60px;
        padding-left: 60px;
    }

    .jumbotron .h1,
    .jumbotron h1 {
        font-size: 63px;
    }
}

.thumbnail {
    display: block;
    padding: 4px;
    margin-bottom: 20px;
    line-height: 1.42857143;
    background-color: #fff;
    border: 1px solid #ddd;
    border-radius: 4px;
    -webkit-transition: border 0.2s ease-in-out;
    transition: border 0.2s ease-in-out;
}

.thumbnail > img,
.thumbnail a > img {
    margin-right: auto;
    margin-left: auto;
}

a.thumbnail.active,
a.thumbnail:focus,
a.thumbnail:hover {
    border-color: #337ab7;
}

.thumbnail .caption {
    padding: 9px;
    color: #333;
}

.alert {
    margin-bottom: 20px;
    border: 1px solid transparent;
    border-radius: 4px;
}

.alert h4 {
    margin-top: 0;
    color: inherit;
}

.alert .alert-link {
    font-weight: 700;
}

.alert > p,
.alert > ul {
    margin-bottom: 0;
}

.alert > p + p {
    margin-top: 5px;
}

.alert-dismissable,
.alert-dismissible {
    padding-right: 35px;
}

.alert-dismissable .close,
.alert-dismissible .close {
    position: relative;
    top: -2px;
    right: -21px;
    color: inherit;
}

.alert-success {
    color: #3c763d;
    background-color: #dff0d8;
    border-color: #d6e9c6;
}

.alert-success hr {
    border-top-color: #c9e2b3;
}

.alert-success .alert-link {
    color: #2b542c;
}

.alert-info {
    color: #31708f;
    background-color: #d9edf7;
    border-color: #bce8f1;
}

.alert-info hr {
    border-top-color: #a6e1ec;
}

.alert-info .alert-link {
    color: #245269;
}

.alert-warning {
    color: #8a6d3b;
    background-color: #fcf8e3;
    border-color: #faebcc;
}

.alert-warning hr {
    border-top-color: #f7e1b5;
}

.alert-warning .alert-link {
    color: #66512c;
}

.alert-danger {
    color: #a94442;
    background-color: #f2dede;
    border-color: #ebccd1;
}

.alert-danger hr {
    border-top-color: #e4b9c0;
}

.alert-danger .alert-link {
    color: #843534;
}

@-webkit-keyframes progress-bar-stripes {
    0% {
        background-position: 40px 0;
    }

    to {
        background-position: 0 0;
    }
}

@keyframes progress-bar-stripes {
    0% {
        background-position: 40px 0;
    }

    to {
        background-position: 0 0;
    }
}

.progress {
    height: 20px;
    margin-bottom: 20px;
    overflow: hidden;
    background-color: #f5f5f5;
    border-radius: 4px;
    -webkit-box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1);
    box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1);
}

.progress-bar {
    float: left;
    width: 0;
    height: 100%;
    font-size: 12px;
    line-height: 20px;
    color: #fff;
    text-align: center;
    background-color: #337ab7;
    -webkit-box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
    box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
    -webkit-transition: width 0.6s ease;
    transition: width 0.6s ease;
}

.progress-bar-striped,
.progress-striped .progress-bar {
    background-image: linear-gradient(
        45deg,
        hsla(0, 0%, 100%, 0.15) 25%,
        transparent 0,
        transparent 50%,
        hsla(0, 0%, 100%, 0.15) 0,
        hsla(0, 0%, 100%, 0.15) 75%,
        transparent 0,
        transparent
    );
    background-size: 40px 40px;
}

.progress-bar.active,
.progress.active .progress-bar {
    -webkit-animation: progress-bar-stripes 2s linear infinite;
    animation: progress-bar-stripes 2s linear infinite;
}

.progress-bar-success {
    background-color: #5cb85c;
}

.progress-striped .progress-bar-success {
    background-image: linear-gradient(
        45deg,
        hsla(0, 0%, 100%, 0.15) 25%,
        transparent 0,
        transparent 50%,
        hsla(0, 0%, 100%, 0.15) 0,
        hsla(0, 0%, 100%, 0.15) 75%,
        transparent 0,
        transparent
    );
}

.progress-bar-info {
    background-color: #5bc0de;
}

.progress-striped .progress-bar-info {
    background-image: linear-gradient(
        45deg,
        hsla(0, 0%, 100%, 0.15) 25%,
        transparent 0,
        transparent 50%,
        hsla(0, 0%, 100%, 0.15) 0,
        hsla(0, 0%, 100%, 0.15) 75%,
        transparent 0,
        transparent
    );
}

.progress-bar-warning {
    background-color: #f0ad4e;
}

.progress-striped .progress-bar-warning {
    background-image: linear-gradient(
        45deg,
        hsla(0, 0%, 100%, 0.15) 25%,
        transparent 0,
        transparent 50%,
        hsla(0, 0%, 100%, 0.15) 0,
        hsla(0, 0%, 100%, 0.15) 75%,
        transparent 0,
        transparent
    );
}

.progress-bar-danger {
    background-color: #d9534f;
}

.progress-striped .progress-bar-danger {
    background-image: linear-gradient(
        45deg,
        hsla(0, 0%, 100%, 0.15) 25%,
        transparent 0,
        transparent 50%,
        hsla(0, 0%, 100%, 0.15) 0,
        hsla(0, 0%, 100%, 0.15) 75%,
        transparent 0,
        transparent
    );
}

.media {
    margin-top: 15px;
}

.media:first-child {
    margin-top: 0;
}

.media,
.media-body {
    overflow: hidden;
    zoom: 1;
}

.media-body {
    width: 10000px;
}

.media-object {
    display: block;
}

.media-object.img-thumbnail {
    max-width: none;
}

.media-right,
.media > .pull-right {
    padding-left: 10px;
}

.media-left,
.media > .pull-left {
    padding-right: 10px;
}

.media-body,
.media-left,
.media-right {
    display: table-cell;
    vertical-align: top;
}

.media-middle {
    vertical-align: middle;
}

.media-bottom {
    vertical-align: bottom;
}

.media-heading {
    margin-top: 0;
    margin-bottom: 5px;
}

.media-list {
    padding-left: 0;
    list-style: none;
}

.list-group {
    padding-left: 0;
    margin-bottom: 20px;
}

.list-group-item {
    position: relative;
    display: block;
    padding: 10px 15px;
    margin-bottom: -1px;
    background-color: #fff;
    border: 1px solid #ddd;
}

.list-group-item:first-child {
    border-top-left-radius: 4px;
    border-top-right-radius: 4px;
}

.list-group-item:last-child {
    margin-bottom: 0;
    border-bottom-right-radius: 4px;
    border-bottom-left-radius: 4px;
}

a.list-group-item,
button.list-group-item {
    color: #555;
}

a.list-group-item .list-group-item-heading,
button.list-group-item .list-group-item-heading {
    color: #333;
}

a.list-group-item:focus,
a.list-group-item:hover,
button.list-group-item:focus,
button.list-group-item:hover {
    color: #555;
    text-decoration: none;
    background-color: #f5f5f5;
}

button.list-group-item {
    width: 100%;
    text-align: left;
}

.list-group-item.disabled,
.list-group-item.disabled:focus,
.list-group-item.disabled:hover {
    color: #777;
    cursor: not-allowed;
    background-color: #eee;
}

.list-group-item.disabled .list-group-item-heading,
.list-group-item.disabled:focus .list-group-item-heading,
.list-group-item.disabled:hover .list-group-item-heading {
    color: inherit;
}

.list-group-item.disabled .list-group-item-text,
.list-group-item.disabled:focus .list-group-item-text,
.list-group-item.disabled:hover .list-group-item-text {
    color: #777;
}

.list-group-item.active,
.list-group-item.active:focus,
.list-group-item.active:hover {
    z-index: 2;
    color: #fff;
    background-color: #337ab7;
    border-color: #337ab7;
}

.list-group-item.active .list-group-item-heading,
.list-group-item.active .list-group-item-heading > .small,
.list-group-item.active .list-group-item-heading > small,
.list-group-item.active:focus .list-group-item-heading,
.list-group-item.active:focus .list-group-item-heading > .small,
.list-group-item.active:focus .list-group-item-heading > small,
.list-group-item.active:hover .list-group-item-heading,
.list-group-item.active:hover .list-group-item-heading > .small,
.list-group-item.active:hover .list-group-item-heading > small {
    color: inherit;
}

.list-group-item.active .list-group-item-text,
.list-group-item.active:focus .list-group-item-text,
.list-group-item.active:hover .list-group-item-text {
    color: #c7ddef;
}

.list-group-item-success {
    color: #3c763d;
    background-color: #dff0d8;
}

a.list-group-item-success,
button.list-group-item-success {
    color: #3c763d;
}

a.list-group-item-success .list-group-item-heading,
button.list-group-item-success .list-group-item-heading {
    color: inherit;
}

a.list-group-item-success:focus,
a.list-group-item-success:hover,
button.list-group-item-success:focus,
button.list-group-item-success:hover {
    color: #3c763d;
    background-color: #d0e9c6;
}

a.list-group-item-success.active,
a.list-group-item-success.active:focus,
a.list-group-item-success.active:hover,
button.list-group-item-success.active,
button.list-group-item-success.active:focus,
button.list-group-item-success.active:hover {
    color: #fff;
    background-color: #3c763d;
    border-color: #3c763d;
}

.list-group-item-info {
    color: #31708f;
    background-color: #d9edf7;
}

a.list-group-item-info,
button.list-group-item-info {
    color: #31708f;
}

a.list-group-item-info .list-group-item-heading,
button.list-group-item-info .list-group-item-heading {
    color: inherit;
}

a.list-group-item-info:focus,
a.list-group-item-info:hover,
button.list-group-item-info:focus,
button.list-group-item-info:hover {
    color: #31708f;
    background-color: #c4e3f3;
}

a.list-group-item-info.active,
a.list-group-item-info.active:focus,
a.list-group-item-info.active:hover,
button.list-group-item-info.active,
button.list-group-item-info.active:focus,
button.list-group-item-info.active:hover {
    color: #fff;
    background-color: #31708f;
    border-color: #31708f;
}

.list-group-item-warning {
    color: #8a6d3b;
    background-color: #fcf8e3;
}

a.list-group-item-warning,
button.list-group-item-warning {
    color: #8a6d3b;
}

a.list-group-item-warning .list-group-item-heading,
button.list-group-item-warning .list-group-item-heading {
    color: inherit;
}

a.list-group-item-warning:focus,
a.list-group-item-warning:hover,
button.list-group-item-warning:focus,
button.list-group-item-warning:hover {
    color: #8a6d3b;
    background-color: #faf2cc;
}

a.list-group-item-warning.active,
a.list-group-item-warning.active:focus,
a.list-group-item-warning.active:hover,
button.list-group-item-warning.active,
button.list-group-item-warning.active:focus,
button.list-group-item-warning.active:hover {
    color: #fff;
    background-color: #8a6d3b;
    border-color: #8a6d3b;
}

.list-group-item-danger {
    color: #a94442;
    background-color: #f2dede;
}

a.list-group-item-danger,
button.list-group-item-danger {
    color: #a94442;
}

a.list-group-item-danger .list-group-item-heading,
button.list-group-item-danger .list-group-item-heading {
    color: inherit;
}

a.list-group-item-danger:focus,
a.list-group-item-danger:hover,
button.list-group-item-danger:focus,
button.list-group-item-danger:hover {
    color: #a94442;
    background-color: #ebcccc;
}

a.list-group-item-danger.active,
a.list-group-item-danger.active:focus,
a.list-group-item-danger.active:hover,
button.list-group-item-danger.active,
button.list-group-item-danger.active:focus,
button.list-group-item-danger.active:hover {
    color: #fff;
    background-color: #a94442;
    border-color: #a94442;
}

.list-group-item-heading {
    margin-top: 0;
    margin-bottom: 5px;
}

.list-group-item-text {
    margin-bottom: 0;
    line-height: 1.3;
}

.panel {
    margin-bottom: 20px;
    background-color: #fff;
    border: 1px solid transparent;
    border-radius: 4px;
    -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05);
    box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05);
}

.panel-body {
    padding: 15px;
}

.panel-heading {
    padding: 10px 15px;
    border-bottom: 1px solid transparent;
    border-top-left-radius: 3px;
    border-top-right-radius: 3px;
}

.panel-heading > .dropdown .dropdown-toggle,
.panel-title {
    color: inherit;
}

.panel-title {
    margin-top: 0;
    margin-bottom: 0;
    font-size: 16px;
}

.panel-title > .small,
.panel-title > .small > a,
.panel-title > a,
.panel-title > small,
.panel-title > small > a {
    color: inherit;
}

.panel-footer {
    padding: 10px 15px;
    background-color: #f5f5f5;
    border-top: 1px solid #ddd;
    border-bottom-right-radius: 3px;
    border-bottom-left-radius: 3px;
}

.panel > .list-group,
.panel > .panel-collapse > .list-group {
    margin-bottom: 0;
}

.panel > .list-group .list-group-item,
.panel > .panel-collapse > .list-group .list-group-item {
    border-width: 1px 0;
    border-radius: 0;
}

.panel > .list-group:first-child .list-group-item:first-child,
.panel
    > .panel-collapse
    > .list-group:first-child
    .list-group-item:first-child {
    border-top: 0;
    border-top-left-radius: 3px;
    border-top-right-radius: 3px;
}

.panel > .list-group:last-child .list-group-item:last-child,
.panel > .panel-collapse > .list-group:last-child .list-group-item:last-child {
    border-bottom: 0;
    border-bottom-right-radius: 3px;
    border-bottom-left-radius: 3px;
}

.panel
    > .panel-heading
    + .panel-collapse
    > .list-group
    .list-group-item:first-child {
    border-top-left-radius: 0;
    border-top-right-radius: 0;
}

.list-group + .panel-footer,
.panel-heading + .list-group .list-group-item:first-child {
    border-top-width: 0;
}

.panel > .panel-collapse > .table,
.panel > .table,
.panel > .table-responsive > .table {
    margin-bottom: 0;
}

.panel > .panel-collapse > .table caption,
.panel > .table-responsive > .table caption,
.panel > .table caption {
    padding-right: 15px;
    padding-left: 15px;
}

.panel > .table-responsive:first-child > .table:first-child,
.panel
    > .table-responsive:first-child
    > .table:first-child
    > tbody:first-child
    > tr:first-child,
.panel
    > .table-responsive:first-child
    > .table:first-child
    > thead:first-child
    > tr:first-child,
.panel > .table:first-child,
.panel > .table:first-child > tbody:first-child > tr:first-child,
.panel > .table:first-child > thead:first-child > tr:first-child {
    border-top-left-radius: 3px;
    border-top-right-radius: 3px;
}

.panel
    > .table-responsive:first-child
    > .table:first-child
    > tbody:first-child
    > tr:first-child
    td:first-child,
.panel
    > .table-responsive:first-child
    > .table:first-child
    > tbody:first-child
    > tr:first-child
    th:first-child,
.panel
    > .table-responsive:first-child
    > .table:first-child
    > thead:first-child
    > tr:first-child
    td:first-child,
.panel
    > .table-responsive:first-child
    > .table:first-child
    > thead:first-child
    > tr:first-child
    th:first-child,
.panel > .table:first-child > tbody:first-child > tr:first-child td:first-child,
.panel > .table:first-child > tbody:first-child > tr:first-child th:first-child,
.panel > .table:first-child > thead:first-child > tr:first-child td:first-child,
.panel
    > .table:first-child
    > thead:first-child
    > tr:first-child
    th:first-child {
    border-top-left-radius: 3px;
}

.panel
    > .table-responsive:first-child
    > .table:first-child
    > tbody:first-child
    > tr:first-child
    td:last-child,
.panel
    > .table-responsive:first-child
    > .table:first-child
    > tbody:first-child
    > tr:first-child
    th:last-child,
.panel
    > .table-responsive:first-child
    > .table:first-child
    > thead:first-child
    > tr:first-child
    td:last-child,
.panel
    > .table-responsive:first-child
    > .table:first-child
    > thead:first-child
    > tr:first-child
    th:last-child,
.panel > .table:first-child > tbody:first-child > tr:first-child td:last-child,
.panel > .table:first-child > tbody:first-child > tr:first-child th:last-child,
.panel > .table:first-child > thead:first-child > tr:first-child td:last-child,
.panel > .table:first-child > thead:first-child > tr:first-child th:last-child {
    border-top-right-radius: 3px;
}

.panel > .table-responsive:last-child > .table:last-child,
.panel
    > .table-responsive:last-child
    > .table:last-child
    > tbody:last-child
    > tr:last-child,
.panel
    > .table-responsive:last-child
    > .table:last-child
    > tfoot:last-child
    > tr:last-child,
.panel > .table:last-child,
.panel > .table:last-child > tbody:last-child > tr:last-child,
.panel > .table:last-child > tfoot:last-child > tr:last-child {
    border-bottom-right-radius: 3px;
    border-bottom-left-radius: 3px;
}

.panel
    > .table-responsive:last-child
    > .table:last-child
    > tbody:last-child
    > tr:last-child
    td:first-child,
.panel
    > .table-responsive:last-child
    > .table:last-child
    > tbody:last-child
    > tr:last-child
    th:first-child,
.panel
    > .table-responsive:last-child
    > .table:last-child
    > tfoot:last-child
    > tr:last-child
    td:first-child,
.panel
    > .table-responsive:last-child
    > .table:last-child
    > tfoot:last-child
    > tr:last-child
    th:first-child,
.panel > .table:last-child > tbody:last-child > tr:last-child td:first-child,
.panel > .table:last-child > tbody:last-child > tr:last-child th:first-child,
.panel > .table:last-child > tfoot:last-child > tr:last-child td:first-child,
.panel > .table:last-child > tfoot:last-child > tr:last-child th:first-child {
    border-bottom-left-radius: 3px;
}

.panel
    > .table-responsive:last-child
    > .table:last-child
    > tbody:last-child
    > tr:last-child
    td:last-child,
.panel
    > .table-responsive:last-child
    > .table:last-child
    > tbody:last-child
    > tr:last-child
    th:last-child,
.panel
    > .table-responsive:last-child
    > .table:last-child
    > tfoot:last-child
    > tr:last-child
    td:last-child,
.panel
    > .table-responsive:last-child
    > .table:last-child
    > tfoot:last-child
    > tr:last-child
    th:last-child,
.panel > .table:last-child > tbody:last-child > tr:last-child td:last-child,
.panel > .table:last-child > tbody:last-child > tr:last-child th:last-child,
.panel > .table:last-child > tfoot:last-child > tr:last-child td:last-child,
.panel > .table:last-child > tfoot:last-child > tr:last-child th:last-child {
    border-bottom-right-radius: 3px;
}

.panel > .panel-body + .table,
.panel > .panel-body + .table-responsive,
.panel > .table + .panel-body,
.panel > .table-responsive + .panel-body {
    border-top: 1px solid #ddd;
}

.panel > .table > tbody:first-child > tr:first-child td,
.panel > .table > tbody:first-child > tr:first-child th {
    border-top: 0;
}

.panel > .table-bordered,
.panel > .table-responsive > .table-bordered {
    border: 0;
}

.panel > .table-bordered > tbody > tr > td:first-child,
.panel > .table-bordered > tbody > tr > th:first-child,
.panel > .table-bordered > tfoot > tr > td:first-child,
.panel > .table-bordered > tfoot > tr > th:first-child,
.panel > .table-bordered > thead > tr > td:first-child,
.panel > .table-bordered > thead > tr > th:first-child,
.panel > .table-responsive > .table-bordered > tbody > tr > td:first-child,
.panel > .table-responsive > .table-bordered > tbody > tr > th:first-child,
.panel > .table-responsive > .table-bordered > tfoot > tr > td:first-child,
.panel > .table-responsive > .table-bordered > tfoot > tr > th:first-child,
.panel > .table-responsive > .table-bordered > thead > tr > td:first-child,
.panel > .table-responsive > .table-bordered > thead > tr > th:first-child {
    border-left: 0;
}

.panel > .table-bordered > tbody > tr > td:last-child,
.panel > .table-bordered > tbody > tr > th:last-child,
.panel > .table-bordered > tfoot > tr > td:last-child,
.panel > .table-bordered > tfoot > tr > th:last-child,
.panel > .table-bordered > thead > tr > td:last-child,
.panel > .table-bordered > thead > tr > th:last-child,
.panel > .table-responsive > .table-bordered > tbody > tr > td:last-child,
.panel > .table-responsive > .table-bordered > tbody > tr > th:last-child,
.panel > .table-responsive > .table-bordered > tfoot > tr > td:last-child,
.panel > .table-responsive > .table-bordered > tfoot > tr > th:last-child,
.panel > .table-responsive > .table-bordered > thead > tr > td:last-child,
.panel > .table-responsive > .table-bordered > thead > tr > th:last-child {
    border-right: 0;
}

.panel > .table-bordered > tbody > tr:first-child > td,
.panel > .table-bordered > tbody > tr:first-child > th,
.panel > .table-bordered > tbody > tr:last-child > td,
.panel > .table-bordered > tbody > tr:last-child > th,
.panel > .table-bordered > tfoot > tr:last-child > td,
.panel > .table-bordered > tfoot > tr:last-child > th,
.panel > .table-bordered > thead > tr:first-child > td,
.panel > .table-bordered > thead > tr:first-child > th,
.panel > .table-responsive > .table-bordered > tbody > tr:first-child > td,
.panel > .table-responsive > .table-bordered > tbody > tr:first-child > th,
.panel > .table-responsive > .table-bordered > tbody > tr:last-child > td,
.panel > .table-responsive > .table-bordered > tbody > tr:last-child > th,
.panel > .table-responsive > .table-bordered > tfoot > tr:last-child > td,
.panel > .table-responsive > .table-bordered > tfoot > tr:last-child > th,
.panel > .table-responsive > .table-bordered > thead > tr:first-child > td,
.panel > .table-responsive > .table-bordered > thead > tr:first-child > th {
    border-bottom: 0;
}

.panel > .table-responsive {
    margin-bottom: 0;
    border: 0;
}

.panel-group {
    margin-bottom: 20px;
}

.panel-group .panel {
    margin-bottom: 0;
    border-radius: 4px;
}

.panel-group .panel + .panel {
    margin-top: 5px;
}

.panel-group .panel-heading {
    border-bottom: 0;
}

.panel-group .panel-heading + .panel-collapse > .list-group,
.panel-group .panel-heading + .panel-collapse > .panel-body {
    border-top: 1px solid #ddd;
}

.panel-group .panel-footer {
    border-top: 0;
}

.panel-group .panel-footer + .panel-collapse .panel-body {
    border-bottom: 1px solid #ddd;
}

.panel-default {
    border-color: #ddd;
}

.panel-default > .panel-heading {
    color: #333;
    background-color: #f5f5f5;
    border-color: #ddd;
}

.panel-default > .panel-heading + .panel-collapse > .panel-body {
    border-top-color: #ddd;
}

.panel-default > .panel-heading .badge {
    color: #f5f5f5;
    background-color: #333;
}

.panel-default > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #ddd;
}

.panel-primary {
    border-color: #337ab7;
}

.panel-primary > .panel-heading {
    color: #fff;
    background-color: #337ab7;
    border-color: #337ab7;
}

.panel-primary > .panel-heading + .panel-collapse > .panel-body {
    border-top-color: #337ab7;
}

.panel-primary > .panel-heading .badge {
    color: #337ab7;
    background-color: #fff;
}

.panel-primary > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #337ab7;
}

.panel-success {
    border-color: #d6e9c6;
}

.panel-success > .panel-heading {
    color: #3c763d;
    background-color: #dff0d8;
    border-color: #d6e9c6;
}

.panel-success > .panel-heading + .panel-collapse > .panel-body {
    border-top-color: #d6e9c6;
}

.panel-success > .panel-heading .badge {
    color: #dff0d8;
    background-color: #3c763d;
}

.panel-success > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #d6e9c6;
}

.panel-info {
    border-color: #bce8f1;
}

.panel-info > .panel-heading {
    color: #31708f;
    background-color: #d9edf7;
    border-color: #bce8f1;
}

.panel-info > .panel-heading + .panel-collapse > .panel-body {
    border-top-color: #bce8f1;
}

.panel-info > .panel-heading .badge {
    color: #d9edf7;
    background-color: #31708f;
}

.panel-info > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #bce8f1;
}

.panel-warning {
    border-color: #faebcc;
}

.panel-warning > .panel-heading {
    color: #8a6d3b;
    background-color: #fcf8e3;
    border-color: #faebcc;
}

.panel-warning > .panel-heading + .panel-collapse > .panel-body {
    border-top-color: #faebcc;
}

.panel-warning > .panel-heading .badge {
    color: #fcf8e3;
    background-color: #8a6d3b;
}

.panel-warning > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #faebcc;
}

.panel-danger {
    border-color: #ebccd1;
}

.panel-danger > .panel-heading {
    color: #a94442;
    background-color: #f2dede;
    border-color: #ebccd1;
}

.panel-danger > .panel-heading + .panel-collapse > .panel-body {
    border-top-color: #ebccd1;
}

.panel-danger > .panel-heading .badge {
    color: #f2dede;
    background-color: #a94442;
}

.panel-danger > .panel-footer + .panel-collapse > .panel-body {
    border-bottom-color: #ebccd1;
}

.embed-responsive {
    position: relative;
    display: block;
    height: 0;
    padding: 0;
    overflow: hidden;
}

.embed-responsive .embed-responsive-item,
.embed-responsive embed,
.embed-responsive iframe,
.embed-responsive object,
.embed-responsive video {
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    width: 100%;
    height: 100%;
    border: 0;
}

.embed-responsive-16by9 {
    padding-bottom: 56.25%;
}

.embed-responsive-4by3 {
    padding-bottom: 75%;
}

.well {
    min-height: 20px;
    padding: 19px;
    margin-bottom: 20px;
    background-color: #f5f5f5;
    border: 1px solid #e3e3e3;
    border-radius: 4px;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
}

.well blockquote {
    border-color: #ddd;
    border-color: rgba(0, 0, 0, 0.15);
}

.well-lg {
    padding: 24px;
    border-radius: 6px;
}

.well-sm {
    padding: 9px;
    border-radius: 3px;
}

.close {
    float: right;
    font-size: 21px;
    font-weight: 700;
    line-height: 1;
    color: #000;
    text-shadow: 0 1px 0 #fff;
    filter: alpha(opacity=20);
    opacity: 0.2;
}

.close:focus,
.close:hover {
    color: #000;
    text-decoration: none;
    cursor: pointer;
    filter: alpha(opacity=50);
    opacity: 0.5;
}

button.close {
    -webkit-appearance: none;
    padding: 0;
    cursor: pointer;
    background: 0 0;
    border: 0;
}

.modal,
.modal-open {
    overflow: hidden;
}

.modal {
    position: fixed;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    z-index: 1050;
    display: none;
    -webkit-overflow-scrolling: touch;
    outline: 0;
}

.modal.fade .modal-dialog {
    -webkit-transition: -webkit-transform 0.3s ease-out;
    transition: -webkit-transform 0.3s ease-out;
    transition: transform 0.3s ease-out;
    transition: transform 0.3s ease-out, -webkit-transform 0.3s ease-out;
    -webkit-transform: translateY(-25%);
    transform: translateY(-25%);
}

.modal.in .modal-dialog {
    -webkit-transform: translate(0);
    transform: translate(0);
}

.modal-open .modal {
    overflow-x: hidden;
    overflow-y: auto;
}

.modal-dialog {
    position: relative;
    width: auto;
    margin: 10px;
}

.modal-content {
    -webkit-background-clip: padding-box;
    background-clip: padding-box;
    border: 1px solid #999;
    border: 1px solid rgba(0, 0, 0, 0.2);
    border-radius: 6px;
    outline: 0;
    -webkit-box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
    box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
}

.modal-backdrop {
    position: fixed;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    z-index: 1040;
    background-color: #000;
}

.modal-backdrop.fade {
    filter: alpha(opacity=0);
    opacity: 0;
}

.modal-backdrop.in {
    filter: alpha(opacity=50);
    opacity: 0.5;
}

.modal-header {
    padding: 15px;
    border-bottom: 1px solid #e5e5e5;
}

.modal-header .close {
    margin-top: -2px;
}

.modal-title {
    margin: 0;
    line-height: 1.42857143;
}

.modal-body {
    position: relative;
    padding: 15px;
}

.modal-footer {
    padding: 15px;
    text-align: right;
    border-top: 1px solid #e5e5e5;
}

.modal-footer .btn + .btn {
    margin-bottom: 0;
    margin-left: 5px;
}

.modal-footer .btn-group .btn + .btn {
    margin-left: -1px;
}

.modal-footer .btn-block + .btn-block {
    margin-left: 0;
}

.modal-scrollbar-measure {
    position: absolute;
    top: -9999px;
    width: 50px;
    height: 50px;
    overflow: scroll;
}

@media (min-width: 768px) {
    .modal-dialog {
        width: 600px;
        margin: 30px auto;
    }

    .modal-content {
        -webkit-box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5);
        box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5);
    }

    .modal-sm {
        width: 300px;
    }
}

@media (min-width: 992px) {
    .modal-lg {
        width: 900px;
    }
}

.tooltip {
    position: absolute;
    z-index: 1070;
    display: block;
    font-family: Helvetica Neue, Helvetica, Arial, sans-serif;
    font-size: 12px;
    font-style: normal;
    font-weight: 400;
    line-height: 1.42857143;
    text-align: left;
    text-align: start;
    text-decoration: none;
    text-shadow: none;
    text-transform: none;
    letter-spacing: normal;
    word-break: normal;
    word-spacing: normal;
    word-wrap: normal;
    white-space: normal;
    filter: alpha(opacity=0);
    opacity: 0;
    line-break: auto;
}

.tooltip.in {
    filter: alpha(opacity=90);
    opacity: 0.9;
}

.tooltip.top {
    padding: 5px 0;
    margin-top: -3px;
}

.tooltip.right {
    padding: 0 5px;
    margin-left: 3px;
}

.tooltip.bottom {
    padding: 5px 0;
    margin-top: 3px;
}

.tooltip.left {
    padding: 0 5px;
    margin-left: -3px;
}

.tooltip-inner {
    max-width: 200px;
    padding: 3px 8px;
    color: #fff;
    text-align: center;
    background-color: #000;
    border-radius: 4px;
}

.tooltip-arrow {
    position: absolute;
    width: 0;
    height: 0;
    border-color: transparent;
    border-style: solid;
}

.tooltip.top .tooltip-arrow {
    bottom: 0;
    left: 50%;
    margin-left: -5px;
    border-width: 5px 5px 0;
    border-top-color: #000;
}

.tooltip.top-left .tooltip-arrow {
    right: 5px;
}

.tooltip.top-left .tooltip-arrow,
.tooltip.top-right .tooltip-arrow {
    bottom: 0;
    margin-bottom: -5px;
    border-width: 5px 5px 0;
    border-top-color: #000;
}

.tooltip.top-right .tooltip-arrow {
    left: 5px;
}

.tooltip.right .tooltip-arrow {
    top: 50%;
    left: 0;
    margin-top: -5px;
    border-width: 5px 5px 5px 0;
    border-right-color: #000;
}

.tooltip.left .tooltip-arrow {
    top: 50%;
    right: 0;
    margin-top: -5px;
    border-width: 5px 0 5px 5px;
    border-left-color: #000;
}

.tooltip.bottom .tooltip-arrow {
    left: 50%;
    margin-left: -5px;
    border-width: 0 5px 5px;
    border-bottom-color: #000;
}

.tooltip.bottom-left .tooltip-arrow {
    top: 0;
    right: 5px;
    margin-top: -5px;
    border-width: 0 5px 5px;
    border-bottom-color: #000;
}

.tooltip.bottom-right .tooltip-arrow {
    top: 0;
    left: 5px;
    margin-top: -5px;
    border-width: 0 5px 5px;
    border-bottom-color: #000;
}

.popover {
    position: absolute;
    top: 0;
    left: 0;
    z-index: 1060;
    display: none;
    max-width: 276px;
    padding: 1px;
    font-family: Helvetica Neue, Helvetica, Arial, sans-serif;
    font-size: 14px;
    font-style: normal;
    font-weight: 400;
    line-height: 1.42857143;
    text-align: left;
    text-align: start;
    text-decoration: none;
    text-shadow: none;
    text-transform: none;
    letter-spacing: normal;
    word-break: normal;
    word-spacing: normal;
    word-wrap: normal;
    white-space: normal;
    background-color: #fff;
    -webkit-background-clip: padding-box;
    background-clip: padding-box;
    border: 1px solid #ccc;
    border: 1px solid rgba(0, 0, 0, 0.2);
    border-radius: 6px;
    -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
    box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
    line-break: auto;
}

.popover.top {
    margin-top: -10px;
}

.popover.right {
    margin-left: 10px;
}

.popover.bottom {
    margin-top: 10px;
}

.popover.left {
    margin-left: -10px;
}

.popover-title {
    padding: 8px 14px;
    margin: 0;
    font-size: 14px;
    background-color: #f7f7f7;
    border-bottom: 1px solid #ebebeb;
    border-radius: 5px 5px 0 0;
}

.popover-content {
    padding: 9px 14px;
}

.popover > .arrow,
.popover > .arrow:after {
    position: absolute;
    display: block;
    width: 0;
    height: 0;
    border-color: transparent;
    border-style: solid;
}

.popover > .arrow {
    border-width: 11px;
}

.popover > .arrow:after {
    content: '';
    border-width: 10px;
}

.popover.top > .arrow {
    bottom: -11px;
    left: 50%;
    margin-left: -11px;
    border-top-color: #999;
    border-top-color: rgba(0, 0, 0, 0.25);
    border-bottom-width: 0;
}

.popover.top > .arrow:after {
    bottom: 1px;
    margin-left: -10px;
    content: ' ';
    border-top-color: #fff;
    border-bottom-width: 0;
}

.popover.right > .arrow {
    top: 50%;
    left: -11px;
    margin-top: -11px;
    border-right-color: #999;
    border-right-color: rgba(0, 0, 0, 0.25);
    border-left-width: 0;
}

.popover.right > .arrow:after {
    bottom: -10px;
    left: 1px;
    content: ' ';
    border-right-color: #fff;
    border-left-width: 0;
}

.popover.bottom > .arrow {
    top: -11px;
    left: 50%;
    margin-left: -11px;
    border-top-width: 0;
    border-bottom-color: #999;
    border-bottom-color: rgba(0, 0, 0, 0.25);
}

.popover.bottom > .arrow:after {
    top: 1px;
    margin-left: -10px;
    content: ' ';
    border-top-width: 0;
    border-bottom-color: #fff;
}

.popover.left > .arrow {
    top: 50%;
    right: -11px;
    margin-top: -11px;
    border-right-width: 0;
    border-left-color: #999;
    border-left-color: rgba(0, 0, 0, 0.25);
}

.popover.left > .arrow:after {
    right: 1px;
    bottom: -10px;
    content: ' ';
    border-right-width: 0;
    border-left-color: #fff;
}

.carousel,
.carousel-inner {
    position: relative;
}

.carousel-inner {
    width: 100%;
    overflow: hidden;
}

.carousel-inner > .item {
    position: relative;
    display: none;
    -webkit-transition: left 0.6s ease-in-out;
    transition: left 0.6s ease-in-out;
}

.carousel-inner > .item > a > img,
.carousel-inner > .item > img {
    line-height: 1;
}

@media (-webkit-transform-3d), (transform-3d) {
    .carousel-inner > .item {
        -webkit-transition: -webkit-transform 0.6s ease-in-out;
        transition: -webkit-transform 0.6s ease-in-out;
        transition: transform 0.6s ease-in-out;
        transition: transform 0.6s ease-in-out,
            -webkit-transform 0.6s ease-in-out;
        -webkit-backface-visibility: hidden;
        backface-visibility: hidden;
        -webkit-perspective: 1000px;
        perspective: 1000px;
    }

    .carousel-inner > .item.active.right,
    .carousel-inner > .item.next {
        left: 0;
        -webkit-transform: translate3d(100%, 0, 0);
        transform: translate3d(100%, 0, 0);
    }

    .carousel-inner > .item.active.left,
    .carousel-inner > .item.prev {
        left: 0;
        -webkit-transform: translate3d(-100%, 0, 0);
        transform: translate3d(-100%, 0, 0);
    }

    .carousel-inner > .item.active,
    .carousel-inner > .item.next.left,
    .carousel-inner > .item.prev.right {
        left: 0;
        -webkit-transform: translateZ(0);
        transform: translateZ(0);
    }
}

.carousel-inner > .active,
.carousel-inner > .next,
.carousel-inner > .prev {
    display: block;
}

.carousel-inner > .active {
    left: 0;
}

.carousel-inner > .next,
.carousel-inner > .prev {
    position: absolute;
    top: 0;
    width: 100%;
}

.carousel-inner > .next {
    left: 100%;
}

.carousel-inner > .prev {
    left: -100%;
}

.carousel-inner > .next.left,
.carousel-inner > .prev.right {
    left: 0;
}

.carousel-inner > .active.left {
    left: -100%;
}

.carousel-inner > .active.right {
    left: 100%;
}

.carousel-control {
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    width: 15%;
    font-size: 20px;
    color: #fff;
    text-align: center;
    text-shadow: 0 1px 2px rgba(0, 0, 0, 0.6);
    background-color: transparent;
    filter: alpha(opacity=50);
    opacity: 0.5;
}

.carousel-control.left {
    background-image: -webkit-gradient(
        linear,
        left top,
        right top,
        color-stop(0, rgba(0, 0, 0, 0.5)),
        to(rgba(0, 0, 0, 0.0001))
    );
    background-image: linear-gradient(
        90deg,
        rgba(0, 0, 0, 0.5) 0,
        rgba(0, 0, 0, 0.0001)
    );
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr="#80000000",endColorstr="#00000000",GradientType=1);
    background-repeat: repeat-x;
}

.carousel-control.right {
    right: 0;
    left: auto;
    background-image: -webkit-gradient(
        linear,
        left top,
        right top,
        color-stop(0, rgba(0, 0, 0, 0.0001)),
        to(rgba(0, 0, 0, 0.5))
    );
    background-image: linear-gradient(
        90deg,
        rgba(0, 0, 0, 0.0001) 0,
        rgba(0, 0, 0, 0.5)
    );
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr="#00000000",endColorstr="#80000000",GradientType=1);
    background-repeat: repeat-x;
}

.carousel-control:focus,
.carousel-control:hover {
    color: #fff;
    text-decoration: none;
    filter: alpha(opacity=90);
    outline: 0;
    opacity: 0.9;
}

.carousel-control .glyphicon-chevron-left,
.carousel-control .glyphicon-chevron-right,
.carousel-control .icon-next,
.carousel-control .icon-prev {
    position: absolute;
    top: 50%;
    z-index: 5;
    display: inline-block;
    margin-top: -10px;
}

.carousel-control .glyphicon-chevron-left,
.carousel-control .icon-prev {
    left: 50%;
    margin-left: -10px;
}

.carousel-control .glyphicon-chevron-right,
.carousel-control .icon-next {
    right: 50%;
    margin-right: -10px;
}

.carousel-control .icon-next,
.carousel-control .icon-prev {
    width: 20px;
    height: 20px;
    font-family: serif;
    line-height: 1;
}

.carousel-control .icon-prev:before {
    content: '‹';
}

.carousel-control .icon-next:before {
    content: '›';
}

.carousel-indicators {
    position: absolute;
    bottom: 10px;
    left: 50%;
    z-index: 15;
    width: 60%;
    padding-left: 0;
    margin-left: -30%;
    text-align: center;
    list-style: none;
}

.carousel-indicators li {
    display: inline-block;
    width: 10px;
    height: 10px;
    margin: 1px;
    text-indent: -999px;
    cursor: pointer;
    background-color: #000\9;
    background-color: transparent;
    border: 1px solid #fff;
    border-radius: 10px;
}

.carousel-indicators .active {
    width: 12px;
    height: 12px;
    margin: 0;
    background-color: #fff;
}

.carousel-caption {
    position: absolute;
    right: 15%;
    bottom: 20px;
    left: 15%;
    z-index: 10;
    padding-top: 20px;
    padding-bottom: 20px;
    color: #fff;
    text-align: center;
    text-shadow: 0 1px 2px rgba(0, 0, 0, 0.6);
}

.carousel-caption .btn {
    text-shadow: none;
}

@media screen and (min-width: 768px) {
    .carousel-control .glyphicon-chevron-left,
    .carousel-control .glyphicon-chevron-right,
    .carousel-control .icon-next,
    .carousel-control .icon-prev {
        width: 30px;
        height: 30px;
        margin-top: -10px;
        font-size: 30px;
    }

    .carousel-control .glyphicon-chevron-left,
    .carousel-control .icon-prev {
        margin-left: -10px;
    }

    .carousel-control .glyphicon-chevron-right,
    .carousel-control .icon-next {
        margin-right: -10px;
    }

    .carousel-caption {
        right: 20%;
        left: 20%;
        padding-bottom: 30px;
    }

    .carousel-indicators {
        bottom: 20px;
    }
}

.btn-group-vertical > .btn-group:after,
.btn-group-vertical > .btn-group:before,
.btn-toolbar:after,
.btn-toolbar:before,
.clearfix:after,
.clearfix:before,
.container-fluid:after,
.container-fluid:before,
.container:after,
.container:before,
.dl-horizontal dd:after,
.dl-horizontal dd:before,
.form-horizontal .form-group:after,
.form-horizontal .form-group:before,
.modal-footer:after,
.modal-footer:before,
.modal-header:after,
.modal-header:before,
.nav:after,
.nav:before,
.navbar-collapse:after,
.navbar-collapse:before,
.navbar-header:after,
.navbar-header:before,
.navbar:after,
.navbar:before,
.pager:after,
.pager:before,
.panel-body:after,
.panel-body:before,
.row:after,
.row:before {
    display: table;
    content: ' ';
}

.btn-group-vertical > .btn-group:after,
.btn-toolbar:after,
.clearfix:after,
.container-fluid:after,
.container:after,
.dl-horizontal dd:after,
.form-horizontal .form-group:after,
.modal-footer:after,
.modal-header:after,
.nav:after,
.navbar-collapse:after,
.navbar-header:after,
.navbar:after,
.pager:after,
.panel-body:after,
.row:after {
    clear: both;
}

.center-block {
    display: block;
    margin-right: auto;
    margin-left: auto;
}

.pull-right {
    float: right !important;
}

.pull-left {
    float: left !important;
}

.hide {
    display: none !important;
}

.show {
    display: block !important;
}

.invisible {
    visibility: hidden;
}

.text-hide {
    font: 0/0 a;
    color: transparent;
    text-shadow: none;
    background-color: transparent;
    border: 0;
}

.hidden {
    display: none !important;
}

.affix {
    position: fixed;
}

@-ms-viewport {
    width: device-width;
}

.visible-lg,
.visible-lg-block,
.visible-lg-inline,
.visible-lg-inline-block,
.visible-md,
.visible-md-block,
.visible-md-inline,
.visible-md-inline-block,
.visible-sm,
.visible-sm-block,
.visible-sm-inline,
.visible-sm-inline-block,
.visible-xs,
.visible-xs-block,
.visible-xs-inline,
.visible-xs-inline-block {
    display: none !important;
}

@media (max-width: 767px) {
    .visible-xs {
        display: block !important;
    }

    table.visible-xs {
        display: table !important;
    }

    tr.visible-xs {
        display: table-row !important;
    }

    td.visible-xs,
    th.visible-xs {
        display: table-cell !important;
    }
}

@media (max-width: 767px) {
    .visible-xs-block {
        display: block !important;
    }
}

@media (max-width: 767px) {
    .visible-xs-inline {
        display: inline !important;
    }
}

@media (max-width: 767px) {
    .visible-xs-inline-block {
        display: inline-block !important;
    }
}

@media (min-width: 768px) and (max-width: 991px) {
    .visible-sm {
        display: block !important;
    }

    table.visible-sm {
        display: table !important;
    }

    tr.visible-sm {
        display: table-row !important;
    }

    td.visible-sm,
    th.visible-sm {
        display: table-cell !important;
    }
}

@media (min-width: 768px) and (max-width: 991px) {
    .visible-sm-block {
        display: block !important;
    }
}

@media (min-width: 768px) and (max-width: 991px) {
    .visible-sm-inline {
        display: inline !important;
    }
}

@media (min-width: 768px) and (max-width: 991px) {
    .visible-sm-inline-block {
        display: inline-block !important;
    }
}

@media (min-width: 992px) and (max-width: 1199px) {
    .visible-md {
        display: block !important;
    }

    table.visible-md {
        display: table !important;
    }

    tr.visible-md {
        display: table-row !important;
    }

    td.visible-md,
    th.visible-md {
        display: table-cell !important;
    }
}

@media (min-width: 992px) and (max-width: 1199px) {
    .visible-md-block {
        display: block !important;
    }
}

@media (min-width: 992px) and (max-width: 1199px) {
    .visible-md-inline {
        display: inline !important;
    }
}

@media (min-width: 992px) and (max-width: 1199px) {
    .visible-md-inline-block {
        display: inline-block !important;
    }
}

@media (min-width: 1200px) {
    .visible-lg {
        display: block !important;
    }

    table.visible-lg {
        display: table !important;
    }

    tr.visible-lg {
        display: table-row !important;
    }

    td.visible-lg,
    th.visible-lg {
        display: table-cell !important;
    }
}

@media (min-width: 1200px) {
    .visible-lg-block {
        display: block !important;
    }
}

@media (min-width: 1200px) {
    .visible-lg-inline {
        display: inline !important;
    }
}

@media (min-width: 1200px) {
    .visible-lg-inline-block {
        display: inline-block !important;
    }
}

@media (max-width: 767px) {
    .hidden-xs {
        display: none !important;
    }
}

@media (min-width: 768px) and (max-width: 991px) {
    .hidden-sm {
        display: none !important;
    }
}

@media (min-width: 992px) and (max-width: 1199px) {
    .hidden-md {
        display: none !important;
    }
}

@media (min-width: 1200px) {
    .hidden-lg {
        display: none !important;
    }
}

.visible-print {
    display: none !important;
}

@media print {
    .visible-print {
        display: block !important;
    }

    table.visible-print {
        display: table !important;
    }

    tr.visible-print {
        display: table-row !important;
    }

    td.visible-print,
    th.visible-print {
        display: table-cell !important;
    }
}

.visible-print-block {
    display: none !important;
}

@media print {
    .visible-print-block {
        display: block !important;
    }
}

.visible-print-inline {
    display: none !important;
}

@media print {
    .visible-print-inline {
        display: inline !important;
    }
}

.visible-print-inline-block {
    display: none !important;
}

@media print {
    .visible-print-inline-block {
        display: inline-block !important;
    }
}

@media print {
    .hidden-print {
        display: none !important;
    }
}

/*!
 *  Font Awesome 4.7.0 by @davegandy - http://fontawesome.io - @fontawesome
 *  License - http://fontawesome.io/license (Font: SIL OFL 1.1, CSS: MIT License)
 */
@font-face {
    font-family: FontAwesome;
    font-display: swap;
    src: url(https://cdn.kkday.com/pc-web/assets/fonts/fontawesome-webfont.eot?v=4.7.0);
    src: url(https://cdn.kkday.com/pc-web/assets/fonts/fontawesome-webfont.eot#iefix&v=4.7.0)
            format('embedded-opentype'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/fontawesome-webfont.woff2?v=4.7.0)
            format('woff2'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/fontawesome-webfont.woff?v=4.7.0)
            format('woff'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/fontawesome-webfont.ttf?v=4.7.0)
            format('truetype'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/fontawesome-webfont.svg?v=4.7.0#fontawesomeregular)
            format('svg');
    font-weight: 400;
    font-style: normal;
}

.fa {
    display: inline-block;
    font: normal normal normal 14px/1 FontAwesome;
    font-size: inherit;
    text-rendering: auto;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
}

.fa-lg {
    font-size: 1.33333333em;
    line-height: 0.75em;
    vertical-align: -15%;
}

.fa-2x {
    font-size: 2em;
}

.fa-3x {
    font-size: 3em;
}

.fa-4x {
    font-size: 4em;
}

.fa-5x {
    font-size: 5em;
}

.fa-fw {
    width: 1.28571429em;
    text-align: center;
}

.fa-ul {
    padding-left: 0;
    margin-left: 2.14285714em;
    list-style-type: none;
}

.fa-ul > li {
    position: relative;
}

.fa-li {
    position: absolute;
    left: -2.14285714em;
    width: 2.14285714em;
    top: 0.14285714em;
    text-align: center;
}

.fa-li.fa-lg {
    left: -1.85714286em;
}

.fa-border {
    padding: 0.2em 0.25em 0.15em;
    border: 0.08em solid #eee;
    border-radius: 0.1em;
}

.fa-pull-left {
    float: left;
}

.fa-pull-right {
    float: right;
}

.fa.fa-pull-left {
    margin-right: 0.3em;
}

.fa.fa-pull-right {
    margin-left: 0.3em;
}

.pull-right {
    float: right;
}

.pull-left {
    float: left;
}

.fa.pull-left {
    margin-right: 0.3em;
}

.fa.pull-right {
    margin-left: 0.3em;
}

.fa-spin {
    -webkit-animation: fa-spin 2s linear infinite;
    animation: fa-spin 2s linear infinite;
}

.fa-pulse {
    -webkit-animation: fa-spin 1s steps(8) infinite;
    animation: fa-spin 1s steps(8) infinite;
}

@-webkit-keyframes fa-spin {
    0% {
        -webkit-transform: rotate(0deg);
        transform: rotate(0deg);
    }

    to {
        -webkit-transform: rotate(359deg);
        transform: rotate(359deg);
    }
}

@keyframes fa-spin {
    0% {
        -webkit-transform: rotate(0deg);
        transform: rotate(0deg);
    }

    to {
        -webkit-transform: rotate(359deg);
        transform: rotate(359deg);
    }
}

.fa-rotate-90 {
    -ms-filter: 'progid:DXImageTransform.Microsoft.BasicImage(rotation=1)';
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
}

.fa-rotate-180 {
    -ms-filter: 'progid:DXImageTransform.Microsoft.BasicImage(rotation=2)';
    -webkit-transform: rotate(180deg);
    transform: rotate(180deg);
}

.fa-rotate-270 {
    -ms-filter: 'progid:DXImageTransform.Microsoft.BasicImage(rotation=3)';
    -webkit-transform: rotate(270deg);
    transform: rotate(270deg);
}

.fa-flip-horizontal {
    -ms-filter: 'progid:DXImageTransform.Microsoft.BasicImage(rotation=0, mirror=1)';
    -webkit-transform: scaleX(-1);
    transform: scaleX(-1);
}

.fa-flip-vertical {
    -ms-filter: 'progid:DXImageTransform.Microsoft.BasicImage(rotation=2, mirror=1)';
    -webkit-transform: scaleY(-1);
    transform: scaleY(-1);
}

:root .fa-flip-horizontal,
:root .fa-flip-vertical,
:root .fa-rotate-90,
:root .fa-rotate-180,
:root .fa-rotate-270 {
    -webkit-filter: none;
    filter: none;
}

.fa-stack {
    position: relative;
    display: inline-block;
    width: 2em;
    height: 2em;
    line-height: 2em;
    vertical-align: middle;
}

.fa-stack-1x,
.fa-stack-2x {
    position: absolute;
    left: 0;
    width: 100%;
    text-align: center;
}

.fa-stack-1x {
    line-height: inherit;
}

.fa-stack-2x {
    font-size: 2em;
}

.fa-inverse {
    color: #fff;
}

.fa-glass:before {
    content: '';
}

.fa-music:before {
    content: '';
}

.fa-search:before {
    content: '';
}

.fa-envelope-o:before {
    content: '';
}

.fa-heart:before {
    content: '';
}

.fa-star:before {
    content: '';
}

.fa-star-o:before {
    content: '';
}

.fa-user:before {
    content: '';
}

.fa-film:before {
    content: '';
}

.fa-th-large:before {
    content: '';
}

.fa-th:before {
    content: '';
}

.fa-th-list:before {
    content: '';
}

.fa-check:before {
    content: '';
}

.fa-close:before,
.fa-remove:before,
.fa-times:before {
    content: '';
}

.fa-search-plus:before {
    content: '';
}

.fa-search-minus:before {
    content: '';
}

.fa-power-off:before {
    content: '';
}

.fa-signal:before {
    content: '';
}

.fa-cog:before,
.fa-gear:before {
    content: '';
}

.fa-trash-o:before {
    content: '';
}

.fa-home:before {
    content: '';
}

.fa-file-o:before {
    content: '';
}

.fa-clock-o:before {
    content: '';
}

.fa-road:before {
    content: '';
}

.fa-download:before {
    content: '';
}

.fa-arrow-circle-o-down:before {
    content: '';
}

.fa-arrow-circle-o-up:before {
    content: '';
}

.fa-inbox:before {
    content: '';
}

.fa-play-circle-o:before {
    content: '';
}

.fa-repeat:before,
.fa-rotate-right:before {
    content: '';
}

.fa-refresh:before {
    content: '';
}

.fa-list-alt:before {
    content: '';
}

.fa-lock:before {
    content: '';
}

.fa-flag:before {
    content: '';
}

.fa-headphones:before {
    content: '';
}

.fa-volume-off:before {
    content: '';
}

.fa-volume-down:before {
    content: '';
}

.fa-volume-up:before {
    content: '';
}

.fa-qrcode:before {
    content: '';
}

.fa-barcode:before {
    content: '';
}

.fa-tag:before {
    content: '';
}

.fa-tags:before {
    content: '';
}

.fa-book:before {
    content: '';
}

.fa-bookmark:before {
    content: '';
}

.fa-print:before {
    content: '';
}

.fa-camera:before {
    content: '';
}

.fa-font:before {
    content: '';
}

.fa-bold:before {
    content: '';
}

.fa-italic:before {
    content: '';
}

.fa-text-height:before {
    content: '';
}

.fa-text-width:before {
    content: '';
}

.fa-align-left:before {
    content: '';
}

.fa-align-center:before {
    content: '';
}

.fa-align-right:before {
    content: '';
}

.fa-align-justify:before {
    content: '';
}

.fa-list:before {
    content: '';
}

.fa-dedent:before,
.fa-outdent:before {
    content: '';
}

.fa-indent:before {
    content: '';
}

.fa-video-camera:before {
    content: '';
}

.fa-image:before,
.fa-photo:before,
.fa-picture-o:before {
    content: '';
}

.fa-pencil:before {
    content: '';
}

.fa-map-marker:before {
    content: '';
}

.fa-adjust:before {
    content: '';
}

.fa-tint:before {
    content: '';
}

.fa-edit:before,
.fa-pencil-square-o:before {
    content: '';
}

.fa-share-square-o:before {
    content: '';
}

.fa-check-square-o:before {
    content: '';
}

.fa-arrows:before {
    content: '';
}

.fa-step-backward:before {
    content: '';
}

.fa-fast-backward:before {
    content: '';
}

.fa-backward:before {
    content: '';
}

.fa-play:before {
    content: '';
}

.fa-pause:before {
    content: '';
}

.fa-stop:before {
    content: '';
}

.fa-forward:before {
    content: '';
}

.fa-fast-forward:before {
    content: '';
}

.fa-step-forward:before {
    content: '';
}

.fa-eject:before {
    content: '';
}

.fa-chevron-left:before {
    content: '';
}

.fa-chevron-right:before {
    content: '';
}

.fa-plus-circle:before {
    content: '';
}

.fa-minus-circle:before {
    content: '';
}

.fa-times-circle:before {
    content: '';
}

.fa-check-circle:before {
    content: '';
}

.fa-question-circle:before {
    content: '';
}

.fa-info-circle:before {
    content: '';
}

.fa-crosshairs:before {
    content: '';
}

.fa-times-circle-o:before {
    content: '';
}

.fa-check-circle-o:before {
    content: '';
}

.fa-ban:before {
    content: '';
}

.fa-arrow-left:before {
    content: '';
}

.fa-arrow-right:before {
    content: '';
}

.fa-arrow-up:before {
    content: '';
}

.fa-arrow-down:before {
    content: '';
}

.fa-mail-forward:before,
.fa-share:before {
    content: '';
}

.fa-expand:before {
    content: '';
}

.fa-compress:before {
    content: '';
}

.fa-plus:before {
    content: '';
}

.fa-minus:before {
    content: '';
}

.fa-asterisk:before {
    content: '';
}

.fa-exclamation-circle:before {
    content: '';
}

.fa-gift:before {
    content: '';
}

.fa-leaf:before {
    content: '';
}

.fa-fire:before {
    content: '';
}

.fa-eye:before {
    content: '';
}

.fa-eye-slash:before {
    content: '';
}

.fa-exclamation-triangle:before,
.fa-warning:before {
    content: '';
}

.fa-plane:before {
    content: '';
}

.fa-calendar:before {
    content: '';
}

.fa-random:before {
    content: '';
}

.fa-comment:before {
    content: '';
}

.fa-magnet:before {
    content: '';
}

.fa-chevron-up:before {
    content: '';
}

.fa-chevron-down:before {
    content: '';
}

.fa-retweet:before {
    content: '';
}

.fa-shopping-cart:before {
    content: '';
}

.fa-folder:before {
    content: '';
}

.fa-folder-open:before {
    content: '';
}

.fa-arrows-v:before {
    content: '';
}

.fa-arrows-h:before {
    content: '';
}

.fa-bar-chart-o:before,
.fa-bar-chart:before {
    content: '';
}

.fa-twitter-square:before {
    content: '';
}

.fa-facebook-square:before {
    content: '';
}

.fa-camera-retro:before {
    content: '';
}

.fa-key:before {
    content: '';
}

.fa-cogs:before,
.fa-gears:before {
    content: '';
}

.fa-comments:before {
    content: '';
}

.fa-thumbs-o-up:before {
    content: '';
}

.fa-thumbs-o-down:before {
    content: '';
}

.fa-star-half:before {
    content: '';
}

.fa-heart-o:before {
    content: '';
}

.fa-sign-out:before {
    content: '';
}

.fa-linkedin-square:before {
    content: '';
}

.fa-thumb-tack:before {
    content: '';
}

.fa-external-link:before {
    content: '';
}

.fa-sign-in:before {
    content: '';
}

.fa-trophy:before {
    content: '';
}

.fa-github-square:before {
    content: '';
}

.fa-upload:before {
    content: '';
}

.fa-lemon-o:before {
    content: '';
}

.fa-phone:before {
    content: '';
}

.fa-square-o:before {
    content: '';
}

.fa-bookmark-o:before {
    content: '';
}

.fa-phone-square:before {
    content: '';
}

.fa-twitter:before {
    content: '';
}

.fa-facebook-f:before,
.fa-facebook:before {
    content: '';
}

.fa-github:before {
    content: '';
}

.fa-unlock:before {
    content: '';
}

.fa-credit-card:before {
    content: '';
}

.fa-feed:before,
.fa-rss:before {
    content: '';
}

.fa-hdd-o:before {
    content: '';
}

.fa-bullhorn:before {
    content: '';
}

.fa-bell:before {
    content: '';
}

.fa-certificate:before {
    content: '';
}

.fa-hand-o-right:before {
    content: '';
}

.fa-hand-o-left:before {
    content: '';
}

.fa-hand-o-up:before {
    content: '';
}

.fa-hand-o-down:before {
    content: '';
}

.fa-arrow-circle-left:before {
    content: '';
}

.fa-arrow-circle-right:before {
    content: '';
}

.fa-arrow-circle-up:before {
    content: '';
}

.fa-arrow-circle-down:before {
    content: '';
}

.fa-globe:before {
    content: '';
}

.fa-wrench:before {
    content: '';
}

.fa-tasks:before {
    content: '';
}

.fa-filter:before {
    content: '';
}

.fa-briefcase:before {
    content: '';
}

.fa-arrows-alt:before {
    content: '';
}

.fa-group:before,
.fa-users:before {
    content: '';
}

.fa-chain:before,
.fa-link:before {
    content: '';
}

.fa-cloud:before {
    content: '';
}

.fa-flask:before {
    content: '';
}

.fa-cut:before,
.fa-scissors:before {
    content: '';
}

.fa-copy:before,
.fa-files-o:before {
    content: '';
}

.fa-paperclip:before {
    content: '';
}

.fa-floppy-o:before,
.fa-save:before {
    content: '';
}

.fa-square:before {
    content: '';
}

.fa-bars:before,
.fa-navicon:before,
.fa-reorder:before {
    content: '';
}

.fa-list-ul:before {
    content: '';
}

.fa-list-ol:before {
    content: '';
}

.fa-strikethrough:before {
    content: '';
}

.fa-underline:before {
    content: '';
}

.fa-table:before {
    content: '';
}

.fa-magic:before {
    content: '';
}

.fa-truck:before {
    content: '';
}

.fa-pinterest:before {
    content: '';
}

.fa-pinterest-square:before {
    content: '';
}

.fa-google-plus-square:before {
    content: '';
}

.fa-google-plus:before {
    content: '';
}

.fa-money:before {
    content: '';
}

.fa-caret-down:before {
    content: '';
}

.fa-caret-up:before {
    content: '';
}

.fa-caret-left:before {
    content: '';
}

.fa-caret-right:before {
    content: '';
}

.fa-columns:before {
    content: '';
}

.fa-sort:before,
.fa-unsorted:before {
    content: '';
}

.fa-sort-desc:before,
.fa-sort-down:before {
    content: '';
}

.fa-sort-asc:before,
.fa-sort-up:before {
    content: '';
}

.fa-envelope:before {
    content: '';
}

.fa-linkedin:before {
    content: '';
}

.fa-rotate-left:before,
.fa-undo:before {
    content: '';
}

.fa-gavel:before,
.fa-legal:before {
    content: '';
}

.fa-dashboard:before,
.fa-tachometer:before {
    content: '';
}

.fa-comment-o:before {
    content: '';
}

.fa-comments-o:before {
    content: '';
}

.fa-bolt:before,
.fa-flash:before {
    content: '';
}

.fa-sitemap:before {
    content: '';
}

.fa-umbrella:before {
    content: '';
}

.fa-clipboard:before,
.fa-paste:before {
    content: '';
}

.fa-lightbulb-o:before {
    content: '';
}

.fa-exchange:before {
    content: '';
}

.fa-cloud-download:before {
    content: '';
}

.fa-cloud-upload:before {
    content: '';
}

.fa-user-md:before {
    content: '';
}

.fa-stethoscope:before {
    content: '';
}

.fa-suitcase:before {
    content: '';
}

.fa-bell-o:before {
    content: '';
}

.fa-coffee:before {
    content: '';
}

.fa-cutlery:before {
    content: '';
}

.fa-file-text-o:before {
    content: '';
}

.fa-building-o:before {
    content: '';
}

.fa-hospital-o:before {
    content: '';
}

.fa-ambulance:before {
    content: '';
}

.fa-medkit:before {
    content: '';
}

.fa-fighter-jet:before {
    content: '';
}

.fa-beer:before {
    content: '';
}

.fa-h-square:before {
    content: '';
}

.fa-plus-square:before {
    content: '';
}

.fa-angle-double-left:before {
    content: '';
}

.fa-angle-double-right:before {
    content: '';
}

.fa-angle-double-up:before {
    content: '';
}

.fa-angle-double-down:before {
    content: '';
}

.fa-angle-left:before {
    content: '';
}

.fa-angle-right:before {
    content: '';
}

.fa-angle-up:before {
    content: '';
}

.fa-angle-down:before {
    content: '';
}

.fa-desktop:before {
    content: '';
}

.fa-laptop:before {
    content: '';
}

.fa-tablet:before {
    content: '';
}

.fa-mobile-phone:before,
.fa-mobile:before {
    content: '';
}

.fa-circle-o:before {
    content: '';
}

.fa-quote-left:before {
    content: '';
}

.fa-quote-right:before {
    content: '';
}

.fa-spinner:before {
    content: '';
}

.fa-circle:before {
    content: '';
}

.fa-mail-reply:before,
.fa-reply:before {
    content: '';
}

.fa-github-alt:before {
    content: '';
}

.fa-folder-o:before {
    content: '';
}

.fa-folder-open-o:before {
    content: '';
}

.fa-smile-o:before {
    content: '';
}

.fa-frown-o:before {
    content: '';
}

.fa-meh-o:before {
    content: '';
}

.fa-gamepad:before {
    content: '';
}

.fa-keyboard-o:before {
    content: '';
}

.fa-flag-o:before {
    content: '';
}

.fa-flag-checkered:before {
    content: '';
}

.fa-terminal:before {
    content: '';
}

.fa-code:before {
    content: '';
}

.fa-mail-reply-all:before,
.fa-reply-all:before {
    content: '';
}

.fa-star-half-empty:before,
.fa-star-half-full:before,
.fa-star-half-o:before {
    content: '';
}

.fa-location-arrow:before {
    content: '';
}

.fa-crop:before {
    content: '';
}

.fa-code-fork:before {
    content: '';
}

.fa-chain-broken:before,
.fa-unlink:before {
    content: '';
}

.fa-question:before {
    content: '';
}

.fa-info:before {
    content: '';
}

.fa-exclamation:before {
    content: '';
}

.fa-superscript:before {
    content: '';
}

.fa-subscript:before {
    content: '';
}

.fa-eraser:before {
    content: '';
}

.fa-puzzle-piece:before {
    content: '';
}

.fa-microphone:before {
    content: '';
}

.fa-microphone-slash:before {
    content: '';
}

.fa-shield:before {
    content: '';
}

.fa-calendar-o:before {
    content: '';
}

.fa-fire-extinguisher:before {
    content: '';
}

.fa-rocket:before {
    content: '';
}

.fa-maxcdn:before {
    content: '';
}

.fa-chevron-circle-left:before {
    content: '';
}

.fa-chevron-circle-right:before {
    content: '';
}

.fa-chevron-circle-up:before {
    content: '';
}

.fa-chevron-circle-down:before {
    content: '';
}

.fa-html5:before {
    content: '';
}

.fa-css3:before {
    content: '';
}

.fa-anchor:before {
    content: '';
}

.fa-unlock-alt:before {
    content: '';
}

.fa-bullseye:before {
    content: '';
}

.fa-ellipsis-h:before {
    content: '';
}

.fa-ellipsis-v:before {
    content: '';
}

.fa-rss-square:before {
    content: '';
}

.fa-play-circle:before {
    content: '';
}

.fa-ticket:before {
    content: '';
}

.fa-minus-square:before {
    content: '';
}

.fa-minus-square-o:before {
    content: '';
}

.fa-level-up:before {
    content: '';
}

.fa-level-down:before {
    content: '';
}

.fa-check-square:before {
    content: '';
}

.fa-pencil-square:before {
    content: '';
}

.fa-external-link-square:before {
    content: '';
}

.fa-share-square:before {
    content: '';
}

.fa-compass:before {
    content: '';
}

.fa-caret-square-o-down:before,
.fa-toggle-down:before {
    content: '';
}

.fa-caret-square-o-up:before,
.fa-toggle-up:before {
    content: '';
}

.fa-caret-square-o-right:before,
.fa-toggle-right:before {
    content: '';
}

.fa-eur:before,
.fa-euro:before {
    content: '';
}

.fa-gbp:before {
    content: '';
}

.fa-dollar:before,
.fa-usd:before {
    content: '';
}

.fa-inr:before,
.fa-rupee:before {
    content: '';
}

.fa-cny:before,
.fa-jpy:before,
.fa-rmb:before,
.fa-yen:before {
    content: '';
}

.fa-rouble:before,
.fa-rub:before,
.fa-ruble:before {
    content: '';
}

.fa-krw:before,
.fa-won:before {
    content: '';
}

.fa-bitcoin:before,
.fa-btc:before {
    content: '';
}

.fa-file:before {
    content: '';
}

.fa-file-text:before {
    content: '';
}

.fa-sort-alpha-asc:before {
    content: '';
}

.fa-sort-alpha-desc:before {
    content: '';
}

.fa-sort-amount-asc:before {
    content: '';
}

.fa-sort-amount-desc:before {
    content: '';
}

.fa-sort-numeric-asc:before {
    content: '';
}

.fa-sort-numeric-desc:before {
    content: '';
}

.fa-thumbs-up:before {
    content: '';
}

.fa-thumbs-down:before {
    content: '';
}

.fa-youtube-square:before {
    content: '';
}

.fa-youtube:before {
    content: '';
}

.fa-xing:before {
    content: '';
}

.fa-xing-square:before {
    content: '';
}

.fa-youtube-play:before {
    content: '';
}

.fa-dropbox:before {
    content: '';
}

.fa-stack-overflow:before {
    content: '';
}

.fa-instagram:before {
    content: '';
}

.fa-flickr:before {
    content: '';
}

.fa-adn:before {
    content: '';
}

.fa-bitbucket:before {
    content: '';
}

.fa-bitbucket-square:before {
    content: '';
}

.fa-tumblr:before {
    content: '';
}

.fa-tumblr-square:before {
    content: '';
}

.fa-long-arrow-down:before {
    content: '';
}

.fa-long-arrow-up:before {
    content: '';
}

.fa-long-arrow-left:before {
    content: '';
}

.fa-long-arrow-right:before {
    content: '';
}

.fa-apple:before {
    content: '';
}

.fa-windows:before {
    content: '';
}

.fa-android:before {
    content: '';
}

.fa-linux:before {
    content: '';
}

.fa-dribbble:before {
    content: '';
}

.fa-skype:before {
    content: '';
}

.fa-foursquare:before {
    content: '';
}

.fa-trello:before {
    content: '';
}

.fa-female:before {
    content: '';
}

.fa-male:before {
    content: '';
}

.fa-gittip:before,
.fa-gratipay:before {
    content: '';
}

.fa-sun-o:before {
    content: '';
}

.fa-moon-o:before {
    content: '';
}

.fa-archive:before {
    content: '';
}

.fa-bug:before {
    content: '';
}

.fa-vk:before {
    content: '';
}

.fa-weibo:before {
    content: '';
}

.fa-renren:before {
    content: '';
}

.fa-pagelines:before {
    content: '';
}

.fa-stack-exchange:before {
    content: '';
}

.fa-arrow-circle-o-right:before {
    content: '';
}

.fa-arrow-circle-o-left:before {
    content: '';
}

.fa-caret-square-o-left:before,
.fa-toggle-left:before {
    content: '';
}

.fa-dot-circle-o:before {
    content: '';
}

.fa-wheelchair:before {
    content: '';
}

.fa-vimeo-square:before {
    content: '';
}

.fa-try:before,
.fa-turkish-lira:before {
    content: '';
}

.fa-plus-square-o:before {
    content: '';
}

.fa-space-shuttle:before {
    content: '';
}

.fa-slack:before {
    content: '';
}

.fa-envelope-square:before {
    content: '';
}

.fa-wordpress:before {
    content: '';
}

.fa-openid:before {
    content: '';
}

.fa-bank:before,
.fa-institution:before,
.fa-university:before {
    content: '';
}

.fa-graduation-cap:before,
.fa-mortar-board:before {
    content: '';
}

.fa-yahoo:before {
    content: '';
}

.fa-google:before {
    content: '';
}

.fa-reddit:before {
    content: '';
}

.fa-reddit-square:before {
    content: '';
}

.fa-stumbleupon-circle:before {
    content: '';
}

.fa-stumbleupon:before {
    content: '';
}

.fa-delicious:before {
    content: '';
}

.fa-digg:before {
    content: '';
}

.fa-pied-piper-pp:before {
    content: '';
}

.fa-pied-piper-alt:before {
    content: '';
}

.fa-drupal:before {
    content: '';
}

.fa-joomla:before {
    content: '';
}

.fa-language:before {
    content: '';
}

.fa-fax:before {
    content: '';
}

.fa-building:before {
    content: '';
}

.fa-child:before {
    content: '';
}

.fa-paw:before {
    content: '';
}

.fa-spoon:before {
    content: '';
}

.fa-cube:before {
    content: '';
}

.fa-cubes:before {
    content: '';
}

.fa-behance:before {
    content: '';
}

.fa-behance-square:before {
    content: '';
}

.fa-steam:before {
    content: '';
}

.fa-steam-square:before {
    content: '';
}

.fa-recycle:before {
    content: '';
}

.fa-automobile:before,
.fa-car:before {
    content: '';
}

.fa-cab:before,
.fa-taxi:before {
    content: '';
}

.fa-tree:before {
    content: '';
}

.fa-spotify:before {
    content: '';
}

.fa-deviantart:before {
    content: '';
}

.fa-soundcloud:before {
    content: '';
}

.fa-database:before {
    content: '';
}

.fa-file-pdf-o:before {
    content: '';
}

.fa-file-word-o:before {
    content: '';
}

.fa-file-excel-o:before {
    content: '';
}

.fa-file-powerpoint-o:before {
    content: '';
}

.fa-file-image-o:before,
.fa-file-photo-o:before,
.fa-file-picture-o:before {
    content: '';
}

.fa-file-archive-o:before,
.fa-file-zip-o:before {
    content: '';
}

.fa-file-audio-o:before,
.fa-file-sound-o:before {
    content: '';
}

.fa-file-movie-o:before,
.fa-file-video-o:before {
    content: '';
}

.fa-file-code-o:before {
    content: '';
}

.fa-vine:before {
    content: '';
}

.fa-codepen:before {
    content: '';
}

.fa-jsfiddle:before {
    content: '';
}

.fa-life-bouy:before,
.fa-life-buoy:before,
.fa-life-ring:before,
.fa-life-saver:before,
.fa-support:before {
    content: '';
}

.fa-circle-o-notch:before {
    content: '';
}

.fa-ra:before,
.fa-rebel:before,
.fa-resistance:before {
    content: '';
}

.fa-empire:before,
.fa-ge:before {
    content: '';
}

.fa-git-square:before {
    content: '';
}

.fa-git:before {
    content: '';
}

.fa-hacker-news:before,
.fa-y-combinator-square:before,
.fa-yc-square:before {
    content: '';
}

.fa-tencent-weibo:before {
    content: '';
}

.fa-qq:before {
    content: '';
}

.fa-wechat:before,
.fa-weixin:before {
    content: '';
}

.fa-paper-plane:before,
.fa-send:before {
    content: '';
}

.fa-paper-plane-o:before,
.fa-send-o:before {
    content: '';
}

.fa-history:before {
    content: '';
}

.fa-circle-thin:before {
    content: '';
}

.fa-header:before {
    content: '';
}

.fa-paragraph:before {
    content: '';
}

.fa-sliders:before {
    content: '';
}

.fa-share-alt:before {
    content: '';
}

.fa-share-alt-square:before {
    content: '';
}

.fa-bomb:before {
    content: '';
}

.fa-futbol-o:before,
.fa-soccer-ball-o:before {
    content: '';
}

.fa-tty:before {
    content: '';
}

.fa-binoculars:before {
    content: '';
}

.fa-plug:before {
    content: '';
}

.fa-slideshare:before {
    content: '';
}

.fa-twitch:before {
    content: '';
}

.fa-yelp:before {
    content: '';
}

.fa-newspaper-o:before {
    content: '';
}

.fa-wifi:before {
    content: '';
}

.fa-calculator:before {
    content: '';
}

.fa-paypal:before {
    content: '';
}

.fa-google-wallet:before {
    content: '';
}

.fa-cc-visa:before {
    content: '';
}

.fa-cc-mastercard:before {
    content: '';
}

.fa-cc-discover:before {
    content: '';
}

.fa-cc-amex:before {
    content: '';
}

.fa-cc-paypal:before {
    content: '';
}

.fa-cc-stripe:before {
    content: '';
}

.fa-bell-slash:before {
    content: '';
}

.fa-bell-slash-o:before {
    content: '';
}

.fa-trash:before {
    content: '';
}

.fa-copyright:before {
    content: '';
}

.fa-at:before {
    content: '';
}

.fa-eyedropper:before {
    content: '';
}

.fa-paint-brush:before {
    content: '';
}

.fa-birthday-cake:before {
    content: '';
}

.fa-area-chart:before {
    content: '';
}

.fa-pie-chart:before {
    content: '';
}

.fa-line-chart:before {
    content: '';
}

.fa-lastfm:before {
    content: '';
}

.fa-lastfm-square:before {
    content: '';
}

.fa-toggle-off:before {
    content: '';
}

.fa-toggle-on:before {
    content: '';
}

.fa-bicycle:before {
    content: '';
}

.fa-bus:before {
    content: '';
}

.fa-ioxhost:before {
    content: '';
}

.fa-angellist:before {
    content: '';
}

.fa-cc:before {
    content: '';
}

.fa-ils:before,
.fa-shekel:before,
.fa-sheqel:before {
    content: '';
}

.fa-meanpath:before {
    content: '';
}

.fa-buysellads:before {
    content: '';
}

.fa-connectdevelop:before {
    content: '';
}

.fa-dashcube:before {
    content: '';
}

.fa-forumbee:before {
    content: '';
}

.fa-leanpub:before {
    content: '';
}

.fa-sellsy:before {
    content: '';
}

.fa-shirtsinbulk:before {
    content: '';
}

.fa-simplybuilt:before {
    content: '';
}

.fa-skyatlas:before {
    content: '';
}

.fa-cart-plus:before {
    content: '';
}

.fa-cart-arrow-down:before {
    content: '';
}

.fa-diamond:before {
    content: '';
}

.fa-ship:before {
    content: '';
}

.fa-user-secret:before {
    content: '';
}

.fa-motorcycle:before {
    content: '';
}

.fa-street-view:before {
    content: '';
}

.fa-heartbeat:before {
    content: '';
}

.fa-venus:before {
    content: '';
}

.fa-mars:before {
    content: '';
}

.fa-mercury:before {
    content: '';
}

.fa-intersex:before,
.fa-transgender:before {
    content: '';
}

.fa-transgender-alt:before {
    content: '';
}

.fa-venus-double:before {
    content: '';
}

.fa-mars-double:before {
    content: '';
}

.fa-venus-mars:before {
    content: '';
}

.fa-mars-stroke:before {
    content: '';
}

.fa-mars-stroke-v:before {
    content: '';
}

.fa-mars-stroke-h:before {
    content: '';
}

.fa-neuter:before {
    content: '';
}

.fa-genderless:before {
    content: '';
}

.fa-facebook-official:before {
    content: '';
}

.fa-pinterest-p:before {
    content: '';
}

.fa-whatsapp:before {
    content: '';
}

.fa-server:before {
    content: '';
}

.fa-user-plus:before {
    content: '';
}

.fa-user-times:before {
    content: '';
}

.fa-bed:before,
.fa-hotel:before {
    content: '';
}

.fa-viacoin:before {
    content: '';
}

.fa-train:before {
    content: '';
}

.fa-subway:before {
    content: '';
}

.fa-medium:before {
    content: '';
}

.fa-y-combinator:before,
.fa-yc:before {
    content: '';
}

.fa-optin-monster:before {
    content: '';
}

.fa-opencart:before {
    content: '';
}

.fa-expeditedssl:before {
    content: '';
}

.fa-battery-4:before,
.fa-battery-full:before,
.fa-battery:before {
    content: '';
}

.fa-battery-3:before,
.fa-battery-three-quarters:before {
    content: '';
}

.fa-battery-2:before,
.fa-battery-half:before {
    content: '';
}

.fa-battery-1:before,
.fa-battery-quarter:before {
    content: '';
}

.fa-battery-0:before,
.fa-battery-empty:before {
    content: '';
}

.fa-mouse-pointer:before {
    content: '';
}

.fa-i-cursor:before {
    content: '';
}

.fa-object-group:before {
    content: '';
}

.fa-object-ungroup:before {
    content: '';
}

.fa-sticky-note:before {
    content: '';
}

.fa-sticky-note-o:before {
    content: '';
}

.fa-cc-jcb:before {
    content: '';
}

.fa-cc-diners-club:before {
    content: '';
}

.fa-clone:before {
    content: '';
}

.fa-balance-scale:before {
    content: '';
}

.fa-hourglass-o:before {
    content: '';
}

.fa-hourglass-1:before,
.fa-hourglass-start:before {
    content: '';
}

.fa-hourglass-2:before,
.fa-hourglass-half:before {
    content: '';
}

.fa-hourglass-3:before,
.fa-hourglass-end:before {
    content: '';
}

.fa-hourglass:before {
    content: '';
}

.fa-hand-grab-o:before,
.fa-hand-rock-o:before {
    content: '';
}

.fa-hand-paper-o:before,
.fa-hand-stop-o:before {
    content: '';
}

.fa-hand-scissors-o:before {
    content: '';
}

.fa-hand-lizard-o:before {
    content: '';
}

.fa-hand-spock-o:before {
    content: '';
}

.fa-hand-pointer-o:before {
    content: '';
}

.fa-hand-peace-o:before {
    content: '';
}

.fa-trademark:before {
    content: '';
}

.fa-registered:before {
    content: '';
}

.fa-creative-commons:before {
    content: '';
}

.fa-gg:before {
    content: '';
}

.fa-gg-circle:before {
    content: '';
}

.fa-tripadvisor:before {
    content: '';
}

.fa-odnoklassniki:before {
    content: '';
}

.fa-odnoklassniki-square:before {
    content: '';
}

.fa-get-pocket:before {
    content: '';
}

.fa-wikipedia-w:before {
    content: '';
}

.fa-safari:before {
    content: '';
}

.fa-chrome:before {
    content: '';
}

.fa-firefox:before {
    content: '';
}

.fa-opera:before {
    content: '';
}

.fa-internet-explorer:before {
    content: '';
}

.fa-television:before,
.fa-tv:before {
    content: '';
}

.fa-contao:before {
    content: '';
}

.fa-500px:before {
    content: '';
}

.fa-amazon:before {
    content: '';
}

.fa-calendar-plus-o:before {
    content: '';
}

.fa-calendar-minus-o:before {
    content: '';
}

.fa-calendar-times-o:before {
    content: '';
}

.fa-calendar-check-o:before {
    content: '';
}

.fa-industry:before {
    content: '';
}

.fa-map-pin:before {
    content: '';
}

.fa-map-signs:before {
    content: '';
}

.fa-map-o:before {
    content: '';
}

.fa-map:before {
    content: '';
}

.fa-commenting:before {
    content: '';
}

.fa-commenting-o:before {
    content: '';
}

.fa-houzz:before {
    content: '';
}

.fa-vimeo:before {
    content: '';
}

.fa-black-tie:before {
    content: '';
}

.fa-fonticons:before {
    content: '';
}

.fa-reddit-alien:before {
    content: '';
}

.fa-edge:before {
    content: '';
}

.fa-credit-card-alt:before {
    content: '';
}

.fa-codiepie:before {
    content: '';
}

.fa-modx:before {
    content: '';
}

.fa-fort-awesome:before {
    content: '';
}

.fa-usb:before {
    content: '';
}

.fa-product-hunt:before {
    content: '';
}

.fa-mixcloud:before {
    content: '';
}

.fa-scribd:before {
    content: '';
}

.fa-pause-circle:before {
    content: '';
}

.fa-pause-circle-o:before {
    content: '';
}

.fa-stop-circle:before {
    content: '';
}

.fa-stop-circle-o:before {
    content: '';
}

.fa-shopping-bag:before {
    content: '';
}

.fa-shopping-basket:before {
    content: '';
}

.fa-hashtag:before {
    content: '';
}

.fa-bluetooth:before {
    content: '';
}

.fa-bluetooth-b:before {
    content: '';
}

.fa-percent:before {
    content: '';
}

.fa-gitlab:before {
    content: '';
}

.fa-wpbeginner:before {
    content: '';
}

.fa-wpforms:before {
    content: '';
}

.fa-envira:before {
    content: '';
}

.fa-universal-access:before {
    content: '';
}

.fa-wheelchair-alt:before {
    content: '';
}

.fa-question-circle-o:before {
    content: '';
}

.fa-blind:before {
    content: '';
}

.fa-audio-description:before {
    content: '';
}

.fa-volume-control-phone:before {
    content: '';
}

.fa-braille:before {
    content: '';
}

.fa-assistive-listening-systems:before {
    content: '';
}

.fa-american-sign-language-interpreting:before,
.fa-asl-interpreting:before {
    content: '';
}

.fa-deaf:before,
.fa-deafness:before,
.fa-hard-of-hearing:before {
    content: '';
}

.fa-glide:before {
    content: '';
}

.fa-glide-g:before {
    content: '';
}

.fa-sign-language:before,
.fa-signing:before {
    content: '';
}

.fa-low-vision:before {
    content: '';
}

.fa-viadeo:before {
    content: '';
}

.fa-viadeo-square:before {
    content: '';
}

.fa-snapchat:before {
    content: '';
}

.fa-snapchat-ghost:before {
    content: '';
}

.fa-snapchat-square:before {
    content: '';
}

.fa-pied-piper:before {
    content: '';
}

.fa-first-order:before {
    content: '';
}

.fa-yoast:before {
    content: '';
}

.fa-themeisle:before {
    content: '';
}

.fa-google-plus-circle:before,
.fa-google-plus-official:before {
    content: '';
}

.fa-fa:before,
.fa-font-awesome:before {
    content: '';
}

.fa-handshake-o:before {
    content: '';
}

.fa-envelope-open:before {
    content: '';
}

.fa-envelope-open-o:before {
    content: '';
}

.fa-linode:before {
    content: '';
}

.fa-address-book:before {
    content: '';
}

.fa-address-book-o:before {
    content: '';
}

.fa-address-card:before,
.fa-vcard:before {
    content: '';
}

.fa-address-card-o:before,
.fa-vcard-o:before {
    content: '';
}

.fa-user-circle:before {
    content: '';
}

.fa-user-circle-o:before {
    content: '';
}

.fa-user-o:before {
    content: '';
}

.fa-id-badge:before {
    content: '';
}

.fa-drivers-license:before,
.fa-id-card:before {
    content: '';
}

.fa-drivers-license-o:before,
.fa-id-card-o:before {
    content: '';
}

.fa-quora:before {
    content: '';
}

.fa-free-code-camp:before {
    content: '';
}

.fa-telegram:before {
    content: '';
}

.fa-thermometer-4:before,
.fa-thermometer-full:before,
.fa-thermometer:before {
    content: '';
}

.fa-thermometer-3:before,
.fa-thermometer-three-quarters:before {
    content: '';
}

.fa-thermometer-2:before,
.fa-thermometer-half:before {
    content: '';
}

.fa-thermometer-1:before,
.fa-thermometer-quarter:before {
    content: '';
}

.fa-thermometer-0:before,
.fa-thermometer-empty:before {
    content: '';
}

.fa-shower:before {
    content: '';
}

.fa-bath:before,
.fa-bathtub:before,
.fa-s15:before {
    content: '';
}

.fa-podcast:before {
    content: '';
}

.fa-window-maximize:before {
    content: '';
}

.fa-window-minimize:before {
    content: '';
}

.fa-window-restore:before {
    content: '';
}

.fa-times-rectangle:before,
.fa-window-close:before {
    content: '';
}

.fa-times-rectangle-o:before,
.fa-window-close-o:before {
    content: '';
}

.fa-bandcamp:before {
    content: '';
}

.fa-grav:before {
    content: '';
}

.fa-etsy:before {
    content: '';
}

.fa-imdb:before {
    content: '';
}

.fa-ravelry:before {
    content: '';
}

.fa-eercast:before {
    content: '';
}

.fa-microchip:before {
    content: '';
}

.fa-snowflake-o:before {
    content: '';
}

.fa-superpowers:before {
    content: '';
}

.fa-wpexplorer:before {
    content: '';
}

.fa-meetup:before {
    content: '';
}

.sr-only {
    position: absolute;
    width: 1px;
    height: 1px;
    padding: 0;
    margin: -1px;
    overflow: hidden;
    clip: rect(0, 0, 0, 0);
    border: 0;
}

.sr-only-focusable:active,
.sr-only-focusable:focus {
    position: static;
    width: auto;
    height: auto;
    margin: 0;
    overflow: visible;
    clip: auto;
}

@font-face {
    font-family: simple-line-icons;
    font-display: swap;
    src: url(https://cdn.kkday.com/pc-web/assets/fonts/Simple-Line-Icons.eot?v=2.4.0);
    src: url(https://cdn.kkday.com/pc-web/assets/fonts/Simple-Line-Icons.eot?v=2.4.0#iefix)
            format('embedded-opentype'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/Simple-Line-Icons.woff2?v=2.4.0)
            format('woff2'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/Simple-Line-Icons.ttf?v=2.4.0)
            format('truetype'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/Simple-Line-Icons.woff?v=2.4.0)
            format('woff'),
        url(https://cdn.kkday.com/pc-web/assets/fonts/Simple-Line-Icons.svg?v=2.4.0#simple-line-icons)
            format('svg');
    font-weight: 400;
    font-style: normal;
}

.icon-action-redo,
.icon-action-undo,
.icon-anchor,
.icon-arrow-down,
.icon-arrow-down-circle,
.icon-arrow-left,
.icon-arrow-left-circle,
.icon-arrow-right,
.icon-arrow-right-circle,
.icon-arrow-up,
.icon-arrow-up-circle,
.icon-badge,
.icon-bag,
.icon-ban,
.icon-basket,
.icon-basket-loaded,
.icon-bell,
.icon-book-open,
.icon-briefcase,
.icon-bubble,
.icon-bubbles,
.icon-bulb,
.icon-calculator,
.icon-calendar,
.icon-call-end,
.icon-call-in,
.icon-call-out,
.icon-camera,
.icon-camrecorder,
.icon-chart,
.icon-check,
.icon-chemistry,
.icon-clock,
.icon-close,
.icon-cloud-download,
.icon-cloud-upload,
.icon-compass,
.icon-control-end,
.icon-control-forward,
.icon-control-pause,
.icon-control-play,
.icon-control-rewind,
.icon-control-start,
.icon-credit-card,
.icon-crop,
.icon-cup,
.icon-cursor,
.icon-cursor-move,
.icon-diamond,
.icon-direction,
.icon-directions,
.icon-disc,
.icon-dislike,
.icon-doc,
.icon-docs,
.icon-drawer,
.icon-drop,
.icon-earphones,
.icon-earphones-alt,
.icon-emotsmile,
.icon-energy,
.icon-envelope,
.icon-envelope-letter,
.icon-envelope-open,
.icon-equalizer,
.icon-event,
.icon-exclamation,
.icon-eye,
.icon-eyeglass,
.icon-feed,
.icon-film,
.icon-fire,
.icon-flag,
.icon-folder,
.icon-folder-alt,
.icon-frame,
.icon-game-controller,
.icon-ghost,
.icon-globe,
.icon-globe-alt,
.icon-graduation,
.icon-graph,
.icon-grid,
.icon-handbag,
.icon-heart,
.icon-home,
.icon-hourglass,
.icon-info,
.icon-key,
.icon-layers,
.icon-like,
.icon-link,
.icon-list,
.icon-location-pin,
.icon-lock,
.icon-lock-open,
.icon-login,
.icon-logout,
.icon-loop,
.icon-magic-wand,
.icon-magnet,
.icon-magnifier,
.icon-magnifier-add,
.icon-magnifier-remove,
.icon-map,
.icon-menu,
.icon-microphone,
.icon-minus,
.icon-mouse,
.icon-music-tone,
.icon-music-tone-alt,
.icon-mustache,
.icon-note,
.icon-notebook,
.icon-options,
.icon-options-vertical,
.icon-organization,
.icon-paper-clip,
.icon-paper-plane,
.icon-paypal,
.icon-pencil,
.icon-people,
.icon-phone,
.icon-picture,
.icon-pie-chart,
.icon-pin,
.icon-plane,
.icon-playlist,
.icon-plus,
.icon-power,
.icon-present,
.icon-printer,
.icon-puzzle,
.icon-question,
.icon-refresh,
.icon-reload,
.icon-rocket,
.icon-screen-desktop,
.icon-screen-smartphone,
.icon-screen-tablet,
.icon-settings,
.icon-share,
.icon-share-alt,
.icon-shield,
.icon-shuffle,
.icon-size-actual,
.icon-size-fullscreen,
.icon-social-behance,
.icon-social-dribbble,
.icon-social-dropbox,
.icon-social-facebook,
.icon-social-foursqare,
.icon-social-github,
.icon-social-google,
.icon-social-instagram,
.icon-social-linkedin,
.icon-social-pinterest,
.icon-social-reddit,
.icon-social-skype,
.icon-social-soundcloud,
.icon-social-spotify,
.icon-social-steam,
.icon-social-stumbleupon,
.icon-social-tumblr,
.icon-social-twitter,
.icon-social-vkontakte,
.icon-social-youtube,
.icon-speech,
.icon-speedometer,
.icon-star,
.icon-support,
.icon-symbol-female,
.icon-symbol-male,
.icon-tag,
.icon-target,
.icon-trash,
.icon-trophy,
.icon-umbrella,
.icon-user,
.icon-user-female,
.icon-user-follow,
.icon-user-following,
.icon-user-unfollow,
.icon-vector,
.icon-volume-1,
.icon-volume-2,
.icon-volume-off,
.icon-wallet,
.icon-wrench {
    font-family: simple-line-icons;
    speak: none;
    font-style: normal;
    font-weight: 400;
    font-variant: normal;
    text-transform: none;
    line-height: 1;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
}

.icon-user:before {
    content: '';
}

.icon-people:before {
    content: '';
}

.icon-user-female:before {
    content: '';
}

.icon-user-follow:before {
    content: '';
}

.icon-user-following:before {
    content: '';
}

.icon-user-unfollow:before {
    content: '';
}

.icon-login:before {
    content: '';
}

.icon-logout:before {
    content: '';
}

.icon-emotsmile:before {
    content: '';
}

.icon-phone:before {
    content: '';
}

.icon-call-end:before {
    content: '';
}

.icon-call-in:before {
    content: '';
}

.icon-call-out:before {
    content: '';
}

.icon-map:before {
    content: '';
}

.icon-location-pin:before {
    content: '';
}

.icon-direction:before {
    content: '';
}

.icon-directions:before {
    content: '';
}

.icon-compass:before {
    content: '';
}

.icon-layers:before {
    content: '';
}

.icon-menu:before {
    content: '';
}

.icon-list:before {
    content: '';
}

.icon-options-vertical:before {
    content: '';
}

.icon-options:before {
    content: '';
}

.icon-arrow-down:before {
    content: '';
}

.icon-arrow-left:before {
    content: '';
}

.icon-arrow-right:before {
    content: '';
}

.icon-arrow-up:before {
    content: '';
}

.icon-arrow-up-circle:before {
    content: '';
}

.icon-arrow-left-circle:before {
    content: '';
}

.icon-arrow-right-circle:before {
    content: '';
}

.icon-arrow-down-circle:before {
    content: '';
}

.icon-check:before {
    content: '';
}

.icon-clock:before {
    content: '';
}

.icon-plus:before {
    content: '';
}

.icon-minus:before {
    content: '';
}

.icon-close:before {
    content: '';
}

.icon-event:before {
    content: '';
}

.icon-exclamation:before {
    content: '';
}

.icon-organization:before {
    content: '';
}

.icon-trophy:before {
    content: '';
}

.icon-screen-smartphone:before {
    content: '';
}

.icon-screen-desktop:before {
    content: '';
}

.icon-plane:before {
    content: '';
}

.icon-notebook:before {
    content: '';
}

.icon-mustache:before {
    content: '';
}

.icon-mouse:before {
    content: '';
}

.icon-magnet:before {
    content: '';
}

.icon-energy:before {
    content: '';
}

.icon-disc:before {
    content: '';
}

.icon-cursor:before {
    content: '';
}

.icon-cursor-move:before {
    content: '';
}

.icon-crop:before {
    content: '';
}

.icon-chemistry:before {
    content: '';
}

.icon-speedometer:before {
    content: '';
}

.icon-shield:before {
    content: '';
}

.icon-screen-tablet:before {
    content: '';
}

.icon-magic-wand:before {
    content: '';
}

.icon-hourglass:before {
    content: '';
}

.icon-graduation:before {
    content: '';
}

.icon-ghost:before {
    content: '';
}

.icon-game-controller:before {
    content: '';
}

.icon-fire:before {
    content: '';
}

.icon-eyeglass:before {
    content: '';
}

.icon-envelope-open:before {
    content: '';
}

.icon-envelope-letter:before {
    content: '';
}

.icon-bell:before {
    content: '';
}

.icon-badge:before {
    content: '';
}

.icon-anchor:before {
    content: '';
}

.icon-wallet:before {
    content: '';
}

.icon-vector:before {
    content: '';
}

.icon-speech:before {
    content: '';
}

.icon-puzzle:before {
    content: '';
}

.icon-printer:before {
    content: '';
}

.icon-present:before {
    content: '';
}

.icon-playlist:before {
    content: '';
}

.icon-pin:before {
    content: '';
}

.icon-picture:before {
    content: '';
}

.icon-handbag:before {
    content: '';
}

.icon-globe-alt:before {
    content: '';
}

.icon-globe:before {
    content: '';
}

.icon-folder-alt:before {
    content: '';
}

.icon-folder:before {
    content: '';
}

.icon-film:before {
    content: '';
}

.icon-feed:before {
    content: '';
}

.icon-drop:before {
    content: '';
}

.icon-drawer:before {
    content: '';
}

.icon-docs:before {
    content: '';
}

.icon-doc:before {
    content: '';
}

.icon-diamond:before {
    content: '';
}

.icon-cup:before {
    content: '';
}

.icon-calculator:before {
    content: '';
}

.icon-bubbles:before {
    content: '';
}

.icon-briefcase:before {
    content: '';
}

.icon-book-open:before {
    content: '';
}

.icon-basket-loaded:before {
    content: '';
}

.icon-basket:before {
    content: '';
}

.icon-bag:before {
    content: '';
}

.icon-action-undo:before {
    content: '';
}

.icon-action-redo:before {
    content: '';
}

.icon-wrench:before {
    content: '';
}

.icon-umbrella:before {
    content: '';
}

.icon-trash:before {
    content: '';
}

.icon-tag:before {
    content: '';
}

.icon-support:before {
    content: '';
}

.icon-frame:before {
    content: '';
}

.icon-size-fullscreen:before {
    content: '';
}

.icon-size-actual:before {
    content: '';
}

.icon-shuffle:before {
    content: '';
}

.icon-share-alt:before {
    content: '';
}

.icon-share:before {
    content: '';
}

.icon-rocket:before {
    content: '';
}

.icon-question:before {
    content: '';
}

.icon-pie-chart:before {
    content: '';
}

.icon-pencil:before {
    content: '';
}

.icon-note:before {
    content: '';
}

.icon-loop:before {
    content: '';
}

.icon-home:before {
    content: '';
}

.icon-grid:before {
    content: '';
}

.icon-graph:before {
    content: '';
}

.icon-microphone:before {
    content: '';
}

.icon-music-tone-alt:before {
    content: '';
}

.icon-music-tone:before {
    content: '';
}

.icon-earphones-alt:before {
    content: '';
}

.icon-earphones:before {
    content: '';
}

.icon-equalizer:before {
    content: '';
}

.icon-like:before {
    content: '';
}

.icon-dislike:before {
    content: '';
}

.icon-control-start:before {
    content: '';
}

.icon-control-rewind:before {
    content: '';
}

.icon-control-play:before {
    content: '';
}

.icon-control-pause:before {
    content: '';
}

.icon-control-forward:before {
    content: '';
}

.icon-control-end:before {
    content: '';
}

.icon-volume-1:before {
    content: '';
}

.icon-volume-2:before {
    content: '';
}

.icon-volume-off:before {
    content: '';
}

.icon-calendar:before {
    content: '';
}

.icon-bulb:before {
    content: '';
}

.icon-chart:before {
    content: '';
}

.icon-ban:before {
    content: '';
}

.icon-bubble:before {
    content: '';
}

.icon-camrecorder:before {
    content: '';
}

.icon-camera:before {
    content: '';
}

.icon-cloud-download:before {
    content: '';
}

.icon-cloud-upload:before {
    content: '';
}

.icon-envelope:before {
    content: '';
}

.icon-eye:before {
    content: '';
}

.icon-flag:before {
    content: '';
}

.icon-heart:before {
    content: '';
}

.icon-info:before {
    content: '';
}

.icon-key:before {
    content: '';
}

.icon-link:before {
    content: '';
}

.icon-lock:before {
    content: '';
}

.icon-lock-open:before {
    content: '';
}

.icon-magnifier:before {
    content: '';
}

.icon-magnifier-add:before {
    content: '';
}

.icon-magnifier-remove:before {
    content: '';
}

.icon-paper-clip:before {
    content: '';
}

.icon-paper-plane:before {
    content: '';
}

.icon-power:before {
    content: '';
}

.icon-refresh:before {
    content: '';
}

.icon-reload:before {
    content: '';
}

.icon-settings:before {
    content: '';
}

.icon-star:before {
    content: '';
}

.icon-symbol-female:before {
    content: '';
}

.icon-symbol-male:before {
    content: '';
}

.icon-target:before {
    content: '';
}

.icon-credit-card:before {
    content: '';
}

.icon-paypal:before {
    content: '';
}

.icon-social-tumblr:before {
    content: '';
}

.icon-social-twitter:before {
    content: '';
}

.icon-social-facebook:before {
    content: '';
}

.icon-social-instagram:before {
    content: '';
}

.icon-social-linkedin:before {
    content: '';
}

.icon-social-pinterest:before {
    content: '';
}

.icon-social-github:before {
    content: '';
}

.icon-social-google:before {
    content: '';
}

.icon-social-reddit:before {
    content: '';
}

.icon-social-skype:before {
    content: '';
}

.icon-social-dribbble:before {
    content: '';
}

.icon-social-behance:before {
    content: '';
}

.icon-social-foursqare:before {
    content: '';
}

.icon-social-soundcloud:before {
    content: '';
}

.icon-social-spotify:before {
    content: '';
}

.icon-social-stumbleupon:before {
    content: '';
}

.icon-social-youtube:before {
    content: '';
}

.icon-social-dropbox:before {
    content: '';
}

.icon-social-vkontakte:before {
    content: '';
}

.icon-social-steam:before {
    content: '';
}

.select2-container {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    display: inline-block;
    margin: 0;
    position: relative;
    vertical-align: middle;
}

.select2-container .select2-selection--single {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    cursor: pointer;
    display: block;
    height: 28px;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    -webkit-user-select: none;
}

.select2-container .select2-selection--single .select2-selection__rendered {
    display: block;
    padding-left: 8px;
    padding-right: 20px;
    overflow: hidden;
    text-overflow: ellipsis;
    white-space: nowrap;
}

.select2-container .select2-selection--single .select2-selection__clear {
    position: relative;
}

.select2-container[dir='rtl']
    .select2-selection--single
    .select2-selection__rendered {
    padding-right: 8px;
    padding-left: 20px;
}

.select2-container .select2-selection--multiple {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    cursor: pointer;
    display: block;
    min-height: 32px;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    -webkit-user-select: none;
}

.select2-container .select2-selection--multiple .select2-selection__rendered {
    display: inline-block;
    overflow: hidden;
    padding-left: 8px;
    text-overflow: ellipsis;
    white-space: nowrap;
}

.select2-container .select2-search--inline {
    float: left;
}

.select2-container .select2-search--inline .select2-search__field {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    border: none;
    font-size: 100%;
    margin-top: 5px;
    padding: 0;
}

.select2-container
    .select2-search--inline
    .select2-search__field::-webkit-search-cancel-button {
    -webkit-appearance: none;
}

.select2-dropdown {
    background-color: #fff;
    border: 1px solid #aaa;
    border-radius: 4px;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    display: block;
    position: absolute;
    left: -100000px;
    width: 100%;
    z-index: 1051;
}

.select2-results {
    display: block;
}

.select2-results__options {
    list-style: none;
    margin: 0;
    padding: 0;
}

.select2-results__option {
    padding: 6px;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    -webkit-user-select: none;
}

.select2-results__option[aria-selected] {
    cursor: pointer;
}

.select2-container--open .select2-dropdown {
    left: 0;
}

.select2-container--open .select2-dropdown--above {
    border-bottom: none;
    border-bottom-left-radius: 0;
    border-bottom-right-radius: 0;
}

.select2-container--open .select2-dropdown--below {
    border-top: none;
    border-top-left-radius: 0;
    border-top-right-radius: 0;
}

.select2-search--dropdown {
    display: block;
    padding: 4px;
}

.select2-search--dropdown .select2-search__field {
    padding: 4px;
    width: 100%;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
}

.select2-search--dropdown .select2-search__field::-webkit-search-cancel-button {
    -webkit-appearance: none;
}

.select2-search--dropdown.select2-search--hide {
    display: none;
}

.select2-close-mask {
    border: 0;
    margin: 0;
    padding: 0;
    display: block;
    position: fixed;
    left: 0;
    top: 0;
    min-height: 100%;
    min-width: 100%;
    height: auto;
    width: auto;
    opacity: 0;
    z-index: 99;
    background-color: #fff;
    filter: alpha(opacity=0);
}

.select2-hidden-accessible {
    border: 0 !important;
    clip: rect(0 0 0 0) !important;
    -webkit-clip-path: inset(50%) !important;
    clip-path: inset(50%) !important;
    height: 1px !important;
    overflow: hidden !important;
    padding: 0 !important;
    position: absolute !important;
    width: 1px !important;
    white-space: nowrap !important;
}

.select2-container--default .select2-selection--single {
    background-color: #fff;
    border: 1px solid #aaa;
    border-radius: 4px;
}

.select2-container--default
    .select2-selection--single
    .select2-selection__rendered {
    color: #444;
    line-height: 28px;
}

.select2-container--default
    .select2-selection--single
    .select2-selection__clear {
    cursor: pointer;
    float: right;
    font-weight: 700;
}

.select2-container--default
    .select2-selection--single
    .select2-selection__placeholder {
    color: #999;
}

.select2-container--default
    .select2-selection--single
    .select2-selection__arrow {
    height: 26px;
    position: absolute;
    top: 1px;
    right: 1px;
    width: 20px;
}

.select2-container--default
    .select2-selection--single
    .select2-selection__arrow
    b {
    border-color: #888 transparent transparent;
    border-style: solid;
    border-width: 5px 4px 0;
    height: 0;
    left: 50%;
    margin-left: -4px;
    margin-top: -2px;
    position: absolute;
    top: 50%;
    width: 0;
}

.select2-container--default[dir='rtl']
    .select2-selection--single
    .select2-selection__clear {
    float: left;
}

.select2-container--default[dir='rtl']
    .select2-selection--single
    .select2-selection__arrow {
    left: 1px;
    right: auto;
}

.select2-container--default.select2-container--disabled
    .select2-selection--single {
    background-color: #eee;
    cursor: default;
}

.select2-container--default.select2-container--disabled
    .select2-selection--single
    .select2-selection__clear {
    display: none;
}

.select2-container--default.select2-container--open
    .select2-selection--single
    .select2-selection__arrow
    b {
    border-color: transparent transparent #888;
    border-width: 0 4px 5px;
}

.select2-container--default .select2-selection--multiple {
    background-color: #fff;
    border: 1px solid #aaa;
    border-radius: 4px;
    cursor: text;
}

.select2-container--default
    .select2-selection--multiple
    .select2-selection__rendered {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    list-style: none;
    margin: 0;
    padding: 0 5px;
    width: 100%;
}

.select2-container--default
    .select2-selection--multiple
    .select2-selection__rendered
    li {
    list-style: none;
}

.select2-container--default
    .select2-selection--multiple
    .select2-selection__clear {
    cursor: pointer;
    float: right;
    font-weight: 700;
    margin-top: 5px;
    margin-right: 10px;
    padding: 1px;
}

.select2-container--default
    .select2-selection--multiple
    .select2-selection__choice {
    background-color: #e4e4e4;
    border: 1px solid #aaa;
    border-radius: 4px;
    cursor: default;
    float: left;
    margin-right: 5px;
    margin-top: 5px;
    padding: 0 5px;
}

.select2-container--default
    .select2-selection--multiple
    .select2-selection__choice__remove {
    color: #999;
    cursor: pointer;
    display: inline-block;
    font-weight: 700;
    margin-right: 2px;
}

.select2-container--default
    .select2-selection--multiple
    .select2-selection__choice__remove:hover {
    color: #333;
}

.select2-container--default[dir='rtl']
    .select2-selection--multiple
    .select2-search--inline,
.select2-container--default[dir='rtl']
    .select2-selection--multiple
    .select2-selection__choice {
    float: right;
}

.select2-container--default[dir='rtl']
    .select2-selection--multiple
    .select2-selection__choice {
    margin-left: 5px;
    margin-right: auto;
}

.select2-container--default[dir='rtl']
    .select2-selection--multiple
    .select2-selection__choice__remove {
    margin-left: 2px;
    margin-right: auto;
}

.select2-container--default.select2-container--focus
    .select2-selection--multiple {
    border: 1px solid #000;
    outline: 0;
}

.select2-container--default.select2-container--disabled
    .select2-selection--multiple {
    background-color: #eee;
    cursor: default;
}

.select2-container--default.select2-container--disabled
    .select2-selection__choice__remove {
    display: none;
}

.select2-container--default.select2-container--open.select2-container--above
    .select2-selection--multiple,
.select2-container--default.select2-container--open.select2-container--above
    .select2-selection--single {
    border-top-left-radius: 0;
    border-top-right-radius: 0;
}

.select2-container--default.select2-container--open.select2-container--below
    .select2-selection--multiple,
.select2-container--default.select2-container--open.select2-container--below
    .select2-selection--single {
    border-bottom-left-radius: 0;
    border-bottom-right-radius: 0;
}

.select2-container--default .select2-search--dropdown .select2-search__field {
    border: 1px solid #aaa;
}

.select2-container--default .select2-search--inline .select2-search__field {
    background: transparent;
    border: none;
    outline: 0;
    -webkit-box-shadow: none;
    box-shadow: none;
    -webkit-appearance: textfield;
}

.select2-container--default .select2-results > .select2-results__options {
    max-height: 200px;
    overflow-y: auto;
}

.select2-container--default .select2-results__option[role='group'] {
    padding: 0;
}

.select2-container--default .select2-results__option[aria-disabled='true'] {
    color: #999;
}

.select2-container--default .select2-results__option[aria-selected='true'] {
    background-color: #ddd;
}

.select2-container--default .select2-results__option .select2-results__option {
    padding-left: 1em;
}

.select2-container--default
    .select2-results__option
    .select2-results__option
    .select2-results__group {
    padding-left: 0;
}

.select2-container--default
    .select2-results__option
    .select2-results__option
    .select2-results__option {
    margin-left: -1em;
    padding-left: 2em;
}

.select2-container--default
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option {
    margin-left: -2em;
    padding-left: 3em;
}

.select2-container--default
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option {
    margin-left: -3em;
    padding-left: 4em;
}

.select2-container--default
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option {
    margin-left: -4em;
    padding-left: 5em;
}

.select2-container--default
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option
    .select2-results__option {
    margin-left: -5em;
    padding-left: 6em;
}

.select2-container--default
    .select2-results__option--highlighted[aria-selected] {
    background-color: #5897fb;
    color: #fff;
}

.select2-container--default .select2-results__group {
    cursor: default;
    display: block;
    padding: 6px;
}

.select2-container--classic .select2-selection--single {
    background-color: #f7f7f7;
    border: 1px solid #aaa;
    border-radius: 4px;
    outline: 0;
    background-image: -webkit-gradient(
        linear,
        left top,
        left bottom,
        color-stop(50%, #fff),
        to(#eee)
    );
    background-image: linear-gradient(180deg, #fff 50%, #eee);
    background-repeat: repeat-x;
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr="#FFFFFFFF",endColorstr="#FFEEEEEE",GradientType=0);
}

.select2-container--classic .select2-selection--single:focus {
    border: 1px solid #5897fb;
}

.select2-container--classic
    .select2-selection--single
    .select2-selection__rendered {
    color: #444;
    line-height: 28px;
}

.select2-container--classic
    .select2-selection--single
    .select2-selection__clear {
    cursor: pointer;
    float: right;
    font-weight: 700;
    margin-right: 10px;
}

.select2-container--classic
    .select2-selection--single
    .select2-selection__placeholder {
    color: #999;
}

.select2-container--classic
    .select2-selection--single
    .select2-selection__arrow {
    background-color: #ddd;
    border: none;
    border-left: 1px solid #aaa;
    border-top-right-radius: 4px;
    border-bottom-right-radius: 4px;
    height: 26px;
    position: absolute;
    top: 1px;
    right: 1px;
    width: 20px;
    background-image: -webkit-gradient(
        linear,
        left top,
        left bottom,
        color-stop(50%, #eee),
        to(#ccc)
    );
    background-image: linear-gradient(180deg, #eee 50%, #ccc);
    background-repeat: repeat-x;
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr="#FFEEEEEE",endColorstr="#FFCCCCCC",GradientType=0);
}

.select2-container--classic
    .select2-selection--single
    .select2-selection__arrow
    b {
    border-color: #888 transparent transparent;
    border-style: solid;
    border-width: 5px 4px 0;
    height: 0;
    left: 50%;
    margin-left: -4px;
    margin-top: -2px;
    position: absolute;
    top: 50%;
    width: 0;
}

.select2-container--classic[dir='rtl']
    .select2-selection--single
    .select2-selection__clear {
    float: left;
}

.select2-container--classic[dir='rtl']
    .select2-selection--single
    .select2-selection__arrow {
    border: none;
    border-right: 1px solid #aaa;
    border-radius: 0;
    border-top-left-radius: 4px;
    border-bottom-left-radius: 4px;
    left: 1px;
    right: auto;
}

.select2-container--classic.select2-container--open .select2-selection--single {
    border: 1px solid #5897fb;
}

.select2-container--classic.select2-container--open
    .select2-selection--single
    .select2-selection__arrow {
    background: transparent;
    border: none;
}

.select2-container--classic.select2-container--open
    .select2-selection--single
    .select2-selection__arrow
    b {
    border-color: transparent transparent #888;
    border-width: 0 4px 5px;
}

.select2-container--classic.select2-container--open.select2-container--above
    .select2-selection--single {
    border-top: none;
    border-top-left-radius: 0;
    border-top-right-radius: 0;
    background-image: -webkit-gradient(
        linear,
        left top,
        left bottom,
        from(#fff),
        color-stop(50%, #eee)
    );
    background-image: linear-gradient(180deg, #fff 0, #eee 50%);
    background-repeat: repeat-x;
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr="#FFFFFFFF",endColorstr="#FFEEEEEE",GradientType=0);
}

.select2-container--classic.select2-container--open.select2-container--below
    .select2-selection--single {
    border-bottom: none;
    border-bottom-left-radius: 0;
    border-bottom-right-radius: 0;
    background-image: -webkit-gradient(
        linear,
        left top,
        left bottom,
        color-stop(50%, #eee),
        to(#fff)
    );
    background-image: linear-gradient(180deg, #eee 50%, #fff);
    background-repeat: repeat-x;
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr="#FFEEEEEE",endColorstr="#FFFFFFFF",GradientType=0);
}

.select2-container--classic .select2-selection--multiple {
    background-color: #fff;
    border: 1px solid #aaa;
    border-radius: 4px;
    cursor: text;
    outline: 0;
}

.select2-container--classic .select2-selection--multiple:focus {
    border: 1px solid #5897fb;
}

.select2-container--classic
    .select2-selection--multiple
    .select2-selection__rendered {
    list-style: none;
    margin: 0;
    padding: 0 5px;
}

.select2-container--classic
    .select2-selection--multiple
    .select2-selection__clear {
    display: none;
}

.select2-container--classic
    .select2-selection--multiple
    .select2-selection__choice {
    background-color: #e4e4e4;
    border: 1px solid #aaa;
    border-radius: 4px;
    cursor: default;
    float: left;
    margin-right: 5px;
    margin-top: 5px;
    padding: 0 5px;
}

.select2-container--classic
    .select2-selection--multiple
    .select2-selection__choice__remove {
    color: #888;
    cursor: pointer;
    display: inline-block;
    font-weight: 700;
    margin-right: 2px;
}

.select2-container--classic
    .select2-selection--multiple
    .select2-selection__choice__remove:hover {
    color: #555;
}

.select2-container--classic[dir='rtl']
    .select2-selection--multiple
    .select2-selection__choice {
    float: right;
    margin-left: 5px;
    margin-right: auto;
}

.select2-container--classic[dir='rtl']
    .select2-selection--multiple
    .select2-selection__choice__remove {
    margin-left: 2px;
    margin-right: auto;
}

.select2-container--classic.select2-container--open
    .select2-selection--multiple {
    border: 1px solid #5897fb;
}

.select2-container--classic.select2-container--open.select2-container--above
    .select2-selection--multiple {
    border-top: none;
    border-top-left-radius: 0;
    border-top-right-radius: 0;
}

.select2-container--classic.select2-container--open.select2-container--below
    .select2-selection--multiple {
    border-bottom: none;
    border-bottom-left-radius: 0;
    border-bottom-right-radius: 0;
}

.select2-container--classic .select2-search--dropdown .select2-search__field {
    border: 1px solid #aaa;
    outline: 0;
}

.select2-container--classic .select2-search--inline .select2-search__field {
    outline: 0;
    -webkit-box-shadow: none;
    box-shadow: none;
}

.select2-container--classic .select2-dropdown {
    background-color: #fff;
    border: 1px solid transparent;
}

.select2-container--classic .select2-dropdown--above {
    border-bottom: none;
}

.select2-container--classic .select2-dropdown--below {
    border-top: none;
}

.select2-container--classic .select2-results > .select2-results__options {
    max-height: 200px;
    overflow-y: auto;
}

.select2-container--classic .select2-results__option[role='group'] {
    padding: 0;
}

.select2-container--classic .select2-results__option[aria-disabled='true'] {
    color: grey;
}

.select2-container--classic
    .select2-results__option--highlighted[aria-selected] {
    background-color: #3875d7;
    color: #fff;
}

.select2-container--classic .select2-results__group {
    cursor: default;
    display: block;
    padding: 6px;
}

.select2-container--classic.select2-container--open .select2-dropdown {
    border-color: #5897fb;
}

.daterangepicker {
    position: absolute;
    color: inherit;
    background-color: #fff;
    border-radius: 4px;
    border: 1px solid #ddd;
    width: 278px;
    max-width: none;
    padding: 0;
    margin-top: 7px;
    top: 100px;
    left: 20px;
    z-index: 3001;
    display: none;
    font-family: arial;
    font-size: 15px;
    line-height: 1em;
}

.daterangepicker:after,
.daterangepicker:before {
    position: absolute;
    display: inline-block;
    border-bottom-color: rgba(0, 0, 0, 0.2);
    content: '';
}

.daterangepicker:before {
    top: -7px;
    border-right: 7px solid transparent;
    border-left: 7px solid transparent;
    border-bottom: 7px solid #ccc;
}

.daterangepicker:after {
    top: -6px;
    border-right: 6px solid transparent;
    border-bottom: 6px solid #fff;
    border-left: 6px solid transparent;
}

.daterangepicker.opensleft:before {
    right: 9px;
}

.daterangepicker.opensleft:after {
    right: 10px;
}

.daterangepicker.openscenter:after,
.daterangepicker.openscenter:before {
    left: 0;
    right: 0;
    width: 0;
    margin-left: auto;
    margin-right: auto;
}

.daterangepicker.opensright:before {
    left: 9px;
}

.daterangepicker.opensright:after {
    left: 10px;
}

.daterangepicker.drop-up {
    margin-top: -7px;
}

.daterangepicker.drop-up:before {
    top: auto;
    bottom: -7px;
    border-bottom: initial;
    border-top: 7px solid #ccc;
}

.daterangepicker.drop-up:after {
    top: auto;
    bottom: -6px;
    border-bottom: initial;
    border-top: 6px solid #fff;
}

.daterangepicker.single .daterangepicker .ranges,
.daterangepicker.single .drp-calendar {
    float: none;
}

.daterangepicker.single .drp-selected {
    display: none;
}

.daterangepicker.show-calendar .drp-buttons,
.daterangepicker.show-calendar .drp-calendar {
    display: block;
}

.daterangepicker.auto-apply .drp-buttons {
    display: none;
}

.daterangepicker .drp-calendar {
    display: none;
    max-width: 270px;
}

.daterangepicker .drp-calendar.left {
    padding: 8px 0 8px 8px;
}

.daterangepicker .drp-calendar.right {
    padding: 8px;
}

.daterangepicker .drp-calendar.single .calendar-table {
    border: none;
}

.daterangepicker .calendar-table .next span,
.daterangepicker .calendar-table .prev span {
    color: #fff;
    border: solid #000;
    border-width: 0 2px 2px 0;
    border-radius: 0;
    display: inline-block;
    padding: 3px;
}

.daterangepicker .calendar-table .next span {
    transform: rotate(-45deg);
    -webkit-transform: rotate(-45deg);
}

.daterangepicker .calendar-table .prev span {
    transform: rotate(135deg);
    -webkit-transform: rotate(135deg);
}

.daterangepicker .calendar-table td,
.daterangepicker .calendar-table th {
    text-align: center;
    vertical-align: middle;
    min-width: 32px;
    width: 32px;
    height: 24px;
    line-height: 24px;
    font-size: 12px;
    border-radius: 4px;
    border: 1px solid transparent;
    white-space: nowrap;
    cursor: pointer;
}

.daterangepicker .calendar-table {
    border: 1px solid #fff;
    border-radius: 4px;
    background-color: #fff;
}

.daterangepicker .calendar-table table {
    width: 100%;
    margin: 0;
    border-spacing: 0;
    border-collapse: collapse;
}

.daterangepicker td.available:hover,
.daterangepicker th.available:hover {
    background-color: #eee;
    border-color: transparent;
    color: inherit;
}

.daterangepicker td.week,
.daterangepicker th.week {
    font-size: 80%;
    color: #ccc;
}

.daterangepicker td.off,
.daterangepicker td.off.end-date,
.daterangepicker td.off.in-range,
.daterangepicker td.off.start-date {
    background-color: #fff;
    border-color: transparent;
    color: #999;
}

.daterangepicker td.in-range {
    background-color: #ebf4f8;
    border-color: transparent;
    color: #000;
    border-radius: 0;
}

.daterangepicker td.start-date {
    border-radius: 4px 0 0 4px;
}

.daterangepicker td.end-date {
    border-radius: 0 4px 4px 0;
}

.daterangepicker td.start-date.end-date {
    border-radius: 4px;
}

.daterangepicker td.active,
.daterangepicker td.active:hover {
    background-color: #357ebd;
    border-color: transparent;
    color: #fff;
}

.daterangepicker th.month {
    width: auto;
}

.daterangepicker option.disabled,
.daterangepicker td.disabled {
    color: #999;
    cursor: not-allowed;
}

.daterangepicker select.monthselect,
.daterangepicker select.yearselect {
    font-size: 12px;
    padding: 1px;
    height: auto;
    margin: 0;
    cursor: default;
}

.daterangepicker select.monthselect {
    margin-right: 2%;
    width: 56%;
}

.daterangepicker select.yearselect {
    width: 40%;
}

.daterangepicker select.ampmselect,
.daterangepicker select.hourselect,
.daterangepicker select.minuteselect,
.daterangepicker select.secondselect {
    width: 50px;
    margin: 0 auto;
    background: #eee;
    border: 1px solid #eee;
    padding: 2px;
    outline: 0;
    font-size: 12px;
}

.daterangepicker .calendar-time {
    text-align: center;
    margin: 4px auto 0;
    line-height: 30px;
    position: relative;
}

.daterangepicker .calendar-time select.disabled {
    color: #ccc;
    cursor: not-allowed;
}

.daterangepicker .drp-buttons {
    clear: both;
    padding: 8px;
    border-top: 1px solid #ddd;
    display: none;
    line-height: 12px;
    vertical-align: middle;
}

.daterangepicker .drp-selected {
    display: inline-block;
    font-size: 12px;
    padding-right: 8px;
}

.daterangepicker .drp-buttons .btn {
    margin-left: 8px;
    font-size: 12px;
    font-weight: 700;
    padding: 4px 8px;
}

.daterangepicker.show-ranges.single.rtl .drp-calendar.left {
    border-right: 1px solid #ddd;
}

.daterangepicker.show-ranges.single.ltr .drp-calendar.left {
    border-left: 1px solid #ddd;
}

.daterangepicker.show-ranges.rtl .drp-calendar.right {
    border-right: 1px solid #ddd;
}

.daterangepicker.show-ranges.ltr .drp-calendar.left {
    border-left: 1px solid #ddd;
}

.daterangepicker .ranges {
    float: none;
    text-align: left;
    margin: 0;
}

.daterangepicker.show-calendar .ranges {
    margin-top: 8px;
}

.daterangepicker .ranges ul {
    list-style: none;
    margin: 0 auto;
    padding: 0;
    width: 100%;
}

.daterangepicker .ranges li {
    font-size: 12px;
    padding: 8px 12px;
    cursor: pointer;
}

.daterangepicker .ranges li:hover {
    background-color: #eee;
}

.daterangepicker .ranges li.active {
    background-color: #08c;
    color: #fff;
}

@media (min-width: 564px) {
    .daterangepicker {
        width: auto;
    }

    .daterangepicker .ranges ul {
        width: 140px;
    }

    .daterangepicker.single .ranges ul {
        width: 100%;
    }

    .daterangepicker.single .drp-calendar.left {
        clear: none;
    }

    .daterangepicker.single .drp-calendar,
    .daterangepicker.single .ranges {
        float: left;
    }

    .daterangepicker {
        direction: ltr;
        text-align: left;
    }

    .daterangepicker .drp-calendar.left {
        clear: left;
        margin-right: 0;
    }

    .daterangepicker .drp-calendar.left .calendar-table {
        border-right: none;
        border-top-right-radius: 0;
        border-bottom-right-radius: 0;
    }

    .daterangepicker .drp-calendar.right {
        margin-left: 0;
    }

    .daterangepicker .drp-calendar.right .calendar-table {
        border-left: none;
        border-top-left-radius: 0;
        border-bottom-left-radius: 0;
    }

    .daterangepicker .drp-calendar.left .calendar-table {
        padding-right: 8px;
    }

    .daterangepicker .drp-calendar,
    .daterangepicker .ranges {
        float: left;
    }
}

@media (min-width: 730px) {
    .daterangepicker .ranges {
        width: auto;
        float: left;
    }

    .daterangepicker.rtl .ranges {
        float: right;
    }

    .daterangepicker .drp-calendar.left {
        clear: none !important;
    }
}

body,
html {
    -webkit-overflow-scrolling: touch;
}

html {
    font-size: 10px;
}

body {
    background-color: #f5f5f5;
    font-size: 1.4rem;
    line-height: 1.7;
    font-family: Helvetica Neue, Helvetica, Arial, sans-serif;
    font-weight: 400;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    letter-spacing: 0.5px;
    color: #333;
    margin: 0 auto;
    overflow-x: hidden;
}

[lang^='zh-tw'] body {
    font-family: Noto Sans TC, 微软雅黑, Microsoft YaHei, sans-serif;
}

[lang^='zh-hk'] body {
    font-family: Noto Sans HK, 微软雅黑, Microsoft YaHei, sans-serif;
}

[lang^='zh-cn'] body,
[lang^='zh-my'] body {
    font-family: Noto Sans SC, 微软雅黑, Microsoft YaHei, sans-serif;
}

[lang^='ja-jp'] body {
    font-family: Noto Sans JP, MS PGothic, MS Gothic, ＭＳ ゴシック, sans-serif;
}

[lang^='ko-kr'] body {
    font-family: Noto Sans KR, 맑은 고딕, Malgun Gothic, dotum, sans-serif;
}

[lang^='th-th'] body {
    font-family: Noto Sans Thai, sans-serif;
}

[lang^='vi-vn'] body {
    font-family: -apple-system, BlinkMacSystemFont, Segoe UI, Roboto,
        RobotoDraft, Helvetica, Arial, sans-serif;
}

:focus {
    outline: none !important;
}

.pre-line {
    white-space: pre-line;
}

.break-word {
    word-break: break-word;
    word-wrap: break-word;
}

.mt-0 {
    margin-top: 0 !important;
}

.relative {
    position: relative;
}

.overflow-hidden {
    overflow: hidden;
}

.display-inline-block {
    display: inline-block;
}

.login-sns button {
    color: #fff;
}

.login-sns button:focus,
.login-sns button:hover {
    color: #fff;
    -webkit-box-shadow: 100px 100px 0 rgba(0, 0, 0, 0.1) inset;
    box-shadow: inset 100px 100px 0 rgba(0, 0, 0, 0.1);
}

.login-facebook {
    background-color: #3b5998;
}

.login-google,
.login-google-plus {
    background-color: #dd4b39;
}

.login-wechat {
    background-color: #2dc100;
}

.login-qq {
    background-color: #14b7f6;
}

.login-QQ {
    background-color: #68bcfd;
}

.login-naver {
    background-color: #00c73c;
}

.login-kakao {
    background-color: #fae101;
    color: #523e35 !important;
}

.login-yahoo {
    background-color: #fa0f30;
}

.login-line {
    background-color: #01b901;
}

.login-sns .login-kakao i img,
.login-sns .login-line i img {
    width: 24px;
}

@-webkit-keyframes placeHolderShimmer2 {
    to {
        -webkit-transform: translateX(100%);
        transform: translateX(100%);
    }
}

@keyframes placeHolderShimmer2 {
    to {
        -webkit-transform: translateX(100%);
        transform: translateX(100%);
    }
}

.search-dropdown-v2 {
    color: #333;
    background: #fff;
    border-radius: 6px;
    padding: 16px;
    position: absolute;
    width: 640px;
    top: 50px;
    left: 0;
    z-index: 999;
    max-height: 425px;
    -webkit-box-shadow: 0 1px 4px 0 rgba(38, 50, 56, 0.12);
    box-shadow: 0 1px 4px 0 rgba(38, 50, 56, 0.12);
    overflow-y: auto;
}

.search-dropdown-v2::-webkit-scrollbar {
    width: 6px;
    height: 6px;
}

.search-dropdown-v2::-webkit-scrollbar-button {
    display: none;
}

.search-dropdown-v2::-webkit-scrollbar-corner {
    background: transparent;
}

.search-dropdown-v2::-webkit-scrollbar-thumb {
    background: #ddd;
    border-radius: 6px;
}

.search-dropdown-v2::-webkit-scrollbar-track {
    border-radius: 6px;
}

.search-dropdown-v2::-webkit-scrollbar-track-piece {
    background: transparent;
}

.search-dropdown-v2__destinations,
.search-dropdown-v2__experiences {
    list-style: none;
    margin: 0;
    padding: 0;
}

.search-dropdown-v2__destination-item:not(:last-child) {
    margin-bottom: 2px;
}

.search-dropdown-v2__experience-item:first-child {
    margin-top: 4px;
}

.search-dropdown-v2__experience-item:hover .search-product {
    background-color: #f6f7f9;
}

.search-dropdown-v2__recent-search:not(:last-child) {
    margin-bottom: 24px;
}

.search-dropdown-v2__loading {
    color: #ccc;
}

.search-dropdown-v2 .default-suggest__title {
    font-size: 1.4rem;
    margin-top: 0;
    color: #212121;
}

.search-dropdown-v2 .default-suggest__cities {
    list-style: none;
    width: 100%;
    margin: 0;
    padding: 0;
    -webkit-column-count: 3;
    -moz-column-count: 3;
    column-count: 3;
    -webkit-column-rule: 1px solid #eee;
    -moz-column-rule: 1px solid #eee;
    column-rule: 1px solid #eee;
}

.search-dropdown-v2 .default-suggest__city {
    line-height: normal;
}

.search-dropdown-v2 .default-suggest__city:hover {
    background-color: #f6f7f9;
}

.search-dropdown-v2 .default-suggest__city a {
    color: inherit;
    padding: 6px 8px;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.search-dropdown-v2 .default-suggest__hot {
    margin-left: 4px;
}

.search-dropdown-v2 .default-suggest .destination-city {
    width: 296px;
    border-radius: 8px;
    background-color: #fff;
    color: #212121;
}

.search-dropdown-v2 .default-suggest .destination-city:active,
.search-dropdown-v2 .default-suggest .destination-city:hover {
    background-color: #f7fafc;
}

.search-dropdown-v2 .default-suggest .destination-city-img {
    width: 58px;
    height: 58px;
    border-radius: 8px;
    -o-object-fit: cover;
    object-fit: cover;
}

.h1,
.h2,
.h3,
.h4,
h1,
h2,
h3,
h4 {
    font-family: inherit;
    font-weight: 700;
}

.h5,
.h6,
h5,
h6 {
    font-family: inherit;
    font-weight: 400;
}

.h1,
h1 {
    font-size: 2.4rem;
    line-height: 1.5;
}

.h2,
h2 {
    font-size: 2.2rem;
}

.h2,
.h3,
h2,
h3 {
    line-height: 1.7;
}

.h3,
h3 {
    font-size: 2rem;
}

.h4,
h4 {
    font-size: 1.6rem;
}

.h4,
.h5,
h4,
h5 {
    line-height: 1.7;
}

.h5,
.p,
h5,
p {
    font-size: 1.4rem;
}

a {
    cursor: pointer;
    color: #26bec9;
    -webkit-transition: 0.25s;
    transition: 0.25s;
}

a,
a:focus,
a:hover {
    text-decoration: none;
}

a:focus,
a:hover {
    color: #22a7aa;
    outline: 0;
}

a.link-secondary {
    color: #138184;
}

a:not(.btn).disabled,
a:not(.btn).disabled:focus {
    pointer-events: none;
    color: #999;
}

hr {
    border-color: rgba(0, 0, 0, 0.06);
}

.custom-kk-icon {
    display: inline-block;
    width: 1em;
    height: 1em;
    fill: currentColor;
}

.text-lg {
    font-size: 2rem !important;
}

.text-md {
    font-size: 1.6rem !important;
}

.text-sm {
    font-size: 1.4rem !important;
}

.text-xs,
small {
    font-size: 1.2rem !important;
}

.text-left {
    text-align: left !important;
}

.text-center {
    text-align: center !important;
}

.text-right {
    text-align: right !important;
}

.text-bold {
    font-weight: 700;
}

.mg-0 {
    margin: 0 !important;
}

.mt-10 {
    margin-top: 10px !important;
}

.mt-15 {
    margin-top: 15px !important;
}

.mt-20 {
    margin-top: 20px !important;
}

.mb-15 {
    margin-bottom: 15px !important;
}

.mb-20 {
    margin-bottom: 20px !important;
}

.mb-0 {
    margin-bottom: 0 !important;
}

.mr-20 {
    margin-right: 20px !important;
}

.mr-5 {
    margin-right: 5px;
}

.pd-10 {
    padding: 10px !important;
}

.pd-20 {
    padding: 20px !important;
}

.no-border {
    border: 0 !important;
}

.overflow-x {
    overflow-x: auto;
}

.img-bg {
    background-position: 50%;
    background-repeat: no-repeat;
    background-size: cover;
    overflow: hidden;
}

.city-item,
.img-bg,
.product-item .product-img,
ul.map-info .map-img {
    background-color: #eaeaea;
}

.svg-sprite-wrap {
    position: absolute;
    bottom: 0;
    left: 0;
}

.break-words {
    display: inline-block;
    word-break: break-all;
    overflow-wrap: break-word;
}

.w-90 {
    width: 90px !important;
}

.w-120 {
    width: 120px !important;
}

.w-150 {
    width: 150px !important;
}

.w-180 {
    width: 180px !important;
}

.text-heavy {
    color: #333 !important;
}

.text-grey {
    color: #666 !important;
}

.text-grey-light {
    color: #999 !important;
}

.text-light {
    color: #ccc;
}

.text-muted {
    color: #aaa !important;
}

.text-primary {
    color: #26bec9 !important;
}

.text-secondary {
    color: #138184 !important;
}

.text-success {
    color: #ffb400;
}

.text-danger {
    color: #e65f50 !important;
}

.text-warning {
    color: #ffb400 !important;
}

.text-yellow {
    color: #ffc612 !important;
}

.text-white {
    color: #fff !important;
}

.bg-grey {
    background-color: #eee !important;
}

.bg-grey-light {
    background-color: #f4f4f4 !important;
}

.bg-primary {
    background-color: #26bec9 !important;
}

.bg-primary-light {
    background: #ecfafb !important;
}

.bg-warning {
    background-color: #ffb400 !important;
}

.bg-secondary-light {
    background-color: rgba(19, 129, 132, 0.6) !important;
}

.bg-danger-light {
    background-color: rgba(239, 122, 112, 0.7) !important;
}

.bg-warning-light {
    background-color: rgba(255, 180, 0, 0.7) !important;
}

.bg-white {
    background-color: #fff !important;
}

.bg-danger {
    background-color: #ef7a70 !important;
}

.bg-trans {
    background-color: transparent;
}

.btn.active,
.btn:active,
.btn:focus,
button:focus {
    outline: 0;
    -webkit-box-shadow: none;
    box-shadow: none;
}

.btn {
    font-size: 1.4rem;
    padding: 10px 24px;
    font-weight: 400;
    line-height: 1.6;
    border-radius: 4px;
    -webkit-font-smoothing: subpixel-antialiased;
    -webkit-transition: border 0.25s linear, color 0.25s linear,
        background-color 0.25s linear;
    transition: border 0.25s linear, color 0.25s linear,
        background-color 0.25s linear;
}

.btn-md {
    padding: 12px 28px;
    font-size: 1.6rem;
}

.btn-sm {
    padding: 8px 14px;
    font-size: 1.4rem;
}

.btn-xs {
    padding: 6px 12px;
    font-size: 1.2rem;
}

.btn-block {
    white-space: normal;
    max-width: none;
    margin: 0 auto;
    padding: 13px 10px;
    font-weight: 500;
}

.btn.disabled,
.btn[disabled],
fieldset[disabled] .btn {
    opacity: 1;
    background-color: #ddd;
    color: #fff;
    cursor: not-allowed;
}

.btn-default {
    color: #666;
    background: #fff;
    border: 1px solid #e1e1e1;
}

.btn-default.active,
.btn-default:active,
.btn-default:focus,
.btn-default:hover,
.open .dropdown-toggle.btn-default {
    color: #333;
    background-color: #f4f4f4;
    border: 1px solid #ddd;
}

.btn-default.active.focus,
.btn-default.active:focus,
.btn-default.active:hover,
.btn-default:active.focus,
.btn-default:active:focus,
.btn-default:active:hover,
.open > .dropdown-toggle.btn-default.focus,
.open > .dropdown-toggle.btn-default:focus,
.open > .dropdown-toggle.btn-default:hover {
    color: #666;
    background-color: #e6e6e6;
    border-color: #eee;
}

.btn-default.active,
.btn-default:active,
.open .dropdown-toggle.btn-default {
    color: #666;
    background-color: #f4f4f4;
    border-color: #e6e6e6;
}

.btn-default.disabled,
.btn-default.disabled.active,
.btn-default.disabled:active,
.btn-default.disabled:focus,
.btn-default.disabled:hover,
.btn-default[disabled],
.btn-default[disabled].active,
.btn-default[disabled]:active,
.btn-default[disabled]:focus,
.btn-default[disabled]:hover,
fieldset[disabled] .btn-default,
fieldset[disabled] .btn-default.active,
fieldset[disabled] .btn-default:active,
fieldset[disabled] .btn-default:focus,
fieldset[disabled] .btn-default:hover {
    background-color: #e6e6e6;
    color: #ccc;
}

.btn-primary {
    color: #fff;
    background-color: #26bec9;
    border: none;
}

.btn-primary.active,
.btn-primary.active.focus,
.btn-primary.active:focus,
.btn-primary.active:hover,
.btn-primary:active,
.btn-primary:active.focus,
.btn-primary:active:focus,
.btn-primary:active:hover,
.btn-primary:focus,
.btn-primary:hover,
.open .dropdown-toggle.btn-primary,
.open > .dropdown-toggle.btn-primary.focus,
.open > .dropdown-toggle.btn-primary:focus,
.open > .dropdown-toggle.btn-primary:hover {
    color: #fff;
    background-color: #22a7aa;
    border-color: #22a7aa;
}

.btn-primary.disabled,
.btn-primary.disabled.active,
.btn-primary.disabled:active,
.btn-primary.disabled:focus,
.btn-primary.disabled:hover,
.btn-primary[disabled],
.btn-primary[disabled].active,
.btn-primary[disabled]:active,
.btn-primary[disabled]:focus,
.btn-primary[disabled]:hover,
fieldset[disabled] .btn-primary,
fieldset[disabled] .btn-primary.active,
fieldset[disabled] .btn-primary:active,
fieldset[disabled] .btn-primary:focus,
fieldset[disabled] .btn-primary:hover {
    background-color: #ddd;
    border-color: #ddd;
}

.btn-blue {
    background-color: #64b3f4;
    color: #fff;
}

.btn-blue:active,
.btn-blue:focus,
.btn-blue:hover {
    background-color: #489add;
    color: #fff;
}

.btn-white {
    background: #fff;
    border: 1px solid #eee;
    color: #333;
}

.btn-white:focus,
.btn-white:hover {
    -webkit-box-shadow: inset 100px 100px 0 rgba(0, 0, 0, 0.02);
    box-shadow: inset 100px 100px 0 rgba(0, 0, 0, 0.02);
    border: 1px solid #eee;
    color: #333;
}

.btn-info {
    color: #666;
    background-color: #fff;
    border: 1px solid #999;
}

.btn-info.active,
.btn-info.active.focus,
.btn-info.active:focus,
.btn-info.active:hover,
.btn-info:active,
.btn-info:active.focus,
.btn-info:active:focus,
.btn-info:active:hover,
.btn-info:focus,
.btn-info:hover,
.open .dropdown-toggle.btn-info,
.open > .dropdown-toggle.btn-info.focus,
.open > .dropdown-toggle.btn-info:focus,
.open > .dropdown-toggle.btn-info:hover {
    color: #666;
    background-color: #eee;
    border-color: #999;
}

.btn-info.disabled,
.btn-info.disabled.active,
.btn-info.disabled:active,
.btn-info.disabled:focus,
.btn-info.disabled:hover,
.btn-info[disabled],
.btn-info[disabled].active,
.btn-info[disabled]:active,
.btn-info[disabled]:focus,
.btn-info[disabled]:hover,
fieldset[disabled] .btn-info,
fieldset[disabled] .btn-info.active,
fieldset[disabled] .btn-info:active,
fieldset[disabled] .btn-info:focus,
fieldset[disabled] .btn-info:hover {
    background-color: #eee;
    border-color: #eee;
    color: #ccc;
}

.btn-success {
    color: #26bec9;
    background-color: #fff;
    border: 1.5px solid rgba(38, 190, 201, 0.7);
}

.btn-success.active,
.btn-success.active.focus,
.btn-success.active:focus,
.btn-success.active:hover,
.btn-success:active,
.btn-success:active.focus,
.btn-success:active:focus,
.btn-success:active:hover,
.btn-success:focus,
.btn-success:hover,
.open .dropdown-toggle.btn-success,
.open > .dropdown-toggle.btn-success.focus,
.open > .dropdown-toggle.btn-success:focus,
.open > .dropdown-toggle.btn-success:hover {
    color: #22a7aa;
    background-color: #e4f4f5;
    border-color: #26bec9;
}

.btn-success.disabled,
.btn-success.disabled.active,
.btn-success.disabled:active,
.btn-success.disabled:focus,
.btn-success.disabled:hover,
.btn-success[disabled],
.btn-success[disabled].active,
.btn-success[disabled]:active,
.btn-success[disabled]:focus,
.btn-success[disabled]:hover,
fieldset[disabled] .btn-success,
fieldset[disabled] .btn-success.active,
fieldset[disabled] .btn-success:active,
fieldset[disabled] .btn-success:focus,
fieldset[disabled] .btn-success:hover {
    border-color: #26bec9;
    background: #fff;
    opacity: 0.4;
    color: #26bec9;
    cursor: not-allowed;
}

.btn-link {
    color: #26bec9;
    background-color: transparent;
}

.btn-link:focus,
.btn-link:hover {
    color: #22a7aa;
    text-decoration: none;
}

.btn-link.disabled,
.btn-link.disabled.active,
.btn-link.disabled:active,
.btn-link.disabled:focus,
.btn-link.disabled:hover,
.btn-link[disabled],
.btn-link[disabled].active,
.btn-link[disabled]:active,
.btn-link[disabled]:focus,
.btn-link[disabled]:hover,
fieldset[disabled] .btn-link,
fieldset[disabled] .btn-link.active,
fieldset[disabled] .btn-link:active,
fieldset[disabled] .btn-link:focus,
fieldset[disabled] .btn-link:hover {
    color: #999;
    text-decoration: none;
    background-color: transparent;
}

.btn-grey {
    background: #666;
    border: 0;
    color: #fff;
}

.btn-grey:hover {
    background-color: #555;
}

.btn-grey-light {
    background-color: #eee;
    border: 0;
    color: #333;
}

.btn-grey-light:hover {
    background: #e5e5e5;
    color: #333;
}

.btn-danger {
    background-color: #ef7a70;
    border: none;
    color: #fff;
}

.btn-danger:active,
.btn-danger:active:focus,
.btn-danger:focus,
.btn-danger:hover {
    background-color: rgba(239, 122, 112, 0.1);
    color: #ef7a70;
    border: 1.5px solid rgba(239, 122, 112, 0.7);
}

.btn-danger.disabled {
    background-color: transparent;
    color: #ef7a70;
    opacity: 0.4;
}

.btn-warning {
    background-color: #ffb400;
    border: 0;
}

.btn-warning:active,
.btn-warning:focus,
.btn-warning:hover {
    background-color: #e9a300;
}

.btn-ghost {
    background-color: transparent;
    color: inherit;
    border-color: inherit;
}

.btn-ghost.disabled,
.btn-ghost[disabled] {
    background-color: transparent;
    border-color: #ddd;
    color: #ddd;
}

.btn-ghost--warning {
    border-color: #ffb400;
    color: #ffb400;
}

.btn-ghost--warning:active,
.btn-ghost--warning:focus,
.btn-ghost--warning:hover {
    border-color: #e9a300;
    color: #e9a300;
}

.btn-group > .btn:first-child:not(:last-child):not(.dropdown-toggle),
.btn-group > .btn:last-child:not(.dropdown-toggle),
.btn-group > .btn:not(:first-child):not(:last-child):not(.dropdown-toggle) {
    border-radius: 4px;
}

.btn-group > .btn {
    background-color: #eee;
    color: #999;
    margin-right: 10px;
    margin-bottom: 10px;
    padding: 8px 16px;
    -webkit-transition: none;
    transition: none;
}

.btn-group .btn.focus {
    outline: 0;
}

.btn-group .btn.active {
    background-color: #26bec9;
    color: #fff;
}

.form-group .btn-group {
    display: block;
}

label {
    color: #555;
    font-weight: 400;
    line-height: 1.7;
}

.form-control,
.form-control[readonly],
.select2-container--default .select2-search--dropdown .select2-search__field,
.select2-container .select2-selection--single {
    height: 45px;
    padding: 10px 12px;
    color: #333;
    font-family: inherit;
    font-size: 1.5rem;
    line-height: 1.5;
    letter-spacing: 0.5px;
    border-radius: 4px;
    background-color: #fff;
    border: 1px solid #e1e1e1;
    -webkit-box-shadow: none;
    box-shadow: none;
    opacity: 1;
}

.form-control[readonly] {
    cursor: pointer;
}

.form-control:not([type='checkbox']):not([type='radio']) {
    -webkit-appearance: none;
    -moz-appearance: none;
    appearance: none;
}

.form-control::-webkit-input-placeholder {
    color: #aaa;
}

.form-control::-moz-placeholder {
    color: #aaa;
}

.form-control::-ms-clear {
    display: none;
    width: 0;
    height: 0;
}

.form-control[disabled],
fieldset[disabled] .form-control {
    border-color: #eee;
    background-color: #e6e6e6;
    color: #999;
    cursor: not-allowed;
    opacity: 0.7;
}

.form-control-inline {
    display: inline-block;
}

.form-group {
    position: relative;
    margin-bottom: 24px;
}

.form-control.StripeElement--focus,
.form-control.tappay-field-focus,
.form-control:focus,
.form-group.focus .form-control {
    border-color: #26bec9;
    outline: 0;
    -webkit-box-shadow: none;
    box-shadow: none;
}

.form-group .intl-tel-input {
    display: block;
}

.intl-tel-input .country-list {
    border-radius: 6px;
    -webkit-box-shadow: 0 2px 20px rgba(0, 0, 0, 0.15);
    box-shadow: 0 2px 20px rgba(0, 0, 0, 0.15);
    border-color: #fff;
    border-style: solid;
    border-width: 10px 0;
    margin-top: 1px;
    padding: 0 10px;
    -ms-scroll-chaining: none;
    overscroll-behavior: contain;
}

.intl-tel-input .country-list .divider {
    border-bottom: 1px solid #eaeaea;
}

.intl-tel-input .country-list .country {
    border-radius: 4px;
}

.intl-tel-input .country-list .country.highlight {
    background-color: rgba(0, 0, 0, 0.04);
}

.intl-tel-input.separate-dial-code .selected-flag {
    border-radius: 4px;
    overflow: hidden;
}

.intl-tel-input .selected-flag .iti-arrow {
    border: none;
    background: url(https://cdn.kkday.com/pc-web/assets/img/bg_dropdown.svg);
    background-size: 11px 6px;
    background-repeat: no-repeat;
    width: 11px;
    height: 6px;
}

.intl-tel-input.allow-dropdown .flag-container:hover .selected-flag,
.intl-tel-input.separate-dial-code .selected-flag {
    background: #fff;
}

.intl-tel-input .selected-flag .iti-flag {
    display: none;
}

.intl-tel-input.separate-dial-code .selected-dial-code {
    padding-left: 5px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 .selected-flag {
    width: 50px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 input {
    padding-left: 55px !important;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 .selected-flag {
    width: 60px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 input {
    padding-left: 65px !important;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 .selected-flag {
    width: 70px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 input {
    padding-left: 75px !important;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 .selected-flag {
    width: 80px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 input {
    padding-left: 85px !important;
}

.intl-tel-input .country-list .flag-box {
    display: none;
}

.intl-tel-input .country-list .country.active {
    color: #26bec9;
}

.help-block {
    font-size: 15px;
    margin-bottom: 5px;
    color: inherit;
}

select::-ms-expand {
    display: none;
}

.input-dropdown,
.select2-container .select2-selection--single,
select.form-control {
    padding: 0 25px 0 8px;
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_dropdown.svg);
    background-size: 11px 6px;
    background-position: center right 12px;
    background-repeat: no-repeat;
    margin: 0;
}

select.form-control:focus {
    border: 1px solid #26bec9;
}

select.form-control option {
    padding: 2px;
    color: #666;
    background: #fafafa;
}

select.form-control option:disabled {
    color: #aaa;
}

select.form-control option:first-child {
    color: #ccc;
}

.input-dropdown.disabled {
    background-color: #e6e6e6;
    cursor: not-allowed;
    color: #aaa;
}

select.select-num {
    width: 80px;
    display: inline-block;
}

.time-select .time-gap {
    font-size: 1.4rem;
    margin: 0 10px 0 5px;
}

.input-sm {
    padding: 6px 10px;
    height: 36px;
    font-size: 1.3rem;
    line-height: 1.4;
    border-radius: 4px;
}

.input-lg {
    height: 48px;
    padding: 10px 15px;
    font-size: 17px;
    line-height: 1.235;
    border-radius: 6px;
}

.input-dropdown {
    word-break: break-word;
    text-align: left;
    height: auto;
    min-height: 42px;
    padding: 10px 40px 10px 12px;
}

.input-dropdown i {
    margin-right: 8px;
}

.input-dropdown-menu li.text-muted.text-xs {
    padding: 0 15px;
}

.input-dropdown-menu > li > a {
    white-space: normal;
}

textarea.form-control {
    resize: none;
}

.input-group-addon {
    background: transparent;
    color: #999;
    padding: 10px 12px;
    font-size: 1.4rem;
    text-align: center;
    border: 1px solid #e1e1e1;
    border-radius: 4px;
    -webkit-transition: border 0.25s linear, color 0.25s linear,
        background-color 0.25s linear;
    transition: border 0.25s linear, color 0.25s linear,
        background-color 0.25s linear;
}

.input-btn input {
    width: calc(100% - 95px);
    display: inline-block;
}

.input-btn .btn {
    width: 95px;
    height: 45px;
    position: relative;
    top: -2px;
    margin-left: -10px;
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
    line-height: 25px;
}

.input-group-btn .btn {
    height: 45px;
    border: 0;
    color: #fff;
}

.input-group-btn .btn:active,
.input-group-btn .btn:focus,
.input-group-btn .btn:hover {
    -webkit-box-shadow: inset 100px 100px 0 rgba(0, 0, 0, 0.1);
    box-shadow: inset 100px 100px 0 rgba(0, 0, 0, 0.1);
}

.form-control + .input-icon {
    position: absolute;
    top: 2px;
    right: 2px;
    line-height: 37px;
    vertical-align: middle;
    font-size: 20px;
    color: #b2bcc5;
    background-color: #fff;
    padding: 0 12px 0 0;
    border-radius: 6px;
}

.input-icon {
    position: relative;
}

.input-icon .form-control {
    padding-left: 35px;
}

.input-icon .flag {
    position: absolute;
    left: 10px;
    top: 7.5px;
}

.input-icon .flag img {
    width: 17px;
    margin-top: 3px;
}

.input-icon i {
    position: absolute;
    left: 10px;
    top: 16px;
    color: #aaa;
}

optgroup[label] {
    text-align: center;
    background: #eee;
}

input[type='checkbox'],
input[type='radio'] {
    margin: 4px;
}

.checkbox,
.radio {
    padding-left: 0;
    margin-bottom: 12px;
    position: relative;
    -webkit-transition: color 0.25s linear;
    transition: color 0.25s linear;
    font-size: 14px;
    line-height: 1.5;
    cursor: pointer;
}

.checkbox {
    margin-right: 30px;
}

.checkbox.checked,
.radio.checked {
    color: #26bec9;
}

.checkbox input,
.radio input {
    outline: none !important;
    display: none;
}

.checkbox label,
.radio label {
    padding-left: 0;
}

.checkbox > i {
    color: #999;
    width: 20px;
}

.checkbox > .fa-square-o {
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
    -webkit-transform-origin: 0 0;
    transform-origin: 0 0;
}

.checkbox.checked i,
.checkbox:hover > i {
    color: #26bec9;
}

.checkbox-title {
    color: #666;
}

.form-control.has-success,
.has-success .form-control {
    border-color: rgba(38, 190, 201, 0.5);
    -webkit-box-shadow: none;
    box-shadow: none;
}

.form-control.has-success:focus,
.has-success .form-control:focus {
    border-color: #26bec9;
    -webkit-box-shadow: none;
    box-shadow: none;
}

.has-success .checkbox,
.has-success .checkbox-inline,
.has-success .control-label,
.has-success .form-control-feedback,
.has-success .help-block,
.has-success .radio,
.has-success .radio-inline {
    color: #26bec9;
}

.has-success .form-control::-moz-placeholder {
    opacity: 1;
}

.has-success .checkbox,
.has-success .checkbox-inline,
.has-success .control-label,
.has-success .help-block,
.has-success .radio,
.has-success .radio-inline {
    color: #26bec9;
}

.has-success .input-group-addon {
    color: #26bec9;
    border-color: rgba(38, 190, 201, 0.5);
    background-color: #e0f7f9;
}

.has-success .input-icon {
    color: rgba(38, 190, 201, 0.5);
}

.form-control.has-error,
.form-control.has-error:focus,
.has-error .form-control,
.has-error .form-control:focus {
    border: 1px solid #e65f50 !important;
    color: #333;
    -webkit-box-shadow: none;
    box-shadow: none;
}

.has-error .checkbox,
.has-error .checkbox-inline,
.has-error .control-label,
.has-error .form-control-feedback,
.has-error .help-block,
.has-error .radio,
.has-error .radio-inline,
.has-error label {
    color: #e65f50;
}

.has-error .form-control::-moz-placeholder {
    color: #aaa;
    opacity: 1;
}

.has-error .form-control:-ms-input-placeholder {
    color: #aaa;
}

.has-error .form-control::-webkit-input-placeholder {
    color: #aaa;
}

.has-error .form-control.placeholder {
    color: #aaa;
}

.has-error .form-control:focus {
    border-color: #e65f50;
    -webkit-box-shadow: none;
    box-shadow: none;
}

.has-error .input-group-addon {
    color: #e65f50;
    border-color: #e65f50;
    background-color: #f2dede;
}

.has-error .input-icon {
    color: #e65f50;
}

input[type='number'].form-control::-webkit-inner-spin-button,
input[type='number'].form-control::-webkit-outer-spin-button {
    -webkit-appearance: none;
}

.form-inline label {
    cursor: pointer;
}

.input-select,
.select-input {
    position: relative;
}

.input-select + .tip,
.select-input + .tip {
    margin-top: -20px;
}

.input-select .form-select {
    position: absolute;
    top: 0;
    right: 0;
    width: 80px;
}

.input-select .form-select select {
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
}

.input-select .form-input {
    width: calc(100% - 80px);
}

.input-select .form-input input {
    border-top-right-radius: 0;
    border-bottom-right-radius: 0;
    border-right-width: 0;
}

.input-select .form-input input:focus {
    border-right-width: 1px;
}

.form-inline .form-group,
.time-select .form-group {
    margin-bottom: 0;
    display: inline-block;
    vertical-align: middle;
}

.clear-input {
    position: absolute;
    right: 0;
    top: 0;
    color: #ccc;
    height: 42px;
    padding: 0 10px;
    line-height: 42px;
    cursor: pointer;
    z-index: 3;
}

.clear-input:hover {
    color: #666;
}

.fill-group {
    margin-bottom: 15px;
    font-size: 1.5rem;
    color: #333;
}

.fill-group label {
    display: block;
    font-size: 1.3rem;
    color: #999;
}

.fill-group .tip {
    color: #666;
}

.fill-group ol {
    padding-left: 20px;
}

.phone-input-group {
    position: relative;
}

.phone-input-group .select2-container {
    position: absolute;
    top: 1px;
    left: 1px;
}

.phone-input-group .select2-container .select2-selection--single {
    width: 80px;
    height: 40px;
    border: 0;
}

.phone-input-group .form-control {
    padding-left: 80px;
}

.alert {
    font-size: 1.3rem;
    padding: 15px;
    color: #666;
}

.alert-info {
    border-color: rgba(38, 190, 201, 0.3);
    background-color: rgba(38, 190, 201, 0.1);
}

.alert-danger {
    border-color: rgba(239, 122, 112, 0.3);
    background-color: rgba(239, 122, 112, 0.1);
    color: #ef7a70;
}

.alert-warning {
    border-color: rgba(254, 226, 105, 0.3);
    background-color: rgba(254, 226, 105, 0.2);
}

.alert-kkday-danger,
.alert-kkday-info,
.alert-kkday-success,
.alert-kkday-warning {
    width: 60%;
    text-align: center;
    z-index: 1060 !important;
}

.alert-kkday-success {
    color: #3c763d;
    background-color: #dff0d8;
    border: 3px solid #d6e9c6;
}

.alert-kkday-info {
    color: #31708f;
    background-color: #d9edf7;
    border: 3px solid #bce8f1;
}

.alert-kkday-warning {
    color: #8a6d3b;
    background-color: #fcf8e3;
    border: 3px solid #faebcc;
}

.alert-kkday-danger {
    color: #a94442;
    background-color: #f2dede;
    border: 3px solid #ebccd1;
}

.kkday-alert {
    position: fixed;
    right: 20px;
    bottom: 20px;
    width: 346px;
    background-color: #fff;
    border-radius: 4px;
    -webkit-box-shadow: 0 4px 20px rgba(0, 0, 0, 0.2);
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.2);
    z-index: 1010;
}

.kkday-alert:before,
.modal-content:before {
    content: '';
    display: block;
    height: 8px;
    border-radius: 4px 4px 0 0;
    background: linear-gradient(65deg, #64b3f4, #26bec9 60%);
}

.kkday-alert:before {
    height: 4px;
}

.alert-header {
    padding: 15px 20px 0;
    color: #333;
    font-size: 2rem;
    font-weight: 700;
}

.alert-body {
    padding: 20px;
    color: #666;
}

.alert-footer {
    text-align: right;
    padding: 0 20px 15px;
}

.d-flex {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
}

.justify-content-center {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
}

.justify-content-between {
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
}

.align-items-center {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.justify-content-end {
    -webkit-box-pack: end;
    -ms-flex-pack: end;
    justify-content: flex-end;
}

.also-search {
    text-align: center;
}

.also-search .chip {
    font-size: 1.3rem;
}

.board {
    padding: 32px 20px;
    background: #fff;
    margin-bottom: 15px;
    border-radius: 6px;
}

.board .sub-title {
    margin: 20px 0;
    color: #333;
    font-size: 1.8rem;
    font-weight: 700;
    line-height: 1;
}

.board .sub-title:before,
.page-wrap .info-section .info-title:before {
    content: '';
    display: inline-block;
    position: static;
    width: 4px;
    height: 18px;
    margin-right: 8px;
    background-color: #333;
    vertical-align: top;
    border-radius: 4px;
}

.board-footer {
    margin: 0 -20px;
    padding: 15px 20px;
    border-top: 1px solid #eee;
}

.badge {
    letter-spacing: 0;
}

.cut-bread {
    padding: 15px 0;
}

.breadcrumb {
    margin: 0;
    padding: 0;
    background: transparent;
    font-size: 1.2rem;
    white-space: nowrap;
    overflow-x: hidden;
    text-overflow: ellipsis;
}

.prodlist-breadcrumb {
    margin-top: 20px;
}

.breadcrumb > li.active {
    color: #999;
}

.breadcrumb > li + li:before {
    content: '';
    font: normal normal normal 14px/1 FontAwesome;
    text-rendering: auto;
    color: #999;
    margin: 0 5px 0 3px;
    padding: 0;
}

.breadcrumb a {
    color: #138184;
}

.breadcrumb a:hover {
    text-decoration: underline;
}

.breadcrumb .gap {
    margin: 0 -4px 0 0;
}

.breadcrumb-black li {
    color: #aaa;
    font-size: 14px;
}

.breadcrumb-black li.active {
    color: #333;
    font-weight: 700;
}

.breadcrumb-black > li + li:before {
    margin-right: 10px;
    padding: 0 5px;
}

.breadcrumb-black > li > a {
    color: #aaa;
}

.breadcrumb-black > li > a:hover {
    color: #333;
}

.label-top10 {
    width: 44px;
    height: 51px;
}

.label-top10__rank {
    width: 24px;
    height: 21px;
    font-size: 1.8rem;
    font-weight: 600;
    color: #fff;
    line-height: 1.2;
    text-align: center;
}

.card {
    background: #fff;
    min-width: auto;
    border-radius: 6px;
    overflow: hidden;
    -webkit-transition: 0.2s ease-in-out;
    transition: 0.2s ease-in-out;
    position: relative;
    z-index: 1;
    line-height: inherit;
}

.card .label-top10 {
    position: absolute;
    top: 133px;
    right: 10px;
}

.card .label-top10__rank {
    position: absolute;
    top: 10px;
    right: 10px;
}

.card:hover {
    opacity: 0.8;
}

.cart-item {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
    margin-bottom: 15px;
    padding-bottom: 10px;
    background-color: #fff;
    border-bottom: 1px solid #eee;
}

.cart-item:last-child {
    margin-bottom: 0;
    border-bottom: 0;
}

.cart-item .product-img {
    width: 80px;
    border-radius: 4px;
    padding-bottom: 66.7%;
}

.cart-item > .product-img {
    min-width: 80px;
    height: 50px;
    padding-bottom: 0;
}

.cart-detail {
    -webkit-box-flex: 1;
    -ms-flex-positive: 1;
    flex-grow: 1;
    padding-left: 15px;
}

.cart-item .product-img:hover {
    opacity: 0.7;
}

.cart-item .product-detail {
    padding: 0;
}

.cart-item .product-detail > h3 {
    margin: -2px 0 5px;
    height: auto;
    font-size: 1.4rem;
}

.cart-item .product-detail > h3 a {
    color: #333;
}

.cart-item .product-detail > h3 a:focus,
.cart-item .product-detail > h3 a:hover {
    text-decoration: underline;
}

.cart-item .product-detail > .product-option {
    display: -webkit-box;
    -webkit-line-clamp: 2;
    -webkit-box-orient: vertical;
    overflow: hidden;
    max-height: 48px;
    margin-top: 4px;
    color: #333;
    font-size: 1.4rem;
}

.cart-item .product-pricing h4 {
    white-space: nowrap;
    font-size: 1.6rem;
}

.cart-item .critical-info {
    display: inline-block;
    margin-top: 5px;
    margin-right: 30px;
    margin-bottom: 0;
    font-size: 1.4rem;
    font-weight: 400;
    vertical-align: bottom;
}

.cart-item .fake {
    width: 60%;
    height: 54px;
}

.cart-item .fake .mask {
    width: auto;
}

.cart-item .fake .mask2 {
    top: 18px;
    right: 0;
    left: 80px;
    height: 6px;
}

.cart-item .fake .mask3 {
    bottom: 0;
    right: 0;
    left: 80px;
    height: 15px;
}

.cart-item .fake .mask4 {
    top: 0;
    left: 80px;
    width: 10px;
    height: 100%;
}

.cart-item .fake .mask5 {
    top: 24px;
    right: 0;
    width: 20%;
    height: 15px;
}

.cart-item .fake .mask6,
.cart-item .fake .mask7,
.cart-item .fake .mask8,
.cart-item .fake .mask9 {
    width: 20px;
    height: 20px;
    background: transparent;
    border: 10px solid #fff;
}

.cart-item .fake .mask6 {
    left: -10px;
    top: -10px;
    border-radius: 15px 0 0 0;
    border-right: transparent;
    border-bottom: transparent;
}

.cart-item .fake .mask7 {
    left: 70px;
    top: -10px;
    border-radius: 0 15px 0 0;
    border-bottom: transparent;
    border-left: transparent;
}

.cart-item .fake .mask8 {
    left: 70px;
    bottom: -10px;
    border-radius: 0 0 15px 0;
    border-top: transparent;
    border-left: transparent;
}

.cart-item .fake .mask9 {
    left: -10px;
    bottom: -10px;
    border-radius: 0 0 0 15px;
    border-top: transparent;
    border-right: transparent;
}

.cart-link.active:after {
    content: '';
    position: absolute;
    top: 20px;
    right: 15px;
    width: 8px;
    height: 8px;
    border-radius: 50%;
    background-color: #ef7a70;
    -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, 0.2);
    box-shadow: 0 1px 1px rgba(0, 0, 0, 0.2);
}

.order-main-goday {
    font-family: Arial Rounded MT Bold, Arial Rounded MT, sans-serif;
    border-radius: 4px;
    text-align: center;
    background: #f4f4f4;
    color: #666;
    -webkit-box-shadow: 0 2px 0 rgba(0, 0, 0, 0.1);
    box-shadow: 0 2px 0 rgba(0, 0, 0, 0.1);
    padding: 0 0 4px;
    width: 70px;
    margin: 10px 15px 15px 0;
}

.order-main-goday.disabled {
    opacity: 0.6;
}

.order-main-goday .year {
    font-size: 1.2rem;
    line-height: 1;
    letter-spacing: 1px;
    position: relative;
    border-radius: 4px 4px 0 0;
    color: #fff;
    background: #26bec9;
    padding: 4px;
}

.order-main-goday.disabled .year {
    background-color: #ccc;
}

.order-main-goday .mon {
    font-size: 1.6rem;
    line-height: 1.2;
    margin-top: 5px;
    text-transform: uppercase;
}

.order-main-goday .day {
    font-size: 2.4rem;
    line-height: 1;
    margin-bottom: 2px;
}

.chip {
    display: inline-block;
    font-size: 1.2rem;
    margin: 5px 2px;
    max-width: 100%;
    vertical-align: middle;
}

.chip-city-group {
    padding-bottom: 10px;
}

.chip-city {
    font-size: 1.4rem;
}

.chip a {
    color: #26bec9;
    border: 1px solid #26bec9;
    border-radius: 100px;
    padding: 2px 12px;
    -webkit-transition: none;
    transition: none;
    white-space: nowrap;
    display: block;
    overflow: hidden;
    text-overflow: ellipsis;
}

.chip a.city-selected,
.chip a:focus,
.chip a:hover {
    background-color: #26bec9;
    color: #fff;
}

.chip i:first-child {
    margin-right: 5px;
}

.chip-grey a,
.chip-grey a:focus,
.chip-grey a:hover {
    border: 1px solid #ccc;
    border-radius: 100px;
    padding: 4px 16px;
    color: #666;
    font-weight: 700;
}

.chip-grey a:focus,
.chip-grey a:hover {
    background-color: #f5f5f5;
}

.chip-grey i {
    color: #aaa;
}

.chip-info a,
.chip-info a:focus,
.chip-info a:hover {
    border: 1px solid #999;
    border-radius: 100px;
    padding: 2px 12px;
    color: #666;
    -webkit-transition: none;
    transition: none;
    white-space: nowrap;
    display: block;
    overflow: hidden;
    text-overflow: ellipsis;
}

.chip-info a:focus,
.chip-info a:hover {
    background-color: #f5f5f5;
}

.chip--darkgrey a {
    color: #666;
    border-color: #666;
}

.chip--darkgrey a:focus,
.chip--darkgrey a:hover {
    background-color: #fff;
    color: #666;
}

.chip--white a {
    color: #fff;
    border-color: #fff;
}

.chip--white a:focus,
.chip--white a:hover {
    background-color: hsla(0, 0%, 100%, 0.15);
    -webkit-box-shadow: 0 0 15px rgba(0, 0, 0, 0.08);
    box-shadow: 0 0 15px rgba(0, 0, 0, 0.08);
}

.critical-info {
    color: #666;
    padding-left: 25px;
}

.critical-info .custom-kk-icon,
.critical-info i,
.critical-info span {
    vertical-align: middle;
}

.critical-info span {
    color: #333;
}

.critical-info .custom-kk-icon:first-child,
.critical-info i:first-child,
.critical-info img:first-child {
    display: inline-block;
    margin-right: 5px;
    width: 16px;
    text-align: center;
    margin-left: -25px;
}

.critical-info .custom-kk-icon:first-child {
    width: 1em;
}

.critical-info img:first-child {
    width: 16px;
}

#cropperWrap {
    max-width: 100%;
}

.modal .cropper-container {
    background: #f4f4f4;
}

.cropper-modal {
    background-color: #f4f4f4;
    opacity: 0.8;
}

.cropper-view-box {
    outline: 1px solid #26bec9;
}

.cropper-crop-box,
.cropper-face,
.cropper-view-box {
    border-radius: 50%;
}

.zoom-slider .irs {
    margin-bottom: 42px;
}

.zoom-slider .irs-line {
    background: #ddd;
    border-color: #ddd;
}

.zoom-slider .irs-bar,
.zoom-slider .irs-bar-edge {
    background: transparent;
}

.zoom-slider .input-group-addon {
    border: none;
    font-size: 2rem;
}

.zoom-slider .input-group-addon:first-child {
    padding-left: 0;
}

.zoom-slider .input-group-addon:last-child {
    padding-right: 0;
}

.daterangepicker {
    width: auto;
    max-height: none;
    min-width: auto;
    padding-bottom: 58px;
    visibility: visible;
    opacity: 1;
    border: 0;
}

.daterangepicker_input {
    display: none;
}

.daterangepicker.show-calendar .calendar {
    padding-bottom: 5px;
    margin-bottom: 5px;
}

.daterangepicker .calendar-table td,
.daterangepicker .calendar-table th {
    font-size: 1.4rem;
}

.daterangepicker td.today {
    color: #26bec9;
}

.daterangepicker td.off.available {
    color: #333;
}

.daterangepicker td.off.ends {
    visibility: hidden;
    height: 0;
    line-height: 0;
    padding: 0;
}

.daterangepicker td.active,
.daterangepicker td.active:hover,
.daterangepicker td.off.available.active {
    background: #26bec9 !important;
    color: #fff;
    display: table-cell;
}

.daterangepicker option.disabled,
.daterangepicker td.disabled {
    text-decoration: line-through;
    cursor: default;
    color: #eaeaea !important;
}

.daterangepicker .drp-buttons {
    border-top: 1px solid #eee;
    width: 100%;
    margin: 0;
    padding: 10px 15px;
    position: absolute;
    bottom: 0;
    right: 0;
    background: #fff;
    text-align: right;
}

.daterangepicker .drp-buttons .btn {
    font-size: 1.4rem;
    padding: 8px 14px;
}

.daterangepicker .drp-buttons .drp-selected {
    display: none;
}

.daterangepicker.single {
    padding-bottom: 0;
}

.daterangepicker.single.show-calendar .calendar {
    border-bottom: none;
}

.daterangepicker select.monthselect,
.daterangepicker select.yearselect {
    border: none;
    padding: 0 20px 0 8px;
    width: 80px;
    background: url(https://cdn.kkday.com/pc-web/assets/img/ic_down.svg) #fff;
    background-position: 100%;
    background-repeat: no-repeat;
    background-size: 2.2rem 1.5rem;
    -webkit-appearance: none;
    -moz-appearance: none;
    appearance: none;
    font-size: 1.4rem;
}

.daterangepicker select.monthselect option,
.daterangepicker select.yearselect option {
    padding: 5px 0;
}

.dot-load {
    width: 100%;
    text-align: center;
}

.dot-load-white .dot {
    background: #fff;
}

.option-group .dot-load {
    display: none;
    background: hsla(0, 0%, 95.7%, 0.6);
    position: absolute;
    left: 0;
    top: 0;
    padding-top: 50px;
}

.dot-load .dot {
    display: inline-block;
    width: 10px;
    height: 10px;
    border-radius: 50%;
    background-color: #ccc;
    margin: 3px;
    vertical-align: middle;
    -webkit-animation-name: dot-load;
    animation-name: dot-load;
    -webkit-animation-duration: 0.7s;
    animation-duration: 0.7s;
    -webkit-animation-iteration-count: infinite;
    animation-iteration-count: infinite;
}

.dot-load-primary .dot {
    background-color: #26bec9;
}

.dot-load .dot-1 {
    -webkit-animation-delay: 0s;
    animation-delay: 0s;
}

.dot-load .dot-2 {
    -webkit-animation-delay: 0.1s;
    animation-delay: 0.1s;
}

.dot-load .dot-3 {
    -webkit-animation-delay: 0.2s;
    animation-delay: 0.2s;
}

@-webkit-keyframes dot-load {
    0% {
        opacity: 1;
    }

    50% {
        opacity: 0.2;
    }

    to {
        opacity: 1;
    }
}

@keyframes dot-load {
    0% {
        opacity: 1;
    }

    50% {
        opacity: 0.2;
    }

    to {
        opacity: 1;
    }
}

a[data-toggle='dropdown'].disabled > .fa-angle-down {
    display: none;
}

.daterangepicker,
.dropdown-menu,
.select2-dropdown {
    background-color: #fff;
    border: none;
    border-radius: 6px;
    margin-top: 1px;
    opacity: 1;
    visibility: initial;
    -webkit-transition: 0.25s;
    transition: 0.25s;
    -webkit-box-shadow: 0 2px 20px rgba(0, 0, 0, 0.15);
    box-shadow: 0 2px 20px rgba(0, 0, 0, 0.15);
    min-width: 250px;
    overflow-y: auto;
    overscroll-behavior-y: contain;
}

.dropdown-scroll .dropdown-menu,
.input-dropdown-menu {
    border-color: #fff;
    border-style: solid;
    border-width: 10px 0;
    max-height: 290px;
    width: 100%;
}

.dropdown-menu ul {
    overflow: auto;
    max-height: 275px;
    padding: 0;
    margin: 0;
    list-style: none;
}

.dropdown-menu .divider {
    margin: 5px 0;
    background-color: #ddd;
}

.dropdown-arrow {
    border-color: transparent transparent #fff;
    border-style: solid;
    border-width: 0 8px 7px;
    margin-top: -6px;
    width: 0;
    height: 0;
    opacity: 0;
    position: absolute;
    left: 19px;
    top: 100%;
    z-index: 1001;
}

.open > .dropdown-arrow {
    opacity: 1;
}

.dropdown-menu-right + .dropdown-arrow {
    left: auto;
    right: 15px;
}

.dropdown-menu .checkbox,
.dropdown-menu .radio,
.dropdown-menu li > a,
.select2-results__option {
    padding: 8px 16px;
    margin: 0;
    line-height: 1.5;
}

.dropdown-menu li > a:active,
.dropdown-menu li > a:focus,
.dropdown-menu li > a:hover {
    background-color: rgba(0, 0, 0, 0.04);
}

.dropdown-menu li.active > a {
    background: transparent;
    color: #26bec9;
    font-weight: 700;
}

.dropdown-menu li.active > a:focus,
.dropdown-menu li.active > a:hover {
    background: rgba(0, 0, 0, 0.04);
    color: #26bec9;
}

.picked {
    color: #26bec9;
}

.sorting {
    text-align: right;
    margin-bottom: 15px;
    margin-top: 10px;
}

.sorting .dropdown {
    display: inline-block;
}

.sorting .dropdown > span {
    vertical-align: middle;
    color: #999;
}

.editor-inline .title,
.editor-inline > .editor-logo {
    display: inline-block;
    vertical-align: middle;
}

.editor-inline .title {
    margin-left: 10px;
}

.empty-list {
    width: 100%;
    border: 1px solid #ddd;
    border-radius: 6px;
    margin-top: 20px;
    padding: 30px;
}

.empty-list img {
    width: 200px;
}

.empty-list .none-title {
    text-align: center;
}

.empty-list .none-title h3 {
    margin-top: 15px;
}

.empty-list .none-hint {
    color: #666;
    max-width: 80%;
    margin: 0 auto;
}

.empty-list .section-head {
    margin-top: 50px;
    margin-bottom: 10px;
}

.empty-list .section-head h2.title {
    font-size: 2rem;
}

.empty-list .section-head h4.sub-title {
    font-size: 1.4rem;
}

.empty-list .none-title img {
    width: 140px;
}

.empty-list .owl-theme .owl-nav [class*='owl-'] {
    background-color: hsla(0, 0%, 100%, 0.9);
    border-radius: 100%;
    width: 50px;
    height: 50px;
    text-align: center;
    -webkit-box-shadow: 1px 2px 8px rgba(0, 0, 0, 0.2);
    box-shadow: 1px 2px 8px rgba(0, 0, 0, 0.2);
}

.empty-list .owl-theme .owl-nav [class*='owl-']:hover {
    background-color: #fff;
}

.empty-list .owl-theme .owl-nav [class*='owl-'] i {
    width: 38px;
    line-height: 48px;
    font-size: 3rem;
    color: #666;
}

.empty-list .owl-theme .owl-nav [class*='owl-']:hover i {
    color: #333;
}

.empty-list .city-item {
    height: 252px;
}

.loading-card {
    list-style: none;
    padding: 0;
}

.fake {
    -webkit-animation-duration: 1s;
    animation-duration: 1s;
    -webkit-animation-fill-mode: forwards;
    animation-fill-mode: forwards;
    -webkit-animation-iteration-count: infinite;
    animation-iteration-count: infinite;
    -webkit-animation-name: placeHolderShimmer;
    animation-name: placeHolderShimmer;
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
    background: #eaeaea;
    background: linear-gradient(295deg, #eaeaea 8%, #e0e0e0 28%, #eaeaea 50%);
    background-size: 1200px 300px;
    position: relative;
}

.fake .img-bg {
    background: transparent;
}

.fake .product-detail {
    height: 205px;
    padding: 0;
    position: relative;
}

.fake .mask {
    position: absolute;
    background: #fff;
    width: 100%;
}

.fake .list-top-mask {
    height: 15px;
    top: 0;
    left: -5px;
    border-radius: 0 6px 0 0;
}

.fake .list-bottom-mask {
    height: 150px;
    bottom: 0;
    left: -5px;
    border-radius: 0 0 6px 0;
}

.fake .list-left-mask {
    width: 15px;
    height: 100%;
    bottom: 0;
    left: -20px;
}

.fake .list-right-mask {
    width: 15px;
    height: 100%;
    bottom: 0;
    right: 0;
    border-radius: 0 6px 6px 0;
}

.fake .list-middle-mask {
    height: 10px;
    top: 30px;
    left: -15px;
}

.fake .list-right-mask-1 {
    width: 20%;
    height: 25px;
    top: 15px;
    right: 0;
}

.fake .list-right-mask-2 {
    width: 60%;
    height: 20px;
    top: 35px;
    right: 0;
}

.card.fake {
    height: 300px;
    border: 1px solid #eaeaea;
}

.card.fake .mask1 {
    height: 10px;
    top: 160px;
}

.card.fake .mask2,
.card.fake .mask3 {
    height: 110px;
    width: 10px;
    top: 165px;
}

.card.fake .mask3 {
    right: 0;
}

.card.fake .mask4 {
    height: 55px;
    bottom: 0;
}

.card.fake .mask5 {
    height: 5px;
    top: 188px;
    left: 10px;
    width: 100%;
}

.card.fake .mask6 {
    height: 15px;
    top: 211px;
    left: 10px;
    width: 100%;
}

.card.fake .mask7 {
    height: 15px;
    top: 280px;
    left: 10px;
    width: 100%;
}

.card.fake .mask8 {
    height: 20px;
    top: 192px;
    right: 10px;
    width: 30%;
}

.card.fake .mask9 {
    height: 20px;
    top: 225px;
    right: 10px;
    width: 70%;
}

@-webkit-keyframes placeHolderShimmer {
    0% {
        background-position: -600px 0;
    }

    to {
        background-position: 600px 0;
    }
}

@keyframes placeHolderShimmer {
    0% {
        background-position: -600px 0;
    }

    to {
        background-position: 600px 0;
    }
}

.gap {
    margin: 0 5px;
    color: #aaa;
}

.title-gap {
    border-bottom: 1px solid #eee;
    text-align: center;
    height: 12px;
    margin: 20px 0 30px;
}

.title-gap span {
    display: inline-block;
    padding: 0 10px;
    background: #fff;
    color: #666;
}

.header-sheet {
    background-color: #666;
    color: #fff;
    padding: 15px 0;
    position: relative;
}

.header-sheet .content {
    padding: 0 100px;
    text-align: center;
}

.header-sheet a {
    color: #7bdad7;
    text-decoration: underline;
}

.header-sheet .close {
    color: #fff;
    opacity: 1;
    font-size: 2.4rem;
    position: absolute;
    right: 20px;
    top: calc(50% - 3px);
    -webkit-transform: translateY(-50%);
    transform: translateY(-50%);
}

.new-feature-tip {
    background: linear-gradient(45deg, #64b3f4, #26bec9);
}

.new-feature-tip .content {
    font-weight: 600;
}

.new-feature-tip .content i {
    margin-left: 5px;
}

.label {
    font-size: 1.2rem;
    padding: 3px 8px;
}

.label-primary {
    background-color: #26bec9;
}

.label-secondary {
    background-color: #138184;
}

.label-default {
    background-color: #aaa;
}

.label-warning {
    background-color: #ffb400;
}

.label > i {
    margin: 0 4px 0 2px;
}

.label-danger {
    background-color: #ef7a70;
}

.label-grey {
    background-color: #eee;
    color: #666;
}

.label-gray {
    background-color: #999;
}

.label-outline-grey {
    border: 1px solid #e6e6e6;
    color: #333;
}

.list-item-group {
    line-height: 1.5;
}

.list-item-group > .list-item > a {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
}

.list-item .list-item-icon:not(.editor-logo) {
    color: #666;
    font-size: 1.8rem;
    vertical-align: middle;
    height: 2.1rem;
}

.list-item .list-item-icon:first-child {
    margin-right: 10px;
}

.list-item .list-item-icon.editor-logo {
    min-width: 50px;
    height: 50px;
    margin-left: -5px;
    margin-right: 10px;
}

.list-item .list-item-title {
    -webkit-box-flex: 1;
    -ms-flex: 1 0 auto;
    flex: 1 0 auto;
}

.list-item .sub-title {
    font-size: 1.2rem;
    color: #666;
}

.list-item .list-item-addon,
.list-item .list-item-icon:last-child {
    text-align: right;
    margin-left: 10px;
    font-family: Arial Rounded MT Bold, Arial Rounded MT, sans-serif;
}

.fa-spin.fa-circle-o-notch {
    -webkit-transform-origin: 48.5% 51%;
    transform-origin: 48.5% 51%;
}

.modal-dialog {
    width: 500px;
}

.modal-lg {
    width: 700px;
}

.modal-md {
    width: 600px;
}

.modal-sm {
    width: 400px;
}

.modal-content {
    border: none;
    padding: 0;
    width: 100%;
    background-color: #fff;
    -webkit-box-shadow: none;
    box-shadow: none;
    position: relative;
}

.modal-content:before {
    content: '';
    display: block;
    height: 8px;
    border-radius: 4px 4px 0 0;
    background: linear-gradient(65deg, #64b3f4, #26bec9 60%);
}

#select-a-date .modal-content:before,
.modal-lightbox .modal-content:before {
    display: none;
}

.modal-header {
    padding: 25px 30px 0;
    min-height: 16px;
    border: none;
}

.modal-header .modal-title {
    color: #333;
    margin-top: 0;
    font-size: 2.4rem;
}

.modal .close {
    font-size: 2.6rem;
    color: #666;
    opacity: 1;
    position: absolute;
    right: 30px;
    top: 40px;
    z-index: 9;
}

.modal-body {
    padding: 25px 30px;
}

.modal-body .modal-icon {
    font-size: 60px;
    margin-bottom: 10px;
    color: #ccc;
}

.modal-body .modal-icon img {
    width: 120px;
}

.modal-footer {
    border-top: 0;
    padding: 0 30px 20px;
}

.modal-footer .btn-default {
    border: 0;
    -webkit-transition: none;
    transition: none;
}

.modal-footer .btn-default:focus,
.modal-footer .btn-default:hover {
    background-color: transparent;
    color: #333;
}

.modal-sm .modal-header {
    padding: 20px 20px 0;
}

.modal-sm .modal-body {
    padding: 25px 20px;
}

.modal-sm .modal-footer {
    padding: 0 20px 15px;
}

.event-modal .modal-content:before {
    display: none;
}

.event-modal .modal-body {
    padding-top: 50px;
    padding-bottom: 50px;
}

.event-modal .close {
    top: 20px;
    right: 20px;
}

.event-title {
    font-size: 3.2rem;
    line-height: 1.5;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    margin-bottom: 30px;
}

.owl-carousel {
    position: relative;
    background: transparent;
    margin-top: 0;
}

.owl-carousel .owl-stage-outer {
    -webkit-overflow-scrolling: touch;
}

.owl-carousel .owl-item .item {
    background: #fff;
    margin: 0 10px;
    width: calc(100% - 20px);
    border-radius: 2px;
}

.owl-carousel .animated {
    -webkit-animation-duration: 0.3s;
    animation-duration: 0.3s;
}

.fadeIn {
    -webkit-animation-name: fadeIn;
    animation-name: fadeIn;
}

@-webkit-keyframes fadeIn {
    0% {
        opacity: 0;
    }

    to {
        opacity: 1;
    }
}

@keyframes fadeIn {
    0% {
        opacity: 0;
    }

    to {
        opacity: 1;
    }
}

.owl-carousel .owl-item .owl-lazy:not([src]),
.owl-carousel .owl-item .owl-lazy[src^=''] {
    max-height: none;
}

.overlap {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
}

ul.pagination {
    margin: 30px 0;
    position: relative;
    left: 50%;
    -webkit-transform: translateX(-50%);
    transform: translateX(-50%);
}

ul.pagination > li > span,
ul.pagination li > a {
    color: #999;
    margin: 1px;
    padding: 4px 10px;
    position: relative;
    border: 1px solid #eee;
}

.pagination > li > a:focus,
.pagination > li > a:hover,
.pagination > li > span:focus,
.pagination > li > span:hover {
    color: #999;
    border-color: #e6e6e6;
}

.pagination > .disabled > a,
.pagination > .disabled > a:focus,
.pagination > .disabled > a:hover,
.pagination > .disabled > span,
.pagination > .disabled > span:focus,
.pagination > .disabled > span:hover {
    color: #ccc;
    border-color: #eee;
    cursor: default;
}

.pagination > .active > a,
.pagination > .active > a:focus,
.pagination > .active > a:hover,
.pagination > .active > span,
.pagination > .active > span:focus,
.pagination > .active > span:hover {
    color: #fff;
    background-color: #26bec9;
    border-color: #26bec9;
}

.photo-group {
    list-style: none;
    padding: 0;
    margin: 0 -5px;
}

.photo-item {
    width: 100px;
    height: 100px;
    border-radius: 4px;
    background-size: cover;
    background-position: 50%;
    background-color: #f4f4f4;
    position: relative;
    float: left;
    margin: 5px;
    cursor: pointer;
}

.photo-upload {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    color: #ccc;
    cursor: pointer;
}

.photo-upload:hover {
    background-color: #eaeaea;
}

.photo-item .img-bg,
.photo-item .loading {
    height: 100%;
    border-radius: 4px;
}

.photo-item .loading {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    background-color: hsla(0, 0%, 100%, 0.6);
    color: #fff;
}

.photo-item .delete {
    position: absolute;
    top: -5px;
    right: -5px;
    background-color: #666;
    color: #fff;
    width: 25px;
    height: 25px;
    border-radius: 50%;
    text-align: center;
    line-height: 22px;
    cursor: pointer;
    display: none;
}

.photo-item:hover .delete {
    display: block;
}

.photo-item .delete:hover {
    background-color: #333;
}

.photo-item .delete i {
    margin-right: -1px;
}

.product-detail {
    padding: 4px 10px;
    min-height: auto;
}

.product-detail i {
    width: 20px;
    color: #ccc;
    text-align: center;
    display: inline-block;
}

.product-detail > h3 {
    display: -webkit-box;
    -webkit-line-clamp: 2;
    -webkit-box-orient: vertical;
    overflow: hidden;
    height: 52px;
    max-height: 52px;
    font-size: 1.6rem;
    color: #333;
}

.product-detail > h3 i {
    width: auto;
    -webkit-transition: 0.3s ease-in-out;
    transition: 0.3s ease-in-out;
    margin-right: 5px;
}

.product-detail .description {
    color: #666;
    font-size: 1.4rem;
    line-height: 1.6;
    margin-bottom: 8px;
    max-height: 43px;
    overflow: hidden;
    position: relative;
}

.product-item:hover h3 i,
.product-listview:hover h3 i {
    -webkit-transform: rotateY(1turn);
    transform: rotateY(1turn);
    color: #ffc612 !important;
    text-shadow: 0 0 15px rgba(255, 198, 18, 0.2);
}

.product-guide-lang,
.product-instant,
.product-place,
.product-time {
    font-size: 1.2rem;
    margin-bottom: 4px;
    color: #666;
}

.product-instant {
    color: #666;
    font-weight: 700;
}

.product-instant i {
    color: #26bec9;
}

.product-footer {
    min-height: 24px;
}

.product-footer > div {
    display: inline-block;
}

.product-footer > .product-star + .divider {
    display: inline-block;
    width: 1px;
    background: #eee;
    height: 16px;
    vertical-align: middle;
    margin: 0 3px;
}

.product-detail .product-book,
.product-detail .product-star {
    font-size: 1.2rem;
    color: #999;
}

.product-star {
    white-space: nowrap;
    letter-spacing: -4px;
}

.product-star b {
    margin-right: 4px;
}

.product-star .star {
    display: inline-block;
    font-size: 1.2rem;
    margin-right: 0.3em;
    background-size: 100% 100%;
    background-position: 50%;
    background-repeat: no-repeat;
    margin-bottom: -1px;
}

.product-star.text-sm .star {
    font-size: 14px;
}

.product-star * {
    letter-spacing: 0.5px;
}

.product-star .star-0 {
    color: #ccc;
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/ic_star4_0.svg);
}

.product-star .star-25 {
    fill: url(#star_25);
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/ic_star4_1.svg);
}

.product-star .star-50 {
    fill: url(#star_50);
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/ic_star4_2.svg);
}

.product-star .star-75 {
    fill: url(#star_75);
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/ic_star4_3.svg);
}

.product-star .star-100 {
    color: #26bec9;
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/ic_star4_4.svg);
}

.product-pricing {
    font-family: Arial Rounded MT Bold, Arial Rounded MT, sans-serif;
    letter-spacing: 0;
    text-align: right;
}

.product-pricing h2,
.product-pricing h4,
.product-pricing span {
    display: inline-block;
    font-weight: 400;
    margin: 0;
}

.product-pricing h2,
.product-pricing h4 {
    color: #26bec9;
}

.product-pricing .sale-price h4 {
    color: #333;
}

.product-pricing span {
    color: #999;
}

.product-pricing h4 {
    font-size: 2.2rem;
}

.origin-price {
    color: #999;
    font-size: 1.2rem;
    font-family: sans-serif;
    text-decoration: line-through;
    margin-top: 5px;
}

.product-tag {
    padding: 0 8px;
    margin: 0;
    text-align: right;
    -webkit-box-shadow: -1px 1px 1px rgba(0, 0, 0, 0.1);
    box-shadow: -1px 1px 1px rgba(0, 0, 0, 0.1);
    position: absolute;
    bottom: 60px;
    right: -10px;
}

.product-tag:after {
    content: ' ';
    border-style: solid;
    border-width: 0 10px 4px;
    position: absolute;
    right: -10px;
    bottom: -4px;
}

.product-tag.bg-primary:after {
    border-color: transparent transparent transparent #138184;
}

.product-tag span {
    font-size: 1.2rem;
    color: #fff;
    font-weight: 700;
    text-shadow: 0 0 2px rgba(0, 0, 0, 0.1);
}

.product-hint {
    position: absolute;
    top: -20px;
    left: -20px;
    padding: 4px 10px;
    font-size: 1.2rem;
    color: #fff;
    -webkit-box-shadow: 0 0 5px rgba(0, 0, 0, 0.3);
    box-shadow: 0 0 5px rgba(0, 0, 0, 0.3);
    background: #26bec9;
    border-radius: 4px;
    -webkit-transition: all 0.3s ease-in-out;
    transition: all 0.3s ease-in-out;
    opacity: 0;
}

.product-hint i {
    color: #fff;
    margin: 0;
    font-size: 1.4rem;
}

.product-hint:after {
    display: block;
    content: '';
    width: 0;
    height: 0;
    border-left: 10px solid transparent;
    border-right: 10px solid transparent;
    border-top: 10px solid #26bec9;
    position: absolute;
    left: 5px;
}

.product-item .product-img {
    height: 160px;
    position: relative;
    border-radius: 5px 5px 0 0;
}

.product-item .product-detail > h3 {
    font-weight: 500;
    margin: 0 0 10px;
    -webkit-font-smoothing: auto;
    -moz-osx-font-smoothing: auto;
}

.product-item .product-book,
.product-item .product-place {
    color: #666;
    white-space: nowrap;
    overflow: hidden;
    text-overflow: ellipsis;
    margin-bottom: 2px;
    height: 20px;
    font-size: 1.2rem;
}

.product-item .product-place {
    padding-right: 100px;
}

.product-item .product-book i,
.product-item .product-place i {
    margin-left: -2px;
    margin-right: 2px;
}

.product-item .product-footer {
    position: relative;
}

.product-listview .card-point {
    margin-bottom: 8px;
}

.product-listview .product-footer {
    position: absolute;
    left: 0;
    bottom: -15px;
    width: 100%;
}

.product-listview.search-info .product-footer {
    bottom: 0;
}

.product-listview .product-footer > .product-star {
    margin-left: 5px;
}

.product-item .product-pricing,
.product-listview .product-pricing {
    position: absolute;
}

.product-item .product-pricing {
    right: 0;
    bottom: 0;
    line-height: 1;
}

.product-item .product-pricing span {
    font-size: 1.2rem;
}

.product-item .product-pricing h4 {
    font-size: 1.8rem;
}

.product-item:hover .product-hint,
.product-listview:hover .product-hint {
    opacity: 1;
    -webkit-transform: translateY(-10px);
    transform: translateY(-10px);
}

.product-item .product-hint {
    top: 145px;
    left: 0;
}

.product-item .btn-wish {
    top: 5px;
    right: 5px;
    background-color: #fff;
    width: 32px;
    height: 32px;
    padding: 0;
    border-radius: 50%;
    font-size: 1.6rem;
    -webkit-box-shadow: 0 0 4px rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 4px rgba(0, 0, 0, 0.1);
}

.product-item .btn-wish .ani-heart-red {
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
}

.product-item-sm {
    padding: 10px;
    overflow: visible;
}

.product-item-sm > a {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
}

.product-item-sm .product-img {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 110px;
    flex: 0 0 110px;
    height: 86px;
    border-radius: 6px;
    margin-right: 10px;
}

.product-item-sm .product-detail {
    -webkit-box-flex: 1;
    -ms-flex-positive: 1;
    flex-grow: 1;
    padding: 0;
    position: relative;
}

.product-item-sm .product-detail > h3 {
    font-size: 1.4rem;
    line-height: 1.5;
    height: 64px;
    max-height: 64px;
    margin-bottom: 4px;
    padding-right: 30px;
    -webkit-line-clamp: 3;
}

.product-item-sm .product-detail .product-footer {
    margin-bottom: -6px;
}

.product-item-sm .product-detail .product-pricing h4 {
    font-size: 1.4rem;
}

.product-item-sm .product-detail .product-hint {
    top: -22px;
    left: -12px;
}

.product-item-sm .btn-wish {
    -webkit-box-shadow: none;
    box-shadow: none;
}

.product-item-sm.fake {
    height: 106px;
    overflow: hidden;
}

.product-item-sm.fake .mask1 {
    top: 0;
    left: 0;
    height: 12px;
}

.product-item-sm.fake .mask2 {
    top: 10px;
    left: 0;
    width: 12px;
}

.product-item-sm.fake .mask3 {
    top: 10px;
    left: 120px;
}

.product-item-sm.fake .mask4 {
    top: auto;
    bottom: 0;
    left: 0;
    height: 12px;
}

.product-item-sm.fake .mask5 {
    top: 10px;
    left: auto;
    right: 0;
    width: 20%;
    height: 20px;
}

.product-item-sm.fake .mask6 {
    top: 30px;
    left: 120px;
    width: calc(100% - 120px);
    height: 5px;
}

.product-item-sm.fake .mask7 {
    top: 35px;
    left: auto;
    right: 0;
    width: 40%;
    height: 20px;
}

.product-item-sm.fake .mask8 {
    top: auto;
    bottom: 0;
    left: 120px;
    width: calc(100% - 120px);
    height: 55px;
}

.product-benefit {
    margin: -10px -15px;
}

.product-benefit .critical-info {
    display: inline-block;
    margin: 15px;
    font-size: 1.5rem;
}

.product-abstract {
    color: #666;
    margin-top: 25px;
}

#product-scroll-spy {
    display: none;
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    z-index: 9;
    border-bottom: 1px solid #e1e1e1;
    background-color: #fff;
    -ms-overflow-style: none;
    overflow-x: auto;
    overflow-y: hidden;
}

#product-scroll-spy::-webkit-scrollbar {
    display: none;
}

#product-scroll-spy.active {
    display: block;
}

#product-scroll-spy .page-tab {
    position: relative;
    white-space: nowrap;
}

#product-scroll-spy .page-tab > li {
    float: none;
    display: inline-block;
    margin-right: -5px;
    border-bottom-width: 4px;
}

#product-scroll-spy .page-tab > li > a {
    padding: 10px 15px;
}

#page-scroll-spy {
    display: none;
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    z-index: 9;
    border-bottom: 1px solid #e1e1e1;
    background-color: #fff;
    -ms-overflow-style: none;
    overflow-x: auto;
    overflow-y: hidden;
}

#page-scroll-spy::-webkit-scrollbar {
    display: none;
}

#page-scroll-spy.active {
    display: block;
}

#page-scroll-spy .page-tab {
    position: relative;
    white-space: nowrap;
}

#page-scroll-spy .page-tab > li {
    float: none;
    display: inline-block;
    margin-right: -5px;
    border-bottom-width: 4px;
}

#page-scroll-spy .page-tab > li > a {
    padding: 10px 15px;
}

.home-carousel .owl-item .item {
    margin: auto;
    width: auto;
    border-radius: 6px;
}

.owl-carousel .owl-nav {
    margin-top: 0;
}

.owl-carousel .owl-nav button[class*='owl-'] {
    position: absolute;
    top: 50%;
    -webkit-transform: translateY(-50%);
    transform: translateY(-50%);
    color: #999;
    background-color: transparent;
    margin: 0;
}

.owl-carousel .owl-nav button[class*='owl-']:hover {
    color: #333;
    background-color: transparent;
}

.owl-carousel .owl-nav .owl-prev {
    left: -40px;
}

.owl-carousel .owl-next {
    right: -40px;
}

.owl-carousel .owl-next.disabled,
.owl-carousel .owl-prev.disabled {
    display: none;
}

.owl-theme .owl-dots .owl-dot {
    vertical-align: middle;
}

.info-section {
    padding: 30px 0;
}

.info-title {
    font-size: 2rem;
    color: #333;
    line-height: 1;
    margin-top: 0;
    margin-bottom: 40px;
    position: relative;
}

.info-title:before {
    content: '';
    display: inline-block;
    height: 1px;
    width: 40px;
    background-color: #333;
    position: absolute;
    left: 0;
    bottom: -8px;
}

.info-subtitle {
    font-size: 1.6rem;
    margin: 25px 0 10px;
}

.info-content {
    padding-left: 20px;
}

.info-section img {
    width: 100%;
}

.info-content > ol:not([class]),
.info-content > ul:not([class]) {
    padding-left: 20px;
}

.info-content > ol:not([class]) li,
.info-content > ul:not([class]) li,
.option-detail > ul li {
    padding: 5px 0;
    word-break: break-word;
}

.info-content .pagination {
    margin: 10px 0;
}

.progress {
    -webkit-box-shadow: none;
    box-shadow: none;
    background: transparent;
}

.progress-bar {
    background-color: #26bec9;
}

ul.time-info {
    margin-left: 0;
    list-style: none;
    padding-left: 30px;
}

ul.time-info li {
    padding: 15px 0;
    position: relative;
}

ul.time-info li:after {
    content: '';
    width: 3px;
    height: 100%;
    background-color: #eee;
    position: absolute;
    left: -24px;
    top: 30px;
}

ul.time-info li:last-child:after {
    display: none;
}

ul.time-info .time-info-day {
    display: inline-block;
    color: #fff;
    font-weight: 700;
    font-size: 1.6rem;
    padding: 18px 45px 18px 8px;
    margin-left: -26px;
    margin-bottom: 15px;
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_time_info_day.svg);
    background-size: 100% 100%;
    background-repeat: no-repeat;
    position: relative;
}

ul.time-info .time-info-day:after {
    left: 2px;
    top: 62px;
    height: 50px;
}

.time-info-include {
    font-weight: 700;
}

.time-info-include:before,
.time-info-spot:before {
    content: '';
    position: absolute;
    text-align: center;
    border-radius: 100%;
    z-index: 1;
}

.time-info-include:before {
    content: '$';
    color: #fff;
    font-weight: 700;
    background-color: #ffc612;
    width: 22px;
    height: 22px;
    left: -33px;
    top: 16px;
}

.time-info-spot:before {
    color: #999;
    background-color: #ccc;
    width: 15px;
    height: 15px;
    left: -30px;
    top: 20px;
}

.time-info-title {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
}

.time-info-spot .time {
    font-size: 1.6rem;
    margin-top: -2px;
    padding-right: 10px;
    color: #999;
    min-width: 60px;
}

.time-info-img {
    text-align: center;
    margin-top: 10px;
    border-radius: 4px;
    border: 1px solid #f5f5f5;
    overflow: hidden;
}

.map-img > img,
.time-info-img > img {
    cursor: -webkit-zoom-in;
    cursor: zoom-in;
}

ul.price-include,
ul.price-not {
    list-style: none;
    padding-left: 0;
}

ul.price-include li,
ul.price-not li {
    padding: 5px 0 5px 28px;
}

ul.price-include li img,
ul.price-not li img {
    width: 16px;
    margin-top: -4px;
    margin-right: 12px;
    margin-left: -28px;
}

.exchange-info {
    margin-top: 30px;
}

.exchange-info h5 {
    font-weight: 700;
    margin-bottom: 15px;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
}

.exchange-info h5 span:first-child {
    display: inline-block;
    padding: 5px 15px;
    color: #666;
    background-color: #eaeaea;
    border-radius: 4px 0 0 4px;
    white-space: nowrap;
}

.exchange-info h5 span:nth-child(2) {
    display: inline-block;
    color: #333;
    background-color: #f5f5f5;
    padding: 5px 15px;
    border-radius: 0 4px 4px 0;
}

.exchange-info .critical-info {
    padding-left: 40px;
}

.exchange-info .critical-info i {
    margin-left: -23px;
}

.cancel-info {
    width: 100%;
    border: 1px solid #eaeaea;
    border-radius: 4px;
    border-collapse: separate;
}

.cancel-info thead {
    background-color: #f4f4f4;
}

.cancel-info tbody tr td,
.cancel-info thead tr th {
    padding: 10px 15px;
    font-size: 1.4rem;
}

.cancel-info tbody td {
    color: #666;
    border-top: 1px solid #eaeaea;
}

.cancel-info tbody td span {
    margin-right: 5px;
}

ul.map-info {
    margin-left: 0;
    padding-left: 0;
    padding-bottom: 20px;
    font-size: 1.4rem;
    list-style: none;
}

ul.map-info > li {
    margin-bottom: 20px;
}

ul.map-info > li > .map-title {
    padding-left: 14px;
    margin-bottom: 5px;
}

ul.map-info > li > .map-title > i {
    color: #ccc;
    margin-right: 5px;
    margin-left: -14px;
}

ul.map-info:last-child,
ul.map-info > li:last-child {
    margin-bottom: 0;
    padding-bottom: 0;
}

ul.map-info ul li span {
    margin-bottom: 10px;
}

ul.map-info .map-img {
    border-radius: 4px;
    overflow: hidden;
}

ul.map-info .map-img img {
    width: 100%;
    height: auto;
}

ul.map-info #map_source,
ul.map-info #map_target {
    padding-bottom: 56.26%;
}

.review-score .review-badge {
    font-size: 2.4rem;
    color: #fff;
    background: linear-gradient(45deg, #64b3f4, #26bec9 50%);
    border-radius: 4px;
    padding: 8px 10px;
    float: left;
    margin-right: 15px;
    font-family: Arial Rounded MT Bold, Arial Rounded MT, sans-serif;
}

.review-score .product-star {
    overflow: hidden;
}

.review-score .product-star .star {
    width: 25px;
    height: 25px;
    margin-right: 2.5px;
}

.review-score .product-star .review-num {
    color: #666;
    font-size: 1.4rem;
    margin: 5px 0 0 4px;
}

.review-list-header {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
    border-bottom: 2px solid #eee;
    margin: 15px 0;
    padding-bottom: 10px;
}

.review-filter > .checkbox,
.review-filter > .dropdown {
    display: inline-block;
    margin-right: 20px;
}

.review-filter > .dropdown > button {
    padding: 8px 40px 8px 10px;
    min-height: auto;
}

.review-filter > .dropdown > button.active {
    border-color: #26bec9;
    color: #26bec9;
    -webkit-box-shadow: 0 0 5px rgba(38, 190, 201, 0.2);
    box-shadow: 0 0 5px rgba(38, 190, 201, 0.2);
}

.review-filter .dropdown-menu .checkbox-title {
    color: #333;
}

.review-list-header .sorting {
    margin: 0;
}

.review-list-header .sorting .btn-default {
    border: none;
    padding: 0;
}

.review-list-header .sorting .btn-default:focus,
.review-list-header .sorting .btn-default:hover {
    background-color: transparent;
}

.review-result {
    color: #666;
    margin-bottom: 20px;
}

.review-item {
    padding: 10px 0;
    font-size: 1.4rem;
    position: relative;
}

.review-item > .editor {
    float: left;
    text-align: center;
    margin-right: 20px;
}

.editor-logo {
    width: 50px;
    height: 50px;
    border-radius: 50%;
    border: 1px solid #eee;
    text-align: center;
    background-color: #eaeaea;
    background-size: cover;
    background-position: 50%;
}

.editor-logo.king {
    border: 2px solid #ffb400;
    position: relative;
}

.editor-logo.king > img {
    width: 28px;
    position: absolute;
    top: -14px;
    left: -7px;
}

.review-item > .editor .sub-title {
    font-size: 1.2rem;
    margin-top: 5px;
    font-weight: 700;
}

.board .review-item > .editor .sub-title:before {
    display: none;
}

.board .review-item .review-detail.fake .mask-4 {
    height: 40px;
}

.review-item .review-detail {
    overflow: hidden;
}

.review-item .product-star .star {
    width: 18px;
    height: 18px;
    margin-top: 0;
}

.review-item .review-info {
    font-size: 1.3rem;
    line-height: 1.2;
    color: #666;
}

.review-item .review-info .review-info-item {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    margin-bottom: 8px;
}

.review-item .review-info .review-info-item > * {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
    margin-right: 4px;
}

.review-item .review-info .review-info-item > :last-child {
    margin-right: 0;
}

.review-item .review-info .review-info-item:last-child {
    margin-bottom: 0;
}

.review-item .review-info .member-name {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
    -webkit-box-flex: 0;
    -ms-flex: 0 1 auto;
    flex: 0 1 auto;
    font-size: 1.5rem;
}

.review-item .product-star .review-info {
    color: #777;
    font-size: 1.3rem;
    margin: 0 5px;
    vertical-align: text-bottom;
}

.review-item .product-star .review-info .gap {
    margin: 0;
}

.review-item .product-star .review-info .label {
    margin-left: 5px;
    font-weight: 400;
}

.review-item .review-content {
    background-color: #f6f6f6;
    border-radius: 6px;
    padding: 15px;
    margin-top: 15px;
    position: relative;
}

.review-item .review-detail .txt {
    margin-bottom: 10px;
}

.review-item .review-content .txt > h4 {
    margin-top: 0;
    margin-bottom: 5px;
    word-break: break-word;
}

.review-item .review-detail .txt p {
    margin-bottom: 5px;
    max-height: 48px;
    display: -webkit-box;
    -webkit-line-clamp: 2;
    -webkit-box-orient: vertical;
    overflow: hidden;
    word-break: break-word;
}

.review-item .review-detail .txt.expand p {
    max-height: none;
    display: block;
    overflow: visible;
}

.review-item .review-detail .txt .readmore {
    -webkit-transition: none;
    transition: none;
}

.review-item .photo-item {
    width: 80px;
    height: 60px;
    opacity: 0.8;
    -webkit-filter: grayscale(0.1);
    filter: grayscale(0.1);
}

.review-item .photo-item:hover {
    opacity: 1;
    -webkit-filter: grayscale(0);
    filter: grayscale(0);
}

.review-item .review-content .review-info {
    margin-top: 15px;
}

.review-item .logo-google {
    width: 100px;
    margin-top: -15px;
}

.review-reply {
    position: relative;
    margin-top: 20px;
    margin-bottom: 15px;
}

.review-reply:before {
    content: '';
    display: inline-block;
    width: 5px;
    height: 100%;
    position: absolute;
    left: 0;
    background-color: #ddd;
    border-radius: 4px;
}

.review-reply .detail-toggle {
    font-weight: 700;
    color: #333;
}

.review-reply .option-detail {
    color: #666;
    font-size: 1.3rem;
    width: auto;
    margin-top: 5px;
}

.review-footer {
    margin: 10px 0;
    text-align: right;
}

.review-item .review-detail hr {
    border-color: #e6e6e6;
    width: 100%;
    margin: 30px 0 10px;
}

.review-item .review-detail .review-footer + hr {
    margin: 10px 0;
}

.review-detail.fake {
    height: 140px;
    margin-top: 5px;
    margin-bottom: 20px;
}

.review-detail.fake .mask-1 {
    width: 100%;
    height: 10px;
    top: 20px;
    left: 0;
}

.review-detail.fake .mask-2 {
    width: 100%;
    height: 20px;
    top: 45px;
    left: 0;
}

.review-detail.fake .mask-3 {
    width: 100%;
    height: 5px;
    top: 80px;
    left: 0;
}

.review-detail.fake .mask-4 {
    width: 100%;
    height: 39px;
    top: 100px;
    left: 0;
}

.review-detail.fake .mask-5 {
    width: 80%;
    height: 25px;
    top: 0;
    right: 0;
}

.review-detail.fake .mask-6 {
    width: 90%;
    height: 15px;
    top: 30px;
    right: 0;
}

.review-detail.fake .mask-7 {
    width: 30%;
    height: 15px;
    top: 65px;
    right: 0;
}

.review-detail.fake .mask-8 {
    width: 60%;
    height: 15px;
    top: 85px;
    right: 0;
}

.scroll-top-wrapper {
    position: fixed;
    opacity: 0;
    visibility: hidden;
    overflow: hidden;
    text-align: center;
    z-index: 1001;
    background-color: rgba(0, 0, 0, 0.4);
    color: #fff;
    width: 4rem;
    height: 4rem;
    line-height: 4rem;
    right: 1.5rem;
    bottom: 50px;
    padding-top: 2px;
    border-radius: 2px;
    border: none;
    -webkit-box-shadow: 0 0 4px 0 rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 4px 0 rgba(0, 0, 0, 0.1);
    -webkit-transition: all 0.25s ease-in-out;
    transition: all 0.25s ease-in-out;
}

.scroll-top-wrapper i.fa {
    line-height: 1;
    top: -2px;
}

.scroll-top-wrapper.show:hover {
    opacity: 1;
}

.scroll-top-wrapper.show {
    visibility: visible;
    cursor: pointer;
    opacity: 0.8;
}

.section-head {
    margin-bottom: 15px;
}

.section-head h2 {
    font-size: 2.4rem;
    line-height: 1.5;
    margin: 0;
}

.section-head h4 {
    color: #666;
    font-weight: 400;
    margin: 0;
    font-size: 1.4rem;
}

.tip {
    font-size: 1.3rem;
    color: #999;
    margin-top: 4px;
}

.tip.verify-success {
    color: #26bec9;
}

.tip.verify-failed {
    color: #e65f50;
}

.tip span {
    margin: 0 5px;
}

.tip i {
    margin-right: 5px;
}

.has-error .tip {
    color: #e65f50;
}

.tooltip-inner {
    background: rgba(51, 51, 51, 0.8);
    padding: 8px;
    -webkit-box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
}

.tooltip.top .tooltip-arrow {
    border-top-color: rgba(51, 51, 51, 0.8) !important;
}

.tooltip.left .tooltip-arrow {
    border-left-color: rgba(51, 51, 51, 0.8);
}

.tooltip.bottom .tooltip-arrow {
    border-bottom-color: rgba(51, 51, 51, 0.8);
    top: 0;
}

.tooltip.right .tooltip-arrow {
    border-right-color: rgba(51, 51, 51, 0.8);
}

.popover {
    background-color: rgba(51, 51, 51, 0.8);
    border: 0;
    color: #fff;
}

.popover.left > .arrow:after {
    border-left-color: rgba(51, 51, 51, 0.8);
}

.popover-content {
    font-size: 1.4rem !important;
}

.popover.bottom > .arrow {
    border-bottom-color: rgba(51, 51, 51, 0.8);
}

.popover.bottom > .arrow:after {
    display: none;
}

.popover.bottom.bg-danger > .arrow {
    border-bottom-color: #ef7a70;
}

.select2-container .select2-selection--single {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.select2-container--default
    .select2-selection--single
    .select2-selection__rendered {
    padding: 0;
    line-height: inherit;
}

.select2-container--default
    .select2-selection--single
    .select2-selection__arrow
    b {
    display: none;
}

.select2-dropdown {
    border: 0;
    padding-bottom: 10px;
    -webkit-transition: none;
    transition: none;
}

.select2-search--dropdown {
    border-bottom: 1px solid #eee;
    padding: 10px;
    margin: 0 0 10px;
}

.select2-container--default .select2-search--dropdown .select2-search__field {
    height: 30px;
    padding: 10px;
}

.select2-results__options {
    -ms-scroll-chaining: none;
    overscroll-behavior: contain;
}

.select2-container--default .select2-results__option[aria-selected='true'] {
    background-color: transparent;
}

.select2-container--default
    .select2-results__option--highlighted[aria-selected] {
    background: transparent;
    color: #333;
    background-color: #f4f4f4;
}

.btn-wish {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    position: absolute;
    top: 0;
    right: 0;
    padding: 15px;
    color: #ccc;
    font-size: 1.8rem;
    text-align: center;
    cursor: pointer;
}

.btn-wish i.fa {
    margin-right: -1px;
}

.btn-wish:hover i {
    color: #666;
}

.btn-wish:hover i.fa-heart {
    opacity: 0.6;
}

.btn-trash {
    cursor: pointer;
}

.popup {
    -webkit-animation-duration: 0.6s;
    animation-duration: 0.6s;
    -webkit-animation-iteration-count: 1;
    animation-iteration-count: 1;
    -webkit-animation-name: popup;
    animation-name: popup;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
}

.ani-heart-red {
    display: inline-block;
    width: 17px;
    height: 17px;
    background-repeat: no-repeat;
    background-position: 0 0;
    -webkit-animation: heartbroken 1s steps(20);
    animation: heartbroken 1s steps(20);
    vertical-align: middle;
    background-size: auto 17px;
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/ani_heartbroken_red.png);
}

.btn-wish .ani-heart-red {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
}

@-webkit-keyframes heartbroken {
    0% {
        background-position: 0 0;
    }

    to {
        background-position: -340px 0;
    }
}

@keyframes heartbroken {
    0% {
        background-position: 0 0;
    }

    to {
        background-position: -340px 0;
    }
}

@-webkit-keyframes popup {
    0% {
        -webkit-transform: scale(1);
        transform: scale(1);
    }

    25% {
        -webkit-transform: scale(1.1);
        transform: scale(1.1);
    }

    50% {
        -webkit-transform: scale(1);
        transform: scale(1);
    }

    75% {
        -webkit-transform: scale(1.07);
        transform: scale(1.07);
    }

    to {
        -webkit-transform: scale(1);
        transform: scale(1);
    }
}

@keyframes popup {
    0% {
        -webkit-transform: scale(1);
        transform: scale(1);
    }

    25% {
        -webkit-transform: scale(1.1);
        transform: scale(1.1);
    }

    50% {
        -webkit-transform: scale(1);
        transform: scale(1);
    }

    75% {
        -webkit-transform: scale(1.07);
        transform: scale(1.07);
    }

    to {
        -webkit-transform: scale(1);
        transform: scale(1);
    }
}

.dropdown-menu-col {
    padding: 10px;
}

.dropdown-menu-col[data-col='3'] {
    -webkit-column-count: 3;
    -moz-column-count: 3;
    column-count: 3;
}

.dropdown-menu-col[data-col='2'] {
    -webkit-column-count: 2;
    -moz-column-count: 2;
    column-count: 2;
}

.dropdown-menu-col > li {
    -webkit-column-break-inside: avoid;
    -moz-column-break-inside: avoid;
    break-inside: avoid-column;
}

.dropdown-menu-col > li > a {
    border-radius: 4px;
}

.menu-fake {
    width: 250px;
    height: 20px;
    max-width: 90%;
    border-radius: 2px;
    margin-right: 20px;
}

.fake-circle {
    border-radius: 50%;
    min-width: 42px;
    height: 42px;
    border: 1px solid #eaeaea;
}

.kksearch input {
    background: #fff;
    height: 42px;
}

.kksearch .input-group-btn .btn {
    height: 42px;
    font-size: 1.4rem;
    left: 1px;
}

.kksearch .input-group-btn .btn i {
    top: -2px;
    position: relative;
    color: #fff;
}

.kksearch .clear-input {
    top: 0;
    right: 35px;
    z-index: 100;
}

.kksearch .dropdown-arrow {
    top: 0;
    opacity: 1;
}

.home-section {
    padding: 20px 0;
    overflow-x: hidden;
}

.city-item {
    background-size: cover;
    background-repeat: no-repeat;
    background-position: 50%;
    width: 100%;
    height: 274px;
    position: relative;
}

.city-item .overlap {
    background: -webkit-gradient(
        linear,
        left top,
        left bottom,
        color-stop(60%, transparent),
        to(rgba(0, 0, 0, 0.85))
    );
    background: linear-gradient(transparent 60%, rgba(0, 0, 0, 0.85));
}

.city-item .caption {
    position: absolute;
    bottom: 0;
    left: 0;
    width: 100%;
    padding: 10px 15px;
    color: #fff;
}

.city-item .caption .city-head {
    padding-right: 35px;
}

.city-item .caption .weather {
    opacity: 0.9;
    font-size: 35px;
    height: 35px;
    position: absolute;
    right: 15px;
    bottom: 20px;
}

.city-item .caption h5 {
    margin: 0;
    font-size: 2rem;
    line-height: 1.2;
    font-weight: bolder;
    text-shadow: 0 1px 3px rgba(0, 0, 0, 0.2);
}

.home-section .city-item {
    margin-bottom: 20px;
}

.home-carousel.row,
.row-dense {
    margin-right: -7.5px;
    margin-left: -7.5px;
}

.home-section [class*='col-'],
.row-dense [class*='col-'] {
    padding-right: 7.5px;
    padding-left: 7.5px;
}

.guide-wrap .product-item,
.guide-wrap .product-listview,
.home-section .product-item {
    border: 1px solid #eaeaea;
    margin-bottom: 20px;
}

.city-banner {
    height: auto;
    position: relative;
}

.city-banner-img {
    height: 300px;
    background-size: cover;
    background-position: 100%;
    background-repeat: no-repeat;
    position: relative;
}

.city-banner .overlap {
    display: block;
    position: relative;
}

.city-banner .container {
    position: relative;
}

.city-banner-img .overlap {
    background: linear-gradient(hsla(0, 0%, 98%, 0) 70%, #f5f5f5),
        linear-gradient(45deg, rgba(15, 15, 15, 0.8), rgba(15, 15, 15, 0.2) 60%);
}

.city-banner h2 {
    margin-top: 10px;
}

.city-banner .page-title,
.city-banner h1,
.city-banner h3 {
    color: #fff;
    margin: 2px 0;
    line-height: 1.4;
}

.city-banner .page-title,
.city-banner h1 {
    font-size: 2.8rem;
    color: #fff;
    display: inline-block;
    margin: 0;
    text-shadow: 1px 2px 5px rgba(0, 0, 0, 0.2);
}

.city-banner-img .page-title,
.city-banner-img h1 {
    font-size: 4rem;
    font-weight: 700;
}

.city-banner h1 i {
    margin-left: 10px;
}

.city-banner h3 a {
    color: #fff;
    font-size: 1.6rem;
    font-weight: 400;
    text-shadow: 1px 2px 3px rgba(0, 0, 0, 0.2);
}

.city-banner .dropdown {
    display: inline-block;
}

.city-banner .dropdown.open .dropdown-toggle {
    -webkit-box-shadow: none;
    box-shadow: none;
}

.city-banner .weather {
    color: #fff;
    text-shadow: 1px 2px 5px rgba(0, 0, 0, 0.2);
    position: absolute;
    right: 20px;
    top: 50%;
    -webkit-transform: translateY(-50%);
    transform: translateY(-50%);
}

.city-banner .weather img {
    height: 80px;
    pointer-events: none;
}

.city-banner .weather span {
    font-size: 2rem;
    margin-right: 10px;
}

.product-content {
    margin-top: 25px;
}

.city-banner + .product-content {
    margin-top: 0;
}

.btn-datepicker {
    margin-bottom: 15px;
    position: relative;
}

.btn-datepicker .form-control,
.btn-datepicker .input-group-addon {
    background: #fff;
    border: 0;
}

.btn-datepicker .input-group-addon {
    border-right: 1px solid #eaeaea;
}

.btn-datepicker .input-group {
    display: block;
}

.btn-datepicker .input-group .input-group-addon {
    position: absolute;
    top: 0;
    left: 0;
    z-index: 5;
    width: auto;
    height: 100%;
    color: #333;
    line-height: 25px;
    pointer-events: none;
}

.btn-datepicker .input-group .form-control {
    float: none;
    padding-left: 40px;
    border-radius: 4px !important;
    text-align: center;
    font-weight: 700;
    color: #333;
}

.btn-datepicker .input-group .form-control::-moz-placeholder {
    color: #333;
}

.btn-datepicker .input-group .form-control:-ms-input-placeholder {
    color: #333;
}

.btn-datepicker .input-group .form-control::-webkit-input-placeholder {
    color: #333;
}

.filter-box {
    padding: 5px 20px;
    border: 0;
    background-color: #fff;
    border-radius: 6px;
    margin-bottom: 15px;
}

.filter-box h4 {
    margin: 10px 0;
}

.filter-box h4.collapsable {
    cursor: pointer;
}

.filter-box h4 i,
.theme-board h4 i {
    margin-top: 5px;
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg);
    -webkit-transition: 0.2s;
    transition: 0.2s;
    color: #999;
}

.filter-box h4.collapsed i,
.theme-board h4.collapsed i {
    -webkit-transform: rotate(180deg);
    transform: rotate(180deg);
}

.filter-box h4:hover i,
.theme-board h4:hover i {
    color: #333;
}

.filter-box .form-control {
    margin-bottom: 10px;
}

.filter-box ul {
    list-style: none;
    padding: 0;
    margin: 0;
}

.filter-box ul li a {
    padding: 10px 20px 10px 0;
    display: block;
    white-space: normal;
}

.irs {
    margin-bottom: 30px;
}

.irs-line {
    background: #eee;
    border-color: #eaeaea;
    top: 46px;
    height: 6px;
}

.irs-bar {
    background: linear-gradient(45deg, #64b3f4, #26bec9 50%);
}

.irs-bar,
.irs-bar-edge {
    border: 0;
    top: 46px;
    height: 6px;
}

.irs-bar-edge {
    background: #64b3f4;
}

.irs-slider {
    background: #fff;
    border: 1px solid #ccc;
    -webkit-box-shadow: 0 2px 3px rgba(0, 0, 0, 0.15);
    box-shadow: 0 2px 3px rgba(0, 0, 0, 0.15);
    top: 37px;
    z-index: 0;
    width: 24px;
    height: 24px;
}

.irs-slider.type_last {
    z-index: 0;
}

.irs-from,
.irs-to {
    display: none !important;
}

.irs-single {
    position: static;
    visibility: visible !important;
    background: transparent;
    margin-bottom: 15px;
    padding: 0;
    color: #666;
    font-size: 1.6rem;
    display: block;
}

.filter-box ul.filter-list > li {
    margin: 0;
    padding: 10px 0;
    display: block;
    cursor: pointer;
}

.filter-box ul.filter-list > li i {
    color: #999;
    width: 20px;
}

.filter-box ul.filter-list .checked i,
.filter-box ul.filter-list > li:hover i {
    color: #26bec9;
}

.filter-box span.checkbox-title {
    color: #666;
}

.theme-board {
    padding-top: 5px;
    padding-bottom: 5px;
}

.theme-board h4 i {
    margin-right: 3px;
}

.theme-board .collapse {
    padding-bottom: 15px;
}

.product-result.result-board {
    border-top-left-radius: 3px;
    border-top-right-radius: 3px;
    border-bottom-right-radius: 0;
    border-bottom-left-radius: 0;
}

.product-result.sort-board {
    border-top-left-radius: 0;
    border-top-right-radius: 0;
    border-bottom-right-radius: 3px;
    border-bottom-left-radius: 3px;
    border-top: 1px solid #f4f4f4;
}

.product-result {
    margin-bottom: 30px;
    padding: 15px 20px;
    background-color: #fff;
    border-radius: 6px;
}

.product-result h4 {
    margin: 4px 0;
    color: #333;
    font-weight: 400;
    display: inline-block;
}

.city-banner + .product-content .product-result {
    margin-bottom: 20px;
}

.sort a {
    color: #666;
    font-weight: 700;
}

.sort a.sort-selected,
.sort a:focus,
.sort a:hover {
    color: #26bec9;
    font-weight: 700;
}

.product-result .sorting {
    margin: 0;
}

.product-result h4 span {
    font-size: 1.8rem;
    font-weight: 700;
    margin-right: 4px;
}

.product-result .chip {
    position: relative;
}

.product-result .chip a {
    color: #666;
    cursor: default;
    padding-right: 25px;
    border-color: #999;
}

.product-result .chip a:focus,
.product-result .chip a:hover {
    border-color: #666;
    background: transparent;
}

.product-result .chip .delete-chip {
    position: absolute;
    right: 10px;
    top: 1px;
    color: #999;
    cursor: pointer;
    font-style: normal;
    line-height: 24px;
}

.product-result .chip .delete-chip:focus,
.product-result .chip .delete-chip:hover {
    color: #666;
    background: transparent;
}

.product-result .chip.clearall a {
    background: #999;
    color: #fff;
    cursor: pointer;
    padding-right: 12px;
}

.product-result .chip.clearall a:focus,
.product-result .chip.clearall a:hover {
    background: #666;
}

.product-list {
    overflow-x: hidden;
}

.product-listview {
    background-color: #fff;
    -webkit-box-shadow: none;
    box-shadow: none;
    margin-bottom: 15px;
    position: relative;
    border-radius: 6px;
    -webkit-transition: 0.25s;
    transition: 0.25s;
}

.product-listview .product-soldout {
    position: absolute;
    right: 15px;
    bottom: 2px;
    color: #666;
    text-align: right;
}

.product-listview .product-soldout h4 {
    line-height: 1.2;
    margin: 0;
}

.product-listview .product-soldout .hint {
    font-size: 1rem;
}

.product-listview:hover {
    opacity: 0.8;
}

.product-listview .img-bg {
    height: 205px;
    margin-right: -10px;
    border-radius: 6px 0 0 6px;
}

.product-listview.search-info .img-bg {
    height: 255px;
}

.product-listview .product-detail {
    position: relative;
    min-height: 170px;
}

.product-listview .product-detail > h3 {
    height: auto;
    padding-right: 40px;
    margin: 0 0 8px;
    font-weight: 700;
    font-size: 1.6rem;
    color: #333;
}

.product-listview h4 .fa-flash {
    margin-right: 5px;
    text-align: center;
}

.product-listview .product-pricing {
    right: 15px;
    bottom: 2px;
}

.product-listview .product-pricing h4 {
    font-size: 1.8rem;
    line-height: 1.2;
}

.product-listview .product-pricing span {
    font-size: 1.4rem;
}

.product-listview .product-hint:after,
.product-listview:hover .product-hint:after {
    left: 12px;
}

.product-listview img {
    width: 100%;
}

.product-time-icon img {
    width: 13px;
    margin: 0 0 2px 4px;
}

.theme-wrap {
    background-color: #fff;
}

.theme-wrap .cut-bread {
    padding-top: 20px;
}

.theme-wrap section {
    padding: 50px 0;
    overflow-x: hidden;
}

.theme-wrap section:nth-child(2n) {
    background: #f5f5f5;
}

.theme-wrap .city-banner:not(.city-banner-img) {
    background: linear-gradient(45deg, #64b3f4, #26bec9 50%);
    height: 150px;
}

.theme-wrap .city-banner .overlap {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    position: absolute;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    padding: 0;
}

.theme-wrap .city-banner-img .overlap {
    background: linear-gradient(
        45deg,
        rgba(15, 15, 15, 0.8),
        rgba(15, 15, 15, 0.25) 60%
    );
}

.theme-wrap section.city-intro {
    padding-top: 0;
    padding-bottom: 15px;
    background-color: #fff;
    border-bottom: 10px solid #f5f5f5;
    overflow: visible;
}

.theme-wrap section.city-intro h1 {
    font-size: 2.8rem;
}

.theme-wrap section.city-intro .product-abstract {
    margin-bottom: 40px;
}

.theme-wrap section.city-intro .product-abstract p {
    display: -webkit-box;
    -webkit-line-clamp: 4;
    -webkit-box-orient: vertical;
    overflow: hidden;
    max-height: 91px;
    margin-bottom: 5px;
}

.theme-wrap section.city-intro .product-abstract.expand p {
    max-height: none;
    display: block;
    overflow: visible;
}

.theme-wrap #product-scroll-spy:not(.active) {
    display: block;
    position: static;
    border: 0;
    overflow: visible;
}

.theme-wrap #product-scroll-spy:not(.active) .page-tab {
    overflow: visible;
    white-space: normal;
}

.theme-wrap #product-scroll-spy:not(.active) .page-tab > li {
    margin-right: 10px;
    margin-bottom: 10px;
    border: 0;
}

.theme-wrap #product-scroll-spy:not(.active) .page-tab > li > a {
    padding: 10px 16px;
    -webkit-box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    border-radius: 4px;
    background-color: #fff;
}

.theme-wrap #product-scroll-spy:not(.active) .page-tab > li > a:hover {
    color: #138184;
}

.theme-wrap #page-scroll-spy:not(.active) {
    display: block;
    position: static;
    border: 0;
    overflow: visible;
}

.theme-wrap #page-scroll-spy:not(.active) .page-tab {
    overflow: visible;
    white-space: normal;
}

.theme-wrap #page-scroll-spy:not(.active) .page-tab > li {
    margin-right: 10px;
    margin-bottom: 10px;
    border: 0;
}

.theme-wrap #page-scroll-spy:not(.active) .page-tab > li > a {
    padding: 10px 16px;
    -webkit-box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    border-radius: 4px;
    background-color: #fff;
}

.theme-wrap #page-scroll-spy:not(.active) .page-tab > li > a:hover {
    color: #138184;
}

.theme-wrap .title {
    font-size: 2.6rem;
    text-align: center;
    margin: 0 0 20px;
}

.theme-wrap .city-item {
    width: 100%;
    height: auto;
    margin-bottom: 30px;
    padding: 10% 20px 20px;
    opacity: 1;
}

.theme-wrap .city-item .overlap {
    background: -webkit-gradient(
        linear,
        left top,
        left bottom,
        color-stop(40%, transparent),
        to(rgba(0, 0, 0, 0.85))
    );
    background: linear-gradient(transparent 40%, rgba(0, 0, 0, 0.85));
}

.theme-wrap .city-item .caption {
    position: relative;
    z-index: 2;
    padding: 0;
    width: 66.66%;
    text-shadow: 0 0 5px rgba(0, 0, 0, 0.2);
}

.theme-wrap .city-item .caption h2 {
    font-size: 2.6rem;
}

.theme-wrap .city-item .caption p {
    margin-bottom: 0;
}

.theme-wrap .product-item {
    margin-bottom: 20px;
}

.guide-item .product-img {
    height: 0;
    padding-bottom: 66.67%;
    border-radius: 6px;
    position: relative;
    overflow: hidden;
    background-color: #f4f4f4;
}

.guide-item .product-img .img-bg {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    -webkit-transition: 0.3s;
    transition: 0.3s;
}

.guide-item:hover .product-img .img-bg {
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
}

.guide-item .product-detail {
    padding: 8px 0 0;
}

.guide-item .product-img .play-icon {
    width: 60px;
}

.guide-item .product-detail > h3 {
    color: #333;
    margin-top: 0;
    margin-bottom: 0;
}

.guide-carousel {
    position: relative;
}

.theme-wrap .card {
    -webkit-box-shadow: 0 0 4px rgba(0, 0, 0, 0.15);
    box-shadow: 0 0 4px rgba(0, 0, 0, 0.15);
}

.product-theme-item {
    height: 300px;
    margin-bottom: 30px;
}

.product-theme-item:hover {
    -webkit-box-shadow: 0 0 15px 2px rgba(0, 0, 0, 0.15);
    box-shadow: 0 0 15px 2px rgba(0, 0, 0, 0.15);
    opacity: 1;
}

.product-theme-item .product-book,
.product-theme-item .product-footer,
.product-theme-item .product-img {
    -webkit-transition: 0.3s;
    transition: 0.3s;
}

.product-theme-item .product-img {
    height: 185px;
}

.product-theme-item:hover .product-img {
    height: 130px;
}

.product-theme-item .product-hint {
    top: 115px;
}

.product-theme-item .product-detail > h3 {
    font-weight: 700;
    margin-top: 0;
}

.product-theme-item .product-detail .description {
    height: 43px;
}

.prdouct-theme-item .product-book,
.prdouct-theme-item .product-footer {
    opacity: 0;
}

.prdouct-theme-item:hover .product-book,
.prdouct-theme-item:hover .product-footer {
    opacity: 1;
}

.theme-cta .city-item {
    height: auto;
    margin-bottom: 0;
    padding: 60px 30px;
    color: #fff;
    -webkit-box-shadow: 0 5px 20px rgba(0, 0, 0, 0.15);
    box-shadow: 0 5px 20px rgba(0, 0, 0, 0.15);
}

.theme-cta .city-item:hover {
    -webkit-box-shadow: 0 5px 30px 3px rgba(0, 0, 0, 0.25);
    box-shadow: 0 5px 30px 3px rgba(0, 0, 0, 0.25);
}

.theme-cta .city-item .overlap {
    background-color: #333;
    opacity: 0.4;
    z-index: 0;
}

.theme-cta .city-item h4 {
    -webkit-box-flex: 1;
    -ms-flex-positive: 1;
    flex-grow: 1;
    font-size: 2rem;
    text-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
    position: relative;
}

.guide-wrap .guide-banner {
    width: 100%;
    height: 50vh;
    min-height: 300px;
    position: relative;
}

.guide-wrap .guide-banner.is-video {
    height: 70vh;
    background-color: #000;
    -webkit-box-shadow: 0 0 4px rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 4px rgba(0, 0, 0, 0.1);
}

.guide-wrap .guide-banner.is-video .embed-responsive {
    height: 100%;
}

.guide-wrap .guide-banner.is-video .overlap {
    cursor: pointer;
    background: rgba(0, 0, 0, 0.15);
}

.guide-wrap .title {
    font-size: 2.8rem;
    margin-bottom: 50px;
    position: relative;
}

.guide-wrap .title:before {
    content: '';
    display: inline-block;
    background: #26bec9;
    width: 60px;
    height: 4px;
    border-radius: 4px;
    position: absolute;
    top: calc(100% + 10px);
    left: 0;
}

.guide-wrap .guide-content {
    padding: 20px 0;
}

.guide-wrap .guide-content .embed-responsive {
    -webkit-box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    margin: 20px 0;
}

.guide-wrap .guide-content hr {
    border-color: #eee;
}

.guide-wrap .guide-recommend {
    padding: 10px 0 30px;
}

.guide-wrap .guide-content p,
.guide-wrap .guide-content ul {
    font-size: 1.6rem;
}

.guide-wrap .guide-content img {
    display: block;
    max-width: 100%;
    margin-bottom: 20px;
}

.guide-wrap .guide-content p > span {
    font-size: 2.4rem !important;
    font-weight: 700;
}

.guide-wrap .guide-content p > img + span,
.guide-wrap .guide-content p > img + span + a {
    position: relative;
    top: -20px;
    color: #999 !important;
    font-size: 1.3rem !important;
}

.guide-wrap .guide-content p > span > strong {
    font-size: 1.8rem;
}

.guide-wrap .guide-content a span {
    color: #26bec9 !important;
    font-size: 1.6rem;
}

.guide-wrap .guide-content a:hover span {
    text-decoration: underline;
}

.product-action {
    white-space: nowrap;
}

.product-action > li {
    display: inline-block;
}

.product-action > li > .btn-trash,
.product-action > li > .btn-wish {
    padding: 10px;
    font-size: 2.4rem;
    color: #666;
}

.product-action > li .btn-wish {
    position: static;
    min-width: 44.5px;
    min-height: 44px;
}

.product-action > li .btn-wish .ani-heart-red {
    -webkit-transform: scale(1.8);
    transform: scale(1.8);
}

.product-action > li .btn-trash {
    padding: 0 10px 3px;
}

.play-icon {
    width: 100px;
    position: absolute;
    top: 50%;
    left: 50%;
    -webkit-transform: translateX(-50%) translateY(-50%);
    transform: translateX(-50%) translateY(-50%);
    pointer-events: none;
}

.modal-lightbox.fade .modal-dialog {
    -webkit-transform: none;
    transform: none;
}

.modal-lightbox .modal-content {
    background-color: rgba(0, 0, 0, 0.85) !important;
}

.modal-lightbox .item .photo-by,
.modal-lightbox .modal-header,
.modal-lightbox .owl-theme .owl-dots,
.modal-lightbox .owl-theme .owl-nav [class*='owl-'] {
    -webkit-transition: 0.3s;
    transition: 0.3s;
}

.modal-lightbox:not(.pageActive) .item .photo-by,
.modal-lightbox:not(.pageActive) .modal-header,
.modal-lightbox:not(.pageActive) .owl-theme .owl-dots,
.modal-lightbox:not(.pageActive) .owl-theme .owl-nav [class*='owl-'] {
    opacity: 0;
}

.modal-lightbox .modal-header {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    padding: 20px 20px 0;
    z-index: 100;
}

.modal-lightbox .editor-logo {
    width: 40px;
    height: 40px;
}

.modal-lightbox .close {
    color: #fff;
    font-size: 3.6rem;
    font-weight: 400;
    position: static;
    float: right;
}

.modal-lightbox .modal-body {
    padding: 0;
    position: static;
}

.modal-lightbox .owl-theme .owl-dots .owl-dot span {
    background: #fff;
    opacity: 0.3;
}

.modal-lightbox .owl-theme .owl-dots .owl-dot.active span {
    background: #fff;
    opacity: 1;
}

.modal-lightbox .owl-carousel .owl-nav button[class*='owl-'] {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    position: absolute;
    top: 0;
    z-index: 99;
    width: 10vw;
    height: 100vh;
    min-width: 50px;
    -webkit-transform: none;
    transform: none;
    opacity: 0.4;
}

.modal-lightbox .owl-carousel .owl-nav button[class*='owl-']:hover {
    opacity: 1;
}

.modal-lightbox .owl-carousel .owl-nav .owl-prev {
    -webkit-box-pack: start;
    -ms-flex-pack: start;
    justify-content: flex-start;
    left: 0;
}

.modal-lightbox .owl-carousel .owl-nav .owl-next {
    -webkit-box-pack: end;
    -ms-flex-pack: end;
    justify-content: flex-end;
    right: 0;
}

.modal-lightbox .owl-carousel .owl-nav button[class*='owl-'] i {
    padding: 20px;
    color: #fff;
    font-size: 6rem;
    text-shadow: 0 2px 10px rgba(0, 0, 0, 0.5);
}

.modal-lightbox .owl-carousel .owl-dots {
    position: fixed;
    bottom: 0;
    left: 0;
    width: 100%;
    padding: 10px 0;
    background: -webkit-gradient(
        linear,
        left bottom,
        left top,
        from(rgba(0, 0, 0, 0.4)),
        to(transparent)
    );
    background: linear-gradient(0deg, rgba(0, 0, 0, 0.4), transparent);
}

.modal-lightbox .owl-carousel .item {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    width: 100vw;
    height: 100vh;
    margin: 0;
    background: transparent;
    border-radius: 0;
}

.modal-lightbox .owl-carousel .item img {
    display: block;
    width: auto;
    height: auto;
    max-height: 100%;
    max-width: 100%;
}

.modal-lightbox .owl-carousel .item .embed-responsive {
    width: 100%;
    height: 100%;
    max-height: 56.25vw;
}

.modal-lightbox .owl-carousel .item .embed-responsive iframe {
    padding: 50px 10vw;
}

.modal-lightbox .photo-by {
    position: absolute;
    bottom: 40px;
    left: 50%;
    -webkit-transform: translateX(-50%);
    transform: translateX(-50%);
    z-index: 100;
    color: #fff;
    text-shadow: 0 0 5px rgba(0, 0, 0, 0.5);
}

.modal-lightbox .loading {
    color: #fff;
    font-size: 3rem;
    opacity: 0.4;
}

.detail-toggle {
    color: #666;
    padding-left: 20px;
}

.detail-toggle i {
    display: inline-block;
    width: auto;
}

.detail-toggle.active i {
    -webkit-transform: rotate(180deg);
    transform: rotate(180deg);
}

.option-detail {
    display: none;
    margin-top: 10px;
    padding: 0 20px;
}

.option-detail ul {
    list-style-type: disc;
    padding-left: 20px;
}

.info-subtitle .product-star {
    margin-bottom: 30px;
    color: #666;
    line-height: 1;
}

.info-subtitle .product-star .star {
    width: 25px;
    height: 25px;
    margin-right: 2.5px;
}

.info-subtitle .product-star span {
    font-weight: 400;
}

ul.select-list {
    padding: 0;
    margin: 10px 0 0;
    list-style: none;
}

ul.select-list li {
    cursor: pointer;
    position: relative;
    display: inline-block;
    margin: 5px;
    padding: 5px 10px 5px 25px;
    color: #666;
    border: 1px solid #ccc;
    font-size: 1.2rem;
    border-radius: 5px;
    letter-spacing: 1px;
}

ul.select-list li i {
    position: absolute;
    top: 6px;
    left: 5px;
    font-size: 1.8rem;
    color: #999;
    margin: 0 !important;
}

[class*='order-'] .btn-danger {
    background-color: transparent;
    border: 1.5px solid rgba(239, 122, 112, 0.7);
    color: #ef7a70;
}

[class*='order-'] .btn-danger:active,
[class*='order-'] .btn-danger:active:focus,
[class*='order-'] .btn-danger:focus,
[class*='order-'] .btn-danger:hover {
    background-color: rgba(239, 122, 112, 0.1);
    color: #ef7a70;
    border: 1.5px solid rgba(239, 122, 112, 0.7);
}

ul.rating {
    font-size: 32px;
    display: inline-block;
    margin-left: -5px;
}

ul.rating li {
    float: left;
    color: #ccc;
    padding: 0 5px;
    cursor: pointer;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

ul.rating:hover li {
    color: #26bec0;
}

ul.rating li:hover ~ li {
    color: #ccc;
}

.coupon-listview {
    border-bottom: 1px solid #eaeaea;
    padding: 20px 10px;
}

.coupon-listview.disabled {
    color: #999;
}

.coupon {
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    background-color: #ffb400;
    text-align: center;
    color: #fff;
    font-family: Arial Rounded MT Bold, Arial Rounded MT, sans-serif;
    font-size: 1.6rem;
    line-height: 1;
    min-width: 90px;
    min-height: 45px;
    padding: 5px;
    margin: 0 5px 5px;
    position: relative;
    word-break: break-word;
    word-wrap: break-word;
}

.coupon__container {
    position: relative;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -ms-flex-wrap: wrap;
    flex-wrap: wrap;
}

.coupon__container--title {
    padding: 10px 15px 0;
}

.coupon__hint {
    width: -webkit-fit-content;
    width: -moz-fit-content;
    width: fit-content;
    padding: 10px 25px;
    border-radius: 20px;
    text-align: center;
    z-index: 100;
}

.coupon__hint--err-msg,
.coupon__hint--success {
    background-color: hsla(0, 0%, 40%, 0.95);
    color: #fff;
}

.coupon__hint--err-msg {
    position: absolute;
    left: 50%;
    -webkit-transform: translateX(-50%);
    transform: translateX(-50%);
    width: auto;
    top: 27px;
}

.coupon-listview .fake {
    margin-bottom: 5px;
}

.coupon-fake {
    width: 90px;
    height: 45px;
    border-radius: 2px;
}

.coupon:after,
.coupon:before {
    content: '';
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_coupon.svg);
    background-size: auto 105%;
    width: 5px;
    height: 100%;
    position: absolute;
    top: 0;
}

.coupon:before {
    left: -5px;
    background-position: 0;
}

.coupon:after {
    right: -5px;
    background-position: 100%;
}

.coupon span {
    display: inline-block;
    border: 1px solid hsla(0, 0%, 100%, 0.6);
    border-radius: 2px;
    height: 100%;
    width: 100%;
    padding: 8px 10px;
}

.coupon-code {
    font-weight: 700;
    margin-bottom: 5px;
    word-break: break-word;
    word-wrap: break-word;
}

.coupon-listview .flash-tag {
    font-weight: 400;
    border-radius: 2px;
    border-color: #ccc;
}

.coupon-listview.disabled .coupon {
    background-color: #ccc;
}

.coupon-listview.disabled .coupon:after,
.coupon-listview.disabled .coupon:before {
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_coupon_grey.svg);
}

.coupon-listview ul li {
    font-size: 1.3rem;
}

.btn-coupon {
    display: inline-block;
    margin-top: 10px;
}

div.union {
    background: #fff;
}

div.union ul {
    list-style-type: none;
}

div.union div.pageTitle.wrap {
    padding: 50px 0;
    color: #fff;
    background: #26bec9;
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_cities_green.png);
    background-position: 67% bottom;
    background-size: auto 100%;
    background-repeat: no-repeat;
}

div.union .container {
    margin-top: 0;
}

div.union .main-content,
div.union .main-menu {
    margin-top: 20px;
}

div.union .main-menu > ul {
    padding: 0;
}

div.union .main-menu ul li {
    cursor: pointer;
    font-size: 1.6rem;
    text-align: left;
    padding: 10px;
    background-color: #f6f6f5;
}

div.union .main-menu ul li:hover {
    background-color: #26bec9;
    color: #fff;
}

div.union .main-menu ul li .glyphicon {
    margin-right: 10px;
}

div.union .main-menu ul .active {
    background-color: #26bec9;
    color: #fff;
}

div.union .main-menu ul li.sub {
    padding: 0;
    background-color: #fff;
}

div.union .main-menu ul li.sub ul li {
    list-style-type: none;
    background-color: #fff;
    font-size: 1.4rem;
    padding: 5px;
}

div.union .main-menu ul li.sub ul li a {
    color: #666;
}

div.union .main-menu ul li.sub ul li:hover {
    font-weight: 400;
}

div.union .main-menu ul li.sub ul.active,
div.union .main-menu ul li.sub ul li:hover a {
    color: #26bec9;
}

div.union .mobile-menu {
    margin-top: 10px;
    display: none;
    cursor: pointer;
    font-size: 1.6rem;
    text-align: center;
    padding: 10px;
    width: 50px;
    background-color: #f6f6f5;
    margin-left: 15px;
}

div.union .mobile-menu:hover {
    background-color: #f6f6f5;
    color: #666;
}

div.union .main-content .nav-tabs li a {
    color: #999;
}

div.union .main-content .nav-tabs .active a {
    font-weight: 400;
    font-size: 1.4rem;
    color: #26bec9;
}

div.union .main-content .nav-content {
    border-left: 1px solid #ddd;
    border-right: 1px solid #ddd;
    border-bottom: 1px solid #ddd;
    margin: 0 0 30px;
    padding: 30px 15px;
}

div.union .main-content .adsense span,
div.union .main-content .nav-content label span {
    color: #ef7a70;
}

div.union .main-content .datepicker .next span,
div.union .main-content .datepicker .prev span {
    color: #333;
}

div.union .main-content .nav-content .form-group .radio {
    margin: 0 0 0 20px;
}

div.union .main-content .nav-content .form-group .radio label {
    line-height: 1.4;
}

div.union .main-content .nav-content .form-group .radio label input {
    display: block;
}

div.union .main-content .nav-content .table {
    font-size: 1.4rem;
}

div.union .main-content .nav-content label.radio-inline {
    line-height: 1.4;
}

div.union .main-content .adsense h2 {
    margin-top: 0;
}

div.union .main-content .adsense textarea {
    border: 1px solid #eee;
    background-color: #fafafa;
    border-radius: 4px;
    width: 100%;
}

div.union .main-content .adsense form .checkbox label {
    line-height: 1.4;
}

div.union .main-content .adsense form .checkbox label input {
    display: block;
}

div.union .main-content .adsense hr {
    margin-top: 10px;
}

div.union .form-control-feedback {
    margin-top: 18px;
    margin-right: 10px;
}

div.union .help-block {
    display: none;
}

#agreementBtn {
    width: 150px !important;
}

div.union .form-group .col-xs-11 select {
    margin-bottom: 10px;
}

div.union .form-group .col-xs-1 {
    padding: 0;
}

.errorMsg {
    float: right;
}

.dropdown-meun-white {
    min-width: 130px;
}

.dropdown-menu-white li > a {
    color: #000;
    cursor: pointer;
}

.cid-status-menu {
    color: #999;
    text-align: left;
    padding: 5px 20px;
    cursor: pointer;
}

.cid-status-menu.picked {
    color: #26bec9;
}

.cid-status-menu:hover {
    color: #333;
}

#cidApproved {
    color: #26bec9;
}

#cidRejected {
    color: #ef7a70;
}

#reject-reason {
    display: block;
    float: right;
    cursor: pointer;
    color: #ef7a70;
    text-decoration: underline;
}

#cid_reject_reason {
    background-color: #f4f4f4;
    line-height: 1.7;
    border-radius: 6px;
    margin: 10px 0;
    padding: 10px;
    overflow: auto;
}

.affiliate_form .form-horizontal .has-feedback .form-control-feedback {
    top: 0;
    right: 15px;
}

div.union #total_report p {
    color: #ef7a70;
}

#reportDetailModal {
    background-color: transparent;
}

#reportDetailModal .modal-dialog {
    width: calc(100% - 30px);
    margin: 15px;
}

#reportDetailModal .print {
    margin-bottom: 20px;
}

.table > thead > tr > th {
    vertical-align: middle;
}

div.union .report-result {
    margin-top: 40px;
    width: 100%;
    font-size: 1.6rem;
}

div.union .report-result td {
    border-top: 1px solid #eaeaea;
    vertical-align: top;
    padding: 10px;
}

div.union .report-result .product-pricing {
    white-space: nowrap;
}

#supplier .page {
    width: 100%;
    height: 634px;
    position: relative;
}

#supplier .go-down-btn {
    position: absolute;
    bottom: var(--kk-spacing-5);
    left: 50%;
    -webkit-transform: translate(-50%);
    transform: translate(-50%);
    height: 40px;
    width: 40px;
    border-radius: 50%;
    background-color: var(--kk-color-text-dark);
    opacity: 0.8;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

#supplier .sprite-img.go-down-white {
    background-position: -390px -384px;
}

#supplier .sprite-img.go-down-gray {
    background-position: -390px -190px;
}

#supplier .sprite-img.go-down-green {
    background-position: -391px -10px;
}

#supplier .page1 {
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_host.jpg);
    background-repeat: no-repeat;
    background-size: 100%;
}

#supplier .page1 .page1-slogan {
    line-height: 130px;
}

#supplier .page1 .page1-illustrated {
    margin-top: 20px;
}

#supplier .sprite-img {
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/sprite_marketing.png);
    background-repeat: no-repeat;
    background-size: 800px 1200px;
}

#supplier .sprite-img1 {
    width: 165px;
    height: 130px;
    margin: 0 auto;
    padding: 10px;
}

#supplier .sprite-img1.img1 {
    background-position: 10px -590px;
}

#supplier .sprite-img1.img2 {
    background-position: 10px -790px;
}

#supplier .sprite-img1.img3 {
    background-position: 10px -990px;
}

#supplier .page2 .page2-image {
    width: 40%;
    margin-top: 25px;
}

#supplier .page2 span {
    font-size: 2rem;
    font-weight: 400;
    color: #999;
}

#supplier .page3 .page3-image {
    width: 90%;
    margin-top: 25px;
}

#supplier .page3 h1 {
    margin-top: 45%;
}

#supplier .page6 h1 {
    font-size: 2.4rem;
    margin-top: 10px;
}

#supplier .page3 h3,
#supplier .page4 h3,
#supplier .page5 h3 {
    font-size: 2rem;
    color: #999;
    font-weight: 400;
}

#supplier .page4 .page4-image {
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_feature03.jpg);
    background-repeat: no-repeat;
    background-position: 100% 0;
    background-size: contain;
    height: 634px;
}

#supplier .page5 .page5-image {
    width: 80%;
}

#supplier .page6 {
    padding-top: 50px;
    padding-bottom: 30px;
}

#supplier .page6 h3 {
    font-size: 1.6rem;
    color: #999;
    font-weight: 400;
    margin-top: 5px;
    margin-bottom: 0;
}

#supplier .page7 {
    padding-top: 0;
    padding-bottom: 50px;
}

#supplier .page8 .container {
    padding-top: 50px;
}

#supplier .page8 {
    background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_cities_dark.jpg);
    background-size: cover;
    min-height: 250px;
}

#supplier .page8 .btn-lg {
    width: 70%;
}

.login-sns {
    text-align: center;
}

.login-sns button {
    -webkit-transition: 0.3s;
    transition: 0.3s;
    position: relative;
}

.login-sns button i {
    font-size: 2rem;
    border-right: 1px solid hsla(0, 0%, 100%, 0.25);
    position: absolute;
    width: 60px;
    left: 0;
    top: 0;
    height: 100%;
}

.login-sns button i:before {
    line-height: 46px;
}

.login-sns button i img {
    width: 20px;
    margin-top: -2px;
}

.login-sns button span {
    display: inline-block;
    width: 100%;
    text-align: center;
    white-space: nowrap;
}

.login-sns .btn-circle i {
    position: static;
    border: 0;
    width: auto;
}

.login-sns .btn-circle i:before {
    line-height: 42px;
}

.btn-circle {
    width: 60px;
    height: 60px;
    border: none;
    border-radius: 50%;
    text-align: center;
    margin: 3px;
    padding: 10px;
}

.login-kkday button.btn-primary {
    margin-bottom: 4px;
}

.login-kkday .title-gap {
    color: #999;
}

.login-kkday a {
    color: #666;
}

.login-kkday .policy-link {
    color: #26bec9;
}

.login-kkday a:focus,
.login-kkday a:hover {
    color: #333;
    text-decoration: underline;
}

.login-kkday .errMsg {
    color: #e65f50;
    max-width: none;
    margin-top: 5px;
}

.login-kkday #errorMessage {
    margin: 10px 0;
}

.bg-blur,
.landing-block {
    background-size: cover;
    background-repeat: no-repeat;
}

.landing-page .btn-block {
    max-width: 100%;
}

.bg-block {
    background: #333;
    padding: 80px 0;
    position: relative;
    overflow: hidden;
    width: 100%;
}

.bg-block .bg-blur {
    background-position: 50%;
    width: 110%;
    height: 110%;
    position: absolute;
    top: -5%;
    left: -5%;
    -webkit-filter: blur(35px);
    filter: blur(35px);
    opacity: 0.7;
}

.landing-block {
    background-position: 0;
    border-radius: 10px;
    overflow: hidden;
    position: relative;
}

.landing-content {
    background-color: #fff;
    padding: 120px 70px;
    text-align: center;
}

.landing-content h2 {
    margin-top: 15px;
    margin-bottom: 30px;
}

.landing-content h3 {
    font-weight: 400;
    color: #666;
    margin-bottom: 15px;
}

.landing-info {
    padding: 30px 0;
    background: #fff;
}

#account-logIn .modal-header {
    padding: 0;
}

#account-logIn .modal-header .modal-title {
    font-size: 1.8rem;
    padding: 13px 20px;
    border-bottom: 1px solid #ddd;
    margin-bottom: -15px;
}

#account-logIn .modal-header .close {
    top: 20px;
    right: 15px;
    font-size: 2.6rem;
}

#account-logIn .modal-body {
    padding: 30px 60px;
}

#account-logIn .modal-body article.row.login-sns {
    text-align: center;
    margin-bottom: 20px;
}

#account-logIn .login-sns h4 {
    margin-top: 0;
}

#account-logIn .form-group:last-child {
    margin-bottom: 0;
}

#login_text {
    max-width: 46.8rem;
    margin: 0 auto;
    font-size: 1.6rem;
    letter-spacing: -0.5px;
    color: #787c7d;
}

.link-disabled {
    pointer-events: none;
    cursor: default;
}

.locked-header {
    margin-top: 30px;
}

.modal .modal-header .glyphicon-remove {
    font-size: 3rem;
}

.modal .modal-header .glyphicon-remove:hover {
    opacity: 0.7;
}

.loading-area {
    min-height: 50vh;
}

.loading-area .loading-icon {
    width: 150px;
    height: 150px;
    margin: 18% auto 0;
    padding: 15px;
    border-radius: 10px;
    background: #fff;
    -webkit-box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.loading-area .loading-icon img {
    width: 120px;
}

.page-wrap {
    margin-bottom: 40px;
    min-height: 61vh;
    padding-top: 20px;
}

.page-wrap .cut-bread {
    margin-top: -20px;
}

.page-aside .aside-box {
    padding: 15px;
    background-color: #fff;
    border-radius: 6px;
    margin-bottom: 15px;
}

.buddy-group .panel-body .editor-logo,
.page-aside .editor-logo {
    position: relative;
    overflow: visible;
}

.page-aside .editor-logo {
    width: 120px;
    height: 120px;
    margin: 0 auto;
}

.editor-logo .fa-camera {
    font-size: 1.8rem;
    background-color: #fff;
    border-radius: 50%;
    padding: 4px;
    width: 28px;
    height: 28px;
    position: absolute;
    right: 0;
    bottom: 0;
    z-index: 2;
    cursor: pointer;
}

.editor-logo .overlap {
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.6);
    border-radius: 50%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
}

.page-aside .editor-logo .dot-load {
    height: 100%;
    background: rgba(0, 0, 0, 0.5);
    margin: 0;
    padding-top: 45%;
    border-radius: 100%;
}

.page-aside h4 {
    margin-bottom: 4px;
}

.page-aside .account-group {
    border-top: 1px solid #eee;
    margin: 15px -15px 0;
    padding: 10px 15px 0;
}

.page-aside .account {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
    position: relative;
    margin-top: 10px;
    text-align: left;
    line-height: 1.4;
}

.page-aside .account .now-login {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
    color: #26bec9;
    font-size: 20px;
}

.page-aside .account .channel-icon {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
    height: 20px;
    margin-right: 10px;
}

.page-aside .account .channel-name {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    min-width: 0;
}

.page-aside .account .channel-login-id {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
}

.account span {
    vertical-align: top;
}

.account .corporate-text {
    color: #666;
    font-size: 1.2rem;
    padding-left: 26px;
}

.page-menu {
    list-style: none;
    padding-left: 0;
    background-color: #fff;
    border-radius: 5px;
    margin-top: 15px;
}

.page-menu li a {
    display: block;
    color: #333;
    padding: 10px 15px;
}

.page-menu li a:hover {
    background-color: rgba(0, 0, 0, 0.02);
}

.page-menu li.active a {
    color: #26bec9;
    position: relative;
}

.page-menu li.active .custom-kk-icon {
    color: #26bec9;
}

.page-menu li.active a:before {
    content: '';
    position: absolute;
    top: 50%;
    left: 0;
    -webkit-transform: translateY(-50%);
    transform: translateY(-50%);
    height: 24px;
    width: 4px;
    background-color: #26bec9;
}

.page-aside .product-img {
    height: 160px;
    border-radius: 6px;
}

.page-aside .fill-group {
    font-size: 1.4rem;
}

.page-aside .order-main-title h2 {
    font-size: 1.6rem;
    margin-top: 10px;
    margin-bottom: 0;
}

.page-aside .price-detail,
.page-aside .redeem-detail {
    position: relative;
    margin-bottom: 0;
    padding-top: 15px;
    border-top: 1px dashed #eaeaea;
}

.page-aside .price-detail:after,
.page-aside .price-detail:before,
.page-aside .redeem-detail:after,
.page-aside .redeem-detail:before {
    content: '';
    display: inline-block;
    width: 20px;
    height: 20px;
    position: absolute;
    top: -10px;
    border-radius: 100%;
    background-color: #f5f5f5;
}

.page-aside .price-detail:before,
.page-aside .redeem-detail:before {
    left: -25px;
}

.page-aside .price-detail:after,
.page-aside .redeem-detail:after {
    right: -25px;
}

.page-aside .price-detail hr,
.page-aside .redeem-detail hr {
    margin: 15px 0;
}

.page-aside .price-detail .product-pricing h4,
.page-aside .redeem-detail .product-pricing h4 {
    line-height: 1;
}

.page-aside .price-detail h5 {
    font-size: 1.4rem;
    color: #333;
    letter-spacing: 0.35px;
    font-weight: 700;
}

.page-aside .price-detail-info {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
    color: #333;
    font-size: 1.4rem;
    margin: 0 0 7px;
}

.page-aside .price-detail-info:last-child {
    margin: 0;
}

.page-aside .price-detail-refund {
    margin: 10px 0;
    padding: 10px;
    background: #fff;
    border-radius: 4px;
}

.page-aside .price-detail-refund .refund-title {
    font-size: 1.2rem;
    font-weight: 700;
    padding: 5px 0 8px;
}

.page-aside .price-detail-refund .refund-detail {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
    color: #333;
    font-size: 1.2rem;
    margin: 0 0 5px;
}

.page-aside .price-detail-refund .refund-detail .price {
    color: #666;
}

.page-aside .price-detail-refund .tip {
    font-size: 1.2rem;
}

.page-aside .price-detail .title {
    text-align: left;
}

.page-aside .price-detail .discount-price,
.page-aside .price-detail .price,
.page-aside .price-detail .total-price {
    text-align: right;
}

.page-aside .price-detail .discount-price,
.page-aside .price-detail .total-price {
    color: #26bec9;
}

.page-aside .price-detail .cancel-price {
    color: #ef7a70;
}

.page-aside .price-detail hr.total-hr {
    width: 100%;
    padding: 0 15px;
    margin: 15px -15px;
}

.page-aside .price-detail .actual-hr {
    width: 100%;
    border: 1px dashed #eee;
}

.page-aside .price-detail .total-pay .title {
    font-size: 1.4rem;
    color: #333;
    font-weight: 700;
}

.page-aside .price-detail .total-pay .currency {
    line-height: 0.94;
    letter-spacing: 0.4px;
    font-size: 1.5rem;
    font-weight: 700;
}

.page-aside .price-detail .total-pay .price {
    line-height: 0.82;
    letter-spacing: 0.37px;
    font-size: 2.2rem;
    font-weight: 700;
}

.page-aside .price-detail .refund-pay .currency {
    line-height: 0.94;
    letter-spacing: 0.4px;
    font-size: 1.5rem;
    font-weight: 700;
}

.page-aside .price-detail .refund-pay .price {
    line-height: 0.82;
    letter-spacing: 0.37px;
    font-size: 2.2rem;
    font-weight: 700;
}

.page-aside .price-detail .cancel-pay .total-price {
    font-size: 1.4rem;
    color: #333;
    font-weight: 700;
}

.page-aside .price-detail .actual-price {
    font-family: NotoSansCJKtc;
    color: #666;
    font-size: 1.2rem;
    line-height: 1.08;
    letter-spacing: 0.33px;
}

.page-aside .price-detail .point {
    font-family: ArialRounded;
    color: #ffb400;
    font-weight: 700;
    text-align: right;
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.page-aside .price-detail .point .icons img {
    position: relative;
    max-height: 1.6rem;
}

.page-aside .price-detail .point .price {
    font-size: 1.6rem;
}

.page-aside .price-detail .tip {
    margin: 5px 0 10px;
    font-size: 1.2rem;
}

.page-aside .price-detail .tip .tip-info {
    margin: 4px 0 0 6px;
}

.page-aside .redeem-detail__code,
.page-aside .redeem-detail__title {
    color: #666;
    text-align: center;
}

.page-aside .redeem-detail__title {
    font-size: 1.6rem;
    font-weight: 700;
}

.page-wrap .board {
    border: 0;
    margin-top: 0;
}

.page-head {
    border-bottom: 1px solid #eaeaea;
    margin: 0 -20px 20px;
    padding: 0 20px;
}

.page-head h1,
.page-head h2 {
    margin-top: 0;
    margin-bottom: 20px;
}

.page-tab,
.page-tab > li {
    border: 0;
}

.page-tab > li:hover {
    border-bottom: 3px solid rgba(19, 129, 132, 0.5);
}

.page-tab > li.active {
    border-bottom: 3px solid #138184;
}

.page-tab > li > a,
.page-tab > li > a:focus,
.page-tab > li > a:hover {
    color: #999;
    font-weight: 700;
    border: 0;
    background-color: transparent;
    padding: 10px 20px;
    margin: 0;
    position: relative;
}

.page-tab > li.active > a,
.page-tab > li.active > a:focus,
.page-tab > li.active > a:hover {
    color: #138184;
    border: 0;
}

.list-item-group > li > a .badge,
.page-menu > li > a .badge,
.page-tab > li > a .badge {
    background-color: #ef7a70;
    margin-top: 2px;
}

.list-item-group > li > a .badge:empty,
.page-menu > li > a .badge:empty,
.page-tab > li > a .badge:empty {
    display: inline-block;
    min-width: 0;
    width: 8px;
    height: 8px;
    padding: 0;
    margin-top: 7px;
}

.page-tab > li > a .badge {
    position: absolute;
    top: 1px;
    right: 1px;
    -webkit-box-shadow: 0 1px 2px rgba(0, 0, 0, 0.2);
    box-shadow: 0 1px 2px rgba(0, 0, 0, 0.2);
}

.page-tab > li.active.open > a,
.page-tab > li.active.open > a:focus,
.page-tab > li.active.open > a:hover {
    background-color: #eee;
}

.page-tab li.dropdown.active > a {
    cursor: pointer;
}

.page-tab .dropdown-menu {
    min-width: 250px;
    border-radius: 6px;
}

.page-wrap .info-section {
    padding: 20px 0;
}

.page-wrap .info-section .info-title {
    margin-bottom: 20px;
    font-size: 1.6rem;
}

.page-wrap .info-section .info-content {
    padding-left: 0;
}

.page-wrap .info-section .info-subtitle {
    font-size: 1.4rem;
}

.page-wrap .product-listview {
    border: 1px solid #e6e9ed;
}

.page-wrap .product-listview:hover {
    opacity: 1;
    -webkit-box-shadow: 0 0 8px rgba(0, 0, 0, 0.15);
    box-shadow: 0 0 8px rgba(0, 0, 0, 0.15);
}

.page-wrap .empty-list {
    border: 0;
}

.page-wrap .board .form-inline .btn:last-child {
    margin-left: 20px;
}

.img-bg .tag,
.product-img .tag {
    color: #fff;
    display: inline-block;
    font-weight: 700;
    background-color: rgba(51, 51, 51, 0.8);
    padding: 4px 12px;
    margin-top: 15px;
    border-radius: 0 2px 2px 0;
}

.table-head {
    background-color: #eee;
    padding: 5px 10px;
    margin-top: 20px;
    border-radius: 4px 4px 0 0;
    color: #666;
}

.guide-hint {
    position: absolute;
    background: url(https://cdn.kkday.com/pc-web/assets/img/bg_guide_hint.svg),
        #ffc612;
    background-position: 0 100%;
    background-repeat: no-repeat;
    background-size: 50px;
    border-radius: 4px;
    width: 220px;
    padding: 10px 15px;
    -webkit-box-shadow: 0 1px 8px rgba(0, 0, 0, 0.2);
    box-shadow: 0 1px 8px rgba(0, 0, 0, 0.2);
    z-index: 99;
}

.guide-hint.top {
    bottom: 100%;
    right: 10px;
}

.guide-hint.bottom {
    top: 100%;
    left: 0;
}

.hint-arrow {
    position: absolute;
    border-width: 10px;
    border-style: solid;
}

.guide-hint.top .hint-arrow {
    border-color: #ffc612 transparent transparent;
    bottom: -20px;
    right: 30px;
}

.guide-hint.bottom .hint-arrow {
    border-color: transparent transparent #ffc612;
    top: -20px;
    left: 20px;
}

.hint-body {
    color: #fff;
    font-weight: 700;
    font-size: 1.6rem;
}

.hint-footer {
    text-align: right;
    margin-top: 10px;
}

.hint-footer .btn {
    color: #ffc612;
    border-radius: 4px;
    border: 0;
    -webkit-box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
    -webkit-transition: 0.2s;
    transition: 0.2s;
    font-weight: 700;
}

.hint-footer .btn:focus,
.hint-footer .btn:hover {
    -webkit-transform: translateY(-2px);
    transform: translateY(-2px);
}

.hint-footer .btn:active {
    -webkit-transform: translateY(0);
    transform: translateY(0);
}

.hint--kkgift {
    color: #aaa;
    font-size: 1.2rem;
}

.contact-app .info,
.contact-app .pic {
    float: left;
}

.contact-app .pic,
.contact-app .pic img {
    width: 40px;
}

.contact-app .info {
    padding-left: 10px;
    width: calc(100% - 40px);
    line-height: 20px;
}

.contact-app .info .text {
    color: #999;
}

.page-wrap .panel {
    position: relative;
    margin-bottom: 10px;
    -webkit-transition: 0.3s;
    transition: 0.3s;
    -webkit-box-shadow: none;
    box-shadow: none;
    border: 1px solid #eaeaea;
}

.page-wrap .panel.active,
.page-wrap .panel:hover {
    -webkit-box-shadow: 0 0 10px rgba(0, 0, 0, 0.12);
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.12);
}

.buddy-group .panel .btn-group {
    white-space: nowrap;
    display: none;
}

.buddy-group .panel.active .btn-group,
.buddy-group .panel:hover .btn-group {
    display: block;
}

.buddy-group .panel .panel-heading,
.buddy-group .panel .panel-heading .editor-logo {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.buddy-group .panel .panel-heading .editor-logo {
    color: #fff;
    line-height: 25px;
    letter-spacing: 0;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    width: 35px;
    height: 35px;
    min-width: 35px;
    margin-right: 10px;
}

.buddy-group .panel-title {
    white-space: nowrap;
    text-overflow: ellipsis;
    overflow: hidden;
    -webkit-box-flex: 1;
    -ms-flex-positive: 1;
    flex-grow: 1;
}

.buddy-group .panel-body .editor-logo {
    width: 80px;
    height: 80px;
    font-size: 3rem;
}

.buddy-group .panel-body .editor-logo .fa-camera {
    color: #333;
    bottom: -5px;
    right: -5px;
}

.buddy-group .panel .btn-group a {
    color: #666;
    margin-left: 15px;
}

.buddy-group .panel .btn-group a:hover {
    color: #138184;
}

.buddy-group .panel .btn-group a i {
    margin-right: 4px;
}

.buddy-group .panel .btn-default {
    border: 0;
    -webkit-transition: none;
    transition: none;
}

.buddy-group .panel .btn-default:focus,
.buddy-group .panel .btn-default:hover {
    background-color: transparent;
    color: #333;
}

.add-buddy {
    display: inline-block;
    margin: 10px 0;
}

.add-buddy i {
    margin-right: 8px;
}

#custom_fc_button {
    position: fixed;
    right: 40px;
    bottom: 0;
    z-index: 99;
    -webkit-transition: 0.2s;
    transition: 0.2s;
    opacity: 0;
    visibility: hidden;
}

#custom_fc_button.active {
    opacity: 1;
    visibility: visible;
}

.btn-chat {
    width: 250px;
    cursor: pointer;
    padding: 8px 15px;
    background: #26bec9;
    border-radius: 6px 6px 0 0;
    color: #fff;
    -webkit-box-shadow: 0 -2px 8px rgba(0, 0, 0, 0.1);
    box-shadow: 0 -2px 8px rgba(0, 0, 0, 0.1);
    position: relative;
}

.btn-chat i {
    margin-right: 10px;
}

.btn-chat .offline {
    opacity: 0.5;
}

#custom_fc_button.snoozed .btn-chat i {
    opacity: 0.5;
    margin-top: 2px;
}

#custom_fc_button.snoozed .btn-chat:after,
#custom_fc_button.snoozed .btn-chat:before {
    content: 'z';
    display: inline-block;
    color: #fff;
    font-size: 1.2rem;
    line-height: 1;
    padding: 1px;
    background-color: #26bec9;
    position: absolute;
}

#custom_fc_button.snoozed .btn-chat:before {
    -webkit-transform: scale(0.7);
    transform: scale(0.7);
    top: 9px;
    left: 23px;
    z-index: 1;
}

#custom_fc_button.snoozed .btn-chat:after {
    -webkit-transform: scale(0.8);
    transform: scale(0.8);
    top: 5px;
    left: 29px;
    z-index: 2;
}

.btn-chat #notify {
    visibility: hidden;
    background: #ef7a70;
    position: absolute;
    top: -5px;
    right: -5px;
    width: 15px;
    height: 15px;
    border-radius: 50%;
    min-width: auto;
    padding: 0;
    -webkit-box-shadow: 0 1px 4px rgba(0, 0, 0, 0.2);
    box-shadow: 0 1px 4px rgba(0, 0, 0, 0.2);
}

.btn-chat #notify.active {
    visibility: visible;
    -webkit-animation-duration: 0.6s;
    animation-duration: 0.6s;
    -webkit-animation-fill-mode: forwards;
    animation-fill-mode: forwards;
    -webkit-animation-iteration-count: 1;
    animation-iteration-count: 1;
    -webkit-animation-name: popup;
    animation-name: popup;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
}

#fc_frame,
#fc_frame.fc-widget-normal {
    min-height: auto !important;
    min-width: auto !important;
    bottom: -10px !important;
}

#fc_frame.fc-widget-normal.h-open-container,
#fc_frame.h-open-container {
    width: 100% !important;
    max-width: 420px !important;
    max-height: calc(100% - 220px) !important;
}

#fc_frame.fc-widget-normal.h-open-container.expanded-modal,
#fc_frame.h-open-container.expanded-modal {
    max-width: none !important;
    max-height: none !important;
    top: 0;
}

#fc_frame.fc-widget-normal.h-open-container.expanded-modal:before,
#fc_frame.h-open-container.expanded-modal:before {
    content: '×';
    font-size: 4rem;
    color: #fff;
    position: absolute;
    top: 15px;
    right: 15px;
    pointer-events: none;
}

#fc_frame.fc-widget-normal.h-open-notify,
#fc_frame.h-open-notify {
    right: 10px !important;
    bottom: 35px !important;
    max-height: calc(100% - 420px) !important;
    min-height: 142px !important;
}

[v-cloak] {
    display: none;
}

.emergency-wrap .bg-block {
    background: #f4f4f4;
    padding: 40px 0;
}

.emergency-wrap .landing-content {
    padding: 50px 70px;
}

.emergency-wrap h1 {
    margin-top: 0;
    margin-bottom: 5px;
}

.emergency-wrap .landing-content h4.sub-title {
    font-weight: 400;
    margin: 0;
}

.emergency-wrap .landing-content .board {
    border: 1px solid #eaeaea;
    text-align: left;
    margin-bottom: 0;
}

.emergency-wrap .landing-content .board ol {
    padding-left: 20px;
    margin-top: 10px;
}

.contact-group {
    margin: 30px 0;
}

.contact-item {
    display: inline-block;
    margin: 0 20px;
}

.emergency-wrap .btn-circle {
    width: 100px;
    height: 100px;
    font-size: 4.5rem;
    color: #fff;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
}

.emergency-wrap .btn-circle img {
    width: 100%;
}

.emergency-wrap hr {
    margin: 20px 0;
}

.emergency-time {
    font-size: 1.8rem;
    font-weight: 700;
    color: #138184;
}

.emergency-wrap .tip a {
    color: inherit;
    text-decoration: underline;
}

.emergency-wrap .tip a:focus,
.emergency-wrap .tip a:hover {
    color: #26bec9;
}

#lc_chat_layout {
    right: 40px !important;
}

#lc_chat_layout #lc_chat_header {
    color: #000 !important;
    background-color: #26bec9 !important;
}

#lc_chat_layout #lc_chat_header .lc-minimize {
    top: -3px !important;
}

#lc_chat_layout #lc_chat_container,
#lc_chat_layout #lc_chat_header {
    border-color: transparent !important;
}

#lc_chat_layout #lc_chat_container #lc_chat_message_window {
    padding: 10px !important;
    background-color: #f4f4f4 !important;
}

#lc_chat_layout #lc_chat_container #lc_chat_message_window p {
    padding: 8px 12px !important;
}

#lc_chat_layout #lc_chat_container .lc-guest,
#lc_chat_layout #lc_chat_container .lc-welcome-message {
    background: #fff !important;
    border: none !important;
    border-radius: 6px !important;
}

#lc_chat_layout #lc_chat_container .lc-self {
    background: #eaeaea !important;
    border: none !important;
    border-right: 0 !important;
    border-radius: 6px !important;
}

#lc_chat_layout #lc_chat_container .lc-msg {
    color: #333 !important;
    font-size: 1.4rem !important;
    line-height: 1.5 !important;
}

#lc_chat_layout #lc_chat_container .lc-time {
    color: #999 !important;
    font-size: 1.2rem !important;
}

#lc_chat_layout #lc_chat_container #lc_chat_input_container {
    font-size: 1.4rem !important;
    color: #333 !important;
}

#lc_chat_layout #lc_chat_container .lc-button-submit {
    background-color: #26bec9;
    border: none !important;
    color: #fff !important;
}

#lc_chat_title {
    color: #fff !important;
}

#lc_chat_header.lc-dark-icon {
    background-image: url(http://assets1.chat.freshdesk.com/images/chat-icon.svg) !important;
}

#lc_chat_layout.lc-expanded .lc-dark-icon {
    background-image: none !important;
}

#lc-close {
    opacity: 1 !important;
}

#lc-close,
#lc_minimize {
    color: #fff !important;
}

.lc-collapsed #lc-close,
.lc-collapsed #lc_minimize {
    display: none !important;
}

@media only screen and (max-width: 720px) {
    #lc_chat_layout.lc-collapsed #lc_chat_header {
        display: none;
    }
}

.theme-wrap.usj-wrap .city-banner {
    height: auto;
    background: #00407d;
}

.theme-wrap.usj-wrap .city-banner .overlap {
    position: static;
}

.theme-wrap.usj-wrap .city-banner .overlap .container {
    background-size: 30% auto;
    background-position: 100%;
    background-repeat: no-repeat;
    padding: 65px 15px;
}

.usj-wrap .product-content {
    margin-top: 0;
    padding: 30px 0;
}

.usj-wrap .product-content .product-result h4 {
    margin-top: 0;
}

.usj-wrap .product-filter {
    width: 262.5px;
    z-index: 99;
}

.usj-wrap .product-filter .daterangepicker {
    min-width: 508px;
    left: 0 !important;
}

.usj-listview > a {
    padding: 15px 50px 15px 15px;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
}

.usj-listview .img-bg {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 120px;
    flex: 0 0 120px;
    height: 90px;
    border-radius: 4px;
    margin: 0;
}

.usj-listview .product-detail {
    min-height: auto;
    padding: 0 15px;
    -webkit-box-flex: 1;
    -ms-flex-positive: 1;
    flex-grow: 1;
}

.usj-listview .product-detail > h3 {
    display: block;
    margin-top: 0;
    max-height: none;
    overflow: visible;
    white-space: normal;
}

.usj-listview .product-footer {
    position: static;
}

.usj-listview .product-pricing {
    position: static;
    white-space: nowrap;
}

.usj-listview .product-hint {
    top: -20px;
    left: -5px;
}

.usj-listview .product-detail .detail-toggle {
    display: inline-block;
    padding: 5px;
    margin: 10px 0 -5px -5px;
    color: #333;
}

.usj-listview .product-detail .detail-toggle i {
    color: #333;
}

.usj-listview .product-detail .detail-toggle:hover,
.usj-listview .product-detail .detail-toggle:hover i {
    color: #26bec9;
}

.usj-listview .product-detail .option-detail {
    color: #666;
    width: 100%;
    padding: 0;
}

.usj-listview.fake {
    border-radius: 6px;
    height: 120px;
    overflow: hidden;
    margin-bottom: 15px;
}

.usj-listview.fake .mask1 {
    height: 15px;
    top: 0;
    left: 0;
}

.usj-listview.fake .mask2 {
    height: 15px;
    bottom: 0;
    left: 0;
}

.usj-listview.fake .mask3,
.usj-listview.fake .mask4 {
    width: 15px;
    height: 120px;
    top: 0;
    left: 0;
}

.usj-listview.fake .mask4 {
    left: 135px;
}

.usj-listview.fake .mask5 {
    height: 10px;
    top: 35px;
    left: 135px;
}

.usj-listview.fake .mask6 {
    width: 30%;
    height: 30px;
    top: 15px;
    right: 0;
}

.usj-listview.fake .mask7 {
    width: 50%;
    height: 55px;
    top: 45px;
    right: 0;
}

.usj-listview.fake .mask8 {
    width: calc(100% - 150px);
    height: 45px;
    bottom: 15px;
    right: 0;
}

.usj-wrap .panel-group:not(:last-child) {
    margin-bottom: 0;
    border-bottom: 1px solid #eaeaea;
}

.usj-wrap .panel-title {
    cursor: pointer;
    padding: 10px 50px 10px 0;
    position: relative;
    -webkit-transition: 0.2s ease;
    transition: 0.2s ease;
}

.usj-wrap .panel-title i {
    position: absolute;
    right: 5px;
    top: 50%;
    -webkit-transform: translateY(-50%);
    transform: translateY(-50%);
    -webkit-transition: 0.3s;
    transition: 0.3s;
}

.usj-wrap .panel-title.collapsed i {
    color: #ccc;
    -webkit-transform: translateY(-50%) rotate(180deg);
    transform: translateY(-50%) rotate(180deg);
}

.usj-wrap .panel-title.collapsed:hover i {
    color: #333;
}

.usj-wrap .panel-collapse {
    color: #666;
    padding: 10px 20px 20px;
    display: none;
}

#app-promotion-modal .modal-content {
    background-size: auto 100%;
    background-position: 0;
    background-repeat: no-repeat;
    padding-left: 130px;
}

#app-promotion-modal .event-title img {
    width: 80px;
    margin-right: 20px;
}

#app-promotion-modal .ic-store {
    width: 120px;
    margin: 5px;
}

#app-promotion-modal .app-qrcode {
    width: 140px;
    display: block;
    margin: 20px auto;
}

@media (max-width: 1200px) {
    #supplier .page {
        height: 634px;
    }

    #supplier .page1 .page1-slogan {
        line-height: 130px;
    }

    #supplier .page1 .page1-illustrated {
        margin-top: 20px;
    }

    #supplier .page2 .page2-image {
        width: 48%;
        margin-top: 25px;
    }

    #supplier .page3 .page3-image {
        width: 100%;
        margin-top: 50px;
    }

    #supplier .page3 h1 {
        font-size: 2.8rem;
    }

    #supplier .page4 {
        height: 500px;
    }

    #supplier .page4 .page4-image {
        height: 634px;
    }

    #supplier .page6 h1 {
        font-size: 2.2rem;
    }

    #supplier .page6 h3 {
        font-size: 1.4rem;
    }

    .usj-wrap .product-filter {
        width: 293.33px;
    }
}

#app-promotion-modal.flowchart-modal .modal-content:before {
    display: none;
}

#app-promotion-modal.flowchart-modal .modal-body {
    display: inline-block;
    max-width: 500px;
    padding: 68px 20px 0;
}

#app-promotion-modal.flowchart-modal .close {
    top: 20px;
    right: 20px;
}

#app-promotion-modal.flowchart-modal .flowchart-title {
    display: block;
    color: #333;
    font-size: 2.8rem;
    line-height: 1.4;
    text-align: center;
    letter-spacing: 0.6px;
    margin-bottom: 20px;
}

#app-promotion-modal.flowchart-modal .flowchart-title .text-md {
    letter-spacing: normal;
    line-height: normal;
}

#app-promotion-modal.flowchart-modal .modal-content {
    background-size: auto 85%;
    background-position: 0 0;
    background-repeat: no-repeat;
    padding: 0 0 35px 130px;
    text-align: right;
}

#app-promotion-modal.flowchart-modal .ic-store {
    width: 134px;
    margin: 0 5px 5px;
}

#app-promotion-modal.flowchart-modal .app-qrcode {
    width: 160px;
    margin: 5px auto;
}

#app-promotion-modal.flowchart-modal .event-title img {
    width: 80px;
    margin-right: 20px;
}

@media (max-width: 991px) {
    .kksearch .form-control {
        font-size: 1.4rem;
    }

    .search-dropdown .default-suggest ul {
        -webkit-column-count: 2;
        -moz-column-count: 2;
        column-count: 2;
    }

    .search-dropdown .default-suggest ul li:nth-child(-n + 10) {
        border-right-width: 0;
    }

    .search-dropdown .default-suggest ul li:nth-child(-n + 8) {
        border-right-width: 1px;
    }

    .search-dropdown .autosuggest ul.experience li span.prod_name {
        width: 65%;
    }

    .kksearch .clear-input {
        top: 10px;
        right: 50px;
    }

    .page-aside .aside-box.text-center,
    .page-aside .page-menu {
        display: none;
    }

    #booking-bar,
    .usj-wrap .product-filter {
        position: static !important;
        top: auto;
        bottom: auto;
        right: auto;
        width: auto !important;
        padding-left: 0;
    }

    #supplier .page {
        height: 634px;
    }

    #supplier .page3 {
        height: 550px;
    }

    #supplier .page4 {
        height: 450px;
    }

    #supplier .page1 {
        background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_host.jpg);
        background-size: cover;
    }

    #supplier .page1 .page1-slogan {
        line-height: 130px;
    }

    .page-menu li.active .custom-kk-icon {
        color: #26bec9;
    }

    .page-menu li.active .custom-kk-icon.ic_service_1 {
        fill: currentColor;
    }

    .page-menu li.active a:before {
        content: '';
        position: absolute;
        top: 50%;
        left: 0;
        -webkit-transform: translateY(-50%);
        transform: translateY(-50%);
        height: 24px;
        width: 4px;
        background-color: #26bec9;
    }

    .page-aside .product-img {
        height: 160px;
        border-radius: 6px;
    }

    #supplier .page2 .page2-image {
        width: 60%;
        margin-top: 25px;
    }

    #supplier .page3 .page3-image {
        width: 100%;
        margin-top: 45px;
    }

    #supplier .page3 h1 {
        font-size: 2.8rem;
    }

    #supplier .page3 h3 {
        font-size: 2rem;
    }

    #supplier .page4 h1 {
        font-size: 2.8rem;
    }

    #supplier .page4 h3 {
        font-size: 2rem;
    }

    #supplier .page6 h1 {
        font-size: 2.2rem;
    }

    #supplier .page6 h3 {
        font-size: 1.4rem;
    }

    .bg-block {
        padding: 30px 0;
    }

    .landing-block {
        padding-top: 300px;
        background-size: 100%;
        background-position: top;
    }

    .landing-content {
        padding: 20px 30px;
    }

    .landing-content h2 {
        font-size: 1.6rem;
    }

    .landing-content h3 {
        font-size: 1.4rem;
    }

    .header-sheet .content {
        padding: 0 30px;
    }

    .emergency-wrap header {
        text-align: center;
        height: 55px;
    }

    .emergency-wrap .header-logo {
        float: none;
        height: 45px;
    }

    .emergency-wrap .bg-block {
        padding: 30px 0;
    }

    .emergency-wrap .landing-block {
        padding-top: 0;
    }

    .emergency-wrap .landing-content {
        padding: 30px 15px;
    }

    .emergency-wrap h1 {
        font-size: 2rem;
    }

    .emergency-wrap .landing-content h4.text-danger {
        font-size: 1.4rem;
        margin: 20px 0;
    }

    .contact-group {
        margin: 20px 0;
    }

    .emergency-wrap .btn-circle {
        width: 80px;
        height: 80px;
        font-size: 4rem;
    }

    .emergency-wrap .btn-circle i {
        line-height: 60px;
    }

    .emergency-wrap .tip {
        font-size: 1.3rem;
    }

    .page-tab > li:not(.active) {
        border: 0;
    }

    .theme-wrap #page-scroll-spy:not(.active) .page-tab > li > a:hover,
    .theme-wrap #product-scroll-spy:not(.active) .page-tab > li > a:hover {
        color: #999;
    }

    .theme-wrap .title {
        text-align: left;
        font-size: 2.4rem;
    }

    .theme-wrap .product-item {
        margin-bottom: 15px;
    }

    .theme-wrap .product-item .description {
        display: none;
    }

    .theme-wrap .product-item-sm {
        opacity: 1;
    }

    .theme-wrap .product-item-sm .product-book {
        height: auto;
    }

    .theme-wrap .city-item .caption {
        width: 100%;
        margin-right: 20px;
    }

    .theme-cta .city-item {
        margin-bottom: 15px;
    }

    .usj-wrap .city-banner .overlap .container {
        background: none !important;
    }
}

@media (max-width: 767px) {
    .h1,
    h1 {
        font-size: 2.2rem;
        line-height: 1.5;
    }

    .h2,
    h2 {
        font-size: 2rem;
    }

    .h2,
    .h3,
    h2,
    h3 {
        line-height: 1.7;
    }

    .h3,
    h3 {
        font-size: 1.8rem;
    }

    .h4,
    h4 {
        font-size: 1.6rem;
    }

    .h5,
    h5 {
        font-size: 1.4rem;
    }

    .text-lg {
        font-size: 1.8rem !important;
    }

    .text-md {
        font-size: 1.4rem !important;
    }

    .text-sm {
        font-size: 1.2rem !important;
    }

    .text-xs {
        font-size: 1rem !important;
    }

    .mt-10-xs {
        margin-top: 10px !important;
    }

    .btn {
        font-size: 1.4rem;
        padding: 10px 15px;
    }

    .search-dropdown .default-suggest ul {
        -webkit-column-count: 1;
        -moz-column-count: 1;
        column-count: 1;
    }

    .search-dropdown .default-suggest ul li:nth-child(-n + 15) {
        border-right-width: 0;
    }

    .search-dropdown .autosuggest ul.experience li span.prod_name {
        width: 100%;
    }

    .search-dropdown .autosuggest ul.experience li span.city {
        width: 100%;
        text-align: left;
    }

    .city-banner-img {
        height: 150px;
    }

    .city-banner-img .page-title,
    .city-banner-img h1 {
        font-size: 3rem;
    }

    .city-item {
        width: 150px;
        height: 150px;
    }

    .guide-carousel .owl-stage-outer,
    .home-carousel .owl-stage-outer {
        overflow: visible;
    }

    .city-item .overlap {
        background: -webkit-gradient(
            linear,
            left top,
            left bottom,
            color-stop(45%, transparent),
            to(rgba(0, 0, 0, 0.85))
        );
        background: linear-gradient(transparent 45%, rgba(0, 0, 0, 0.85));
    }

    .city-item .caption {
        padding: 7px;
    }

    .city-item .caption .city-head h5 {
        font-size: 1.6rem;
        font-weight: 400;
    }

    .city-item .caption .city-head span {
        font-size: 1.2rem;
    }

    .product-benefit .critical-info {
        display: block;
    }

    .owl-carousel .product-item {
        width: 280px;
    }

    .product-listview .img-bg {
        margin-right: 0;
        border-radius: 6px 6px 0 0;
    }

    .product-listview .product-detail {
        padding: 8px 12px;
    }

    .product-footer {
        position: static;
    }

    .product-listview .product-pricing {
        bottom: 7px;
    }

    .product-tag {
        right: -10px;
        bottom: 40px;
    }

    .city-banner .container {
        width: 100%;
    }

    div.union .main-menu {
        margin-top: 10px;
        display: none;
        padding: 0 15px;
    }

    div.union .main-menu ul li.sub ul {
        margin-left: 20px;
    }

    div.union .mobile-menu {
        display: block;
    }

    .dropdown-meun-white {
        right: 0;
        left: auto;
    }

    div.union .main-content .nav-content {
        border-top: 1px solid #ddd;
    }

    .modal-header h2,
    .modal-header h4 {
        font-size: 2.4rem;
    }

    .login-kkday {
        margin-top: 10px;
        padding-top: 0;
    }

    #supplier .page1 {
        height: 900px;
    }

    #supplier .page3 h1 {
        margin-top: 8%;
    }

    #supplier .page3 {
        height: 800px;
    }

    #supplier .page4 {
        height: 600px;
    }

    .landing-block {
        padding-top: 160px;
    }

    .modal-dialog {
        width: auto;
    }

    .modal-footer .btn-block {
        max-width: 100%;
    }

    .guide-item {
        width: 280px;
    }

    .product-filter .daterangepicker {
        min-width: auto;
    }

    .theme-wrap .city-item {
        -ms-flex-wrap: wrap;
        flex-wrap: wrap;
        -webkit-box-pack: start;
        -ms-flex-pack: start;
        justify-content: flex-start;
        width: auto;
        margin: -50px -15px -30px;
        padding-bottom: 50px;
        border-radius: 0;
    }

    .theme-wrap .city-item .overlap {
        background: -webkit-gradient(
            linear,
            left top,
            left bottom,
            from(transparent),
            to(rgba(0, 0, 0, 0.9))
        );
        background: linear-gradient(transparent, rgba(0, 0, 0, 0.9));
    }

    .theme-wrap .city-item .caption {
        margin-right: 0;
    }

    .theme-cta .city-item {
        margin: 0 -15px;
    }

    .usj-listview {
        padding: 10px;
    }

    .usj-listview .img-bg {
        display: none;
    }

    .usj-listview .product-detail {
        padding: 0 20px 0 0;
    }

    .usj-listview .product-detail > h3 {
        font-size: 1.5rem;
    }
}

@media (max-width: 580px) {
    #supplier .page {
        height: 550px;
    }

    #supplier .page1 {
        background-image: url(https://cdn.kkday.com/pc-web/assets/img/bg_host.jpg);
        background-size: cover;
        height: 1000px;
    }

    #supplier .page1 .page1-slogan {
        line-height: 170px;
        margin-top: 25px;
    }

    #supplier .thumbnail {
        margin-bottom: 40px;
    }

    #supplier .page2 .page2-image {
        width: 75%;
        margin-top: 25px;
        margin-bottom: 70px;
    }

    #supplier .page3 {
        height: 500px;
    }

    #supplier .page3 h1 {
        margin-top: 8%;
        text-align: center;
    }

    #supplier .page3 h3 {
        text-align: center;
    }

    #supplier .page3 .page3-image {
        width: 100%;
        margin-top: 25px;
        margin-bottom: 60px;
    }

    #supplier .page4 {
        height: 550px;
    }

    #supplier .page4 .col-xs-12 {
        text-align: center;
        margin-top: 125px;
        margin-bottom: 70px;
    }

    #supplier .page6 .col-xs-12 {
        width: 100%;
        margin-bottom: 40px;
    }

    #app-promotion-modal .modal-content {
        background-image: none !important;
        padding-left: 0;
    }

    #app-promotion-modal.flowchart-modal .modal-content {
        padding: 0;
    }

    #app-promotion-modal.flowchart-modal .modal-body {
        padding: 50px 25px 50px 30px;
    }
}

.telephone-input-wrap {
    position: relative;
}

.telephone-input-wrap__icon-verified {
    position: absolute;
    top: 0;
    right: 0;
    bottom: 0;
    height: 1.4rem;
    margin: auto 15px;
    display: none;
}

.telephone-input-wrap--is-verified .telephone-input-wrap__icon-verified {
    display: block;
}

.telephone-input-wrap--is-verified .intl-tel-input input.form-control {
    padding-right: 40px;
}

.search-keyword {
    display: inline-block;
    width: 70%;
    margin-bottom: 10px;
    vertical-align: -35px;
}

.sign-in-banner {
    position: relative;
    display: block;
    background: #fff;
    padding: 25px;
    border-radius: 5px;
    margin: 20px 0;
    text-align: center;
}

.sign-in-banner__close {
    position: absolute;
    top: 0;
    right: 0;
    color: #666;
    margin: 10px;
}

.sign-in-banner__text {
    display: inline-block;
    max-width: 400px;
}

.sign-in-banner__title {
    font-size: 1.6rem;
    font-weight: 700;
    margin-bottom: 8px;
}

.sign-in-banner__buttons {
    margin-top: 10px;
}

.sign-in-banner__button {
    min-width: 120px;
    margin: 0 5px;
}

.member-terms__content {
    margin-bottom: 20px;
}

.member-terms__checkbox {
    vertical-align: text-top;
}

.member-terms .policy-link {
    color: #26bec9;
}

.ic-point {
    position: relative;
    bottom: 1px;
    max-height: 16px;
}

.point .ic-point {
    width: 16px;
    height: 16px;
    margin-right: 4px;
}

[data-gtm-name] * {
    pointer-events: none;
}

#member-active[data-v-243b2f4a] {
    margin: 3.2rem 0;
}

#main-title[data-v-243b2f4a] {
    font-size: 3.8rem;
    font-weight: 500;
    letter-spacing: -0.9px;
    color: #64696b;
    margin-bottom: 1rem;
}

#sub-title[data-v-243b2f4a] {
    font-size: 2rem;
    font-weight: 500;
    letter-spacing: -0.5px;
    color: #76787a;
    margin-top: 1rem;
}

#center-img[data-v-243b2f4a] {
    max-width: 275px;
    margin-bottom: 20px;
}

.btn[data-v-243b2f4a] {
    width: 40%;
}

.action[data-v-243b2f4a] {
    background-color: #e9eff2;
}

.action[data-v-243b2f4a]:active,
.action[data-v-243b2f4a]:focus,
.action[data-v-243b2f4a]:hover {
    color: #494c4f;
    background-color: #b1b1b1 !important;
}

@media (max-width: 991px) {
    .btn[data-v-243b2f4a] {
        width: 100%;
    }
}

.v-enter-active[data-v-691f3694],
.v-leave-active[data-v-691f3694] {
    -webkit-transition: opacity 0.5s;
    transition: opacity 0.5s;
}

.v-enter-from[data-v-691f3694],
.v-leave-to[data-v-691f3694] {
    opacity: 0;
}

.v-enter-to[data-v-691f3694],
.v-leave-from[data-v-691f3694] {
    opacity: 1;
}

.alert-toast[data-v-691f3694] {
    position: fixed;
    left: 50%;
    top: 20px;
    width: 100%;
    height: 100%;
    -webkit-transform: translateX(-50%);
    transform: translateX(-50%);
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    z-index: 99999 !important;
}

.alert-toast--msg[data-v-691f3694] {
    color: #fff;
    margin: 4px 0;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
    display: -webkit-box;
    -webkit-line-clamp: 2;
    -webkit-box-orient: vertical;
    overflow: hidden;
}

@-webkit-keyframes placeHolderShimmer-418e0e57 {
    to {
        -webkit-transform: translateX(100%);
        transform: translateX(100%);
    }
}

@keyframes placeHolderShimmer-418e0e57 {
    to {
        -webkit-transform: translateX(100%);
        transform: translateX(100%);
    }
}

.text-center[data-v-418e0e57] {
    text-align: center;
}

.text-left[data-v-418e0e57] {
    text-align: left;
}

.text-right[data-v-418e0e57] {
    text-align: right;
}

.kk-modal-mask[data-v-418e0e57] {
    position: fixed;
    z-index: var(--5bae73a2);
    inset: 0;
    background-color: rgba(0, 0, 0, 0.6);
    -webkit-transition: opacity 0.4s ease-in-out;
    transition: opacity 0.4s ease-in-out;
}

.kk-modal[data-v-418e0e57] {
    position: fixed;
    z-index: var(--66fb480b);
    top: 30px;
    left: 0;
    right: 0;
    margin: 0 auto;
    -webkit-box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
    box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
}

.kk-modal__line[data-v-418e0e57] {
    height: 8px;
    border-radius: 4px 4px 0 0;
    background: linear-gradient(65deg, #64b3f4, #26bec9 60%);
}

.kk-modal__content[data-v-418e0e57] {
    width: 100%;
    background-color: #fff;
    padding: 0 30px;
    border-radius: 0 0 4px 4px;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
    height: calc(var(--4db42add) - 38px);
    max-height: calc(100vh - 68px);
}

.kk-modal__content .kk-modal__header[data-v-418e0e57] {
    padding-top: 24px;
    border: none;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
}

.kk-modal__content .kk-modal__header-content[data-v-418e0e57] {
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
    min-width: 0;
}

.kk-modal__content .kk-modal__header-title[data-v-418e0e57] {
    color: #333;
    margin: 0 auto;
    font-size: 2.4rem;
}

.kk-modal__content .kk-modal__header-subtitle[data-v-418e0e57] {
    color: #666 !important;
}

.kk-modal__content .kk-modal__header-close[data-v-418e0e57] {
    background: none;
    border: none;
    padding: 0;
    color: #000;
    margin-top: 1rem;
}

.kk-modal__content .kk-modal__body[data-v-418e0e57] {
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
    overflow-y: auto;
    margin: 24px 0;
}

.kk-modal__content .kk-modal__body-icon > [data-v-418e0e57] {
    width: 120px;
    height: auto;
    display: inline-block;
}

.kk-modal__content .kk-modal__body-notes[data-v-418e0e57] {
    list-style: none;
    margin-bottom: 0;
    padding-left: 0;
}

.kk-modal__content .kk-modal__footer[data-v-418e0e57] {
    border-top: 0;
    padding-bottom: 20px;
}

.kk-modal__content
    .kk-modal__footer.kk-modal__footer-button
    .kk-modal__footer-button-link[data-v-418e0e57] {
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.kk-modal__content
    .kk-modal__footer.kk-modal__footer-button
    > [data-v-418e0e57]:not(:first-child) {
    margin-left: 10px;
}

.kk-modal__content .kk-modal__footer-button-fill[data-v-418e0e57] {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
}

.kk-modal__content .kk-modal__footer-button-fill > [data-v-418e0e57] {
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
}

.kk-modal-lg[data-v-418e0e57] {
    width: 700px;
}

.kk-modal-md[data-v-418e0e57] {
    width: 600px;
}

.kk-modal-sm[data-v-418e0e57] {
    width: 400px;
}

.kk-modal-sm .kk-modal__content[data-v-418e0e57] {
    padding: 0 20px;
}

.kk-modal-sm .kk-modal__header[data-v-418e0e57] {
    padding-top: 20px;
}

.kk-modal-sm .kk-modal__header-close[data-v-418e0e57] {
    right: 2rem;
    top: 3.8rem;
}

.kk-modal-sm .kk-modal__footer[data-v-418e0e57] {
    padding-bottom: 16px;
}

@media (max-width: 767px) {
    .kk-modal[data-v-418e0e57] {
        width: calc(100vw - 20px);
    }
}

.kk-modal-enter-active[data-v-418e0e57],
.kk-modal-leave-active[data-v-418e0e57] {
    -webkit-transition: opacity 0.3s ease-in-out,
        -webkit-transform 0.3s ease-in-out;
    transition: opacity 0.3s ease-in-out, -webkit-transform 0.3s ease-in-out;
    transition: opacity 0.3s ease-in-out, transform 0.3s ease-in-out;
    transition: opacity 0.3s ease-in-out, transform 0.3s ease-in-out,
        -webkit-transform 0.3s ease-in-out;
}

.kk-modal-enter[data-v-418e0e57],
.kk-modal-leave-to[data-v-418e0e57] {
    opacity: 0;
    -webkit-transform: translateY(-30px);
    transform: translateY(-30px);
}

.kk-modal.is-mobile[data-v-418e0e57] {
    width: 80vw;
    top: 50vh;
    -webkit-transform: translateY(-50%);
    transform: translateY(-50%);
}

.kk-modal.is-mobile .kk-modal__content[data-v-418e0e57] {
    border-radius: 4px;
    padding: 0 16px;
    max-height: calc(100vh - 60px);
}

.kk-modal.is-mobile .kk-modal__header[data-v-418e0e57] {
    padding-top: 24px;
}

.kk-modal.is-mobile .kk-modal__header-title[data-v-418e0e57] {
    font-size: 2rem;
}

.kk-modal.is-mobile .kk-modal__header-close[data-v-418e0e57] {
    margin-top: 0.3rem;
}

.kk-modal.is-mobile .kk-modal__body[data-v-418e0e57] {
    margin: 20px 0;
}

.kk-modal.is-mobile .kk-modal__footer[data-v-418e0e57] {
    padding-bottom: 24px;
}

.kk-modal.is-mobile
    .kk-modal__footer.kk-modal__footer-button
    > button[data-v-418e0e57],
.kk-modal.is-mobile
    .kk-modal__footer.kk-modal__footer-button
    a[data-v-418e0e57] {
    height: 40px;
    border-radius: 8px;
}

.kk-modal-mobile-enter-active[data-v-418e0e57],
.kk-modal-mobile-leave-active[data-v-418e0e57] {
    -webkit-transition: opacity 0.3s ease-in-out;
    transition: opacity 0.3s ease-in-out;
}

.kk-modal-mobile-enter[data-v-418e0e57],
.kk-modal-mobile-leave-to[data-v-418e0e57] {
    opacity: 0;
}

.kk-fullscreen-modal[data-v-418e0e57] {
    position: fixed;
    z-index: var(--5bae73a2);
    inset: 0;
    background-color: #fff;
}

.kk-fullscreen-modal__content[data-v-418e0e57] {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
    height: 100%;
}

.kk-fullscreen-modal__header[data-v-418e0e57] {
    min-height: 56px;
    display: grid;
    grid-template-columns: 50px 1fr 50px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -webkit-box-shadow: 0 0 4px rgba(0, 0, 0, 0.3);
    box-shadow: 0 0 4px rgba(0, 0, 0, 0.3);
    background-color: #fff;
}

.kk-fullscreen-modal__header-left[data-v-418e0e57],
.kk-fullscreen-modal__header-right[data-v-418e0e57] {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    background: none;
    border: none;
}

.kk-fullscreen-modal__header-title[data-v-418e0e57] {
    grid-column: 2;
    font-weight: 700;
    line-height: 56px;
    font-size: 1.8rem;
    text-align: center;
    color: #333;
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
}

.kk-fullscreen-modal__body[data-v-418e0e57] {
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
    padding: 0 24px;
    overflow-y: auto;
    overflow-x: hidden;
}

.kk-fullscreen-modal__footer[data-v-418e0e57] {
    padding: 16px 24px;
}

.bottom-bar-enter-active[data-v-4c914af2],
.bottom-bar-leave-active[data-v-4c914af2],
.upper-bar-enter-active[data-v-4c914af2],
.upper-bar-leave-active[data-v-4c914af2] {
    -webkit-transition: all 0.25s ease;
    transition: all 0.25s ease;
}

.bottom-bar-enter[data-v-4c914af2],
.bottom-bar-leave-to[data-v-4c914af2] {
    opacity: 0;
    -webkit-transform: translateY(12px);
    transform: translateY(12px);
}

.upper-bar-enter[data-v-4c914af2],
.upper-bar-leave-to[data-v-4c914af2] {
    opacity: 0;
    -webkit-transform: translateY(-12px);
    transform: translateY(-12px);
}

.alert-snackbar[data-v-4c914af2] {
    position: fixed;
    left: 0;
    width: 100%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    z-index: 99999 !important;
}

.alert-snackbar--bottom[data-v-4c914af2] {
    bottom: 72px;
}

.alert-snackbar--upper[data-v-4c914af2] {
    top: 84px;
}

.alert-snackbar--msg[data-v-4c914af2] {
    color: #fff;
    margin: 4px 0;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.main-view[data-v-74d308bd] {
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
}
body {
    line-height: 1.7;
    margin: 0;
}

* {
    box-sizing: border-box;
}

img {
    vertical-align: middle;
}

.container {
    margin-left: auto;
    margin-right: auto;
    padding-left: 15px;
    padding-right: 15px;
}

.d-flex {
    display: flex;
}

.justify-content-center {
    justify-content: center;
}

.justify-content-between {
    justify-content: space-between;
}

.align-items-center {
    align-items: center;
}

.header-logo {
    white-space: nowrap;
}

.header-logo img {
    display: inline-block;
    height: 40px;
}

header .fake-group {
    align-items: center;
    display: flex;
    flex: 1 0 auto;
    height: 60px;
    justify-content: flex-end;
}

.menu-fake {
    border-radius: 2px;
    height: 20px;
    margin-right: 20px;
    max-width: 90%;
    width: 250px;
}

.fake-circle {
    border: 1px solid #eaeaea;
    border-radius: 50%;
    height: 42px;
    min-width: 42px;
}

.fake {
    animation-duration: 1s;
    animation-fill-mode: forwards;
    animation-iteration-count: infinite;
    animation-name: placeHolderShimmer;
    animation-timing-function: linear;
    background: #eaeaea;
    background: linear-gradient(295deg, #eaeaea 8%, #e0e0e0 28%, #eaeaea 50%);
    background-size: 1200px 300px;
    position: relative;
}

@keyframes placeHolderShimmer {
    0% {
        background-position: -600px 0;
    }

    to {
        background-position: 600px 0;
    }
}

.block-pushing {
    min-height: 100vh;
    width: 100%;
}

footer {
    background-color: #444;
    padding-top: 40px;
}

footer ul.list-unstyled {
    margin-bottom: 40px;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

footer ul.list-unstyled li:not(:first-of-type) {
    margin-top: 4px;
}

footer a {
    color: #fff;
}

footer a:focus,
footer a:hover,
footer h4 {
    color: #9c9da0;
}

footer h4 {
    margin-top: 0;
    margin-bottom: 16px;
    font-size: 16px;
    line-height: 24px;
    font-weight: 400;
}

footer p {
    font-size: 1.4rem;
    line-height: 20px;
    margin-bottom: 10px;
    color: #f4f4f4;
}

footer hr {
    border-top: 1px solid #666;
}

footer .cr-font {
    font-size: 1.4rem;
    padding: 0 15px;
    color: #f4f4f4;
}

footer .sns ul li {
    width: 36px;
    height: 36px;
    margin: 3px;
    text-align: center;
    background-color: #555;
    border-radius: 50%;
    display: inline-block;
    font-size: 21px;
}

footer .sns ul li:hover {
    background-color: #26bec9;
}

footer .sns ul li a {
    color: #fff;
    display: flex;
    align-items: center;
    justify-content: center;
    height: 100%;
    filter: grayscale(1);
}

footer .sns ul li a img {
    width: 19px;
}

footer .footer_links .footer_payment_channels {
    display: grid;
    grid-template-columns: repeat(auto-fit, 42px);
    gap: 8px;
    margin-bottom: 40px;
}

footer .footer_partners {
    padding: 0 15px;
    margin-bottom: 40px;
}

footer .footer_partners .footer_partners_logo {
    display: flex;
    flex-wrap: wrap;
    gap: 32px;
}

footer .footer_partners .footer_partners_logo img {
    height: 50px;
    object-fit: contain;
}

footer .footer_companyInfo {
    background-color: #333;
    color: #babbbe;
    padding-top: 32px;
    margin: 0;
}

footer .footer_companyInfo ul.list-unstyled {
    margin-bottom: 32px;
    font-size: 12px;
    line-height: 16px;
    font-weight: 400;
}

footer .footer_companyInfo a {
    color: #babbbe;
}

footer .footer_companyInfo .homepage-copyright {
    float: right;
}

footer .e-commerce {
    background-color: #333;
}

footer .e-commerce__item {
    margin-bottom: 20px;
}

footer .e-commerce__label {
    display: inline-block;
    width: 200px;
}

footer .e-commerce__label img {
    width: 100%;
}

#contact-kkday-row {
    margin: 15px 0 !important;
}

@media (min-width: 678px) {
    .container {
        width: 750px;
    }
}

@media (min-width: 992px) {
    .container {
        width: 970px;
    }

    .footer_companyInfo ul.list-unstyled.cr_align {
        text-align: right;
    }
}

@media (min-width: 1200px) {
    .container {
        width: 1170px;
    }
}
/*!
 * Cropper.js v1.5.11
 * https://fengyuanchen.github.io/cropperjs
 *
 * Copyright 2015-present Chen Fengyuan
 * Released under the MIT license
 *
 * Date: 2021-02-17T11:53:21.992Z
 */
.cropper-container {
    direction: ltr;
    font-size: 0;
    line-height: 0;
    position: relative;
    -ms-touch-action: none;
    touch-action: none;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

.cropper-container img {
    display: block;
    height: 100%;
    image-orientation: 0deg;
    max-height: none !important;
    max-width: none !important;
    min-height: 0 !important;
    min-width: 0 !important;
    width: 100%;
}

.cropper-canvas,
.cropper-crop-box,
.cropper-drag-box,
.cropper-modal,
.cropper-wrap-box {
    bottom: 0;
    left: 0;
    position: absolute;
    right: 0;
    top: 0;
}

.cropper-canvas,
.cropper-wrap-box {
    overflow: hidden;
}

.cropper-drag-box {
    background-color: #fff;
    opacity: 0;
}

.cropper-modal {
    background-color: #000;
    opacity: 0.5;
}

.cropper-view-box {
    display: block;
    height: 100%;
    outline: 1px solid #39f;
    outline-color: rgba(51, 153, 255, 0.75);
    overflow: hidden;
    width: 100%;
}

.cropper-dashed {
    border: 0 dashed #eee;
    display: block;
    opacity: 0.5;
    position: absolute;
}

.cropper-dashed.dashed-h {
    border-bottom-width: 1px;
    border-top-width: 1px;
    height: 33.33333%;
    left: 0;
    top: 33.33333%;
    width: 100%;
}

.cropper-dashed.dashed-v {
    border-left-width: 1px;
    border-right-width: 1px;
    height: 100%;
    left: 33.33333%;
    top: 0;
    width: 33.33333%;
}

.cropper-center {
    display: block;
    height: 0;
    left: 50%;
    opacity: 0.75;
    position: absolute;
    top: 50%;
    width: 0;
}

.cropper-center:after,
.cropper-center:before {
    background-color: #eee;
    content: ' ';
    display: block;
    position: absolute;
}

.cropper-center:before {
    height: 1px;
    left: -3px;
    top: 0;
    width: 7px;
}

.cropper-center:after {
    height: 7px;
    left: 0;
    top: -3px;
    width: 1px;
}

.cropper-face,
.cropper-line,
.cropper-point {
    display: block;
    height: 100%;
    opacity: 0.1;
    position: absolute;
    width: 100%;
}

.cropper-face {
    background-color: #fff;
    left: 0;
    top: 0;
}

.cropper-line {
    background-color: #39f;
}

.cropper-line.line-e {
    cursor: ew-resize;
    right: -3px;
    top: 0;
    width: 5px;
}

.cropper-line.line-n {
    cursor: ns-resize;
    height: 5px;
    left: 0;
    top: -3px;
}

.cropper-line.line-w {
    cursor: ew-resize;
    left: -3px;
    top: 0;
    width: 5px;
}

.cropper-line.line-s {
    bottom: -3px;
    cursor: ns-resize;
    height: 5px;
    left: 0;
}

.cropper-point {
    background-color: #39f;
    height: 5px;
    opacity: 0.75;
    width: 5px;
}

.cropper-point.point-e {
    cursor: ew-resize;
    margin-top: -3px;
    right: -3px;
    top: 50%;
}

.cropper-point.point-n {
    cursor: ns-resize;
    left: 50%;
    margin-left: -3px;
    top: -3px;
}

.cropper-point.point-w {
    cursor: ew-resize;
    left: -3px;
    margin-top: -3px;
    top: 50%;
}

.cropper-point.point-s {
    bottom: -3px;
    cursor: s-resize;
    left: 50%;
    margin-left: -3px;
}

.cropper-point.point-ne {
    cursor: nesw-resize;
    right: -3px;
    top: -3px;
}

.cropper-point.point-nw {
    cursor: nwse-resize;
    left: -3px;
    top: -3px;
}

.cropper-point.point-sw {
    bottom: -3px;
    cursor: nesw-resize;
    left: -3px;
}

.cropper-point.point-se {
    bottom: -3px;
    cursor: nwse-resize;
    height: 20px;
    opacity: 1;
    right: -3px;
    width: 20px;
}

@media (min-width: 768px) {
    .cropper-point.point-se {
        height: 15px;
        width: 15px;
    }
}

@media (min-width: 992px) {
    .cropper-point.point-se {
        height: 10px;
        width: 10px;
    }
}

@media (min-width: 1200px) {
    .cropper-point.point-se {
        height: 5px;
        opacity: 0.75;
        width: 5px;
    }
}

.cropper-point.point-se:before {
    background-color: #39f;
    bottom: -50%;
    content: ' ';
    display: block;
    height: 200%;
    opacity: 0;
    position: absolute;
    right: -50%;
    width: 200%;
}

.cropper-invisible {
    opacity: 0;
}

.cropper-bg {
    background-image: url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQAQMAAAAlPW0iAAAAA3NCSVQICAjb4U/gAAAABlBMVEXMzMz////TjRV2AAAACXBIWXMAAArrAAAK6wGCiw1aAAAAHHRFWHRTb2Z0d2FyZQBBZG9iZSBGaXJld29ya3MgQ1M26LyyjAAAABFJREFUCJlj+M/AgBVhF/0PAH6/D/HkDxOGAAAAAElFTkSuQmCC');
}

.cropper-hide {
    display: block;
    height: 0;
    position: absolute;
    width: 0;
}

.cropper-hidden {
    display: none !important;
}

.cropper-move {
    cursor: move;
}

.cropper-crop {
    cursor: crosshair;
}

.cropper-disabled .cropper-drag-box,
.cropper-disabled .cropper-face,
.cropper-disabled .cropper-line,
.cropper-disabled .cropper-point {
    cursor: not-allowed;
}

.owl-carousel,
.owl-carousel .owl-item {
    -webkit-tap-highlight-color: transparent;
    position: relative;
}

.owl-carousel {
    display: none;
    width: 100%;
    z-index: 1;
}

.owl-carousel .owl-stage {
    position: relative;
    -ms-touch-action: pan-Y;
    touch-action: manipulation;
    -moz-backface-visibility: hidden;
}

.owl-carousel .owl-stage:after {
    content: '.';
    display: block;
    clear: both;
    visibility: hidden;
    line-height: 0;
    height: 0;
}

.owl-carousel .owl-stage-outer {
    position: relative;
    overflow: hidden;
    -webkit-transform: translateZ(0);
}

.owl-carousel .owl-item,
.owl-carousel .owl-wrapper {
    -webkit-backface-visibility: hidden;
    -moz-backface-visibility: hidden;
    -ms-backface-visibility: hidden;
    -webkit-transform: translateZ(0);
    -moz-transform: translateZ(0);
    -ms-transform: translateZ(0);
}

.owl-carousel .owl-item {
    min-height: 1px;
    float: left;
    -webkit-backface-visibility: hidden;
    -webkit-touch-callout: none;
}

.owl-carousel .owl-item img {
    display: block;
    width: 100%;
}

.owl-carousel .owl-dots.disabled,
.owl-carousel .owl-nav.disabled {
    display: none;
}

.no-js .owl-carousel,
.owl-carousel.owl-loaded {
    display: block;
}

.owl-carousel .owl-dot,
.owl-carousel .owl-nav .owl-next,
.owl-carousel .owl-nav .owl-prev {
    cursor: pointer;
    -webkit-user-select: none;
    -khtml-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

.owl-carousel .owl-nav button.owl-next,
.owl-carousel .owl-nav button.owl-prev,
.owl-carousel button.owl-dot {
    background: 0 0;
    color: inherit;
    border: none;
    padding: 0 !important;
    font: inherit;
}

.owl-carousel.owl-loading {
    opacity: 0;
    display: block;
}

.owl-carousel.owl-hidden {
    opacity: 0;
}

.owl-carousel.owl-refresh .owl-item {
    visibility: hidden;
}

.owl-carousel.owl-drag .owl-item {
    -ms-touch-action: pan-y;
    touch-action: pan-y;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

.owl-carousel.owl-grab {
    cursor: move;
    cursor: grab;
}

.owl-carousel.owl-rtl {
    direction: rtl;
}

.owl-carousel.owl-rtl .owl-item {
    float: right;
}

.owl-carousel .animated {
    animation-duration: 1s;
    animation-fill-mode: both;
}

.owl-carousel .owl-animated-in {
    z-index: 0;
}

.owl-carousel .owl-animated-out {
    z-index: 1;
}

.owl-carousel .fadeOut {
    animation-name: fadeOut;
}

@keyframes fadeOut {
    0% {
        opacity: 1;
    }

    to {
        opacity: 0;
    }
}

.owl-height {
    transition: height 0.5s ease-in-out;
}

.owl-carousel .owl-item .owl-lazy {
    opacity: 0;
    transition: opacity 0.4s ease;
}

.owl-carousel .owl-item .owl-lazy:not([src]),
.owl-carousel .owl-item .owl-lazy[src^=''] {
    max-height: 0;
}

.owl-carousel .owl-item img.owl-lazy {
    transform-style: preserve-3d;
}

.owl-carousel .owl-video-wrapper {
    position: relative;
    height: 100%;
    background: #000;
}

.owl-carousel .owl-video-play-icon {
    position: absolute;
    height: 80px;
    width: 80px;
    left: 50%;
    top: 50%;
    margin-left: -40px;
    margin-top: -40px;
    background: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAMAAAC5zwKfAAADAFBMVEVHcEwAAAAAAAAAAAAAAAAAAAAAAAAGBgYEBAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGBgYAAAAAAAAAAAAAAAAAAAAAAAAFBQUAAAD9/f0AAAAAAAD+/v7////29vYAAAAAAAAAAAD8/PwBAQEAAAD+/v7x8fE4ODj4+Pju7u7////////q6uqKioqYmJgAAAD8/Py1tbX9/f34+Pj9/f2ioqLu7u79/f3l5eX////8/Pzq6ur39/fo6Oj9/f2np6fa2tr7+/v4+Pj////9/f3+/v7+/v5ra2vn5+cAAAAiIiJERETw8PD5+fn+/v77+/vr6+utra3x8fGOjo729vb7+/v5+fnx8fHX19fFxcXb29vi4uJZWVmenp61tbXu7u7n5+fr6+v9/f36+vrR0dHk5OTPz8/39/dcXFz7+/v8/PzKysr+/v63t7fu7u729vb4+Pj8/Pzv7+/z8/P9/f3U1NTw8PBWVlZeXl76+vr29vabm5vw8PD29vb19fW8vLzj4+MkJCTc3Nzg4ODf39/Q0NC+vr709PTz8/PX19fT09PS0tLOzs6YmJjw8PDp6en8/Pzj4+Pj4+PBwcH7+/v6+vqdnZ2Ojo729vbm5ubIyMh1dXUxMTGhoaELCwvT09M3Nzf9/f39/f35+fm+vr78/Py9vb2qqqr39/esrKzm5uaCgoK4uLibm5v5+flxcXH////Q0NDMzMz9/f3t7e3d3d38/Py/v7/m5ub7+/v7+/vs7OzCwsJ9fX309PT09PTk5OT6+vpNTU2xsbHR0dGAgIDg4ODW1takpKTOzs7k5OStra319fXW1tZHR0fj4+Obm5v7+/u/v7/c3NwzMzPm5uazs7PGxsbOzs7CwsKwsLDm5uZPT0+urq63t7d9fX3l5eW8vLxeXl4uLi7a2trDw8P9/f1ERESdnZ319fWHh4f9/f3e3t77+/vHx8dCQkLW1tbz8/PMzMzh4eHi4uL09PRsbGzz8/PDw8Nzc3P////GZWjoAAAA/3RSTlMABwgGBBkLAQIDDQ8THQkVLygSIDIKDiQfNSYQPCv1ESL5/uc4NhjzLBfw4UrbqAT7z21yN6GLv+21e9jLZxZjqB+R6TycQuf9h9L2Wsk0Q04le9uAxoTdY5uv8HmnmrS+DRYrm2qIdtR9m5bhMOprheOOzjXQ9m6y7K8RU1YvG2baXeWRwT+5WnNBM8XBNRpaJByub05SgkviyltCqsI1RyFON61Fz7lUeqeUe+wELGgSdzpgC6uj+dW8TJc72FhQi2Fn38TGPXunFGJQDj57Is1KEkhUjW+JD4ZafnKOTbVHiFhasIA8MphqnCk54FVzZHOgSbK4l8MakU5YjFkmdqVZAAAGrUlEQVRYw71ZdXwTVxy/JJeTeBqtppRK6rqywdC1DCkVpEVbbDjF3SnD3d1hDCgMdwYMnbu7MGfKfLu9310a0t5d7q77fPb+yeXee9/83IJh/++aca5to05RDLdiJl3s3vPCEbLeaK07d2IE1qAJS+l6gE7vOIoRXYNW96UUEvc1E3xVDlihgMzpfrjqDuXZBXviQtm166NPb/ZqMt63lTTAIZfKzr4rDe9m/2yPdBkTDSHcMpi1Rtf221t9mKmrVXIgjz3IHc8s3WMPMxp0JtzPG0nRGofe7N4+tIo70+IVWhJvoA/uaKzXbSBwPgkkrdIlDh/JQaY2lSLyPvZcVWmE16gXPUvSJsPw/Pasba4jgiGeeIDFm5xices1QZWIIHeOYQ8P0Ymz3bIRq9nGsWEGtaS4aWLHlzGsIPViiM1YvDPT7EYdLUN7JO75KiEYYvpjsNshxZuolmmyNPFBQ5ZrYcTusHe2KNKAy3YB0pQ3DG69qROQUFvY+S3C6sEVuCipyquEe+/xdd2ctb4iq4dW5PSkZj3I8c4OVV2FPASviyNDcIVRiVQtb4Oufmag+QZ9OstixhXHOdLUCpgb7KR4DJ8P1WrqEYfJtxaDc32jDny5FwwmItpRV7/75AQ9ehEkifxApr8Hho9HhvNUxWzpJ8OI8AHA4E7CfzIdcsfJUC1fgAwz6YU+kl5IPp2KAHrF+++PQF97FLsIUgCQYV56WSNFJP0MsLjZD9AOfT1lNwtYIBtP2vR/Uco4+wxC54bWILRGXxKmuhyYCCDDPNxUIvpQj4CiXaZ7OeRsoRCBmD/LLXk+uHL6gmM87uF+Fp6zrQQZDJBp0KpvML6pbhD5jKwDjgVq5xoFfSQwFafOVwUh8lUItl4dPP6Inu7aQ0gpQIaZuEic7+c2oAN/sijgJQetBCYNyCSsEzVKcgva/zseieUEeoiaZtTIAWSYcc+KGeUEtHs1Gjn0dPRQtstMywNkYtJEnPFCEtq94cSwJ9Fnb0s4KROQialcYBLie9k4tNnVwFnhKRERYsKl1+KFAkRSE9HOTS0XWnNrbFweINOg/0q+iP5AG+VGDINiobFNpQiQYYb9wMu1PSHiRGPYdfQ5U0TJWJCS85dtdfh+Cr2c58IwqN66anHFgMgZa1ecs0G71v8AWD2ydgr6C717FAFurB9gxuRiS23AGgqhQspWDHgmKyfMXDtIggwrrFxJc1AhYI8DEV4tUcdyOqKNWwgQAtn7yrQ8b5rdFs7zaQCa4/KZj00tH7DsaKzVzPe+dM6gMewS5Pgwh1zAhJ+KLEadgOu1hFz8D/KUEuhIvtDJBLx2vNAVIhi5W0MRPzceww5BovwuRFa0qSqNtcY7hCMd6GRWKIo2JBji5XhcGvD0yWKL0SmWBaCgzvWieIhBSt0qopVAvMwn4lzi3UEziK8pbJBZAaL+XCcBeP/oiEie6QUsiNPJcWb4Pfoier4tnAP8YbpiKjK9YLkejOa8xcnmK7DEMW5VEMAm2TlCphewSkDHV1yc4A4DCZv0opVDQnmRV9D0AtbroOMcn2pp0HNvQXcGvN4FhdEeiYpuRhKrYx9RZFMIR6/pSCHA5Max1kTJ3h2anOQIv9hUkAG7CJGYkZ8SxPTuuR0QeMDioQKrO+YNJ//e2rAwg0q6yN7PEhhgy6pV4NDD+catCidkdFZrgJ45lpB7gqEWwqsP+W0PKaetaDaKbUrcgfTgbwt0Q3IbH3YMkFW7KSGJJeD9nzjqMYNi29jyuDo6pfpBN1SZp1aMOIJri3lNCb6ArTC+1ShEnA29aHKKVU8JN5XD8pQhNs9Al8ZnWQx8I6Z0LdgwtV4J19zY6GPhNpZypsFu1ALZQ7Ip3NBtdI7bJEgErWdpZNJWyhsTjN3LJobcWJvYdInWD+E6kuUy3C19YHtubBRnE59W0c7B3Chv1TapgHCOG+JlFtiNwURE6TZnsgej0pYGgTy0phEXyndHREqMjShTfL6vnpw4/4jwT7ccsdHXpI6OdXmkWCHx8He6+FLJhv5rl9XBTC9p3j3Jt707xe6WMyWjCO3Ispp0l3S924RLY0t+nzJlxuFj+zrub9egZqciK07OEI8jUu9+d1bQIXHG5Kw4q5aQPYWiVB73pqHVYnBlc6YWWrU6XImTUiq91jXz16t8tCa5BTkWm5nAlcYlEjd5tK4bMy9XdJhV1SMhofrOmWu3Sq/MDfXaEvVqul7/CCBMvVlrC4u0WOxoWbxWl1tr0NUTrYZ3XO3QOfXhaOmdhEkjBfYvpX7J0Wnxft0AAAAASUVORK5CYII=)
        no-repeat;
    cursor: pointer;
    z-index: 1;
    -webkit-backface-visibility: hidden;
    transition: transform 0.1s ease;
}

.owl-carousel .owl-video-play-icon:hover {
    -ms-transform: scale(1.3);
    transform: scale(1.3);
}

.owl-carousel .owl-video-playing .owl-video-play-icon,
.owl-carousel .owl-video-playing .owl-video-tn {
    display: none;
}

.owl-carousel .owl-video-tn {
    opacity: 0;
    height: 100%;
    background-position: 50%;
    background-repeat: no-repeat;
    background-size: contain;
    transition: opacity 0.4s ease;
}

.owl-carousel .owl-video-frame {
    position: relative;
    z-index: 1;
    height: 100%;
    width: 100%;
}

.intl-tel-input {
    position: relative;
    display: inline-block;
}

.intl-tel-input * {
    box-sizing: border-box;
    -moz-box-sizing: border-box;
}

.intl-tel-input .hide {
    display: none;
}

.intl-tel-input .v-hide {
    visibility: hidden;
}

.intl-tel-input input,
.intl-tel-input input[type='tel'],
.intl-tel-input input[type='text'] {
    position: relative;
    z-index: 0;
    margin-top: 0 !important;
    margin-bottom: 0 !important;
    padding-right: 36px;
    margin-right: 0;
}

.intl-tel-input .flag-container {
    position: absolute;
    top: 0;
    bottom: 0;
    right: 0;
    padding: 1px;
}

.intl-tel-input .selected-flag {
    z-index: 1;
    position: relative;
    width: 36px;
    height: 100%;
    padding: 0 0 0 8px;
}

.intl-tel-input .selected-flag .iti-flag {
    position: absolute;
    top: 0;
    bottom: 0;
    margin: auto;
}

.intl-tel-input .selected-flag .iti-arrow {
    position: absolute;
    top: 50%;
    margin-top: -2px;
    right: 6px;
    width: 0;
    height: 0;
    border-left: 3px solid transparent;
    border-right: 3px solid transparent;
    border-top: 4px solid #555;
}

.intl-tel-input .selected-flag .iti-arrow.up {
    border-top: none;
    border-bottom: 4px solid #555;
}

.intl-tel-input .country-list {
    position: absolute;
    z-index: 2;
    list-style: none;
    text-align: left;
    padding: 0;
    margin: 0 0 0 -1px;
    box-shadow: 1px 1px 4px rgba(0, 0, 0, 0.2);
    background-color: #fff;
    border: 1px solid #ccc;
    white-space: nowrap;
    max-height: 200px;
    overflow-y: scroll;
}

.intl-tel-input .country-list.dropup {
    bottom: 100%;
    margin-bottom: -1px;
}

.intl-tel-input .country-list .flag-box {
    display: inline-block;
    width: 20px;
}

@media (max-width: 500px) {
    .intl-tel-input .country-list {
        white-space: normal;
    }
}

.intl-tel-input .country-list .divider {
    padding-bottom: 5px;
    margin-bottom: 5px;
    border-bottom: 1px solid #ccc;
}

.intl-tel-input .country-list .country {
    padding: 5px 10px;
}

.intl-tel-input .country-list .country .dial-code {
    color: #999;
}

.intl-tel-input .country-list .country.highlight {
    background-color: rgba(0, 0, 0, 0.05);
}

.intl-tel-input .country-list .country-name,
.intl-tel-input .country-list .dial-code,
.intl-tel-input .country-list .flag-box {
    vertical-align: middle;
}

.intl-tel-input .country-list .country-name,
.intl-tel-input .country-list .flag-box {
    margin-right: 6px;
}

.intl-tel-input.allow-dropdown input,
.intl-tel-input.allow-dropdown input[type='tel'],
.intl-tel-input.allow-dropdown input[type='text'],
.intl-tel-input.separate-dial-code input,
.intl-tel-input.separate-dial-code input[type='tel'],
.intl-tel-input.separate-dial-code input[type='text'] {
    padding-right: 6px;
    padding-left: 52px;
    margin-left: 0;
}

.intl-tel-input.allow-dropdown .flag-container,
.intl-tel-input.separate-dial-code .flag-container {
    right: auto;
    left: 0;
}

.intl-tel-input.allow-dropdown .selected-flag,
.intl-tel-input.separate-dial-code .selected-flag {
    width: 46px;
}

.intl-tel-input.allow-dropdown .flag-container:hover {
    cursor: pointer;
}

.intl-tel-input.allow-dropdown .flag-container:hover .selected-flag {
    background-color: rgba(0, 0, 0, 0.05);
}

.intl-tel-input.allow-dropdown input[disabled] + .flag-container:hover,
.intl-tel-input.allow-dropdown input[readonly] + .flag-container:hover {
    cursor: default;
}

.intl-tel-input.allow-dropdown
    input[disabled]
    + .flag-container:hover
    .selected-flag,
.intl-tel-input.allow-dropdown
    input[readonly]
    + .flag-container:hover
    .selected-flag {
    background-color: transparent;
}

.intl-tel-input.separate-dial-code .selected-flag {
    background-color: rgba(0, 0, 0, 0.05);
    display: table;
}

.intl-tel-input.separate-dial-code .selected-dial-code {
    display: table-cell;
    vertical-align: middle;
    padding-left: 28px;
}

.intl-tel-input.separate-dial-code.iti-sdc-2 input,
.intl-tel-input.separate-dial-code.iti-sdc-2 input[type='tel'],
.intl-tel-input.separate-dial-code.iti-sdc-2 input[type='text'] {
    padding-left: 66px;
}

.intl-tel-input.separate-dial-code.iti-sdc-2 .selected-flag {
    width: 60px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 input,
.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 input[type='tel'],
.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 input[type='text'] {
    padding-left: 76px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 .selected-flag {
    width: 70px;
}

.intl-tel-input.separate-dial-code.iti-sdc-3 input,
.intl-tel-input.separate-dial-code.iti-sdc-3 input[type='tel'],
.intl-tel-input.separate-dial-code.iti-sdc-3 input[type='text'] {
    padding-left: 74px;
}

.intl-tel-input.separate-dial-code.iti-sdc-3 .selected-flag {
    width: 68px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 input,
.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 input[type='tel'],
.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 input[type='text'] {
    padding-left: 84px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 .selected-flag {
    width: 78px;
}

.intl-tel-input.separate-dial-code.iti-sdc-4 input,
.intl-tel-input.separate-dial-code.iti-sdc-4 input[type='tel'],
.intl-tel-input.separate-dial-code.iti-sdc-4 input[type='text'] {
    padding-left: 82px;
}

.intl-tel-input.separate-dial-code.iti-sdc-4 .selected-flag {
    width: 76px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 input,
.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 input[type='tel'],
.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 input[type='text'] {
    padding-left: 92px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 .selected-flag {
    width: 86px;
}

.intl-tel-input.separate-dial-code.iti-sdc-5 input,
.intl-tel-input.separate-dial-code.iti-sdc-5 input[type='tel'],
.intl-tel-input.separate-dial-code.iti-sdc-5 input[type='text'] {
    padding-left: 90px;
}

.intl-tel-input.separate-dial-code.iti-sdc-5 .selected-flag {
    width: 84px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 input,
.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 input[type='tel'],
.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 input[type='text'] {
    padding-left: 100px;
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 .selected-flag {
    width: 94px;
}

.intl-tel-input.iti-container {
    position: absolute;
    top: -1000px;
    left: -1000px;
    z-index: 1060;
    padding: 1px;
}

.intl-tel-input.iti-container:hover {
    cursor: pointer;
}

.iti-mobile .intl-tel-input.iti-container {
    top: 30px;
    bottom: 30px;
    left: 30px;
    right: 30px;
    position: fixed;
}

.iti-mobile .intl-tel-input .country-list {
    max-height: 100%;
    width: 100%;
}

.iti-mobile .intl-tel-input .country-list .country {
    padding: 10px;
    line-height: 1.5em;
}

.iti-flag.be {
    width: 18px;
}

.iti-flag.ch {
    width: 15px;
}

.iti-flag.mc {
    width: 19px;
}

.iti-flag.ne {
    width: 18px;
}

.iti-flag.np {
    width: 13px;
}

.iti-flag.va {
    width: 15px;
}

@media only screen and (-o-min-device-pixel-ratio: 2/1),
    only screen and (-webkit-min-device-pixel-ratio: 2),
    only screen and (min--moz-device-pixel-ratio: 2),
    only screen and (min-device-pixel-ratio: 2),
    only screen and (min-resolution: 2dppx),
    only screen and (min-resolution: 192dpi) {
    .iti-flag {
        background-size: 5630px 15px;
    }
}

.iti-flag.ac {
    height: 10px;
    background-position: 0 0;
}

.iti-flag.ad {
    height: 14px;
    background-position: -22px 0;
}

.iti-flag.ae {
    height: 10px;
    background-position: -44px 0;
}

.iti-flag.af {
    height: 14px;
    background-position: -66px 0;
}

.iti-flag.ag {
    height: 14px;
    background-position: -88px 0;
}

.iti-flag.ai {
    height: 10px;
    background-position: -110px 0;
}

.iti-flag.al {
    height: 15px;
    background-position: -132px 0;
}

.iti-flag.am {
    height: 10px;
    background-position: -154px 0;
}

.iti-flag.ao {
    height: 14px;
    background-position: -176px 0;
}

.iti-flag.aq {
    height: 14px;
    background-position: -198px 0;
}

.iti-flag.ar {
    height: 13px;
    background-position: -220px 0;
}

.iti-flag.as {
    height: 10px;
    background-position: -242px 0;
}

.iti-flag.at {
    height: 14px;
    background-position: -264px 0;
}

.iti-flag.au {
    height: 10px;
    background-position: -286px 0;
}

.iti-flag.aw {
    height: 14px;
    background-position: -308px 0;
}

.iti-flag.ax {
    height: 13px;
    background-position: -330px 0;
}

.iti-flag.az {
    height: 10px;
    background-position: -352px 0;
}

.iti-flag.ba {
    height: 10px;
    background-position: -374px 0;
}

.iti-flag.bb {
    height: 14px;
    background-position: -396px 0;
}

.iti-flag.bd {
    height: 12px;
    background-position: -418px 0;
}

.iti-flag.be {
    height: 15px;
    background-position: -440px 0;
}

.iti-flag.bf {
    height: 14px;
    background-position: -460px 0;
}

.iti-flag.bg {
    height: 12px;
    background-position: -482px 0;
}

.iti-flag.bh {
    height: 12px;
    background-position: -504px 0;
}

.iti-flag.bi {
    height: 12px;
    background-position: -526px 0;
}

.iti-flag.bj {
    height: 14px;
    background-position: -548px 0;
}

.iti-flag.bl {
    height: 14px;
    background-position: -570px 0;
}

.iti-flag.bm {
    height: 10px;
    background-position: -592px 0;
}

.iti-flag.bn {
    height: 10px;
    background-position: -614px 0;
}

.iti-flag.bo {
    height: 14px;
    background-position: -636px 0;
}

.iti-flag.bq {
    height: 14px;
    background-position: -658px 0;
}

.iti-flag.br {
    height: 14px;
    background-position: -680px 0;
}

.iti-flag.bs {
    height: 10px;
    background-position: -702px 0;
}

.iti-flag.bt {
    height: 14px;
    background-position: -724px 0;
}

.iti-flag.bv {
    height: 15px;
    background-position: -746px 0;
}

.iti-flag.bw {
    height: 14px;
    background-position: -768px 0;
}

.iti-flag.by {
    height: 10px;
    background-position: -790px 0;
}

.iti-flag.bz {
    height: 14px;
    background-position: -812px 0;
}

.iti-flag.ca {
    height: 10px;
    background-position: -834px 0;
}

.iti-flag.cc {
    height: 10px;
    background-position: -856px 0;
}

.iti-flag.cd {
    height: 15px;
    background-position: -878px 0;
}

.iti-flag.cf {
    height: 14px;
    background-position: -900px 0;
}

.iti-flag.cg {
    height: 14px;
    background-position: -922px 0;
}

.iti-flag.ch {
    height: 15px;
    background-position: -944px 0;
}

.iti-flag.ci {
    height: 14px;
    background-position: -961px 0;
}

.iti-flag.ck {
    height: 10px;
    background-position: -983px 0;
}

.iti-flag.cl {
    height: 14px;
    background-position: -1005px 0;
}

.iti-flag.cm {
    height: 14px;
    background-position: -1027px 0;
}

.iti-flag.cn {
    height: 14px;
    background-position: -1049px 0;
}

.iti-flag.co {
    height: 14px;
    background-position: -1071px 0;
}

.iti-flag.cp {
    height: 14px;
    background-position: -1093px 0;
}

.iti-flag.cr {
    height: 12px;
    background-position: -1115px 0;
}

.iti-flag.cu {
    height: 10px;
    background-position: -1137px 0;
}

.iti-flag.cv {
    height: 12px;
    background-position: -1159px 0;
}

.iti-flag.cw {
    height: 14px;
    background-position: -1181px 0;
}

.iti-flag.cx {
    height: 10px;
    background-position: -1203px 0;
}

.iti-flag.cy {
    height: 13px;
    background-position: -1225px 0;
}

.iti-flag.cz {
    height: 14px;
    background-position: -1247px 0;
}

.iti-flag.de {
    height: 12px;
    background-position: -1269px 0;
}

.iti-flag.dg {
    height: 10px;
    background-position: -1291px 0;
}

.iti-flag.dj {
    height: 14px;
    background-position: -1313px 0;
}

.iti-flag.dk {
    height: 15px;
    background-position: -1335px 0;
}

.iti-flag.dm {
    height: 10px;
    background-position: -1357px 0;
}

.iti-flag.do {
    height: 13px;
    background-position: -1379px 0;
}

.iti-flag.dz {
    height: 14px;
    background-position: -1401px 0;
}

.iti-flag.ea {
    height: 14px;
    background-position: -1423px 0;
}

.iti-flag.ec {
    height: 14px;
    background-position: -1445px 0;
}

.iti-flag.ee {
    height: 13px;
    background-position: -1467px 0;
}

.iti-flag.eg {
    height: 14px;
    background-position: -1489px 0;
}

.iti-flag.eh {
    height: 10px;
    background-position: -1511px 0;
}

.iti-flag.er {
    height: 10px;
    background-position: -1533px 0;
}

.iti-flag.es {
    height: 14px;
    background-position: -1555px 0;
}

.iti-flag.et {
    height: 10px;
    background-position: -1577px 0;
}

.iti-flag.eu {
    height: 14px;
    background-position: -1599px 0;
}

.iti-flag.fi {
    height: 12px;
    background-position: -1621px 0;
}

.iti-flag.fj {
    height: 10px;
    background-position: -1643px 0;
}

.iti-flag.fk {
    height: 10px;
    background-position: -1665px 0;
}

.iti-flag.fm {
    height: 11px;
    background-position: -1687px 0;
}

.iti-flag.fo {
    height: 15px;
    background-position: -1709px 0;
}

.iti-flag.fr {
    height: 14px;
    background-position: -1731px 0;
}

.iti-flag.ga {
    height: 15px;
    background-position: -1753px 0;
}

.iti-flag.gb {
    height: 10px;
    background-position: -1775px 0;
}

.iti-flag.gd {
    height: 12px;
    background-position: -1797px 0;
}

.iti-flag.ge {
    height: 14px;
    background-position: -1819px 0;
}

.iti-flag.gf {
    height: 14px;
    background-position: -1841px 0;
}

.iti-flag.gg {
    height: 14px;
    background-position: -1863px 0;
}

.iti-flag.gh {
    height: 14px;
    background-position: -1885px 0;
}

.iti-flag.gi {
    height: 10px;
    background-position: -1907px 0;
}

.iti-flag.gl {
    height: 14px;
    background-position: -1929px 0;
}

.iti-flag.gm {
    height: 14px;
    background-position: -1951px 0;
}

.iti-flag.gn {
    height: 14px;
    background-position: -1973px 0;
}

.iti-flag.gp {
    height: 14px;
    background-position: -1995px 0;
}

.iti-flag.gq {
    height: 14px;
    background-position: -2017px 0;
}

.iti-flag.gr {
    height: 14px;
    background-position: -2039px 0;
}

.iti-flag.gs {
    height: 10px;
    background-position: -2061px 0;
}

.iti-flag.gt {
    height: 13px;
    background-position: -2083px 0;
}

.iti-flag.gu {
    height: 11px;
    background-position: -2105px 0;
}

.iti-flag.gw {
    height: 10px;
    background-position: -2127px 0;
}

.iti-flag.gy {
    height: 12px;
    background-position: -2149px 0;
}

.iti-flag.hk {
    height: 14px;
    background-position: -2171px 0;
}

.iti-flag.hm {
    height: 10px;
    background-position: -2193px 0;
}

.iti-flag.hn {
    height: 10px;
    background-position: -2215px 0;
}

.iti-flag.hr {
    height: 10px;
    background-position: -2237px 0;
}

.iti-flag.ht {
    height: 12px;
    background-position: -2259px 0;
}

.iti-flag.hu {
    height: 10px;
    background-position: -2281px 0;
}

.iti-flag.ic {
    height: 14px;
    background-position: -2303px 0;
}

.iti-flag.id {
    height: 14px;
    background-position: -2325px 0;
}

.iti-flag.ie {
    height: 10px;
    background-position: -2347px 0;
}

.iti-flag.il {
    height: 15px;
    background-position: -2369px 0;
}

.iti-flag.im {
    height: 10px;
    background-position: -2391px 0;
}

.iti-flag.in {
    height: 14px;
    background-position: -2413px 0;
}

.iti-flag.io {
    height: 10px;
    background-position: -2435px 0;
}

.iti-flag.iq {
    height: 14px;
    background-position: -2457px 0;
}

.iti-flag.ir {
    height: 12px;
    background-position: -2479px 0;
}

.iti-flag.is {
    height: 15px;
    background-position: -2501px 0;
}

.iti-flag.it {
    height: 14px;
    background-position: -2523px 0;
}

.iti-flag.je {
    height: 12px;
    background-position: -2545px 0;
}

.iti-flag.jm {
    height: 10px;
    background-position: -2567px 0;
}

.iti-flag.jo {
    height: 10px;
    background-position: -2589px 0;
}

.iti-flag.jp {
    height: 14px;
    background-position: -2611px 0;
}

.iti-flag.ke {
    height: 14px;
    background-position: -2633px 0;
}

.iti-flag.kg {
    height: 12px;
    background-position: -2655px 0;
}

.iti-flag.kh {
    height: 13px;
    background-position: -2677px 0;
}

.iti-flag.ki {
    height: 10px;
    background-position: -2699px 0;
}

.iti-flag.km {
    height: 12px;
    background-position: -2721px 0;
}

.iti-flag.kn {
    height: 14px;
    background-position: -2743px 0;
}

.iti-flag.kp {
    height: 10px;
    background-position: -2765px 0;
}

.iti-flag.kr {
    height: 14px;
    background-position: -2787px 0;
}

.iti-flag.kw {
    height: 10px;
    background-position: -2809px 0;
}

.iti-flag.ky {
    height: 10px;
    background-position: -2831px 0;
}

.iti-flag.kz {
    height: 10px;
    background-position: -2853px 0;
}

.iti-flag.la {
    height: 14px;
    background-position: -2875px 0;
}

.iti-flag.lb {
    height: 14px;
    background-position: -2897px 0;
}

.iti-flag.lc {
    height: 10px;
    background-position: -2919px 0;
}

.iti-flag.li {
    height: 12px;
    background-position: -2941px 0;
}

.iti-flag.lk {
    height: 10px;
    background-position: -2963px 0;
}

.iti-flag.lr {
    height: 11px;
    background-position: -2985px 0;
}

.iti-flag.ls {
    height: 14px;
    background-position: -3007px 0;
}

.iti-flag.lt {
    height: 12px;
    background-position: -3029px 0;
}

.iti-flag.lu {
    height: 12px;
    background-position: -3051px 0;
}

.iti-flag.lv {
    height: 10px;
    background-position: -3073px 0;
}

.iti-flag.ly {
    height: 10px;
    background-position: -3095px 0;
}

.iti-flag.ma {
    height: 14px;
    background-position: -3117px 0;
}

.iti-flag.mc {
    height: 15px;
    background-position: -3139px 0;
}

.iti-flag.md {
    height: 10px;
    background-position: -3160px 0;
}

.iti-flag.me {
    height: 10px;
    background-position: -3182px 0;
}

.iti-flag.mf {
    height: 14px;
    background-position: -3204px 0;
}

.iti-flag.mg {
    height: 14px;
    background-position: -3226px 0;
}

.iti-flag.mh {
    height: 11px;
    background-position: -3248px 0;
}

.iti-flag.mk {
    height: 10px;
    background-position: -3270px 0;
}

.iti-flag.ml {
    height: 14px;
    background-position: -3292px 0;
}

.iti-flag.mm {
    height: 14px;
    background-position: -3314px 0;
}

.iti-flag.mn {
    height: 10px;
    background-position: -3336px 0;
}

.iti-flag.mo {
    height: 14px;
    background-position: -3358px 0;
}

.iti-flag.mp {
    height: 10px;
    background-position: -3380px 0;
}

.iti-flag.mq {
    height: 14px;
    background-position: -3402px 0;
}

.iti-flag.mr {
    height: 14px;
    background-position: -3424px 0;
}

.iti-flag.ms {
    height: 10px;
    background-position: -3446px 0;
}

.iti-flag.mt {
    height: 14px;
    background-position: -3468px 0;
}

.iti-flag.mu {
    height: 14px;
    background-position: -3490px 0;
}

.iti-flag.mv {
    height: 14px;
    background-position: -3512px 0;
}

.iti-flag.mw {
    height: 14px;
    background-position: -3534px 0;
}

.iti-flag.mx {
    height: 12px;
    background-position: -3556px 0;
}

.iti-flag.my {
    height: 10px;
    background-position: -3578px 0;
}

.iti-flag.mz {
    height: 14px;
    background-position: -3600px 0;
}

.iti-flag.na {
    height: 14px;
    background-position: -3622px 0;
}

.iti-flag.nc {
    height: 10px;
    background-position: -3644px 0;
}

.iti-flag.ne {
    height: 15px;
    background-position: -3666px 0;
}

.iti-flag.nf {
    height: 10px;
    background-position: -3686px 0;
}

.iti-flag.ng {
    height: 10px;
    background-position: -3708px 0;
}

.iti-flag.ni {
    height: 12px;
    background-position: -3730px 0;
}

.iti-flag.nl {
    height: 14px;
    background-position: -3752px 0;
}

.iti-flag.no {
    height: 15px;
    background-position: -3774px 0;
}

.iti-flag.np {
    height: 15px;
    background-position: -3796px 0;
}

.iti-flag.nr {
    height: 10px;
    background-position: -3811px 0;
}

.iti-flag.nu {
    height: 10px;
    background-position: -3833px 0;
}

.iti-flag.nz {
    height: 10px;
    background-position: -3855px 0;
}

.iti-flag.om {
    height: 10px;
    background-position: -3877px 0;
}

.iti-flag.pa {
    height: 14px;
    background-position: -3899px 0;
}

.iti-flag.pe {
    height: 14px;
    background-position: -3921px 0;
}

.iti-flag.pf {
    height: 14px;
    background-position: -3943px 0;
}

.iti-flag.pg {
    height: 15px;
    background-position: -3965px 0;
}

.iti-flag.ph {
    height: 10px;
    background-position: -3987px 0;
}

.iti-flag.pk {
    height: 14px;
    background-position: -4009px 0;
}

.iti-flag.pl {
    height: 13px;
    background-position: -4031px 0;
}

.iti-flag.pm {
    height: 14px;
    background-position: -4053px 0;
}

.iti-flag.pn {
    height: 10px;
    background-position: -4075px 0;
}

.iti-flag.pr {
    height: 14px;
    background-position: -4097px 0;
}

.iti-flag.ps {
    height: 10px;
    background-position: -4119px 0;
}

.iti-flag.pt {
    height: 14px;
    background-position: -4141px 0;
}

.iti-flag.pw {
    height: 13px;
    background-position: -4163px 0;
}

.iti-flag.py {
    height: 11px;
    background-position: -4185px 0;
}

.iti-flag.qa {
    height: 8px;
    background-position: -4207px 0;
}

.iti-flag.re {
    height: 14px;
    background-position: -4229px 0;
}

.iti-flag.ro {
    height: 14px;
    background-position: -4251px 0;
}

.iti-flag.rs {
    height: 14px;
    background-position: -4273px 0;
}

.iti-flag.ru {
    height: 14px;
    background-position: -4295px 0;
}

.iti-flag.rw {
    height: 14px;
    background-position: -4317px 0;
}

.iti-flag.sa {
    height: 14px;
    background-position: -4339px 0;
}

.iti-flag.sb {
    height: 10px;
    background-position: -4361px 0;
}

.iti-flag.sc {
    height: 10px;
    background-position: -4383px 0;
}

.iti-flag.sd {
    height: 10px;
    background-position: -4405px 0;
}

.iti-flag.se {
    height: 13px;
    background-position: -4427px 0;
}

.iti-flag.sg {
    height: 14px;
    background-position: -4449px 0;
}

.iti-flag.sh {
    height: 10px;
    background-position: -4471px 0;
}

.iti-flag.si {
    height: 10px;
    background-position: -4493px 0;
}

.iti-flag.sj {
    height: 15px;
    background-position: -4515px 0;
}

.iti-flag.sk {
    height: 14px;
    background-position: -4537px 0;
}

.iti-flag.sl {
    height: 14px;
    background-position: -4559px 0;
}

.iti-flag.sm {
    height: 15px;
    background-position: -4581px 0;
}

.iti-flag.sn {
    height: 14px;
    background-position: -4603px 0;
}

.iti-flag.so {
    height: 14px;
    background-position: -4625px 0;
}

.iti-flag.sr {
    height: 14px;
    background-position: -4647px 0;
}

.iti-flag.ss {
    height: 10px;
    background-position: -4669px 0;
}

.iti-flag.st {
    height: 10px;
    background-position: -4691px 0;
}

.iti-flag.sv {
    height: 12px;
    background-position: -4713px 0;
}

.iti-flag.sx {
    height: 14px;
    background-position: -4735px 0;
}

.iti-flag.sy {
    height: 14px;
    background-position: -4757px 0;
}

.iti-flag.sz {
    height: 14px;
    background-position: -4779px 0;
}

.iti-flag.ta {
    height: 10px;
    background-position: -4801px 0;
}

.iti-flag.tc {
    height: 10px;
    background-position: -4823px 0;
}

.iti-flag.td {
    height: 14px;
    background-position: -4845px 0;
}

.iti-flag.tf {
    height: 14px;
    background-position: -4867px 0;
}

.iti-flag.tg {
    height: 13px;
    background-position: -4889px 0;
}

.iti-flag.th {
    height: 14px;
    background-position: -4911px 0;
}

.iti-flag.tj {
    height: 10px;
    background-position: -4933px 0;
}

.iti-flag.tk {
    height: 10px;
    background-position: -4955px 0;
}

.iti-flag.tl {
    height: 10px;
    background-position: -4977px 0;
}

.iti-flag.tm {
    height: 14px;
    background-position: -4999px 0;
}

.iti-flag.tn {
    height: 14px;
    background-position: -5021px 0;
}

.iti-flag.to {
    height: 10px;
    background-position: -5043px 0;
}

.iti-flag.tr {
    height: 14px;
    background-position: -5065px 0;
}

.iti-flag.tt {
    height: 12px;
    background-position: -5087px 0;
}

.iti-flag.tv {
    height: 10px;
    background-position: -5109px 0;
}

.iti-flag.tw {
    height: 14px;
    background-position: -5131px 0;
}

.iti-flag.tz {
    height: 14px;
    background-position: -5153px 0;
}

.iti-flag.ua {
    height: 14px;
    background-position: -5175px 0;
}

.iti-flag.ug {
    height: 14px;
    background-position: -5197px 0;
}

.iti-flag.um {
    height: 11px;
    background-position: -5219px 0;
}

.iti-flag.us {
    height: 11px;
    background-position: -5241px 0;
}

.iti-flag.uy {
    height: 14px;
    background-position: -5263px 0;
}

.iti-flag.uz {
    height: 10px;
    background-position: -5285px 0;
}

.iti-flag.va {
    height: 15px;
    background-position: -5307px 0;
}

.iti-flag.vc {
    height: 14px;
    background-position: -5324px 0;
}

.iti-flag.ve {
    height: 14px;
    background-position: -5346px 0;
}

.iti-flag.vg {
    height: 10px;
    background-position: -5368px 0;
}

.iti-flag.vi {
    height: 14px;
    background-position: -5390px 0;
}

.iti-flag.vn {
    height: 14px;
    background-position: -5412px 0;
}

.iti-flag.vu {
    height: 12px;
    background-position: -5434px 0;
}

.iti-flag.wf {
    height: 14px;
    background-position: -5456px 0;
}

.iti-flag.ws {
    height: 10px;
    background-position: -5478px 0;
}

.iti-flag.xk {
    height: 15px;
    background-position: -5500px 0;
}

.iti-flag.ye {
    height: 14px;
    background-position: -5522px 0;
}

.iti-flag.yt {
    height: 14px;
    background-position: -5544px 0;
}

.iti-flag.za {
    height: 14px;
    background-position: -5566px 0;
}

.iti-flag.zm {
    height: 14px;
    background-position: -5588px 0;
}

.iti-flag.zw {
    height: 10px;
    background-position: -5610px 0;
}

.iti-flag {
    width: 20px;
    height: 15px;
    box-shadow: 0 0 1px 0 #888;
    background-image: url(https://cdn.kkday.com/pc-web/pc/dist/img/flags.376404854f9a9419b3b2e5c4a7bee788.png);
    background-repeat: no-repeat;
    background-color: #dbdbdb;
    background-position: 20px 0;
}

@media only screen and (-o-min-device-pixel-ratio: 2/1),
    only screen and (-webkit-min-device-pixel-ratio: 2),
    only screen and (min--moz-device-pixel-ratio: 2),
    only screen and (min-device-pixel-ratio: 2),
    only screen and (min-resolution: 2dppx),
    only screen and (min-resolution: 192dpi) {
    .iti-flag {
        background-image: url(https://cdn.kkday.com/pc-web/pc/dist/img/flags@2x.f8537027fd9a8ea127ca2d9eef84f68f.png);
    }
}

.iti-flag.np {
    background-color: transparent;
}

.irs {
    -webkit-touch-callout: none;
    -webkit-user-select: none;
    -khtml-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

.irs,
.irs-line {
    position: relative;
    display: block;
}

.irs-line {
    overflow: hidden;
    outline: none !important;
}

.irs-line-left,
.irs-line-mid,
.irs-line-right {
    position: absolute;
    display: block;
    top: 0;
}

.irs-line-left {
    left: 0;
    width: 11%;
}

.irs-line-mid {
    left: 9%;
    width: 82%;
}

.irs-line-right {
    right: 0;
    width: 11%;
}

.irs-bar {
    width: 0;
}

.irs-bar,
.irs-bar-edge {
    position: absolute;
    display: block;
    left: 0;
}

.irs-bar-edge {
    top: 0;
}

.irs-shadow {
    position: absolute;
    display: none;
    left: 0;
    width: 0;
}

.irs-slider {
    position: absolute;
    display: block;
    cursor: default;
    z-index: 1;
}

.irs-slider.type_last {
    z-index: 2;
}

.irs-min {
    left: 0;
}

.irs-max,
.irs-min {
    position: absolute;
    display: block;
    cursor: default;
}

.irs-max {
    right: 0;
}

.irs-from,
.irs-single,
.irs-to {
    position: absolute;
    display: block;
    top: 0;
    left: 0;
    cursor: default;
    white-space: nowrap;
}

.irs-grid {
    position: absolute;
    display: none;
    bottom: 0;
    left: 0;
    width: 100%;
    height: 20px;
}

.irs-with-grid .irs-grid {
    display: block;
}

.irs-grid-pol {
    position: absolute;
    top: 0;
    left: 0;
    width: 1px;
    height: 8px;
    background: #000;
}

.irs-grid-pol.small {
    height: 4px;
}

.irs-grid-text {
    position: absolute;
    bottom: 0;
    left: 0;
    white-space: nowrap;
    text-align: center;
    font-size: 9px;
    line-height: 9px;
    padding: 0 3px;
    color: #000;
}

.irs-disable-mask {
    position: absolute;
    display: block;
    top: 0;
    left: -1%;
    width: 102%;
    height: 100%;
    cursor: default;
    background: transparent;
    z-index: 2;
}

.lt-ie9 .irs-disable-mask {
    background: #000;
    filter: alpha(opacity=0);
    cursor: not-allowed;
}

.irs-disabled {
    opacity: 0.4;
}

.irs-hidden-input {
    position: absolute !important;
    display: block !important;
    top: 0 !important;
    left: 0 !important;
    width: 0 !important;
    height: 0 !important;
    font-size: 0 !important;
    line-height: 0 !important;
    padding: 0 !important;
    margin: 0 !important;
    overflow: hidden;
    outline: none !important;
    z-index: -9999 !important;
    background: none !important;
    border-style: solid !important;
    border-color: transparent !important;
}

.irs {
    height: 55px;
}

.irs-with-grid {
    height: 75px;
}

.irs-line {
    height: 10px;
    top: 33px;
    background: #eee;
    background: linear-gradient(180deg, #ddd -50%, #fff 150%);
    border: 1px solid #ccc;
    border-radius: 16px;
    -moz-border-radius: 16px;
}

.irs-line-left,
.irs-line-mid,
.irs-line-right {
    height: 8px;
}

.irs-bar {
    border-top: 1px solid #428bca;
    border-bottom: 1px solid #428bca;
}

.irs-bar,
.irs-bar-edge {
    height: 10px;
    top: 33px;
    background: #428bca;
    background: linear-gradient(0deg, #428bca 0, #7fc3e8);
}

.irs-bar-edge {
    width: 14px;
    border: 1px solid #428bca;
    border-right: 0;
    border-radius: 16px 0 0 16px;
    -moz-border-radius: 16px 0 0 16px;
}

.irs-shadow {
    height: 2px;
    top: 38px;
    background: #000;
    opacity: 0.3;
    border-radius: 5px;
    -moz-border-radius: 5px;
}

.lt-ie9 .irs-shadow {
    filter: alpha(opacity=30);
}

.irs-slider {
    top: 25px;
    width: 27px;
    height: 27px;
    border: 1px solid #aaa;
    background: #ddd;
    background: linear-gradient(180deg, #fff 0, #dcdcdc 20%, #fff);
    border-radius: 27px;
    -moz-border-radius: 27px;
    box-shadow: 1px 1px 3px rgba(0, 0, 0, 0.3);
    cursor: pointer;
}

.irs-slider.state_hover,
.irs-slider:hover {
    background: #fff;
}

.irs-max,
.irs-min {
    color: #333;
    font-size: 12px;
    line-height: 1.333;
    text-shadow: none;
    top: 0;
    padding: 1px 5px;
    background: rgba(0, 0, 0, 0.1);
    border-radius: 3px;
    -moz-border-radius: 3px;
}

.lt-ie9 .irs-max,
.lt-ie9 .irs-min {
    background: #ccc;
}

.irs-from,
.irs-single,
.irs-to {
    color: #fff;
    font-size: 14px;
    line-height: 1.333;
    text-shadow: none;
    padding: 1px 5px;
    background: #428bca;
    border-radius: 3px;
    -moz-border-radius: 3px;
}

.lt-ie9 .irs-from,
.lt-ie9 .irs-single,
.lt-ie9 .irs-to {
    background: #999;
}

.irs-grid {
    height: 27px;
}

.irs-grid-pol {
    opacity: 0.5;
    background: #428bca;
}

.irs-grid-pol.small {
    background: #999;
}

.irs-grid-text {
    bottom: 5px;
    color: #99a4ac;
}

:root {
    --kk-font-size-1: 12px;
    --kk-font-size-2: 14px;
    --kk-font-size-3: 16px;
    --kk-font-size-4: 18px;
    --kk-font-size-5: 22px;
    --kk-font-size-6: 24px;
    --kk-font-size-7: 26px;
    --kk-font-size-8: 28px;
    --kk-font-size-9: 32px;
    --kk-font-weight-light: 300;
    --kk-font-weight-regular: 400;
    --kk-font-weight-medium: 500;
    --kk-font-weight-medium-android: 600;
    --kk-font-weight-bold: 700;
    --kk-text-h4-font-size: 24px;
    --kk-text-h4-line-height: 30px;
    --kk-text-h4-font-weight: 700;
    --kk-text-h5-font-size: 22px;
    --kk-text-h5-line-height: 28px;
    --kk-text-h5-font-weight: 700;
    --kk-text-h6-font-size: 18px;
    --kk-text-h6-line-height: 26px;
    --kk-text-h6-font-weight: 700;
    --kk-text-subtitle-lg-font-size: 16px;
    --kk-text-subtitle-lg-line-height: 24px;
    --kk-text-subtitle-lg-font-weight: 700;
    --kk-text-subtitle-md-font-size: 14px;
    --kk-text-subtitle-md-line-height: 20px;
    --kk-text-subtitle-md-font-weight: 500;
    --kk-text-body-lg-font-size: 16px;
    --kk-text-body-lg-line-height: 24px;
    --kk-text-body-lg-font-weight: 400;
    --kk-text-body-md-font-size: 14px;
    --kk-text-body-md-line-height: 20px;
    --kk-text-body-md-font-weight: 400;
    --kk-text-body-sm-font-size: 12px;
    --kk-text-body-sm-line-height: 16px;
    --kk-text-body-sm-font-weight: 400;
    --kk-text-category-font-size: 12px;
    --kk-text-category-line-height: 16px;
    --kk-text-category-font-weight: 400;
    --kk-color-white: #fff;
    --kk-color-text-lighter: #d5d6db;
    --kk-color-text-light: #babbbe;
    --kk-color-text-medium: #9c9da0;
    --kk-color-text-dark: #727272;
    --kk-color-text-darker: #212121;
    --kk-color-text-primary-lighter: #cef0f3;
    --kk-color-text-primary-light: #ade6eb;
    --kk-color-text-primary-medium: #26bec9;
    --kk-color-text-primary-dark: #13a3b6;
    --kk-color-text-primary-darker: #068b9f;
    --kk-color-text-critical-lighter: #f5a8a4;
    --kk-color-text-critical-light: #f2918a;
    --kk-color-text-critical-medium: #ef7a70;
    --kk-color-text-critical-dark: #e65f50;
    --kk-color-text-critical-darker: #d14330;
    --kk-color-text-info-lighter: #9dd3fa;
    --kk-color-text-info-light: #81c4f7;
    --kk-color-text-info-medium: #64b3f4;
    --kk-color-text-info-dark: #2d84d6;
    --kk-color-text-info-darker: #1565c0;
    --kk-color-text-warning-lighter: #fee269;
    --kk-color-text-warning-light: #facf58;
    --kk-color-text-warning-medium: #f5b53d;
    --kk-color-text-warning-dark: #e78f37;
    --kk-color-text-warning-darker: #de6928;
    --kk-color-text-highlight-lighter: #ffca28;
    --kk-color-text-highlight-light: #ffc128;
    --kk-color-text-highlight-medium: #ffb400;
    --kk-color-text-highlight-dark: #ffa000;
    --kk-color-text-highlight-darker: #ff8f00;
    --kk-color-background-surface-lighter: #f7fafc;
    --kk-color-background-surface-light: #f1f4f8;
    --kk-color-background-surface-medium: #e6e9ed;
    --kk-color-background-surface-dark: #d5d6db;
    --kk-color-background-surface-darker: #9c9da0;
    --kk-color-background-primary-lighter: #f0fafb;
    --kk-color-background-primary-light: #cef0f3;
    --kk-color-background-primary-medium: #26bec9;
    --kk-color-background-primary-dark: #13a3b6;
    --kk-color-background-primary-darker: #03748a;
    --kk-color-background-critical-lighter: #fff2f2;
    --kk-color-background-critical-light: #fac2c0;
    --kk-color-background-critical-medium: #ef7a70;
    --kk-color-background-critical-dark: #e65f50;
    --kk-color-background-critical-darker: #d14330;
    --kk-color-background-info-lighter: #f2faff;
    --kk-color-background-info-light: #b9e0fa;
    --kk-color-background-info-medium: #64b3f4;
    --kk-color-background-info-dark: #2d84d6;
    --kk-color-background-info-darker: #1565c0;
    --kk-color-background-warning-lighter: #fffee0;
    --kk-color-background-warning-light: #fffbc3;
    --kk-color-background-warning-medium: #fee269;
    --kk-color-background-warning-dark: #f5b53d;
    --kk-color-background-warning-darker: #e78f37;
    --kk-color-background-highlight-lighter: #fff8e1;
    --kk-color-background-highlight-light: #ffca28;
    --kk-color-background-highlight-medium: #ffb400;
    --kk-color-background-highlight-dark: #ffa000;
    --kk-color-background-highlight-darker: #ff8f00;
    --kk-color-border-lighter: #e6e9ed;
    --kk-color-border-light: #d5d6db;
    --kk-color-border-medium: #babbbe;
    --kk-color-border-dark: #727272;
    --kk-color-border-darker: #212121;
    --kk-color-border-primary-lighter: #cef0f3;
    --kk-color-border-primary-light: #ade6eb;
    --kk-color-border-primary-medium: #26bec9;
    --kk-color-border-primary-dark: #13a3b6;
    --kk-color-border-primary-darker: #068b9f;
    --kk-color-border-critical-lighter: #f5a8a4;
    --kk-color-border-critical-light: #f2918a;
    --kk-color-border-critical-medium: #ef7a70;
    --kk-color-border-critical-dark: #e65f50;
    --kk-color-border-critical-darker: #d14330;
    --kk-color-border-info-lighter: #9dd3fa;
    --kk-color-border-info-light: #81c4f7;
    --kk-color-border-info-medium: #64b3f4;
    --kk-color-border-info-dark: #499feb;
    --kk-color-border-info-darker: #2d84d6;
    --kk-color-border-warning-lighter: #feed87;
    --kk-color-border-warning-light: #fee269;
    --kk-color-border-warning-medium: #facf58;
    --kk-color-border-warning-dark: #f5b53d;
    --kk-color-border-warning-darker: #e78f37;
    --kk-color-border-highlight-lighter: #ffca28;
    --kk-color-border-highlight-light: #ffc128;
    --kk-color-border-highlight-medium: #ffb400;
    --kk-color-border-highlight-dark: #ffa000;
    --kk-color-border-highlight-darker: #ff8f00;
    --kk-color-line-default: #06c755;
    --kk-color-line-dark: #05b34c;
    --kk-color-kakao-default: #fee500;
    --kk-color-kakao-dark: #f0d700;
    --kk-color-facebook-default: #1877f2;
    --kk-color-facebook-dark: #166fe5;
    --kk-color-apple-default: #000;
    --kk-color-apple-dark: #000;
    --kk-color-naver-default: #19ce60;
    --kk-color-naver-dark: #16b956;
    --kk-color-google-default: #fff;
    --kk-color-google-dark: #f2f3f4;
    --kk-color-wechat-default: #18d271;
    --kk-color-wechat-dark: #16bd66;
    --kk-color-yahoo-jp-default: #f03;
    --kk-color-yahoo-jp-dark: #e5002e;
    --kk-radius-xs: 2px;
    --kk-radius-sm: 4px;
    --kk-radius-md: 8px;
    --kk-radius-lg: 12px;
    --kk-radius-xl: 16px;
    --kk-spacing-1: 2px;
    --kk-spacing-2: 4px;
    --kk-spacing-3: 8px;
    --kk-spacing-4: 12px;
    --kk-spacing-5: 16px;
    --kk-spacing-6: 20px;
    --kk-spacing-7: 24px;
    --kk-spacing-8: 32px;
    --kk-spacing-9: 40px;
    --kk-spacing-10: 48px;
    --kk-elevation-action-offset-x: 0px;
    --kk-elevation-action-offset-y: 1px;
    --kk-elevation-action-blur: 4px;
    --kk-elevation-action-spread: 0px;
    --kk-elevation-action-color: rgba(38, 50, 56, 0.12);
    --kk-elevation-fixed-offset-x: 0px;
    --kk-elevation-fixed-offset-y: 2px;
    --kk-elevation-fixed-blur: 24px;
    --kk-elevation-fixed-spread: 0px;
    --kk-elevation-fixed-color: rgba(38, 50, 56, 0.12);
    --kk-elevation-raised-offset-x: 0px;
    --kk-elevation-raised-offset-y: 8px;
    --kk-elevation-raised-blur: 24px;
    --kk-elevation-raised-spread: 0px;
    --kk-elevation-raised-color: rgba(37, 42, 49, 0.24);
    --kk-dimension-icon-2xs: 14px;
    --kk-dimension-icon-xs: 16px;
    --kk-dimension-icon-sm: 20px;
    --kk-dimension-icon-md: 24px;
    --kk-dimension-icon-lg: 32px;
    --kk-dimension-icon-xl: 48px;
}

body,
html {
    color: #212121;
}

:root {
    --layout-spacing-0: 0;
    --layout-spacing-1: 2px;
    --layout-spacing-2: 4px;
    --layout-spacing-3: 8px;
    --layout-spacing-4: 12px;
    --layout-spacing-5: 16px;
    --layout-spacing-6: 20px;
    --layout-spacing-7: 24px;
    --layout-spacing-8: 32px;
    --layout-spacing-9: 40px;
    --layout-spacing-10: 48px;
}

.layout-absolute {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
}

.layout-absolute__wrapper {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto;
    display: grid;
    grid-template: 1fr/1fr;
}

.layout-absolute__cell {
    grid-column-start: 1;
    grid-column-end: 1;
    grid-row-start: 1;
    grid-row-end: 1;
}

.layout-absolute__cell--top-left {
    justify-self: start;
    -ms-flex-item-align: start;
    align-self: start;
}

.layout-absolute__cell--top {
    justify-self: center;
    -ms-flex-item-align: start;
    align-self: start;
}

.layout-absolute__cell--top-right {
    justify-self: end;
    -ms-flex-item-align: start;
    align-self: start;
}

.layout-absolute__cell--right {
    justify-self: end;
    -ms-flex-item-align: center;
    align-self: center;
}

.layout-absolute__cell--bottom-right {
    justify-self: end;
    -ms-flex-item-align: end;
    align-self: end;
}

.layout-absolute__cell--bottom {
    justify-self: center;
    -ms-flex-item-align: end;
    align-self: end;
}

.layout-absolute__cell--bottom-left {
    justify-self: start;
    -ms-flex-item-align: end;
    align-self: end;
}

.layout-absolute__cell--left {
    justify-self: start;
    -ms-flex-item-align: center;
    align-self: center;
}

.layout-absolute__cell--center {
    justify-self: center;
    -ms-flex-item-align: center;
    align-self: center;
}

.layout-u-debug .layout-absolute {
    background-color: rgba(220, 20, 60, 0.0784313725);
    cursor: default;
}

.layout-u-debug .layout-absolute.layout--debug {
    background: repeating-linear-gradient(
            45deg,
            rgba(220, 20, 60, 0.2),
            rgba(220, 20, 60, 0.2) 1px,
            transparent 0,
            transparent 10px
        ),
        hsla(0, 0%, 100%, 0.5019607843);
    outline: 2px solid rgba(220, 20, 60, 0.6);
    outline-offset: -2px;
}

.layout-u-debug .layout-absolute.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: 'LayoutAbsolute';
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #dc143c;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(220, 20, 60, 0.2) inset;
    box-shadow: inset 0 0 100px rgba(220, 20, 60, 0.2);
    padding: 12px;
    z-index: 9999;
}

.layout-absolute.layout--debug.layout-absolute
    > .layout-absolute__wrapper
    > .layout-absolute__cell:not(:empty) {
    background-color: #f8d0d8;
    outline: 2px dashed rgba(220, 20, 60, 0.6);
    outline-offset: -2px;
}

.layout-align {
    display: grid;
    grid-template-columns: minmax(0, auto);
}

.layout-align--horizontal-align-left {
    -webkit-box-pack: start;
    -ms-flex-pack: start;
    justify-content: start;
}

.layout-align--horizontal-align-center {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
}

.layout-align--horizontal-align-right {
    -webkit-box-pack: end;
    -ms-flex-pack: end;
    justify-content: end;
}

.layout-align--horizontal-align-default,
.layout-align--horizontal-align-stretch {
    -webkit-box-pack: stretch;
    -ms-flex-pack: stretch;
    justify-content: stretch;
}

.layout-align--horizontal-align-default > .layout-align__content,
.layout-align--horizontal-align-stretch > .layout-align__content {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    -ms-flex-direction: row;
    flex-direction: row;
}

.layout-align--horizontal-align-default > .layout-align__content > *,
.layout-align--horizontal-align-stretch > .layout-align__content > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    width: auto;
}

.layout-align--vertical-align-default,
.layout-align--vertical-align-top {
    -ms-flex-line-pack: start;
    align-content: start;
}

.layout-align--vertical-align-center {
    -ms-flex-line-pack: center;
    align-content: center;
}

.layout-align--vertical-align-bottom {
    -ms-flex-line-pack: end;
    align-content: end;
}

.layout-align--vertical-align-stretch {
    -ms-flex-line-pack: stretch;
    align-content: stretch;
}

.layout-align--vertical-align-stretch > .layout-align__content {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
}

.layout-align--vertical-align-stretch > .layout-align__content > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto;
}

.layout-u-debug .layout-align {
    background-color: rgba(255, 127, 80, 0.0784313725);
    cursor: default;
}

.layout-u-debug .layout-align.layout--debug {
    background: repeating-linear-gradient(
            45deg,
            rgba(255, 127, 80, 0.2),
            rgba(255, 127, 80, 0.2) 1px,
            transparent 0,
            transparent 10px
        ),
        hsla(0, 0%, 100%, 0.5019607843);
    outline: 2px solid rgba(255, 127, 80, 0.6);
    outline-offset: -2px;
}

.layout-u-debug .layout-align.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: 'LayoutAlign';
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid coral;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(255, 127, 80, 0.2) inset;
    box-shadow: inset 0 0 100px rgba(255, 127, 80, 0.2);
    padding: 12px;
    z-index: 9999;
}

.layout-align.layout--debug.layout-align > :not(:empty) {
    background-color: #ffe5dc;
    outline: 2px dashed rgba(255, 127, 80, 0.6);
    outline-offset: -2px;
}

.layout-columns {
    --layout-columns-gap: 0px;
    --layout-columns-gap-x: var(--layout-columns-gap);
    --layout-columns-gap-y: var(--layout-columns-gap);
}

.layout-columns--flow-direction-row {
    display: grid;
    grid-template-columns: repeat(
        var(--layout-columns-column-count, auto-fit),
        minmax(var(--layout-columns-content-min-width, 0), 1fr)
    );
    gap: var(--layout-columns-gap-y) var(--layout-columns-gap-x);
    -webkit-box-pack: stretch;
    -ms-flex-pack: stretch;
    justify-content: stretch;
}

.layout-columns--flow-direction-row.layout-columns--vertical-align-top {
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: start;
}

.layout-columns--flow-direction-row.layout-columns--vertical-align-center {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.layout-columns--flow-direction-row.layout-columns--vertical-align-bottom {
    -webkit-box-align: end;
    -ms-flex-align: end;
    align-items: end;
}

.layout-columns--flow-direction-row.layout-columns--vertical-align-default,
.layout-columns--flow-direction-row.layout-columns--vertical-align-stretch {
    -webkit-box-align: stretch;
    -ms-flex-align: stretch;
    align-items: stretch;
}

.layout-columns--flow-direction-column > .layout-columns__wrapper {
    -moz-columns: var(--layout-columns-content-min-width, auto)
        var(--layout-columns-column-count, auto);
    -webkit-columns: var(--layout-columns-content-min-width, auto)
        var(--layout-columns-column-count, auto);
    columns: var(--layout-columns-content-min-width, auto)
        var(--layout-columns-column-count, auto);
    -moz-column-gap: var(--layout-columns-gap-x);
    -webkit-column-gap: var(--layout-columns-gap-x);
    column-gap: var(--layout-columns-gap-x);
    margin-bottom: calc(var(--layout-columns-gap-y) * -1);
}

.layout-columns--flow-direction-column
    > .layout-columns__wrapper
    > .layout-columns__item {
    display: inline-grid;
    width: 100%;
    -moz-column-break-inside: avoid;
    -webkit-column-break-inside: avoid;
    break-inside: avoid;
    margin-bottom: var(--layout-columns-gap-y);
}

.layout-columns--gap-0 {
    --layout-columns-gap: var(--layout-spacing-0);
}

.layout-columns--gap-1 {
    --layout-columns-gap: var(--layout-spacing-1);
}

.layout-columns--gap-2 {
    --layout-columns-gap: var(--layout-spacing-2);
}

.layout-columns--gap-3 {
    --layout-columns-gap: var(--layout-spacing-3);
}

.layout-columns--gap-4 {
    --layout-columns-gap: var(--layout-spacing-4);
}

.layout-columns--gap-5 {
    --layout-columns-gap: var(--layout-spacing-5);
}

.layout-columns--gap-6 {
    --layout-columns-gap: var(--layout-spacing-6);
}

.layout-columns--gap-7 {
    --layout-columns-gap: var(--layout-spacing-7);
}

.layout-columns--gap-8 {
    --layout-columns-gap: var(--layout-spacing-8);
}

.layout-columns--gap-9 {
    --layout-columns-gap: var(--layout-spacing-9);
}

.layout-columns--gap-10 {
    --layout-columns-gap: var(--layout-spacing-10);
}

.layout-columns--gap-x-0 {
    --layout-columns-gap-x: var(--layout-spacing-0);
}

.layout-columns--gap-y-0 {
    --layout-columns-gap-y: var(--layout-spacing-0);
}

.layout-columns--gap-x-1 {
    --layout-columns-gap-x: var(--layout-spacing-1);
}

.layout-columns--gap-y-1 {
    --layout-columns-gap-y: var(--layout-spacing-1);
}

.layout-columns--gap-x-2 {
    --layout-columns-gap-x: var(--layout-spacing-2);
}

.layout-columns--gap-y-2 {
    --layout-columns-gap-y: var(--layout-spacing-2);
}

.layout-columns--gap-x-3 {
    --layout-columns-gap-x: var(--layout-spacing-3);
}

.layout-columns--gap-y-3 {
    --layout-columns-gap-y: var(--layout-spacing-3);
}

.layout-columns--gap-x-4 {
    --layout-columns-gap-x: var(--layout-spacing-4);
}

.layout-columns--gap-y-4 {
    --layout-columns-gap-y: var(--layout-spacing-4);
}

.layout-columns--gap-x-5 {
    --layout-columns-gap-x: var(--layout-spacing-5);
}

.layout-columns--gap-y-5 {
    --layout-columns-gap-y: var(--layout-spacing-5);
}

.layout-columns--gap-x-6 {
    --layout-columns-gap-x: var(--layout-spacing-6);
}

.layout-columns--gap-y-6 {
    --layout-columns-gap-y: var(--layout-spacing-6);
}

.layout-columns--gap-x-7 {
    --layout-columns-gap-x: var(--layout-spacing-7);
}

.layout-columns--gap-y-7 {
    --layout-columns-gap-y: var(--layout-spacing-7);
}

.layout-columns--gap-x-8 {
    --layout-columns-gap-x: var(--layout-spacing-8);
}

.layout-columns--gap-y-8 {
    --layout-columns-gap-y: var(--layout-spacing-8);
}

.layout-columns--gap-x-9 {
    --layout-columns-gap-x: var(--layout-spacing-9);
}

.layout-columns--gap-y-9 {
    --layout-columns-gap-y: var(--layout-spacing-9);
}

.layout-columns--gap-x-10 {
    --layout-columns-gap-x: var(--layout-spacing-10);
}

.layout-columns--gap-y-10 {
    --layout-columns-gap-y: var(--layout-spacing-10);
}

.layout-u-debug .layout-columns {
    background-color: rgba(210, 105, 30, 0.0784313725);
    cursor: default;
}

.layout-u-debug .layout-columns.layout--debug {
    background: repeating-linear-gradient(
            45deg,
            rgba(210, 105, 30, 0.2),
            rgba(210, 105, 30, 0.2) 1px,
            transparent 0,
            transparent 10px
        ),
        hsla(0, 0%, 100%, 0.5019607843);
    outline: 2px solid rgba(210, 105, 30, 0.6);
    outline-offset: -2px;
}

.layout-u-debug .layout-columns.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: 'LayoutColumns';
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #d2691e;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(210, 105, 30, 0.2) inset;
    box-shadow: inset 0 0 100px rgba(210, 105, 30, 0.2);
    padding: 12px;
    z-index: 9999;
}

.layout-columns.layout--debug.layout-columns--flow-direction-column
    > .layout-columns__wrapper
    > .layout-columns__item:not(:empty),
.layout-columns.layout--debug.layout-columns--flow-direction-row
    > :not(:empty) {
    background-color: #f6e1d2;
    outline: 2px dashed rgba(210, 105, 30, 0.6);
    outline-offset: -2px;
}

.layout-flex-column {
    --layout-flex-column-gap: 0px;
    display: grid;
    grid-template-columns: minmax(0, 1fr);
    grid-template-rows: auto minmax(0, 1fr) auto;
    gap: var(--layout-flex-column-gap);
}

.layout-flex-column--no-remain {
    grid-template-rows: auto minmax(var(--layout-flex-column-gap), 1fr) auto;
    gap: 0;
}

.layout-flex-column--no-top {
    grid-template-rows: minmax(0, 1fr) auto;
}

.layout-flex-column--no-bottom {
    grid-template-rows: auto minmax(0, 1fr);
}

.layout-flex-column--no-top.layout-flex-column--no-bottom {
    grid-template-rows: minmax(0, 1fr);
}

.layout-flex-column__remain {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
}

.layout-flex-column__remain > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 0px;
    flex: 1 1 0;
    height: auto;
}

.layout-flex-column--horizontal-align-left {
    justify-items: start;
}

.layout-flex-column--horizontal-align-center {
    justify-items: center;
}

.layout-flex-column--horizontal-align-right {
    justify-items: end;
}

.layout-flex-column--horizontal-align-default,
.layout-flex-column--horizontal-align-stretch {
    justify-items: stretch;
}

.layout-flex-column--gap-0 {
    --layout-flex-column-gap: var(--layout-spacing-0);
}

.layout-flex-column--gap-1 {
    --layout-flex-column-gap: var(--layout-spacing-1);
}

.layout-flex-column--gap-2 {
    --layout-flex-column-gap: var(--layout-spacing-2);
}

.layout-flex-column--gap-3 {
    --layout-flex-column-gap: var(--layout-spacing-3);
}

.layout-flex-column--gap-4 {
    --layout-flex-column-gap: var(--layout-spacing-4);
}

.layout-flex-column--gap-5 {
    --layout-flex-column-gap: var(--layout-spacing-5);
}

.layout-flex-column--gap-6 {
    --layout-flex-column-gap: var(--layout-spacing-6);
}

.layout-flex-column--gap-7 {
    --layout-flex-column-gap: var(--layout-spacing-7);
}

.layout-flex-column--gap-8 {
    --layout-flex-column-gap: var(--layout-spacing-8);
}

.layout-flex-column--gap-9 {
    --layout-flex-column-gap: var(--layout-spacing-9);
}

.layout-flex-column--gap-10 {
    --layout-flex-column-gap: var(--layout-spacing-10);
}

.layout-u-debug .layout-flex-column {
    background-color: rgba(95, 158, 160, 0.0784313725);
    cursor: default;
}

.layout-u-debug .layout-flex-column.layout--debug {
    background: repeating-linear-gradient(
            45deg,
            rgba(95, 158, 160, 0.2),
            rgba(95, 158, 160, 0.2) 1px,
            transparent 0,
            transparent 10px
        ),
        hsla(0, 0%, 100%, 0.5019607843);
    outline: 2px solid rgba(95, 158, 160, 0.6);
    outline-offset: -2px;
}

.layout-u-debug .layout-flex-column.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: 'LayoutFlexColumn';
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #5f9ea0;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(95, 158, 160, 0.2) inset;
    box-shadow: inset 0 0 100px rgba(95, 158, 160, 0.2);
    padding: 12px;
    z-index: 9999;
}

.layout-flex-column.layout--debug.layout-flex-column > :not(:empty) {
    background-color: #dfecec;
    outline: 2px dashed rgba(95, 158, 160, 0.6);
    outline-offset: -2px;
}

.layout-flex-row {
    --layout-flex-row-gap: 0px;
    display: grid;
    grid-template-rows: minmax(0, 1fr);
    grid-template-columns: auto minmax(0, 1fr) auto;
    gap: var(--layout-flex-row-gap);
}

.layout-flex-row--no-remain {
    grid-template-columns: auto minmax(var(--layout-flex-row-gap), 1fr) auto;
    gap: 0;
}

.layout-flex-row--no-left {
    grid-template-columns: minmax(0, 1fr) auto;
}

.layout-flex-row--no-right {
    grid-template-columns: auto minmax(0, 1fr);
}

.layout-flex-row--no-left.layout-flex-row--no-right {
    grid-template-columns: minmax(0, 1fr);
}

.layout-flex-row__remain {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    -ms-flex-direction: row;
    flex-direction: row;
}

.layout-flex-row__remain > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 0px;
    flex: 1 1 0;
    width: auto;
}

.layout-flex-row--vertical-align-top {
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: start;
}

.layout-flex-row--vertical-align-center {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.layout-flex-row--vertical-align-bottom {
    -webkit-box-align: end;
    -ms-flex-align: end;
    align-items: end;
}

.layout-flex-row--vertical-align-default > .layout-flex-row__left,
.layout-flex-row--vertical-align-default > .layout-flex-row__remain,
.layout-flex-row--vertical-align-default > .layout-flex-row__right,
.layout-flex-row--vertical-align-stretch > .layout-flex-row__left,
.layout-flex-row--vertical-align-stretch > .layout-flex-row__remain,
.layout-flex-row--vertical-align-stretch > .layout-flex-row__right {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
}

.layout-flex-row--vertical-align-default > .layout-flex-row__left > *,
.layout-flex-row--vertical-align-default > .layout-flex-row__remain > *,
.layout-flex-row--vertical-align-default > .layout-flex-row__right > *,
.layout-flex-row--vertical-align-stretch > .layout-flex-row__left > *,
.layout-flex-row--vertical-align-stretch > .layout-flex-row__remain > *,
.layout-flex-row--vertical-align-stretch > .layout-flex-row__right > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto;
}

.layout-flex-row--gap-0 {
    --layout-flex-row-gap: var(--layout-spacing-0);
}

.layout-flex-row--gap-1 {
    --layout-flex-row-gap: var(--layout-spacing-1);
}

.layout-flex-row--gap-2 {
    --layout-flex-row-gap: var(--layout-spacing-2);
}

.layout-flex-row--gap-3 {
    --layout-flex-row-gap: var(--layout-spacing-3);
}

.layout-flex-row--gap-4 {
    --layout-flex-row-gap: var(--layout-spacing-4);
}

.layout-flex-row--gap-5 {
    --layout-flex-row-gap: var(--layout-spacing-5);
}

.layout-flex-row--gap-6 {
    --layout-flex-row-gap: var(--layout-spacing-6);
}

.layout-flex-row--gap-7 {
    --layout-flex-row-gap: var(--layout-spacing-7);
}

.layout-flex-row--gap-8 {
    --layout-flex-row-gap: var(--layout-spacing-8);
}

.layout-flex-row--gap-9 {
    --layout-flex-row-gap: var(--layout-spacing-9);
}

.layout-flex-row--gap-10 {
    --layout-flex-row-gap: var(--layout-spacing-10);
}

.layout-u-debug .layout-flex-row {
    background-color: rgba(34, 139, 34, 0.0784313725);
    cursor: default;
}

.layout-u-debug .layout-flex-row.layout--debug {
    background: repeating-linear-gradient(
            45deg,
            rgba(34, 139, 34, 0.2),
            rgba(34, 139, 34, 0.2) 1px,
            transparent 0,
            transparent 10px
        ),
        hsla(0, 0%, 100%, 0.5019607843);
    outline: 2px solid rgba(34, 139, 34, 0.6);
    outline-offset: -2px;
}

.layout-u-debug .layout-flex-row.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: 'LayoutFlexRow';
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #228b22;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(34, 139, 34, 0.2) inset;
    box-shadow: inset 0 0 100px rgba(34, 139, 34, 0.2);
    padding: 12px;
    z-index: 9999;
}

.layout-flex-row.layout--debug.layout-flex-row > :not(:empty) {
    background-color: #d3e8d3;
    outline: 2px dashed rgba(34, 139, 34, 0.6);
    outline-offset: -2px;
}

.layout-grid {
    --column-count: 12;
    --layout-grid-gap: 0px;
    --layout-grid-gap-x: var(--layout-grid-gap);
    --layout-grid-gap-y: var(--layout-grid-gap);
    display: grid;
    grid-template-columns: repeat(var(--column-count), 1fr);
    gap: var(--layout-grid-gap-y) var(--layout-grid-gap-x);
    -webkit-box-align: stretch;
    -ms-flex-align: stretch;
    align-items: stretch;
}

.layout-grid--gap-0 {
    --layout-grid-gap: var(--layout-spacing-0);
}

.layout-grid--gap-1 {
    --layout-grid-gap: var(--layout-spacing-1);
}

.layout-grid--gap-2 {
    --layout-grid-gap: var(--layout-spacing-2);
}

.layout-grid--gap-3 {
    --layout-grid-gap: var(--layout-spacing-3);
}

.layout-grid--gap-4 {
    --layout-grid-gap: var(--layout-spacing-4);
}

.layout-grid--gap-5 {
    --layout-grid-gap: var(--layout-spacing-5);
}

.layout-grid--gap-6 {
    --layout-grid-gap: var(--layout-spacing-6);
}

.layout-grid--gap-7 {
    --layout-grid-gap: var(--layout-spacing-7);
}

.layout-grid--gap-8 {
    --layout-grid-gap: var(--layout-spacing-8);
}

.layout-grid--gap-9 {
    --layout-grid-gap: var(--layout-spacing-9);
}

.layout-grid--gap-10 {
    --layout-grid-gap: var(--layout-spacing-10);
}

.layout-grid--gap-x-0 {
    --layout-grid-gap-x: var(--layout-spacing-0);
}

.layout-grid--gap-y-0 {
    --layout-grid-gap-y: var(--layout-spacing-0);
}

.layout-grid--gap-x-1 {
    --layout-grid-gap-x: var(--layout-spacing-1);
}

.layout-grid--gap-y-1 {
    --layout-grid-gap-y: var(--layout-spacing-1);
}

.layout-grid--gap-x-2 {
    --layout-grid-gap-x: var(--layout-spacing-2);
}

.layout-grid--gap-y-2 {
    --layout-grid-gap-y: var(--layout-spacing-2);
}

.layout-grid--gap-x-3 {
    --layout-grid-gap-x: var(--layout-spacing-3);
}

.layout-grid--gap-y-3 {
    --layout-grid-gap-y: var(--layout-spacing-3);
}

.layout-grid--gap-x-4 {
    --layout-grid-gap-x: var(--layout-spacing-4);
}

.layout-grid--gap-y-4 {
    --layout-grid-gap-y: var(--layout-spacing-4);
}

.layout-grid--gap-x-5 {
    --layout-grid-gap-x: var(--layout-spacing-5);
}

.layout-grid--gap-y-5 {
    --layout-grid-gap-y: var(--layout-spacing-5);
}

.layout-grid--gap-x-6 {
    --layout-grid-gap-x: var(--layout-spacing-6);
}

.layout-grid--gap-y-6 {
    --layout-grid-gap-y: var(--layout-spacing-6);
}

.layout-grid--gap-x-7 {
    --layout-grid-gap-x: var(--layout-spacing-7);
}

.layout-grid--gap-y-7 {
    --layout-grid-gap-y: var(--layout-spacing-7);
}

.layout-grid--gap-x-8 {
    --layout-grid-gap-x: var(--layout-spacing-8);
}

.layout-grid--gap-y-8 {
    --layout-grid-gap-y: var(--layout-spacing-8);
}

.layout-grid--gap-x-9 {
    --layout-grid-gap-x: var(--layout-spacing-9);
}

.layout-grid--gap-y-9 {
    --layout-grid-gap-y: var(--layout-spacing-9);
}

.layout-grid--gap-x-10 {
    --layout-grid-gap-x: var(--layout-spacing-10);
}

.layout-grid--gap-y-10 {
    --layout-grid-gap-y: var(--layout-spacing-10);
}

.layout-grid--vertical-align-top {
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: start;
}

.layout-grid--vertical-align-center {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.layout-grid--vertical-align-bottom {
    -webkit-box-align: end;
    -ms-flex-align: end;
    align-items: end;
}

.layout-grid--vertical-align-default > .layout-grid__cell,
.layout-grid--vertical-align-stretch > .layout-grid__cell {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
}

.layout-grid--vertical-align-default > .layout-grid__cell > *,
.layout-grid--vertical-align-stretch > .layout-grid__cell > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto;
}

.layout-grid__cell {
    --span: 1;
    grid-column: auto/span var(--span);
}

.layout-grid__row-break {
    grid-column-end: -1;
}

.layout-u-debug .layout-grid {
    background-color: rgba(112, 128, 144, 0.0784313725);
    cursor: default;
}

.layout-u-debug .layout-grid.layout--debug {
    background: repeating-linear-gradient(
            45deg,
            rgba(112, 128, 144, 0.2),
            rgba(112, 128, 144, 0.2) 1px,
            transparent 0,
            transparent 10px
        ),
        hsla(0, 0%, 100%, 0.5019607843);
    outline: 2px solid rgba(112, 128, 144, 0.6);
    outline-offset: -2px;
}

.layout-u-debug .layout-grid.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: 'LayoutGrid';
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #708090;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(112, 128, 144, 0.2) inset;
    box-shadow: inset 0 0 100px rgba(112, 128, 144, 0.2);
    padding: 12px;
    z-index: 9999;
}

.layout-grid.layout--debug.layout-grid > .layout-grid__cell:not(:empty) {
    background-color: #e2e6e9;
    outline: 2px dashed rgba(112, 128, 144, 0.6);
    outline-offset: -2px;
}

.layout-list {
    --layout-list-gap: 0px;
    display: grid;
    grid-template-columns: minmax(0, auto);
    gap: var(--layout-list-gap);
}

.layout-list--horizontal-align-left {
    justify-items: start;
}

.layout-list--horizontal-align-center {
    justify-items: center;
}

.layout-list--horizontal-align-right {
    justify-items: end;
}

.layout-list--horizontal-align-default,
.layout-list--horizontal-align-stretch {
    justify-items: stretch;
}

.layout-list--gap-0 {
    --layout-list-gap: var(--layout-spacing-0);
}

.layout-list--gap-1 {
    --layout-list-gap: var(--layout-spacing-1);
}

.layout-list--gap-2 {
    --layout-list-gap: var(--layout-spacing-2);
}

.layout-list--gap-3 {
    --layout-list-gap: var(--layout-spacing-3);
}

.layout-list--gap-4 {
    --layout-list-gap: var(--layout-spacing-4);
}

.layout-list--gap-5 {
    --layout-list-gap: var(--layout-spacing-5);
}

.layout-list--gap-6 {
    --layout-list-gap: var(--layout-spacing-6);
}

.layout-list--gap-7 {
    --layout-list-gap: var(--layout-spacing-7);
}

.layout-list--gap-8 {
    --layout-list-gap: var(--layout-spacing-8);
}

.layout-list--gap-9 {
    --layout-list-gap: var(--layout-spacing-9);
}

.layout-list--gap-10 {
    --layout-list-gap: var(--layout-spacing-10);
}

.layout-u-debug .layout-list {
    background-color: rgba(0, 0, 128, 0.0784313725);
    cursor: default;
}

.layout-u-debug .layout-list.layout--debug {
    background: repeating-linear-gradient(
            45deg,
            rgba(0, 0, 128, 0.2),
            rgba(0, 0, 128, 0.2) 1px,
            transparent 0,
            transparent 10px
        ),
        hsla(0, 0%, 100%, 0.5019607843);
    outline: 2px solid rgba(0, 0, 128, 0.6);
    outline-offset: -2px;
}

.layout-u-debug .layout-list.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: 'LayoutList';
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid navy;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(0, 0, 128, 0.2) inset;
    box-shadow: inset 0 0 100px rgba(0, 0, 128, 0.2);
    padding: 12px;
    z-index: 9999;
}

.layout-list.layout--debug.layout-list > :not(:empty) {
    background-color: #cccce6;
    outline: 2px dashed rgba(0, 0, 128, 0.6);
    outline-offset: -2px;
}

.layout-list-inline {
    display: inline-block;
}

.layout-list-inline__wrapper {
    --layout-list-inline-gap: 0px;
    --layout-list-inline-gap-x: var(--layout-list-inline-gap);
    --layout-list-inline-gap-y: var(--layout-list-inline-gap);
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    vertical-align: top;
    -ms-flex-wrap: wrap;
    flex-wrap: wrap;
    margin: calc(var(--layout-list-inline-gap-y) * -0.5)
        calc(var(--layout-list-inline-gap-x) * -0.5);
}

.layout-list-inline__item {
    margin: calc(var(--layout-list-inline-gap-y) * 0.5)
        calc(var(--layout-list-inline-gap-x) * 0.5);
}

.layout-list-inline--nowrap > .layout-list-inline__wrapper {
    -ms-flex-wrap: nowrap;
    flex-wrap: nowrap;
}

.layout-list-inline--vertical-align-top > .layout-list-inline__wrapper {
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start;
}

.layout-list-inline--vertical-align-center > .layout-list-inline__wrapper {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.layout-list-inline--vertical-align-bottom > .layout-list-inline__wrapper {
    -webkit-box-align: end;
    -ms-flex-align: end;
    align-items: flex-end;
}

.layout-list-inline--vertical-align-default > .layout-list-inline__wrapper,
.layout-list-inline--vertical-align-stretch > .layout-list-inline__wrapper {
    -webkit-box-align: stretch;
    -ms-flex-align: stretch;
    align-items: stretch;
}

.layout-list-inline--vertical-align-default
    > .layout-list-inline__wrapper
    > .layout-list-inline__item,
.layout-list-inline--vertical-align-stretch
    > .layout-list-inline__wrapper
    > .layout-list-inline__item {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
}

.layout-list-inline--vertical-align-default
    > .layout-list-inline__wrapper
    > .layout-list-inline__item
    > *,
.layout-list-inline--vertical-align-stretch
    > .layout-list-inline__wrapper
    > .layout-list-inline__item
    > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto;
}

.layout-list-inline--horizontal-align-default > .layout-list-inline__wrapper,
.layout-list-inline--horizontal-align-left > .layout-list-inline__wrapper {
    -webkit-box-pack: start;
    -ms-flex-pack: start;
    justify-content: flex-start;
}

.layout-list-inline--horizontal-align-center > .layout-list-inline__wrapper {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
}

.layout-list-inline--horizontal-align-right > .layout-list-inline__wrapper {
    -webkit-box-pack: end;
    -ms-flex-pack: end;
    justify-content: flex-end;
}

.layout-list-inline--gap-0 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-0);
}

.layout-list-inline--gap-1 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-1);
}

.layout-list-inline--gap-2 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-2);
}

.layout-list-inline--gap-3 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-3);
}

.layout-list-inline--gap-4 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-4);
}

.layout-list-inline--gap-5 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-5);
}

.layout-list-inline--gap-6 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-6);
}

.layout-list-inline--gap-7 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-7);
}

.layout-list-inline--gap-8 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-8);
}

.layout-list-inline--gap-9 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-9);
}

.layout-list-inline--gap-10 > .layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-10);
}

.layout-list-inline--gap-x-0 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-0);
}

.layout-list-inline--gap-y-0 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-0);
}

.layout-list-inline--gap-x-1 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-1);
}

.layout-list-inline--gap-y-1 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-1);
}

.layout-list-inline--gap-x-2 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-2);
}

.layout-list-inline--gap-y-2 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-2);
}

.layout-list-inline--gap-x-3 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-3);
}

.layout-list-inline--gap-y-3 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-3);
}

.layout-list-inline--gap-x-4 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-4);
}

.layout-list-inline--gap-y-4 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-4);
}

.layout-list-inline--gap-x-5 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-5);
}

.layout-list-inline--gap-y-5 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-5);
}

.layout-list-inline--gap-x-6 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-6);
}

.layout-list-inline--gap-y-6 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-6);
}

.layout-list-inline--gap-x-7 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-7);
}

.layout-list-inline--gap-y-7 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-7);
}

.layout-list-inline--gap-x-8 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-8);
}

.layout-list-inline--gap-y-8 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-8);
}

.layout-list-inline--gap-x-9 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-9);
}

.layout-list-inline--gap-y-9 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-9);
}

.layout-list-inline--gap-x-10 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-10);
}

.layout-list-inline--gap-y-10 > .layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-10);
}

.layout-u-debug .layout-list-inline {
    background-color: rgba(138, 43, 226, 0.0784313725);
    cursor: default;
}

.layout-u-debug .layout-list-inline.layout--debug {
    background: repeating-linear-gradient(
            45deg,
            rgba(138, 43, 226, 0.2),
            rgba(138, 43, 226, 0.2) 1px,
            transparent 0,
            transparent 10px
        ),
        hsla(0, 0%, 100%, 0.5019607843);
    outline: 2px solid rgba(138, 43, 226, 0.6);
    outline-offset: -2px;
}

.layout-u-debug .layout-list-inline.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: 'LayoutListInline';
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #8a2be2;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(138, 43, 226, 0.2) inset;
    box-shadow: inset 0 0 100px rgba(138, 43, 226, 0.2);
    padding: 12px;
    z-index: 9999;
}

.layout-list-inline.layout--debug.layout-list-inline
    > .layout-list-inline__wrapper
    > .layout-list-inline__item:not(:empty) {
    background-color: #e8d5f9;
    outline: 2px dashed rgba(138, 43, 226, 0.6);
    outline-offset: -2px;
}

.layout-u-m-0 {
    margin: var(--layout-spacing-0);
}

.layout-u-p-0 {
    padding: var(--layout-spacing-0);
}

.layout-u-m-1 {
    margin: var(--layout-spacing-1);
}

.layout-u-p-1 {
    padding: var(--layout-spacing-1);
}

.layout-u-m-2 {
    margin: var(--layout-spacing-2);
}

.layout-u-p-2 {
    padding: var(--layout-spacing-2);
}

.layout-u-m-3 {
    margin: var(--layout-spacing-3);
}

.layout-u-p-3 {
    padding: var(--layout-spacing-3);
}

.layout-u-m-4 {
    margin: var(--layout-spacing-4);
}

.layout-u-p-4 {
    padding: var(--layout-spacing-4);
}

.layout-u-m-5 {
    margin: var(--layout-spacing-5);
}

.layout-u-p-5 {
    padding: var(--layout-spacing-5);
}

.layout-u-m-6 {
    margin: var(--layout-spacing-6);
}

.layout-u-p-6 {
    padding: var(--layout-spacing-6);
}

.layout-u-m-7 {
    margin: var(--layout-spacing-7);
}

.layout-u-p-7 {
    padding: var(--layout-spacing-7);
}

.layout-u-m-8 {
    margin: var(--layout-spacing-8);
}

.layout-u-p-8 {
    padding: var(--layout-spacing-8);
}

.layout-u-m-9 {
    margin: var(--layout-spacing-9);
}

.layout-u-p-9 {
    padding: var(--layout-spacing-9);
}

.layout-u-m-10 {
    margin: var(--layout-spacing-10);
}

.layout-u-p-10 {
    padding: var(--layout-spacing-10);
}

.layout-u-mx-0 {
    margin-left: var(--layout-spacing-0);
    margin-right: var(--layout-spacing-0);
}

.layout-u-my-0 {
    margin-top: var(--layout-spacing-0);
    margin-bottom: var(--layout-spacing-0);
}

.layout-u-px-0 {
    padding-left: var(--layout-spacing-0);
    padding-right: var(--layout-spacing-0);
}

.layout-u-py-0 {
    padding-top: var(--layout-spacing-0);
    padding-bottom: var(--layout-spacing-0);
}

.layout-u-mx-1 {
    margin-left: var(--layout-spacing-1);
    margin-right: var(--layout-spacing-1);
}

.layout-u-my-1 {
    margin-top: var(--layout-spacing-1);
    margin-bottom: var(--layout-spacing-1);
}

.layout-u-px-1 {
    padding-left: var(--layout-spacing-1);
    padding-right: var(--layout-spacing-1);
}

.layout-u-py-1 {
    padding-top: var(--layout-spacing-1);
    padding-bottom: var(--layout-spacing-1);
}

.layout-u-mx-2 {
    margin-left: var(--layout-spacing-2);
    margin-right: var(--layout-spacing-2);
}

.layout-u-my-2 {
    margin-top: var(--layout-spacing-2);
    margin-bottom: var(--layout-spacing-2);
}

.layout-u-px-2 {
    padding-left: var(--layout-spacing-2);
    padding-right: var(--layout-spacing-2);
}

.layout-u-py-2 {
    padding-top: var(--layout-spacing-2);
    padding-bottom: var(--layout-spacing-2);
}

.layout-u-mx-3 {
    margin-left: var(--layout-spacing-3);
    margin-right: var(--layout-spacing-3);
}

.layout-u-my-3 {
    margin-top: var(--layout-spacing-3);
    margin-bottom: var(--layout-spacing-3);
}

.layout-u-px-3 {
    padding-left: var(--layout-spacing-3);
    padding-right: var(--layout-spacing-3);
}

.layout-u-py-3 {
    padding-top: var(--layout-spacing-3);
    padding-bottom: var(--layout-spacing-3);
}

.layout-u-mx-4 {
    margin-left: var(--layout-spacing-4);
    margin-right: var(--layout-spacing-4);
}

.layout-u-my-4 {
    margin-top: var(--layout-spacing-4);
    margin-bottom: var(--layout-spacing-4);
}

.layout-u-px-4 {
    padding-left: var(--layout-spacing-4);
    padding-right: var(--layout-spacing-4);
}

.layout-u-py-4 {
    padding-top: var(--layout-spacing-4);
    padding-bottom: var(--layout-spacing-4);
}

.layout-u-mx-5 {
    margin-left: var(--layout-spacing-5);
    margin-right: var(--layout-spacing-5);
}

.layout-u-my-5 {
    margin-top: var(--layout-spacing-5);
    margin-bottom: var(--layout-spacing-5);
}

.layout-u-px-5 {
    padding-left: var(--layout-spacing-5);
    padding-right: var(--layout-spacing-5);
}

.layout-u-py-5 {
    padding-top: var(--layout-spacing-5);
    padding-bottom: var(--layout-spacing-5);
}

.layout-u-mx-6 {
    margin-left: var(--layout-spacing-6);
    margin-right: var(--layout-spacing-6);
}

.layout-u-my-6 {
    margin-top: var(--layout-spacing-6);
    margin-bottom: var(--layout-spacing-6);
}

.layout-u-px-6 {
    padding-left: var(--layout-spacing-6);
    padding-right: var(--layout-spacing-6);
}

.layout-u-py-6 {
    padding-top: var(--layout-spacing-6);
    padding-bottom: var(--layout-spacing-6);
}

.layout-u-mx-7 {
    margin-left: var(--layout-spacing-7);
    margin-right: var(--layout-spacing-7);
}

.layout-u-my-7 {
    margin-top: var(--layout-spacing-7);
    margin-bottom: var(--layout-spacing-7);
}

.layout-u-px-7 {
    padding-left: var(--layout-spacing-7);
    padding-right: var(--layout-spacing-7);
}

.layout-u-py-7 {
    padding-top: var(--layout-spacing-7);
    padding-bottom: var(--layout-spacing-7);
}

.layout-u-mx-8 {
    margin-left: var(--layout-spacing-8);
    margin-right: var(--layout-spacing-8);
}

.layout-u-my-8 {
    margin-top: var(--layout-spacing-8);
    margin-bottom: var(--layout-spacing-8);
}

.layout-u-px-8 {
    padding-left: var(--layout-spacing-8);
    padding-right: var(--layout-spacing-8);
}

.layout-u-py-8 {
    padding-top: var(--layout-spacing-8);
    padding-bottom: var(--layout-spacing-8);
}

.layout-u-mx-9 {
    margin-left: var(--layout-spacing-9);
    margin-right: var(--layout-spacing-9);
}

.layout-u-my-9 {
    margin-top: var(--layout-spacing-9);
    margin-bottom: var(--layout-spacing-9);
}

.layout-u-px-9 {
    padding-left: var(--layout-spacing-9);
    padding-right: var(--layout-spacing-9);
}

.layout-u-py-9 {
    padding-top: var(--layout-spacing-9);
    padding-bottom: var(--layout-spacing-9);
}

.layout-u-mx-10 {
    margin-left: var(--layout-spacing-10);
    margin-right: var(--layout-spacing-10);
}

.layout-u-my-10 {
    margin-top: var(--layout-spacing-10);
    margin-bottom: var(--layout-spacing-10);
}

.layout-u-px-10 {
    padding-left: var(--layout-spacing-10);
    padding-right: var(--layout-spacing-10);
}

.layout-u-py-10 {
    padding-top: var(--layout-spacing-10);
    padding-bottom: var(--layout-spacing-10);
}

.layout-u-mt-0 {
    margin-top: var(--layout-spacing-0);
}

.layout-u-pt-0 {
    padding-top: var(--layout-spacing-0);
}

.layout-u-mb-0 {
    margin-bottom: var(--layout-spacing-0);
}

.layout-u-pb-0 {
    padding-bottom: var(--layout-spacing-0);
}

.layout-u-ml-0 {
    margin-left: var(--layout-spacing-0);
}

.layout-u-pl-0 {
    padding-left: var(--layout-spacing-0);
}

.layout-u-mr-0 {
    margin-right: var(--layout-spacing-0);
}

.layout-u-pr-0 {
    padding-right: var(--layout-spacing-0);
}

.layout-u-mt-1 {
    margin-top: var(--layout-spacing-1);
}

.layout-u-pt-1 {
    padding-top: var(--layout-spacing-1);
}

.layout-u-mb-1 {
    margin-bottom: var(--layout-spacing-1);
}

.layout-u-pb-1 {
    padding-bottom: var(--layout-spacing-1);
}

.layout-u-ml-1 {
    margin-left: var(--layout-spacing-1);
}

.layout-u-pl-1 {
    padding-left: var(--layout-spacing-1);
}

.layout-u-mr-1 {
    margin-right: var(--layout-spacing-1);
}

.layout-u-pr-1 {
    padding-right: var(--layout-spacing-1);
}

.layout-u-mt-2 {
    margin-top: var(--layout-spacing-2);
}

.layout-u-pt-2 {
    padding-top: var(--layout-spacing-2);
}

.layout-u-mb-2 {
    margin-bottom: var(--layout-spacing-2);
}

.layout-u-pb-2 {
    padding-bottom: var(--layout-spacing-2);
}

.layout-u-ml-2 {
    margin-left: var(--layout-spacing-2);
}

.layout-u-pl-2 {
    padding-left: var(--layout-spacing-2);
}

.layout-u-mr-2 {
    margin-right: var(--layout-spacing-2);
}

.layout-u-pr-2 {
    padding-right: var(--layout-spacing-2);
}

.layout-u-mt-3 {
    margin-top: var(--layout-spacing-3);
}

.layout-u-pt-3 {
    padding-top: var(--layout-spacing-3);
}

.layout-u-mb-3 {
    margin-bottom: var(--layout-spacing-3);
}

.layout-u-pb-3 {
    padding-bottom: var(--layout-spacing-3);
}

.layout-u-ml-3 {
    margin-left: var(--layout-spacing-3);
}

.layout-u-pl-3 {
    padding-left: var(--layout-spacing-3);
}

.layout-u-mr-3 {
    margin-right: var(--layout-spacing-3);
}

.layout-u-pr-3 {
    padding-right: var(--layout-spacing-3);
}

.layout-u-mt-4 {
    margin-top: var(--layout-spacing-4);
}

.layout-u-pt-4 {
    padding-top: var(--layout-spacing-4);
}

.layout-u-mb-4 {
    margin-bottom: var(--layout-spacing-4);
}

.layout-u-pb-4 {
    padding-bottom: var(--layout-spacing-4);
}

.layout-u-ml-4 {
    margin-left: var(--layout-spacing-4);
}

.layout-u-pl-4 {
    padding-left: var(--layout-spacing-4);
}

.layout-u-mr-4 {
    margin-right: var(--layout-spacing-4);
}

.layout-u-pr-4 {
    padding-right: var(--layout-spacing-4);
}

.layout-u-mt-5 {
    margin-top: var(--layout-spacing-5);
}

.layout-u-pt-5 {
    padding-top: var(--layout-spacing-5);
}

.layout-u-mb-5 {
    margin-bottom: var(--layout-spacing-5);
}

.layout-u-pb-5 {
    padding-bottom: var(--layout-spacing-5);
}

.layout-u-ml-5 {
    margin-left: var(--layout-spacing-5);
}

.layout-u-pl-5 {
    padding-left: var(--layout-spacing-5);
}

.layout-u-mr-5 {
    margin-right: var(--layout-spacing-5);
}

.layout-u-pr-5 {
    padding-right: var(--layout-spacing-5);
}

.layout-u-mt-6 {
    margin-top: var(--layout-spacing-6);
}

.layout-u-pt-6 {
    padding-top: var(--layout-spacing-6);
}

.layout-u-mb-6 {
    margin-bottom: var(--layout-spacing-6);
}

.layout-u-pb-6 {
    padding-bottom: var(--layout-spacing-6);
}

.layout-u-ml-6 {
    margin-left: var(--layout-spacing-6);
}

.layout-u-pl-6 {
    padding-left: var(--layout-spacing-6);
}

.layout-u-mr-6 {
    margin-right: var(--layout-spacing-6);
}

.layout-u-pr-6 {
    padding-right: var(--layout-spacing-6);
}

.layout-u-mt-7 {
    margin-top: var(--layout-spacing-7);
}

.layout-u-pt-7 {
    padding-top: var(--layout-spacing-7);
}

.layout-u-mb-7 {
    margin-bottom: var(--layout-spacing-7);
}

.layout-u-pb-7 {
    padding-bottom: var(--layout-spacing-7);
}

.layout-u-ml-7 {
    margin-left: var(--layout-spacing-7);
}

.layout-u-pl-7 {
    padding-left: var(--layout-spacing-7);
}

.layout-u-mr-7 {
    margin-right: var(--layout-spacing-7);
}

.layout-u-pr-7 {
    padding-right: var(--layout-spacing-7);
}

.layout-u-mt-8 {
    margin-top: var(--layout-spacing-8);
}

.layout-u-pt-8 {
    padding-top: var(--layout-spacing-8);
}

.layout-u-mb-8 {
    margin-bottom: var(--layout-spacing-8);
}

.layout-u-pb-8 {
    padding-bottom: var(--layout-spacing-8);
}

.layout-u-ml-8 {
    margin-left: var(--layout-spacing-8);
}

.layout-u-pl-8 {
    padding-left: var(--layout-spacing-8);
}

.layout-u-mr-8 {
    margin-right: var(--layout-spacing-8);
}

.layout-u-pr-8 {
    padding-right: var(--layout-spacing-8);
}

.layout-u-mt-9 {
    margin-top: var(--layout-spacing-9);
}

.layout-u-pt-9 {
    padding-top: var(--layout-spacing-9);
}

.layout-u-mb-9 {
    margin-bottom: var(--layout-spacing-9);
}

.layout-u-pb-9 {
    padding-bottom: var(--layout-spacing-9);
}

.layout-u-ml-9 {
    margin-left: var(--layout-spacing-9);
}

.layout-u-pl-9 {
    padding-left: var(--layout-spacing-9);
}

.layout-u-mr-9 {
    margin-right: var(--layout-spacing-9);
}

.layout-u-pr-9 {
    padding-right: var(--layout-spacing-9);
}

.layout-u-mt-10 {
    margin-top: var(--layout-spacing-10);
}

.layout-u-pt-10 {
    padding-top: var(--layout-spacing-10);
}

.layout-u-mb-10 {
    margin-bottom: var(--layout-spacing-10);
}

.layout-u-pb-10 {
    padding-bottom: var(--layout-spacing-10);
}

.layout-u-ml-10 {
    margin-left: var(--layout-spacing-10);
}

.layout-u-pl-10 {
    padding-left: var(--layout-spacing-10);
}

.layout-u-mr-10 {
    margin-right: var(--layout-spacing-10);
}

.layout-u-pr-10 {
    padding-right: var(--layout-spacing-10);
}

.layout-u-content-fill-height {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
}

.layout-u-content-fill-height > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 0px;
    flex: 1 1 0;
    height: auto;
}

.layout-u-position-relative {
    position: relative;
}

.kk-u-position-relative {
    position: relative !important;
}

.kk-u-content-fill-height {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
}

.kk-u-content-fill-height > * {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 0px;
    flex: 1 1 0;
    height: auto;
}

.kk-u-m-0 {
    margin: 0 !important;
}

.kk-u-p-0 {
    padding: 0 !important;
}

.kk-u-m-1 {
    margin: 2px !important;
}

.kk-u-p-1 {
    padding: 2px !important;
}

.kk-u-m-2 {
    margin: 4px !important;
}

.kk-u-p-2 {
    padding: 4px !important;
}

.kk-u-m-3 {
    margin: 8px !important;
}

.kk-u-p-3 {
    padding: 8px !important;
}

.kk-u-m-4 {
    margin: 12px !important;
}

.kk-u-p-4 {
    padding: 12px !important;
}

.kk-u-m-5 {
    margin: 16px !important;
}

.kk-u-p-5 {
    padding: 16px !important;
}

.kk-u-m-6 {
    margin: 20px !important;
}

.kk-u-p-6 {
    padding: 20px !important;
}

.kk-u-m-7 {
    margin: 24px !important;
}

.kk-u-p-7 {
    padding: 24px !important;
}

.kk-u-m-8 {
    margin: 32px !important;
}

.kk-u-p-8 {
    padding: 32px !important;
}

.kk-u-m-9 {
    margin: 40px !important;
}

.kk-u-p-9 {
    padding: 40px !important;
}

.kk-u-m-10 {
    margin: 48px !important;
}

.kk-u-p-10 {
    padding: 48px !important;
}

.kk-u-mx-0 {
    margin-left: 0 !important;
    margin-right: 0 !important;
}

.kk-u-my-0 {
    margin-top: 0 !important;
    margin-bottom: 0 !important;
}

.kk-u-px-0 {
    padding-left: 0 !important;
    padding-right: 0 !important;
}

.kk-u-py-0 {
    padding-top: 0 !important;
    padding-bottom: 0 !important;
}

.kk-u-mx-1 {
    margin-left: 2px !important;
    margin-right: 2px !important;
}

.kk-u-my-1 {
    margin-top: 2px !important;
    margin-bottom: 2px !important;
}

.kk-u-px-1 {
    padding-left: 2px !important;
    padding-right: 2px !important;
}

.kk-u-py-1 {
    padding-top: 2px !important;
    padding-bottom: 2px !important;
}

.kk-u-mx-2 {
    margin-left: 4px !important;
    margin-right: 4px !important;
}

.kk-u-my-2 {
    margin-top: 4px !important;
    margin-bottom: 4px !important;
}

.kk-u-px-2 {
    padding-left: 4px !important;
    padding-right: 4px !important;
}

.kk-u-py-2 {
    padding-top: 4px !important;
    padding-bottom: 4px !important;
}

.kk-u-mx-3 {
    margin-left: 8px !important;
    margin-right: 8px !important;
}

.kk-u-my-3 {
    margin-top: 8px !important;
    margin-bottom: 8px !important;
}

.kk-u-px-3 {
    padding-left: 8px !important;
    padding-right: 8px !important;
}

.kk-u-py-3 {
    padding-top: 8px !important;
    padding-bottom: 8px !important;
}

.kk-u-mx-4 {
    margin-left: 12px !important;
    margin-right: 12px !important;
}

.kk-u-my-4 {
    margin-top: 12px !important;
    margin-bottom: 12px !important;
}

.kk-u-px-4 {
    padding-left: 12px !important;
    padding-right: 12px !important;
}

.kk-u-py-4 {
    padding-top: 12px !important;
    padding-bottom: 12px !important;
}

.kk-u-mx-5 {
    margin-left: 16px !important;
    margin-right: 16px !important;
}

.kk-u-my-5 {
    margin-top: 16px !important;
    margin-bottom: 16px !important;
}

.kk-u-px-5 {
    padding-left: 16px !important;
    padding-right: 16px !important;
}

.kk-u-py-5 {
    padding-top: 16px !important;
    padding-bottom: 16px !important;
}

.kk-u-mx-6 {
    margin-left: 20px !important;
    margin-right: 20px !important;
}

.kk-u-my-6 {
    margin-top: 20px !important;
    margin-bottom: 20px !important;
}

.kk-u-px-6 {
    padding-left: 20px !important;
    padding-right: 20px !important;
}

.kk-u-py-6 {
    padding-top: 20px !important;
    padding-bottom: 20px !important;
}

.kk-u-mx-7 {
    margin-left: 24px !important;
    margin-right: 24px !important;
}

.kk-u-my-7 {
    margin-top: 24px !important;
    margin-bottom: 24px !important;
}

.kk-u-px-7 {
    padding-left: 24px !important;
    padding-right: 24px !important;
}

.kk-u-py-7 {
    padding-top: 24px !important;
    padding-bottom: 24px !important;
}

.kk-u-mx-8 {
    margin-left: 32px !important;
    margin-right: 32px !important;
}

.kk-u-my-8 {
    margin-top: 32px !important;
    margin-bottom: 32px !important;
}

.kk-u-px-8 {
    padding-left: 32px !important;
    padding-right: 32px !important;
}

.kk-u-py-8 {
    padding-top: 32px !important;
    padding-bottom: 32px !important;
}

.kk-u-mx-9 {
    margin-left: 40px !important;
    margin-right: 40px !important;
}

.kk-u-my-9 {
    margin-top: 40px !important;
    margin-bottom: 40px !important;
}

.kk-u-px-9 {
    padding-left: 40px !important;
    padding-right: 40px !important;
}

.kk-u-py-9 {
    padding-top: 40px !important;
    padding-bottom: 40px !important;
}

.kk-u-mx-10 {
    margin-left: 48px !important;
    margin-right: 48px !important;
}

.kk-u-my-10 {
    margin-top: 48px !important;
    margin-bottom: 48px !important;
}

.kk-u-px-10 {
    padding-left: 48px !important;
    padding-right: 48px !important;
}

.kk-u-py-10 {
    padding-top: 48px !important;
    padding-bottom: 48px !important;
}

.kk-u-mt-0 {
    margin-top: 0 !important;
}

.kk-u-pt-0 {
    padding-top: 0 !important;
}

.kk-u-mb-0 {
    margin-bottom: 0 !important;
}

.kk-u-pb-0 {
    padding-bottom: 0 !important;
}

.kk-u-ml-0 {
    margin-left: 0 !important;
}

.kk-u-pl-0 {
    padding-left: 0 !important;
}

.kk-u-mr-0 {
    margin-right: 0 !important;
}

.kk-u-pr-0 {
    padding-right: 0 !important;
}

.kk-u-mt-1 {
    margin-top: 2px !important;
}

.kk-u-pt-1 {
    padding-top: 2px !important;
}

.kk-u-mb-1 {
    margin-bottom: 2px !important;
}

.kk-u-pb-1 {
    padding-bottom: 2px !important;
}

.kk-u-ml-1 {
    margin-left: 2px !important;
}

.kk-u-pl-1 {
    padding-left: 2px !important;
}

.kk-u-mr-1 {
    margin-right: 2px !important;
}

.kk-u-pr-1 {
    padding-right: 2px !important;
}

.kk-u-mt-2 {
    margin-top: 4px !important;
}

.kk-u-pt-2 {
    padding-top: 4px !important;
}

.kk-u-mb-2 {
    margin-bottom: 4px !important;
}

.kk-u-pb-2 {
    padding-bottom: 4px !important;
}

.kk-u-ml-2 {
    margin-left: 4px !important;
}

.kk-u-pl-2 {
    padding-left: 4px !important;
}

.kk-u-mr-2 {
    margin-right: 4px !important;
}

.kk-u-pr-2 {
    padding-right: 4px !important;
}

.kk-u-mt-3 {
    margin-top: 8px !important;
}

.kk-u-pt-3 {
    padding-top: 8px !important;
}

.kk-u-mb-3 {
    margin-bottom: 8px !important;
}

.kk-u-pb-3 {
    padding-bottom: 8px !important;
}

.kk-u-ml-3 {
    margin-left: 8px !important;
}

.kk-u-pl-3 {
    padding-left: 8px !important;
}

.kk-u-mr-3 {
    margin-right: 8px !important;
}

.kk-u-pr-3 {
    padding-right: 8px !important;
}

.kk-u-mt-4 {
    margin-top: 12px !important;
}

.kk-u-pt-4 {
    padding-top: 12px !important;
}

.kk-u-mb-4 {
    margin-bottom: 12px !important;
}

.kk-u-pb-4 {
    padding-bottom: 12px !important;
}

.kk-u-ml-4 {
    margin-left: 12px !important;
}

.kk-u-pl-4 {
    padding-left: 12px !important;
}

.kk-u-mr-4 {
    margin-right: 12px !important;
}

.kk-u-pr-4 {
    padding-right: 12px !important;
}

.kk-u-mt-5 {
    margin-top: 16px !important;
}

.kk-u-pt-5 {
    padding-top: 16px !important;
}

.kk-u-mb-5 {
    margin-bottom: 16px !important;
}

.kk-u-pb-5 {
    padding-bottom: 16px !important;
}

.kk-u-ml-5 {
    margin-left: 16px !important;
}

.kk-u-pl-5 {
    padding-left: 16px !important;
}

.kk-u-mr-5 {
    margin-right: 16px !important;
}

.kk-u-pr-5 {
    padding-right: 16px !important;
}

.kk-u-mt-6 {
    margin-top: 20px !important;
}

.kk-u-pt-6 {
    padding-top: 20px !important;
}

.kk-u-mb-6 {
    margin-bottom: 20px !important;
}

.kk-u-pb-6 {
    padding-bottom: 20px !important;
}

.kk-u-ml-6 {
    margin-left: 20px !important;
}

.kk-u-pl-6 {
    padding-left: 20px !important;
}

.kk-u-mr-6 {
    margin-right: 20px !important;
}

.kk-u-pr-6 {
    padding-right: 20px !important;
}

.kk-u-mt-7 {
    margin-top: 24px !important;
}

.kk-u-pt-7 {
    padding-top: 24px !important;
}

.kk-u-mb-7 {
    margin-bottom: 24px !important;
}

.kk-u-pb-7 {
    padding-bottom: 24px !important;
}

.kk-u-ml-7 {
    margin-left: 24px !important;
}

.kk-u-pl-7 {
    padding-left: 24px !important;
}

.kk-u-mr-7 {
    margin-right: 24px !important;
}

.kk-u-pr-7 {
    padding-right: 24px !important;
}

.kk-u-mt-8 {
    margin-top: 32px !important;
}

.kk-u-pt-8 {
    padding-top: 32px !important;
}

.kk-u-mb-8 {
    margin-bottom: 32px !important;
}

.kk-u-pb-8 {
    padding-bottom: 32px !important;
}

.kk-u-ml-8 {
    margin-left: 32px !important;
}

.kk-u-pl-8 {
    padding-left: 32px !important;
}

.kk-u-mr-8 {
    margin-right: 32px !important;
}

.kk-u-pr-8 {
    padding-right: 32px !important;
}

.kk-u-mt-9 {
    margin-top: 40px !important;
}

.kk-u-pt-9 {
    padding-top: 40px !important;
}

.kk-u-mb-9 {
    margin-bottom: 40px !important;
}

.kk-u-pb-9 {
    padding-bottom: 40px !important;
}

.kk-u-ml-9 {
    margin-left: 40px !important;
}

.kk-u-pl-9 {
    padding-left: 40px !important;
}

.kk-u-mr-9 {
    margin-right: 40px !important;
}

.kk-u-pr-9 {
    padding-right: 40px !important;
}

.kk-u-mt-10 {
    margin-top: 48px !important;
}

.kk-u-pt-10 {
    padding-top: 48px !important;
}

.kk-u-mb-10 {
    margin-bottom: 48px !important;
}

.kk-u-pb-10 {
    padding-bottom: 48px !important;
}

.kk-u-ml-10 {
    margin-left: 48px !important;
}

.kk-u-pl-10 {
    padding-left: 48px !important;
}

.kk-u-mr-10 {
    margin-right: 48px !important;
}

.kk-u-pr-10 {
    padding-right: 48px !important;
}

.kk-u-text-h4 {
    font-size: 24px;
    line-height: 30px;
    font-weight: 700;
}

.kk-u-text-h5 {
    font-size: 22px;
    line-height: 28px;
    font-weight: 700;
}

.kk-u-text-h6 {
    font-size: 18px;
    line-height: 26px;
    font-weight: 700;
}

.kk-u-text-subtitle-lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 700;
}

.kk-u-text-subtitle-md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 500;
}

.kk-u-text-body-lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400;
}

.kk-u-text-body-md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-u-text-body-sm,
.kk-u-text-category {
    font-size: 12px;
    line-height: 16px;
    font-weight: 400;
}

.kk-u-text-lighter {
    color: #d5d6db !important;
}

.kk-u-text-light {
    color: #babbbe !important;
}

.kk-u-text-medium {
    color: #9c9da0 !important;
}

.kk-u-text-dark {
    color: #727272 !important;
}

.kk-u-text-darker {
    color: #212121 !important;
}

.kk-u-text-primary-lighter {
    color: #cef0f3 !important;
}

.kk-u-text-primary-light {
    color: #ade6eb !important;
}

.kk-u-text-primary-medium {
    color: #26bec9 !important;
}

.kk-u-text-primary-dark {
    color: #13a3b6 !important;
}

.kk-u-text-primary-darker {
    color: #068b9f !important;
}

.kk-u-text-critical-lighter {
    color: #f5a8a4 !important;
}

.kk-u-text-critical-light {
    color: #f2918a !important;
}

.kk-u-text-critical-medium {
    color: #ef7a70 !important;
}

.kk-u-text-critical-dark {
    color: #e65f50 !important;
}

.kk-u-text-critical-darker {
    color: #d14330 !important;
}

.kk-u-text-info-lighter {
    color: #9dd3fa !important;
}

.kk-u-text-info-light {
    color: #81c4f7 !important;
}

.kk-u-text-info-medium {
    color: #64b3f4 !important;
}

.kk-u-text-info-dark {
    color: #2d84d6 !important;
}

.kk-u-text-info-darker {
    color: #1565c0 !important;
}

.kk-u-text-warning-lighter {
    color: #fee269 !important;
}

.kk-u-text-warning-light {
    color: #facf58 !important;
}

.kk-u-text-warning-medium {
    color: #f5b53d !important;
}

.kk-u-text-warning-dark {
    color: #e78f37 !important;
}

.kk-u-text-warning-darker {
    color: #de6928 !important;
}

.kk-u-text-highlight-lighter {
    color: #ffca28 !important;
}

.kk-u-text-highlight-light {
    color: #ffc128 !important;
}

.kk-u-text-highlight-medium {
    color: #ffb400 !important;
}

.kk-u-text-highlight-dark {
    color: #ffa000 !important;
}

.kk-u-text-highlight-darker {
    color: #ff8f00 !important;
}

.kk-u-text-align-left {
    text-align: left !important;
}

.kk-u-text-align-center {
    text-align: center !important;
}

.kk-u-text-align-right {
    text-align: right !important;
}

.kk-u-text-ellipsis {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
}

.kk-u-text-line-clamp-1 {
    -webkit-line-clamp: 1;
}

.kk-u-text-line-clamp-1,
.kk-u-text-line-clamp-2 {
    display: -webkit-box;
    -webkit-box-orient: vertical;
    overflow: hidden;
}

.kk-u-text-line-clamp-2 {
    -webkit-line-clamp: 2;
}

.kk-u-text-line-clamp-3 {
    -webkit-line-clamp: 3;
}

.kk-u-text-line-clamp-3,
.kk-u-text-line-clamp-4 {
    display: -webkit-box;
    -webkit-box-orient: vertical;
    overflow: hidden;
}

.kk-u-text-line-clamp-4 {
    -webkit-line-clamp: 4;
}

.kk-u-text-line-clamp-5 {
    display: -webkit-box;
    -webkit-line-clamp: 5;
    -webkit-box-orient: vertical;
    overflow: hidden;
}

.kk-u-text-preserve-newline {
    white-space: pre-line;
}

.accordion-item {
    padding-bottom: 16px;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.accordion-item__header {
    display: grid;
    grid-auto-flow: column;
    grid-template-columns: minmax(0, 1fr) auto;
    gap: 16px;
    padding: 12px 0;
}

.accordion-item__title {
    font-size: 16px;
    line-height: 24px;
    font-weight: 700;
}

.accordion-item__arrow-up {
    -webkit-transition: -webkit-transform 0.3s ease-in-out;
    transition: -webkit-transform 0.3s ease-in-out;
    transition: transform 0.3s ease-in-out;
    transition: transform 0.3s ease-in-out, -webkit-transform 0.3s ease-in-out;
}

.accordion-item--active .accordion-item__arrow-up {
    -webkit-transform: rotate(-180deg);
    transform: rotate(-180deg);
}

.kk-badge {
    --kk-badge-height: 16px;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    min-width: var(--kk-badge-height);
    max-width: 48px;
    height: var(--kk-badge-height);
    border-radius: calc(var(--kk-badge-height) / 2);
    padding: 0 4px;
    overflow: hidden;
    --kk-badge-text-color: #fff;
    --kk-badge-background-color: #e65f50;
    --kk-badge-border-color: #fff;
    --kk-badge-border-width: 1.5px;
    color: var(--kk-badge-text-color);
    background-color: var(--kk-badge-background-color);
    -webkit-box-shadow: 0 0 0 var(--kk-badge-border-width)
        var(--kk-badge-border-color);
    box-shadow: 0 0 0 var(--kk-badge-border-width) var(--kk-badge-border-color);
}

.kk-badge__text {
    --transform-scale: 0.5;
    font-size: 20px;
    font-weight: 700;
    line-height: 1;
    white-space: nowrap;
    -webkit-transform: scale(var(--transform-scale));
    transform: scale(var(--transform-scale));
    -webkit-transform-origin: center;
    transform-origin: center;
}

.kk-badge--marketing-date {
    --kk-badge-background-color: #f5b53d;
}

.kk-badge--marketing-discount {
    --kk-badge-text-color: #e65f50;
    --kk-badge-background-color: #fff;
    --kk-badge-border-color: #ef7a70;
}

.kk-badge:empty {
    padding: 0;
    width: var(--kk-badge-height);
}

.kk-badge--md:empty {
    --kk-badge-height: 6px;
}

.kk-badge--lg:empty {
    --kk-badge-height: 10px;
    --kk-badge-border-width: 2.5px;
}

.kk-badge--xl:empty {
    --kk-badge-height: 12px;
    --kk-badge-border-width: 2.5px;
}

.kk-avatar {
    --action-icon-container-size: 24px;
    --action-icon-size: 16px;
    --border-width: 1px;
    --icon-avatar-border: var(--border-width) solid #e6e9ed;
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    text-align: center;
    overflow: visible;
    border-radius: 50%;
    position: relative;
    width: var(--avatar-size);
    height: var(--avatar-size);
}

.kk-avatar,
.kk-avatar__content-container {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
}

.kk-avatar__content-container {
    border-radius: inherit;
    width: 100%;
    height: 100%;
    overflow: hidden;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
}

.kk-avatar__content-container--img {
    border: var(--border-width) solid #fff;
}

.kk-avatar__content-container--img > img {
    display: block;
    width: 100%;
    height: 100%;
    -o-object-fit: cover;
    object-fit: cover;
}

.kk-avatar__content-container--icon {
    background: var(--avatar-background, #f1f4f8);
    color: var(--avatar-color, #9c9da0);
    border: var(--icon-avatar-border);
}

.kk-avatar__content-container--text {
    background: var(--avatar-background, #26bec9);
    color: var(--avatar-color, #fff);
    border: none;
    font-size: var(--text-avatar-font-size);
    font-weight: var(--text-avatar-font-weight);
    line-height: 1;
}

.kk-avatar__icon {
    display: block;
    fill: currentColor;
    width: var(--avatar-icon-size);
    height: var(--avatar-icon-size);
}

.kk-avatar--action {
    cursor: pointer;
}

.kk-avatar--action:hover .kk-avatar__content-container--img {
    border: var(--border-width) solid #babbbe;
}

.kk-avatar__badge {
    position: absolute;
    top: var(--avatar-offset-top);
    right: var(--avatar-offset-right);
}

.kk-avatar--xs {
    --avatar-size: 32px;
    --avatar-icon-size: 16px;
    --avatar-offset-top: 2px;
    --avatar-offset-right: 2px;
}

.kk-avatar--xs .kk-avatar__content-container--text {
    --text-avatar-font-size: 12px;
    --text-avatar-font-weight: 700;
}

.kk-avatar--sm {
    --avatar-size: 40px;
    --avatar-icon-size: 20px;
    --avatar-offset-top: 0;
    --avatar-offset-right: 0;
}

.kk-avatar--sm .kk-avatar__content-container--text {
    --text-avatar-font-size: 16px;
    --text-avatar-font-weight: 400;
}

.kk-avatar--md {
    --avatar-size: 48px;
    --avatar-icon-size: 24px;
    --avatar-offset-top: 2px;
    --avatar-offset-right: 2px;
}

.kk-avatar--md .kk-avatar__content-container--text {
    --text-avatar-font-size: 20px;
    --text-avatar-font-weight: 700;
}

.kk-avatar--lg {
    --avatar-size: 64px;
    --avatar-icon-size: 32px;
    --avatar-offset-top: 4px;
    --avatar-offset-right: 4px;
}

.kk-avatar--lg .kk-avatar__content-container--text {
    --text-avatar-font-size: 28px;
    --text-avatar-font-weight: 500;
}

.kk-avatar--xl {
    --avatar-size: 80px;
    --avatar-icon-size: 40px;
    --avatar-offset-top: 6px;
    --avatar-offset-right: 6px;
}

.kk-avatar--xl .kk-avatar__content-container--text {
    --text-avatar-font-size: 36px;
    --text-avatar-font-weight: 700;
}

.kk-avatar--2xl {
    --avatar-size: 96px;
    --avatar-icon-size: 48px;
    --avatar-offset-top: 8px;
    --avatar-offset-right: 8px;
}

.kk-avatar--2xl .kk-avatar__content-container--text {
    --text-avatar-font-size: 48px;
    --text-avatar-font-weight: 700;
}

.kk-avatar__action-icon-container {
    position: absolute;
    right: 0;
    bottom: 0;
    background: #fff;
    border-radius: 50%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    width: var(--action-icon-container-size);
    height: var(--action-icon-container-size);
    -webkit-box-shadow: 0 1px 4px rgba(38, 50, 56, 0.1215686275);
    box-shadow: 0 1px 4px rgba(38, 50, 56, 0.1215686275);
}

.kk-avatar__action-icon-container .kk-avatar__action-icon {
    display: block;
    fill: #727272;
    width: var(--action-icon-size);
    height: var(--action-icon-size);
}

.kk-avatar--md .kk-avatar__action-icon-container {
    right: -2px;
    bottom: -2px;
}

.kk-avatar--2xl,
.kk-avatar--xl {
    --action-icon-container-size: 32px;
    --action-icon-size: 20px;
}

.kk-avatar--2xl,
.kk-avatar--lg,
.kk-avatar--xl {
    --border-width: 2px;
}

.kk-avatar--cyan .kk-avatar__content-container--icon,
.kk-avatar--cyan .kk-avatar__content-container--text {
    --avatar-background: #26bec9;
    --avatar-color: #fff;
    --icon-avatar-border: none;
}

.kk-avatar--blue .kk-avatar__content-container--icon,
.kk-avatar--blue .kk-avatar__content-container--text {
    --avatar-background: #64b3f4;
    --avatar-color: #fff;
    --icon-avatar-border: none;
}

.kk-avatar--amber .kk-avatar__content-container--icon,
.kk-avatar--amber .kk-avatar__content-container--text {
    --avatar-background: #ffb400;
    --avatar-color: #fff;
    --icon-avatar-border: none;
}

.kk-avatar--red .kk-avatar__content-container--icon,
.kk-avatar--red .kk-avatar__content-container--text {
    --avatar-background: #ef7a70;
    --avatar-color: #fff;
    --icon-avatar-border: none;
}

.kk-avatar--neutral .kk-avatar__content-container--icon,
.kk-avatar--neutral .kk-avatar__content-container--text {
    --avatar-background: #9c9da0;
    --avatar-color: #fff;
    --icon-avatar-border: none;
}

.kk-icon {
    --icon-size: 24px;
    display: block;
    fill: currentColor;
    width: var(--icon-size);
    height: var(--icon-size);
}

.kk-icon--2xs {
    --icon-size: 14px;
}

.kk-icon--xs {
    --icon-size: 16px;
}

.kk-icon--sm {
    --icon-size: 20px;
}

.kk-icon--md {
    --icon-size: 24px;
}

.kk-icon--lg {
    --icon-size: 32px;
}

.kk-icon--xl {
    --icon-size: 48px;
}

.kk-bottom-sheet {
    --open-close-transition-duration: 0.4s;
    --open-close-transition-duration-after-swipe: 0.3s;
    --body-border-top-transition-duration: 0.1s;
    --overlay-opacity: 0.48;
    --overlay-drag-down-min-opacity: 0.24;
    --drag-up-stickiness: 0.3;
    --close-by-swiping-down-threshold-distance: 200px;
    --close-by-swiping-down-threshold-ratio: 0.33;
    --close-by-swiping-down-threshold-speed: 1000;
    --kk-bottom-sheet-z-index: 1000;
}

.kk-bottom-sheet__fixed-wrapper {
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    height: 100%;
    display: grid;
    grid-template-rows: minmax(16px, 1fr) auto;
    grid-template-areas: 'top-spacer' 'sheet';
    visibility: hidden;
    will-change: transform;
    -webkit-transform: translateY(100%);
    transform: translateY(100%);
    -webkit-transition: visibility 0s var(--open-close-transition-duration),
        -webkit-transform var(--open-close-transition-duration);
    transition: visibility 0s var(--open-close-transition-duration),
        -webkit-transform var(--open-close-transition-duration);
    transition: transform var(--open-close-transition-duration),
        visibility 0s var(--open-close-transition-duration);
    transition: transform var(--open-close-transition-duration),
        visibility 0s var(--open-close-transition-duration),
        -webkit-transform var(--open-close-transition-duration);
    z-index: calc(var(--kk-bottom-sheet-z-index) + 1);
}

.kk-bottom-sheet__fixed-wrapper:after {
    content: '';
    position: absolute;
    top: 100%;
    left: 0;
    width: 100%;
    height: 500px;
    background-color: #fff;
}

.kk-bottom-sheet--full-height .kk-bottom-sheet__fixed-wrapper {
    grid-template-rows: 16px 1fr;
}

.kk-bottom-sheet__top-spacer {
    grid-area: top-spacer;
}

.kk-bottom-sheet__sheet {
    grid-area: sheet;
    display: grid;
    grid-template-rows: auto auto minmax(0, 1fr);
    grid-template-areas: 'handle' 'header' 'content';
    min-height: 240px;
    padding-bottom: env(safe-area-inset-bottom, 0);
    border-radius: 16px 16px 0 0;
    background-color: #fff;
    overflow: hidden;
}

.kk-bottom-sheet__overlay {
    visibility: hidden;
    position: fixed;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    opacity: 0;
    background-color: #000;
    will-change: opacity;
    -webkit-transition: opacity var(--open-close-transition-duration),
        visibility 0s var(--open-close-transition-duration);
    transition: opacity var(--open-close-transition-duration),
        visibility 0s var(--open-close-transition-duration);
    z-index: var(--kk-bottom-sheet-z-index);
}

.kk-bottom-sheet__handle {
    grid-area: handle;
    width: 40px;
    height: 4px;
    border-radius: 2px;
    background-color: #d5d6db;
    margin: 8px auto;
}

.kk-bottom-sheet__header {
    grid-area: header;
    color: #212121;
    background-color: #fff;
}

.kk-bottom-sheet__title-grid {
    display: grid;
    grid-template-columns: 64px 1fr 64px;
    gap: 8px;
    padding: 12px 24px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.kk-bottom-sheet__icon-button {
    justify-self: left;
    cursor: pointer;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    -webkit-box-sizing: content-box;
    box-sizing: content-box;
    padding: 4px;
    margin: -4px;
}

.kk-bottom-sheet__title {
    font-size: 16px;
    line-height: 24px;
    font-weight: 700;
    text-align: center;
}

.kk-bottom-sheet__link,
.kk-bottom-sheet__title {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
}

.kk-bottom-sheet__link {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
    cursor: pointer;
    color: #212121;
    text-decoration: underline;
    justify-self: right;
    max-width: 64px;
}

.kk-bottom-sheet__content {
    grid-area: content;
    display: grid;
    grid-template-rows: auto minmax(0, 1fr) auto auto;
    grid-template-areas: 'below-header' 'body' 'above-footer' 'footer';
    background-color: #fff;
}

.kk-bottom-sheet__below-header {
    grid-area: below-header;
}

.kk-bottom-sheet__body {
    grid-area: body;
    overflow: auto;
    border-top: 1px solid #d5d6db;
    -webkit-transition: border-color var(--body-border-top-transition-duration)
        ease;
    transition: border-color var(--body-border-top-transition-duration) ease;
}

.kk-bottom-sheet__body--scroll-at-top {
    border-top-color: transparent;
}

.kk-bottom-sheet__above-footer {
    grid-area: above-footer;
    border-top: 1px solid #d5d6db;
}

.kk-bottom-sheet__footer {
    grid-area: footer;
    border-top: 1px solid #d5d6db;
}

.kk-bottom-sheet__footer-container {
    padding: 16px 24px;
}

.kk-bottom-sheet__above-footer + .kk-bottom-sheet__footer {
    border-top: none;
}

.kk-bottom-sheet--open > .kk-bottom-sheet__fixed-wrapper {
    visibility: visible;
    -webkit-transform: translateY(0);
    transform: translateY(0);
    -webkit-transition: visibility 0s,
        -webkit-transform var(--open-close-transition-duration);
    transition: visibility 0s,
        -webkit-transform var(--open-close-transition-duration);
    transition: transform var(--open-close-transition-duration), visibility 0s;
    transition: transform var(--open-close-transition-duration), visibility 0s,
        -webkit-transform var(--open-close-transition-duration);
}

.kk-bottom-sheet--open > .kk-bottom-sheet__overlay {
    opacity: var(--overlay-opacity);
    visibility: visible;
    -webkit-transition: opacity var(--open-close-transition-duration),
        visibility 0s;
    transition: opacity var(--open-close-transition-duration), visibility 0s;
}

.kk-bottom-sheet-with-navigation {
    --navigation-transition-duration: 0.3s;
    --navigation-transition-duration-after-swipe: 0.2s;
    --navigation-content-translate-offset: 120px;
    --navigation-content-overlay-opacity: 0.08;
    --navigation-content-overlay-drag-right-min-opacity: 0.008;
    --navigation-back-by-swiping-right-threshold: 50px;
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__header:last-of-type {
    opacity: 1;
    z-index: 3;
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__header:nth-last-of-type(2) {
    z-index: 2;
}

.kk-bottom-sheet-with-navigation
    .kk-bottom-sheet__header:nth-last-of-type(n + 2) {
    opacity: 0;
}

.kk-bottom-sheet-with-navigation
    .kk-bottom-sheet__header:nth-last-of-type(n + 3) {
    z-index: 1;
}

.kk-bottom-sheet-with-navigation.kk-bottom-sheet--open
    .kk-bottom-sheet__header:last-of-type,
.kk-bottom-sheet-with-navigation.kk-bottom-sheet--open
    .kk-bottom-sheet__header:nth-last-of-type(2) {
    will-change: opacity;
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet__header,
.kk-bottom-sheet-with-navigation--on-pushing .kk-bottom-sheet__header {
    -webkit-transition: opacity var(--navigation-transition-duration) linear;
    transition: opacity var(--navigation-transition-duration) linear;
}

.kk-bottom-sheet-with-navigation--on-popping
    .kk-bottom-sheet__header:last-of-type,
.kk-bottom-sheet-with-navigation--on-start-pushing
    .kk-bottom-sheet__header:last-of-type {
    opacity: 0;
}

.kk-bottom-sheet-with-navigation--on-popping
    .kk-bottom-sheet__header:nth-last-of-type(2),
.kk-bottom-sheet-with-navigation--on-start-pushing
    .kk-bottom-sheet__header:nth-last-of-type(2) {
    opacity: 1;
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__content:last-of-type {
    z-index: 4;
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__content:nth-last-of-type(2) {
    z-index: 2;
}

.kk-bottom-sheet-with-navigation
    .kk-bottom-sheet__content:nth-last-of-type(n + 2) {
    -webkit-transform: translate(
        calc(var(--navigation-content-translate-offset) * -1)
    );
    transform: translate(calc(var(--navigation-content-translate-offset) * -1));
}

.kk-bottom-sheet-with-navigation
    .kk-bottom-sheet__content:nth-last-of-type(n + 3) {
    z-index: 1;
}

.kk-bottom-sheet-with-navigation.kk-bottom-sheet--open
    .kk-bottom-sheet__content:last-of-type,
.kk-bottom-sheet-with-navigation.kk-bottom-sheet--open
    .kk-bottom-sheet__content:nth-last-of-type(2) {
    will-change: transform;
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet__content,
.kk-bottom-sheet-with-navigation--on-pushing .kk-bottom-sheet__content {
    -webkit-transition: -webkit-transform var(--navigation-transition-duration)
        ease;
    transition: -webkit-transform var(--navigation-transition-duration) ease;
    transition: transform var(--navigation-transition-duration) ease;
    transition: transform var(--navigation-transition-duration) ease,
        -webkit-transform var(--navigation-transition-duration) ease;
}

.kk-bottom-sheet-with-navigation--on-popping
    .kk-bottom-sheet__content:last-of-type,
.kk-bottom-sheet-with-navigation--on-start-pushing
    .kk-bottom-sheet__content:last-of-type {
    -webkit-transform: translate(100%);
    transform: translate(100%);
}

.kk-bottom-sheet-with-navigation--on-popping
    .kk-bottom-sheet__content:nth-last-of-type(2),
.kk-bottom-sheet-with-navigation--on-start-pushing
    .kk-bottom-sheet__content:nth-last-of-type(2) {
    -webkit-transform: translate(0);
    transform: translate(0);
}

.kk-bottom-sheet-with-navigation__content-overlay {
    grid-area: content;
    background-color: #000;
    opacity: var(--navigation-content-overlay-opacity);
    z-index: 3;
}

.kk-bottom-sheet--open .kk-bottom-sheet-with-navigation__content-overlay {
    will-change: opacity;
}

.kk-bottom-sheet-with-navigation--on-popping
    .kk-bottom-sheet-with-navigation__content-overlay,
.kk-bottom-sheet-with-navigation--on-pushing
    .kk-bottom-sheet-with-navigation__content-overlay {
    -webkit-transition: opacity var(--navigation-transition-duration) linear;
    transition: opacity var(--navigation-transition-duration) linear;
}

.kk-bottom-sheet-with-navigation--on-popping
    .kk-bottom-sheet-with-navigation__content-overlay,
.kk-bottom-sheet-with-navigation--on-start-pushing
    .kk-bottom-sheet-with-navigation__content-overlay {
    opacity: 0;
}

.kk-checkbox {
    display: block;
    margin: 0;
}

.kk-checkbox__input {
    display: none;
}

.kk-checkbox__selector {
    --checkbox-background: #fff;
    --checkbox-border: 1px solid #d5d6db;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 20px;
    height: 20px;
    color: #fff;
    background: var(--checkbox-background);
    border: var(--checkbox-border);
    border-radius: 4px;
    cursor: pointer;
}

.kk-checkbox__input:disabled + .kk-checkbox__selector {
    cursor: default;
    --checkbox-border: 1px solid #d5d6db;
    --checkbox-background: #e6e9ed;
}

.kk-checkbox__input:checked + .kk-checkbox__selector,
.kk-checkbox__input:indeterminate + .kk-checkbox__selector {
    --checkbox-border: none;
    --checkbox-background: #26bec9;
}

.kk-checkbox__input:disabled:checked + .kk-checkbox__selector,
.kk-checkbox__input:disabled:indeterminate + .kk-checkbox__selector {
    --checkbox-background: #cef0f3;
}

@media (hover: hover) {
    .kk-checkbox:hover
        .kk-checkbox__input:not(:disabled)
        + .kk-checkbox__selector {
        --checkbox-border: 1px solid #babbbe;
    }

    .kk-checkbox:hover .kk-checkbox__input:checked + .kk-checkbox__selector,
    .kk-checkbox:hover
        .kk-checkbox__input:indeterminate
        + .kk-checkbox__selector {
        --checkbox-border: none;
    }
}

.kk-option-item-icon-layout {
    display: grid;
    grid-template-columns: var(--grid-template-columns);
    grid-template-rows: var(--grid-template-rows);
}

.kk-option-item-icon-layout--left {
    --grid-template-columns: auto 1fr;
    --grid-template-rows: repeat(2, auto);
    --label-grid-column: 2;
    --label-grid-row: 1;
    --description-grid-column: 2;
    --description-grid-row: 2;
    --icon-grid-column: 1;
    --icon-grid-row: 1/3;
    --icon-padding-left: 0;
    --icon-padding-right: 12px;
}

.kk-option-item-icon-layout--right {
    --description-grid-column: 1;
    --icon-grid-row: 1/3;
    --icon-padding-left: 12px;
}

.kk-option-item-icon-layout--right,
.kk-option-item-icon-layout--top-right {
    --grid-template-columns: 1fr auto;
    --grid-template-rows: repeat(2, auto);
    --label-grid-column: 1;
    --label-grid-row: 1;
    --description-grid-row: 2;
    --icon-grid-column: 2;
    --icon-padding-right: 0;
}

.kk-option-item-icon-layout--top-right {
    --description-grid-column: 1/3;
    --icon-grid-row: 1;
    --icon-padding-left: 20px;
}

.kk-option-item-icon-layout__label {
    grid-column: var(--label-grid-column);
    grid-row: var(--label-grid-row);
}

.kk-option-item-icon-layout__description {
    grid-column: var(--description-grid-column);
    grid-row: var(--description-grid-row);
    padding-top: 2px;
}

.kk-option-item-icon-layout__icon {
    grid-column: var(--icon-grid-column);
    grid-row: var(--icon-grid-row);
    padding-left: var(--icon-padding-left);
    padding-right: var(--icon-padding-right);
}

.kk-option-item-icon-layout--left .kk-option-item-icon-layout__icon,
.kk-option-item-icon-layout--right .kk-option-item-icon-layout__icon {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.kk-option-item-layout {
    display: grid;
    grid-template-columns: var(--grid-template-columns);
    grid-template-rows: var(--grid-template-rows);
}

.kk-option-item-layout--left {
    --grid-template-columns: auto 1fr;
    --input-grid-column: 1;
    --input-grid-row: 0.3333333333;
    --input-label-grid-column: 2;
    --input-label-grid-row: 1;
    --children-grid-column: 2;
    --footer-grid-column: 2;
}

.kk-option-item-layout--left,
.kk-option-item-layout--right {
    --grid-template-rows: repeat(3, auto);
    --children-grid-row: 2;
    --footer-grid-row: 3;
}

.kk-option-item-layout--right {
    --grid-template-columns: 1fr auto;
    --input-grid-column: 2;
    --input-grid-row: 1;
    --input-label-grid-column: 1;
    --input-label-grid-row: 1;
    --children-grid-column: 1/3;
    --footer-grid-column: 1/3;
}

.kk-option-item-layout .kk-option-item-layout__input {
    grid-column: var(--input-grid-column);
    grid-row: var(--input-grid-row);
}

.kk-option-item-layout .kk-option-item-layout__input-label {
    grid-column: var(--input-label-grid-column);
    grid-row: var(--input-label-grid-row);
}

.kk-option-item-layout .kk-option-item-layout__children {
    grid-column: var(--children-grid-column);
    grid-row: var(--children-grid-row);
    padding-top: 24px;
}

.kk-option-item-layout .kk-option-item-layout__footer {
    grid-column: var(--footer-grid-column);
    grid-row: var(--footer-grid-row);
    padding-top: 4px;
}

.kk-option-item-layout--right .kk-option-item-layout__input {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.kk-option-item-icon__icon {
    color: #212121;
}

.kk-option-item-icon__icon--disabled {
    color: #9c9da0;
}

.kk-option-item-icon__image {
    min-height: 24px;
    width: auto;
}

.kk-option-item-icon__image--disabled {
    opacity: 0.4;
}

.kk-option-item-label {
    color: #212121;
}

.kk-option-item-label--disabled {
    color: #9c9da0;
}

.kk-option-item-label--md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-option-item-label--lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400;
}

.kk-option-item-description {
    color: #9c9da0;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-option-item-description--disabled {
    color: #d5d6db;
}

.kk-option-item__label {
    display: block;
    margin: 0;
}

.kk-checkbox-item__checkbox {
    display: block;
}

.kk-checkbox-item__checkbox--md {
    padding-top: 0;
    padding-bottom: 0;
}

.kk-checkbox-item__checkbox--lg {
    padding-top: 2px;
    padding-bottom: 2px;
}

.kk-checkbox-item__checkbox--left {
    padding-right: 12px;
}

.kk-checkbox-item__checkbox--right {
    padding-left: 20px;
}

.kk-chip {
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    gap: 4px;
    padding: 8px 12px;
    color: #212121;
    border-radius: 8px;
    border: 1px solid #d5d6db;
    background: #fff;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    cursor: pointer;
}

.kk-chip--md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-chip--lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400;
}

.kk-chip--rounded {
    border-radius: 20px;
}

.kk-chip--disabled {
    color: #9c9da0;
    background: #f1f4f8;
    cursor: not-allowed;
}

.kk-chip--selected {
    color: #26bec9;
    border: 1px solid #26bec9;
    background: #f0fafb;
}

.kk-chip--selected.kk-chip--disabled {
    color: #ade6eb;
    border: 1px solid #ade6eb;
}

.kk-collapse__content {
    overflow: hidden;
}

.kk-collapse--transition-slow .kk-collapse__content {
    -webkit-transition: height 0.5s ease-out;
    transition: height 0.5s ease-out;
}

.kk-collapse--transition-medium .kk-collapse__content {
    -webkit-transition: height 0.3s ease-out;
    transition: height 0.3s ease-out;
}

.kk-collapse--transition-fast .kk-collapse__content {
    -webkit-transition: height 0.1s ease-out;
    transition: height 0.1s ease-out;
}

.kk-divider {
    --gap: 16px;
    --text-color: #727272;
    --line-color: #babbbe;
    --line-thickness: 1px;
    display: grid;
    grid-template-columns: 1fr fit-content(80%) 1fr;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    grid-gap: var(--gap);
    color: var(--text-color);
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

.kk-divider:empty {
    display: block;
    height: var(--line-thickness);
    background: var(--line-color);
}

.kk-divider:empty:after,
.kk-divider:empty:before {
    display: none;
}

.kk-divider:after,
.kk-divider:before {
    content: '';
    background-color: var(--line-color);
    height: var(--line-thickness);
}

.kk-divider__text {
    text-align: center;
}

.kk-select-dropdown {
    position: relative;
    border-radius: 8px;
    background: #fff;
    overflow: hidden;
    -webkit-box-shadow: 0 2px 24px rgba(38, 50, 56, 0.1215686275);
    box-shadow: 0 2px 24px rgba(38, 50, 56, 0.1215686275);
}

.kk-select-dropdown--auto-width {
    min-width: 120px;
    max-width: 600px;
    width: -moz-max-content;
    width: -webkit-max-content;
    width: max-content;
}

.kk-select-dropdown:hover
    .kk-select-dropdown__content::-webkit-scrollbar-thumb {
    border: 2px solid #fff;
    background-clip: padding-box;
    background: #9c9da0;
    border-radius: 9999px;
}

.kk-select-dropdown__content {
    overflow-y: auto;
    max-height: 416px;
    padding: 8px;
}

.kk-select-dropdown__content::-webkit-scrollbar {
    width: 8px;
}

.kk-select-dropdown__content::-webkit-scrollbar-button {
    display: none;
}

.kk-select-dropdown__content::-webkit-scrollbar-thumb,
.kk-select-dropdown__content::-webkit-scrollbar-track {
    background: transparent;
}

.kk-select-dropdown__overlay {
    position: absolute;
    left: 0;
    right: 0;
    height: 30px;
    pointer-events: none;
    z-index: 999;
}

.kk-select-dropdown__overlay--top {
    top: 0;
    background: -webkit-gradient(
        linear,
        left top,
        left bottom,
        from(#fff),
        to(hsla(0, 0%, 100%, 0))
    );
    background: linear-gradient(180deg, #fff, hsla(0, 0%, 100%, 0));
}

.kk-select-dropdown__overlay--bottom {
    bottom: 0;
    background: -webkit-gradient(
        linear,
        left bottom,
        left top,
        from(#fff),
        to(hsla(0, 0%, 100%, 0))
    );
    background: linear-gradient(0deg, #fff, hsla(0, 0%, 100%, 0));
}

.kk-header-layout {
    --kk-header-layout-position: sticky;
    --kk-header-layout-transition: none;
    --kk-header-layout-main-height: 56px;
    position: var(--kk-header-layout-position);
    top: 0;
    left: 0;
    z-index: 1000;
    -webkit-transition: var(--kk-header-layout-transition);
    transition: var(--kk-header-layout-transition);
    width: 100%;
    background: #fff;
}

.kk-header-layout__main {
    height: var(--kk-header-layout-main-height);
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
}

.kk-header-layout__main--transparent-gradient {
    background: -webkit-gradient(
        linear,
        left top,
        left bottom,
        from(rgba(0, 0, 0, 0.4)),
        to(transparent)
    );
    background: linear-gradient(rgba(0, 0, 0, 0.4), transparent);
}

.kk-header-layout__below-header {
    -webkit-transition: var(--kk-header-layout-transition);
    transition: var(--kk-header-layout-transition);
}

.kk-header-layout__below-header--hidden {
    opacity: 0;
    height: 0;
    overflow: hidden;
}

.kk-header-layout--transparent {
    background: transparent;
}

.kk-header-layout--slide-out {
    -webkit-transform: translateY(-100%);
    transform: translateY(-100%);
}

.kk-header-layout__right {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    gap: 12px;
    -webkit-box-pack: end;
    -ms-flex-pack: end;
    justify-content: flex-end;
}

.kk-header-layout--box-shadow {
    -webkit-box-shadow: 0 2px 24px rgba(38, 50, 56, 0.1215686275);
    box-shadow: 0 2px 24px rgba(38, 50, 56, 0.1215686275);
}

.kk-icon-with-badge {
    display: inline-block;
    position: relative;
}

.kk-icon-with-badge__badge {
    position: absolute;
    top: var(--kk-icon-with-badge-offset-top);
    right: var(--kk-icon-with-badge-offset-right);
}

.kk-icon-with-badge--text > .kk-icon-with-badge__badge {
    -webkit-transform: translate(50%);
    transform: translate(50%);
}

.kk-icon-with-badge--text.kk-icon-with-badge--2xs > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -10px;
    --kk-icon-with-badge-offset-right: calc(-10px + var(--kk-badge-height) / 2);
}

.kk-icon-with-badge--text.kk-icon-with-badge--xs > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -8px;
    --kk-icon-with-badge-offset-right: calc(-10px + var(--kk-badge-height) / 2);
}

.kk-icon-with-badge--text.kk-icon-with-badge--sm > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -6px;
    --kk-icon-with-badge-offset-right: calc(-8px + var(--kk-badge-height) / 2);
}

.kk-icon-with-badge--text.kk-icon-with-badge--md > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -4px;
    --kk-icon-with-badge-offset-right: calc(-6px + var(--kk-badge-height) / 2);
}

.kk-icon-with-badge--text.kk-icon-with-badge--lg > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -2px;
    --kk-icon-with-badge-offset-right: calc(-4px + var(--kk-badge-height) / 2);
}

.kk-icon-with-badge--text.kk-icon-with-badge--xl > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: 0px;
    --kk-icon-with-badge-offset-right: calc(var(--kk-badge-height) / 2);
}

.kk-icon-with-badge--dot.kk-icon-with-badge--2xs > .kk-icon-with-badge__badge,
.kk-icon-with-badge--dot.kk-icon-with-badge--xs > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -3px;
    --kk-icon-with-badge-offset-right: -3px;
}

.kk-icon-with-badge--dot.kk-icon-with-badge--sm > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -2px;
    --kk-icon-with-badge-offset-right: -2px;
}

.kk-icon-with-badge--dot.kk-icon-with-badge--md > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -1px;
    --kk-icon-with-badge-offset-right: -1px;
}

.kk-icon-with-badge--dot.kk-icon-with-badge--lg > .kk-icon-with-badge__badge,
.kk-icon-with-badge--dot.kk-icon-with-badge--xl > .kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: 2px;
    --kk-icon-with-badge-offset-right: 2px;
}

.kk-icon-button {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    height: 32px;
    width: 32px;
    color: #212121;
    background: #fff;
    border-radius: 50%;
    cursor: pointer;
    -webkit-box-shadow: 0 2px 24px rgba(38, 50, 56, 0.1215686275);
    box-shadow: 0 2px 24px rgba(38, 50, 56, 0.1215686275);
}

.kk-icon-button--transparent {
    background: transparent;
    -webkit-box-shadow: initial;
    box-shadow: none;
}

.kk-icon-with-text {
    display: grid;
    gap: var(--icon-with-text-gap);
    grid-template-rows: minmax(0, 1fr);
    grid-template-columns: auto minmax(0, 1fr);
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: start;
    font-size: var(--icon-with-text-font-size);
    line-height: var(--icon-with-text-line-height);
}

.kk-icon-with-text--xs {
    --icon-with-text-gap: 8px;
    --icon-with-text-font-size: 12px;
    --icon-with-text-line-height: 16px;
}

.kk-icon-with-text--sm {
    --icon-with-text-gap: 12px;
    --icon-with-text-font-size: 14px;
    --icon-with-text-line-height: 20px;
}

.kk-icon-with-text--md {
    --icon-with-text-gap: 16px;
    --icon-with-text-font-size: 16px;
    --icon-with-text-line-height: 24px;
}

.kk-inform {
    border-radius: 8px;
    width: auto;
    max-width: 500px;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    --kk-badge-background-color: rgba(64, 64, 64, 0.95);
    background-color: var(--kk-badge-background-color);
}

.kk-inform--snackbar {
    width: calc(100% - 32px);
}

.kk-inform--danger {
    --kk-badge-background-color: #d14330;
}

.kk-inform__inform--text {
    margin: 4px 0;
    color: #fff;
}

.kk-inform__action {
    cursor: pointer;
    display: grid;
}

.kk-inform__icon {
    color: #fff;
    margin: 4px;
}

.kk-label {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    height: var(--kk-label-height);
    font-size: var(--kk-font-size);
    border-radius: var(--kk-label-border-radius);
    padding: 0 var(--kk-label-padding-x);
    color: var(--kk-label-text-color);
    background-color: var(--kk-label-background-color);
}

.kk-label--md {
    --kk-label-height: 28px;
    --kk-label-font-size: 14px;
    --kk-label-border-radius: 4px;
    --kk-label-padding-x: 8px;
}

.kk-label--sm {
    --kk-label-height: 20px;
    --kk-label-font-size: 12px;
    --kk-label-border-radius: 2px;
    --kk-label-padding-x: 8px;
}

.kk-label--grey {
    --kk-label-background-color: #eee;
    --kk-label-text-color: #333;
}

.kk-label--primary {
    --kk-label-background-color: rgba(38, 190, 201, 0.1);
    --kk-label-text-color: #26bec9;
}

.kk-label--info {
    --kk-label-background-color: rgba(100, 179, 244, 0.1);
    --kk-label-text-color: #36a1fa;
}

.kk-label--warning {
    --kk-label-background-color: #ffb400;
    --kk-label-text-color: #fff;
}

.kk-label--critical {
    --kk-label-background-color: #ef7a70;
    --kk-label-text-color: #fff;
}

.kk-message {
    display: grid;
    gap: 2px;
    grid-auto-flow: row;
    -webkit-box-pack: var(--text-align);
    -ms-flex-pack: var(--text-align);
    justify-content: var(--text-align);
    text-align: var(--text-align);
    font-size: 12px;
    line-height: 16px;
    font-weight: 400;
}

.kk-message--left {
    --text-align: left;
}

.kk-message--right {
    --text-align: right;
}

.kk-message__figure {
    display: grid;
    gap: 4px;
    grid-auto-flow: column;
    -webkit-box-pack: var(--text-align);
    -ms-flex-pack: var(--text-align);
    justify-content: var(--text-align);
    margin: 0;
}

.kk-message__figure--success {
    color: #26bec9;
}

.kk-message__figure--warning {
    color: #f5b53d;
}

.kk-message__figure--error {
    color: #e65f50;
}

.kk-message__icon {
    margin: 1px 0;
}

.kk-message__hint {
    color: #727272;
}

.kk-progress > * {
    height: inherit;
}

.kk-progress--sm {
    --progress-height: 6px;
    --progress-bar-radius: calc(var(--progress-height) / 2);
    height: var(--progress-height);
}

.kk-progress--md {
    --progress-height: 15px;
    --progress-bar-radius: 2px;
    height: var(--progress-height);
}

.kk-progress--fragmented {
    display: grid;
    gap: 4px;
    grid-template-columns: repeat(auto-fit, minmax(0, 1fr));
    background-color: transparent;
}

.kk-progress--fragmented .kk-progress__bar {
    -webkit-transition: none;
    transition: none;
}

.kk-progress__progress {
    background-color: #f1f4f8;
    overflow: hidden;
}

.kk-progress__progress:first-child {
    border-top-left-radius: var(--progress-bar-radius);
    border-bottom-left-radius: var(--progress-bar-radius);
}

.kk-progress__progress:last-child {
    border-top-right-radius: var(--progress-bar-radius);
    border-bottom-right-radius: var(--progress-bar-radius);
}

.kk-progress__bar {
    height: inherit;
    -webkit-transition-duration: 0.5s;
    transition-duration: 0.5s;
    -webkit-transition-property: width;
    transition-property: width;
    -webkit-transition-timing-function: cubic-bezier(1, 1.43, 0.83, 0.85);
    transition-timing-function: cubic-bezier(1, 1.43, 0.83, 0.85);
}

.kk-progress--primary .kk-progress__bar {
    background-color: #26bec9;
}

.kk-progress--silver .kk-progress__bar {
    background-color: #64b3f4;
}

.kk-progress--platinum .kk-progress__bar {
    background-color: #6c56a1;
}

.kk-progress--diamond .kk-progress__bar {
    background-color: #3d4854;
}

.kk-radio-button {
    --radio-button-cursor: pointer;
    --radio-button-background: #fff;
    --radio-button-border: 1px solid #d5d6db;
    position: relative;
    width: 20px;
    height: 20px;
}

.kk-radio-button[type='radio'] {
    display: block;
    margin: 0;
}

.kk-radio-button:after {
    position: absolute;
    top: 0;
    left: 0;
    content: '';
    display: block;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 100%;
    height: 100%;
    border-radius: 50%;
    cursor: var(--radio-button-cursor);
    background: var(--radio-button-background);
    border: var(--radio-button-border);
}

.kk-radio-button:disabled {
    --radio-button-cursor: default;
    --radio-button-background: #e6e9ed;
    --radio-button-border: 1px solid #d5d6db;
}

.kk-radio-button:checked {
    --radio-button-cursor: default;
    --radio-button-border: 6px solid #26bec9;
}

.kk-radio-button:disabled:checked {
    --radio-button-background: #fff;
    --radio-button-border: 6px solid #cef0f3;
}

@media (hover: hover) {
    .kk-radio-button:hover:not(:disabled):not(:checked) {
        --radio-button-border: 1px solid #babbbe;
    }
}

.kk-radio-button-group {
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -ms-flex-wrap: wrap;
    flex-wrap: wrap;
    font-size: 0;
    gap: 12px;
}

.kk-radio-button-item__radio-button--md {
    padding-top: 0;
    padding-bottom: 0;
}

.kk-radio-button-item__radio-button--lg {
    padding-top: 2px;
    padding-bottom: 2px;
}

.kk-radio-button-item__radio-button--left {
    padding-right: 12px;
}

.kk-radio-button-item__radio-button--right {
    padding-left: 20px;
}

.kk-select-leading-image--disabled {
    color: #babbbe;
}

.kk-select-leading-image--disabled.kk-select-leading-image--avatar,
.kk-select-leading-image--disabled.kk-select-leading-image--image {
    opacity: 0.4;
}

.kk-select {
    --layout-template-columns: minmax(0, 1fr);
    display: grid;
    grid-template-rows: minmax(0, 1fr);
    grid-template-columns: var(--layout-template-columns);
    gap: 8px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    position: relative;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    vertical-align: middle;
    border-radius: 8px;
    border: 1px solid #d5d6db;
    background-color: #fff;
    height: 48px;
    padding: 12px;
    cursor: pointer;
}

.kk-select__leading-image {
    color: #babbbe;
}

.kk-select__input,
.kk-select__main-content {
    font-family: PingFang TC, sans-serif;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-select__input {
    cursor: inherit;
    padding: 0;
    outline: none;
    border: none;
    background: none;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    color: #212121;
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
}

.kk-select__input::-moz-placeholder {
    color: #babbbe;
}

.kk-select__input::-webkit-input-placeholder {
    color: #babbbe;
}

.kk-select__input:-ms-input-placeholder {
    color: #babbbe;
}

.kk-select__input::-ms-input-placeholder {
    color: #babbbe;
}

.kk-select__input::placeholder {
    color: #babbbe;
}

.kk-select__input:-moz-placeholder-shown {
    text-overflow: ellipsis;
}

.kk-select__input:-ms-input-placeholder {
    text-overflow: ellipsis;
}

.kk-select__input:placeholder-shown {
    text-overflow: ellipsis;
}

.kk-select__trailing-icon:hover {
    color: #212121;
}

.kk-select__trailing-icon--transition {
    -webkit-transition: -webkit-transform 0.3s ease-in-out;
    transition: -webkit-transform 0.3s ease-in-out;
    transition: transform 0.3s ease-in-out;
    transition: transform 0.3s ease-in-out, -webkit-transform 0.3s ease-in-out;
}

.kk-select--expanded .kk-select__trailing-icon--transition {
    -webkit-transform: rotate(-180deg);
    transform: rotate(-180deg);
}

@media (pointer: fine) {
    .kk-select:not(
            .kk-select--disabled,
            .kk-select--search,
            .kk-select--error
        ):hover {
        border-color: #212121;
        outline: #212121;
    }
}

.kk-select:not(
        .kk-select--disabled,
        .kk-select--search,
        .kk-select--error
    ):focus-within {
    border-color: #212121;
    outline: #212121;
}

.kk-select--auto-height {
    height: auto;
    min-height: 48px;
}

.kk-select--disabled {
    cursor: not-allowed;
    border-color: #e6e9ed;
    background-color: #f1f4f8;
}

.kk-select--disabled .kk-select__input,
.kk-select--disabled .kk-select__main-content {
    color: #babbbe;
    -webkit-text-fill-color: #babbbe;
    opacity: 1;
}

.kk-select--disabled .kk-select__input::-webkit-input-placeholder,
.kk-select--disabled .kk-select__main-content::-webkit-input-placeholder {
    color: #babbbe;
}

.kk-select--disabled .kk-select__input::-moz-placeholder,
.kk-select--disabled .kk-select__main-content::-moz-placeholder {
    color: #babbbe;
}

.kk-select--disabled .kk-select__input:-ms-input-placeholder,
.kk-select--disabled .kk-select__main-content:-ms-input-placeholder {
    color: #babbbe;
}

.kk-select--disabled .kk-select__input::-ms-input-placeholder,
.kk-select--disabled .kk-select__main-content::-ms-input-placeholder {
    color: #babbbe;
}

.kk-select--disabled .kk-select__input::placeholder,
.kk-select--disabled .kk-select__main-content::placeholder {
    color: #babbbe;
}

.kk-select--disabled .kk-select__trailing-icon {
    color: #babbbe;
}

.kk-select--error {
    border-color: #e65f50;
}

.kk-select--trailing {
    --layout-template-columns: minmax(0, 1fr) auto;
}

.kk-select--leading {
    --layout-template-columns: auto minmax(0, 1fr);
}

.kk-select--leading.kk-select--trailing {
    --layout-template-columns: auto minmax(0, 1fr) auto;
}

.kk-select-layout {
    --kk-select-layout-menu-z-index: 1000;
}

.kk-select-layout__menu {
    z-index: var(--kk-select-layout-menu-z-index);
}

.kk-select-option {
    list-style: none;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    gap: 8px;
    padding: 8px 12px;
    min-height: 40px;
    color: var(--kk-select-option-color, #212121);
    cursor: pointer;
}

.kk-select-option--grouped {
    padding: 8px 20px;
}

.kk-select-option--disabled {
    --kk-select-option-color: #babbbe;
    cursor: not-allowed;
}

.kk-select-option--selected {
    --kk-select-option-color: #13a3b6;
}

.kk-select-option__icon-text {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
    gap: 8px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
}

.kk-select-option__content {
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
    font-family: PingFang TC, sans-serif;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-select-option:hover {
    border-radius: 8px;
    background: #f1f4f8;
}

.kk-select-option-group {
    list-style: none;
    padding: initial;
}

.kk-select-option-group__title {
    color: #212121;
    padding: 8px;
    font-size: 14px;
    line-height: 20px;
    font-weight: 500;
}

.kk-select-option-group ul {
    padding: initial;
}

.kk-select-with-menu__loading {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
}

.kk-select-with-menu__empty-text,
.kk-select-with-menu__loading {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    min-height: 40px;
    padding: 0 12px;
}

.kk-select-with-menu__empty-text {
    color: #9c9da0;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-stepper {
    display: inline-grid;
    grid-template-columns: auto auto auto;
    gap: 4px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    -ms-touch-action: manipulation;
    touch-action: manipulation;
}

.kk-stepper:focus {
    outline: none;
}

.kk-stepper__btn {
    --kk-stepper-btn-color: var(--kk-stepper-btn-color-default, #26bec9);
    --kk-stepper-btn-border-color: var(
        --kk-stepper-btn-border-color-default,
        #26bec9
    );
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 32px;
    height: 32px;
    border-radius: 50%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    background: none;
    padding: 0;
    border: 1px solid var(--kk-stepper-btn-border-color);
    color: var(--kk-stepper-btn-color);
    cursor: pointer;
}

@media (hover: hover) {
    .kk-stepper__btn:hover {
        --kk-stepper-btn-color: var(--kk-stepper-btn-color-hover, #068b9f);
        --kk-stepper-btn-border-color: var(
            --kk-stepper-btn-border-color-hover,
            #068b9f
        );
    }
}

.kk-stepper__btn:active {
    --kk-stepper-btn-color: var(--kk-stepper-btn-color-active, #068b9f);
    --kk-stepper-btn-border-color: var(
        --kk-stepper-btn-border-color-active,
        #068b9f
    );
}

.kk-stepper__btn:disabled {
    --kk-stepper-btn-color: var(--kk-stepper-btn-color-disabled, #ade6eb);
    --kk-stepper-btn-border-color: var(
        --kk-stepper-btn-border-color-disabled,
        #ade6eb
    );
    cursor: default;
}

.kk-stepper__num {
    width: 40px;
    color: var(--kk-stepper-num-color, #212121);
    text-align: center;
    font-size: 16px;
    line-height: 24px;
    font-weight: 400;
}

.kk-switch {
    --background-color: #d5d6db;
    --cursor: pointer;
    position: relative;
    display: inline-block;
    width: 44px;
    height: 28px;
    margin: 0;
}

.kk-switch__input {
    opacity: 0;
    width: 0;
    height: 0;
    margin: 0;
}

.kk-switch__slider {
    cursor: var(--cursor);
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: var(--background-color);
    border-radius: 14px;
}

.kk-switch__slider,
.kk-switch__slider:before {
    position: absolute;
    -webkit-transition: 0.1s;
    transition: 0.1s;
}

.kk-switch__slider:before {
    content: '';
    height: 22px;
    width: 22px;
    left: 3px;
    bottom: 3px;
    background-color: #fff;
    border-radius: 50%;
}

.kk-switch__input:disabled + .kk-switch__slider {
    --background-color: #e6e9ed;
    --cursor: normal;
}

.kk-switch__input:disabled:checked + .kk-switch__slider {
    --background-color: #cef0f3;
}

.kk-switch__input:checked + .kk-switch__slider {
    --background-color: #26bec9;
}

.kk-switch__input:checked + .kk-switch__slider:before {
    -webkit-transform: translate(16px);
    transform: translate(16px);
}

.kk-tabs {
    --tab-icon-offset-width: 0px;
    --tab-transition-duration: 0.25s;
    --tab-padding-x: 12px;
    --tab-padding-y: 12px;
}

.kk-tabs--show-icon {
    --tab-icon-offset-width: 24px;
}

.kk-tabs__header {
    position: relative;
    overflow-x: auto;
    overscroll-behavior-x: contain;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    border-bottom: 1px solid #e6e9ed;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    scrollbar-width: none;
    -ms-overflow-style: none;
}

.kk-tabs__header::-webkit-scrollbar {
    display: none;
}

.kk-tabs__header-padding-left,
.kk-tabs__header-padding-right {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
    height: 1px;
}

.kk-tabs__header-padding-left {
    width: 12px;
}

.kk-tabs__header-padding-right {
    width: calc(12px + var(--tab-icon-offset-width));
}

.kk-tabs__tab-list {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
    display: grid;
    grid-auto-flow: column;
    grid-auto-columns: minmax(0, auto);
    -webkit-box-pack: left;
    -ms-flex-pack: left;
    justify-content: left;
    padding: 0;
}

.kk-tabs__tab {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400;
    text-decoration: none !important;
    padding: var(--tab-padding-y) var(--tab-padding-x);
    color: #212121;
    cursor: pointer;
    position: relative;
}

@media (prefers-reduced-motion: no-preference) {
    .kk-tabs__tab {
        -webkit-transition-property: color, -webkit-transform;
        transition-property: color, -webkit-transform;
        transition-property: transform, color;
        transition-property: transform, color, -webkit-transform;
        -webkit-transition-timing-function: ease-out;
        transition-timing-function: ease-out;
        -webkit-transition-duration: var(--tab-transition-duration);
        transition-duration: var(--tab-transition-duration);
    }
}

.kk-tabs__tab--active {
    font-size: 16px;
    line-height: 24px;
    font-weight: 700;
    color: #13a3b6;
}

.kk-tabs--show-icon .kk-tabs__tab--active,
.kk-tabs--show-icon .kk-tabs__tab--active ~ .kk-tabs__tab {
    -webkit-transform: translate(var(--tab-icon-offset-width));
    transform: translate(var(--tab-icon-offset-width));
}

.kk-tabs__tab-icon {
    position: absolute;
    top: 0;
    left: calc(var(--tab-icon-offset-width) * -1);
    height: 100%;
    padding-left: var(--tab-padding-x);
    -webkit-transform-origin: right center;
    transform-origin: right center;
    -webkit-transform: scale(0);
    transform: scale(0);
}

@media (prefers-reduced-motion: no-preference) {
    .kk-tabs__tab-icon {
        -webkit-transition: -webkit-transform var(--tab-transition-duration)
            ease-out;
        transition: -webkit-transform var(--tab-transition-duration) ease-out;
        transition: transform var(--tab-transition-duration) ease-out;
        transition: transform var(--tab-transition-duration) ease-out,
            -webkit-transform var(--tab-transition-duration) ease-out;
    }
}

.kk-tabs__tab--active > .kk-tabs__tab-icon {
    -webkit-transform: scale(1);
    transform: scale(1);
}

@media (prefers-reduced-motion: no-preference) {
    .kk-tabs__tab--active > .kk-tabs__tab-icon {
        will-change: transform;
    }
}

.kk-tabs__tab-text {
    display: inline-grid;
    grid-auto-flow: column;
    gap: 4px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    position: relative;
}

.kk-tabs__tab-text--badge-at-corner > .kk-tabs__tab-badge {
    position: absolute;
    top: -1px;
    right: -6px;
}

.kk-tabs__indicator {
    height: 2px;
    border-top-left-radius: 2px;
    border-top-right-radius: 2px;
    background-color: #26bec9;
    position: absolute;
    bottom: 0;
    left: 0;
    width: var(--indicator-width, 0);
    -webkit-transform: translate(var(--indicator-offset));
    transform: translate(var(--indicator-offset));
}

@media (prefers-reduced-motion: no-preference) {
    .kk-tabs__indicator {
        -webkit-transition-property: width, -webkit-transform;
        transition-property: width, -webkit-transform;
        transition-property: transform, width;
        transition-property: transform, width, -webkit-transform;
        -webkit-transition-duration: var(--tab-transition-duration);
        transition-duration: var(--tab-transition-duration);
        -webkit-transition-timing-function: ease-out;
        transition-timing-function: ease-out;
        will-change: transform, width;
    }
}

.kk-tabs--has-content {
    display: grid;
    grid-template-areas: 'header' 'content';
    grid-template-rows: auto minmax(0, 1fr);
    height: 100%;
}

.kk-tabs--has-content > .kk-tabs__header {
    grid-area: header;
}

.kk-tabs__content {
    grid-area: content;
    overflow-y: auto;
    display: none;
}

.kk-tabs__content--active {
    display: block;
}

.kk-tag {
    padding: 3px 8px;
    border-radius: 0.25em;
    vertical-align: middle;
    font-size: 12px;
}

.kk-tag a {
    color: inherit;
}

.kk-tag a :hover {
    text-decoration: none;
}

.kk-tag--yellow {
    background-color: #ffb400;
}

.kk-tag--red {
    background-color: #ef7a70;
}

.kk-form-label {
    display: block;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-form-label__text {
    color: #212121;
}

.kk-form-label__required-star {
    color: #e65f50;
}

.kk-form-label__max-count {
    color: #727272;
}

.kk-text-link {
    display: inline;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    color: #13a3b6;
    cursor: pointer;
}

@media (hover: hover) {
    .kk-text-link:hover {
        color: #068b9f;
    }
}

.kk-text-link--standalone {
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
}

.kk-text-link--secondary,
.kk-text-link--secondary:hover {
    color: #212121;
}

.kk-text-link__text {
    text-decoration: underline;
}

.kk-text-link__icon {
    margin-left: 4px;
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
}

.kk-text-link--sm {
    font-size: 12px;
    line-height: 16px;
    font-weight: 400;
}

.kk-text-link--md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-text-link--lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400;
}

.kk-textarea {
    --textarea-inline-padding: 12px;
    display: block;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    overflow: hidden;
    min-height: 48px;
    width: 100%;
    resize: none;
    padding: var(--textarea-inline-padding);
    border-radius: 8px;
    border-color: #d5d6db;
    outline: none;
    color: #212121;
    background-color: #fff;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-textarea::-moz-placeholder {
    color: #babbbe;
}

.kk-textarea::-webkit-input-placeholder {
    color: #babbbe;
}

.kk-textarea:-ms-input-placeholder {
    color: #babbbe;
}

.kk-textarea::-ms-input-placeholder {
    color: #babbbe;
}

.kk-textarea::placeholder {
    color: #babbbe;
}

@media (pointer: fine) {
    .kk-textarea:not(
            .kk-textarea--disabled,
            .kk-textarea--search,
            .kk-textarea--error
        ):hover {
        border-color: #212121;
        outline: #212121;
    }
}

.kk-textarea:not(
        .kk-textarea--disabled,
        .kk-textarea--search,
        .kk-textarea--error
    ):focus-within {
    border-color: #212121;
    outline: #212121;
}

.kk-textarea--draggable {
    overflow: auto;
    resize: vertical;
}

.kk-textarea--error {
    border-color: #e65f50;
}

.kk-textarea--disabled {
    color: #babbbe;
    background-color: #f1f4f8;
    border-color: #e6e9ed;
    cursor: not-allowed;
}

.kk-validation-provider {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: var(--flex-direction);
    flex-direction: var(--flex-direction);
}

.kk-validation-provider__message-bottom-left,
.kk-validation-provider__message-bottom-right {
    --flex-direction: column;
    --message-padding-bottom: 0;
}

.kk-validation-provider__message-bottom-left--gap-0,
.kk-validation-provider__message-bottom-right--gap-0 {
    --message-padding-top: 0;
}

.kk-validation-provider__message-bottom-left--gap-1,
.kk-validation-provider__message-bottom-right--gap-1 {
    --message-padding-top: 2px;
}

.kk-validation-provider__message-bottom-left--gap-2,
.kk-validation-provider__message-bottom-right--gap-2 {
    --message-padding-top: 4px;
}

.kk-validation-provider__message-bottom-left--gap-3,
.kk-validation-provider__message-bottom-right--gap-3 {
    --message-padding-top: 8px;
}

.kk-validation-provider__message-bottom-left--gap-4,
.kk-validation-provider__message-bottom-right--gap-4 {
    --message-padding-top: 12px;
}

.kk-validation-provider__message-bottom-left--gap-5,
.kk-validation-provider__message-bottom-right--gap-5 {
    --message-padding-top: 16px;
}

.kk-validation-provider__message-bottom-left--gap-6,
.kk-validation-provider__message-bottom-right--gap-6 {
    --message-padding-top: 20px;
}

.kk-validation-provider__message-bottom-left--gap-7,
.kk-validation-provider__message-bottom-right--gap-7 {
    --message-padding-top: 24px;
}

.kk-validation-provider__message-bottom-left--gap-8,
.kk-validation-provider__message-bottom-right--gap-8 {
    --message-padding-top: 32px;
}

.kk-validation-provider__message-bottom-left--gap-9,
.kk-validation-provider__message-bottom-right--gap-9 {
    --message-padding-top: 40px;
}

.kk-validation-provider__message-bottom-left--gap-10,
.kk-validation-provider__message-bottom-right--gap-10 {
    --message-padding-top: 48px;
}

.kk-validation-provider__message-top-left {
    --flex-direction: column-reverse;
    --message-padding-top: 0;
}

.kk-validation-provider__message-top-left--gap-0 {
    --message-padding-bottom: 0;
}

.kk-validation-provider__message-top-left--gap-1 {
    --message-padding-bottom: 2px;
}

.kk-validation-provider__message-top-left--gap-2 {
    --message-padding-bottom: 4px;
}

.kk-validation-provider__message-top-left--gap-3 {
    --message-padding-bottom: 8px;
}

.kk-validation-provider__message-top-left--gap-4 {
    --message-padding-bottom: 12px;
}

.kk-validation-provider__message-top-left--gap-5 {
    --message-padding-bottom: 16px;
}

.kk-validation-provider__message-top-left--gap-6 {
    --message-padding-bottom: 20px;
}

.kk-validation-provider__message-top-left--gap-7 {
    --message-padding-bottom: 24px;
}

.kk-validation-provider__message-top-left--gap-8 {
    --message-padding-bottom: 32px;
}

.kk-validation-provider__message-top-left--gap-9 {
    --message-padding-bottom: 40px;
}

.kk-validation-provider__message-top-left--gap-10 {
    --message-padding-bottom: 48px;
}

.kk-validation-provider__message {
    padding-top: var(--message-padding-top);
    padding-bottom: var(--message-padding-bottom);
}

.svg-spinner[data-v-51b1945b] {
    -webkit-transition-property: -webkit-transform;
    transition-property: -webkit-transform;
    transition-property: transform;
    transition-property: transform, -webkit-transform;
    -webkit-animation-name: rotate-51b1945b;
    animation-name: rotate-51b1945b;
    -webkit-animation-duration: 2s;
    animation-duration: 2s;
    -webkit-animation-iteration-count: infinite;
    animation-iteration-count: infinite;
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
}

@-webkit-keyframes rotate-51b1945b {
    0% {
        -webkit-transform: rotate(0);
        transform: rotate(0);
    }

    to {
        -webkit-transform: rotate(1turn);
        transform: rotate(1turn);
    }
}

@keyframes rotate-51b1945b {
    0% {
        -webkit-transform: rotate(0);
        transform: rotate(0);
    }

    to {
        -webkit-transform: rotate(1turn);
        transform: rotate(1turn);
    }
}

._collapseContainer_yg05e_1 {
    display: grid;
}

._list_stphf_1 {
    --clamp: 2;
    --clamp-padding: 8px;
    --clamp-margin: 0px;
    --clamp-line-height: 20px;
    --clamp-gap: 8px;
    position: relative;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    -ms-flex-flow: row wrap;
    flex-flow: row wrap;
    gap: var(--kk-spacing-3);
    overflow: hidden;
    padding: 0;
    max-height: calc(
        (
                var(--clamp-line-height) + var(--clamp-padding) * 2 +
                    var(--clamp-margin) * 2 + var(--clamp-gap)
            ) * var(--clamp)
    );
    -webkit-transition: 0.3s ease-in-out;
    transition: 0.3s ease-in-out;
}

._expanded_stphf_17 {
    max-height: 100%;
}

._expanded_stphf_17 ._listItemClamp_stphf_20 svg {
    -webkit-transform: scale(-1);
    transform: scale(-1);
}

._listItem_stphf_20 {
    display: block;
    list-style: none;
    margin: 0;
}

._listItemClamp_stphf_20 {
    list-style: none;
}

._listItemClamp_stphf_20 ~ ._listItem_stphf_20 {
    display: none;
}

.typeform-widget {
    width: 100%;
    height: 100%;
}

.typeform-widget iframe {
    width: 100%;
    height: 100%;
    border: none;
    overflow: hidden;
    border-radius: 8px;
}

@font-face {
    font-family: swiper-icons;
    src: url('data:application/font-woff;charset=utf-8;base64, d09GRgABAAAAAAZgABAAAAAADAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABGRlRNAAAGRAAAABoAAAAci6qHkUdERUYAAAWgAAAAIwAAACQAYABXR1BPUwAABhQAAAAuAAAANuAY7+xHU1VCAAAFxAAAAFAAAABm2fPczU9TLzIAAAHcAAAASgAAAGBP9V5RY21hcAAAAkQAAACIAAABYt6F0cBjdnQgAAACzAAAAAQAAAAEABEBRGdhc3AAAAWYAAAACAAAAAj//wADZ2x5ZgAAAywAAADMAAAD2MHtryVoZWFkAAABbAAAADAAAAA2E2+eoWhoZWEAAAGcAAAAHwAAACQC9gDzaG10eAAAAigAAAAZAAAArgJkABFsb2NhAAAC0AAAAFoAAABaFQAUGG1heHAAAAG8AAAAHwAAACAAcABAbmFtZQAAA/gAAAE5AAACXvFdBwlwb3N0AAAFNAAAAGIAAACE5s74hXjaY2BkYGAAYpf5Hu/j+W2+MnAzMYDAzaX6QjD6/4//Bxj5GA8AuRwMYGkAPywL13jaY2BkYGA88P8Agx4j+/8fQDYfA1AEBWgDAIB2BOoAeNpjYGRgYNBh4GdgYgABEMnIABJzYNADCQAACWgAsQB42mNgYfzCOIGBlYGB0YcxjYGBwR1Kf2WQZGhhYGBiYGVmgAFGBiQQkOaawtDAoMBQxXjg/wEGPcYDDA4wNUA2CCgwsAAAO4EL6gAAeNpj2M0gyAACqxgGNWBkZ2D4/wMA+xkDdgAAAHjaY2BgYGaAYBkGRgYQiAHyGMF8FgYHIM3DwMHABGQrMOgyWDLEM1T9/w8UBfEMgLzE////P/5//f/V/xv+r4eaAAeMbAxwIUYmIMHEgKYAYjUcsDAwsLKxc3BycfPw8jEQA/gZBASFhEVExcQlJKWkZWTl5BUUlZRVVNXUNTQZBgMAAMR+E+gAEQFEAAAAKgAqACoANAA+AEgAUgBcAGYAcAB6AIQAjgCYAKIArAC2AMAAygDUAN4A6ADyAPwBBgEQARoBJAEuATgBQgFMAVYBYAFqAXQBfgGIAZIBnAGmAbIBzgHsAAB42u2NMQ6CUAyGW568x9AneYYgm4MJbhKFaExIOAVX8ApewSt4Bic4AfeAid3VOBixDxfPYEza5O+Xfi04YADggiUIULCuEJK8VhO4bSvpdnktHI5QCYtdi2sl8ZnXaHlqUrNKzdKcT8cjlq+rwZSvIVczNiezsfnP/uznmfPFBNODM2K7MTQ45YEAZqGP81AmGGcF3iPqOop0r1SPTaTbVkfUe4HXj97wYE+yNwWYxwWu4v1ugWHgo3S1XdZEVqWM7ET0cfnLGxWfkgR42o2PvWrDMBSFj/IHLaF0zKjRgdiVMwScNRAoWUoH78Y2icB/yIY09An6AH2Bdu/UB+yxopYshQiEvnvu0dURgDt8QeC8PDw7Fpji3fEA4z/PEJ6YOB5hKh4dj3EvXhxPqH/SKUY3rJ7srZ4FZnh1PMAtPhwP6fl2PMJMPDgeQ4rY8YT6Gzao0eAEA409DuggmTnFnOcSCiEiLMgxCiTI6Cq5DZUd3Qmp10vO0LaLTd2cjN4fOumlc7lUYbSQcZFkutRG7g6JKZKy0RmdLY680CDnEJ+UMkpFFe1RN7nxdVpXrC4aTtnaurOnYercZg2YVmLN/d/gczfEimrE/fs/bOuq29Zmn8tloORaXgZgGa78yO9/cnXm2BpaGvq25Dv9S4E9+5SIc9PqupJKhYFSSl47+Qcr1mYNAAAAeNptw0cKwkAAAMDZJA8Q7OUJvkLsPfZ6zFVERPy8qHh2YER+3i/BP83vIBLLySsoKimrqKqpa2hp6+jq6RsYGhmbmJqZSy0sraxtbO3sHRydnEMU4uR6yx7JJXveP7WrDycAAAAAAAH//wACeNpjYGRgYOABYhkgZgJCZgZNBkYGLQZtIJsFLMYAAAw3ALgAeNolizEKgDAQBCchRbC2sFER0YD6qVQiBCv/H9ezGI6Z5XBAw8CBK/m5iQQVauVbXLnOrMZv2oLdKFa8Pjuru2hJzGabmOSLzNMzvutpB3N42mNgZGBg4GKQYzBhYMxJLMlj4GBgAYow/P/PAJJhLM6sSoWKfWCAAwDAjgbRAAB42mNgYGBkAIIbCZo5IPrmUn0hGA0AO8EFTQAA')
        format('woff');
    font-weight: 400;
    font-style: normal;
}

:root {
    --swiper-theme-color: #007aff;
}

.swiper-container {
    margin-left: auto;
    margin-right: auto;
    position: relative;
    overflow: hidden;
    list-style: none;
    padding: 0;
    z-index: 1;
}

.swiper-container-vertical > .swiper-wrapper {
    flex-direction: column;
}

.swiper-wrapper {
    position: relative;
    width: 100%;
    height: 100%;
    z-index: 1;
    display: flex;
    transition-property: transform;
    box-sizing: content-box;
}

.swiper-container-android .swiper-slide,
.swiper-wrapper {
    transform: translateZ(0);
}

.swiper-container-multirow > .swiper-wrapper {
    flex-wrap: wrap;
}

.swiper-container-multirow-column > .swiper-wrapper {
    flex-wrap: wrap;
    flex-direction: column;
}

.swiper-container-free-mode > .swiper-wrapper {
    transition-timing-function: ease-out;
    margin: 0 auto;
}

.swiper-slide {
    flex-shrink: 0;
    width: 100%;
    height: 100%;
    position: relative;
    transition-property: transform;
}

.swiper-slide-invisible-blank {
    visibility: hidden;
}

.swiper-container-autoheight,
.swiper-container-autoheight .swiper-slide {
    height: auto;
}

.swiper-container-autoheight .swiper-wrapper {
    align-items: flex-start;
    transition-property: transform, height;
}

.swiper-container-3d {
    perspective: 1200px;
}

.swiper-container-3d .swiper-cube-shadow,
.swiper-container-3d .swiper-slide,
.swiper-container-3d .swiper-slide-shadow-bottom,
.swiper-container-3d .swiper-slide-shadow-left,
.swiper-container-3d .swiper-slide-shadow-right,
.swiper-container-3d .swiper-slide-shadow-top,
.swiper-container-3d .swiper-wrapper {
    transform-style: preserve-3d;
}

.swiper-container-3d .swiper-slide-shadow-bottom,
.swiper-container-3d .swiper-slide-shadow-left,
.swiper-container-3d .swiper-slide-shadow-right,
.swiper-container-3d .swiper-slide-shadow-top {
    position: absolute;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    pointer-events: none;
    z-index: 10;
}

.swiper-container-3d .swiper-slide-shadow-left {
    background-image: linear-gradient(270deg, rgba(0, 0, 0, 0.5), transparent);
}

.swiper-container-3d .swiper-slide-shadow-right {
    background-image: linear-gradient(90deg, rgba(0, 0, 0, 0.5), transparent);
}

.swiper-container-3d .swiper-slide-shadow-top {
    background-image: linear-gradient(0deg, rgba(0, 0, 0, 0.5), transparent);
}

.swiper-container-3d .swiper-slide-shadow-bottom {
    background-image: linear-gradient(180deg, rgba(0, 0, 0, 0.5), transparent);
}

.swiper-container-css-mode > .swiper-wrapper {
    overflow: auto;
    scrollbar-width: none;
    -ms-overflow-style: none;
}

.swiper-container-css-mode > .swiper-wrapper::-webkit-scrollbar {
    display: none;
}

.swiper-container-css-mode > .swiper-wrapper > .swiper-slide {
    scroll-snap-align: start start;
}

.swiper-container-horizontal.swiper-container-css-mode > .swiper-wrapper {
    scroll-snap-type: x mandatory;
}

.swiper-container-vertical.swiper-container-css-mode > .swiper-wrapper {
    scroll-snap-type: y mandatory;
}

:root {
    --swiper-navigation-size: 44px;
}

.swiper-button-next,
.swiper-button-prev {
    position: absolute;
    top: 50%;
    width: calc(var(--swiper-navigation-size) / 44 * 27);
    height: var(--swiper-navigation-size);
    margin-top: calc(var(--swiper-navigation-size) * -1 / 2);
    z-index: 10;
    cursor: pointer;
    display: flex;
    align-items: center;
    justify-content: center;
    color: var(--swiper-navigation-color, var(--swiper-theme-color));
}

.swiper-button-next.swiper-button-disabled,
.swiper-button-prev.swiper-button-disabled {
    opacity: 0.35;
    cursor: auto;
    pointer-events: none;
}

.swiper-button-next:after,
.swiper-button-prev:after {
    font-family: swiper-icons;
    font-size: var(--swiper-navigation-size);
    text-transform: none !important;
    letter-spacing: 0;
    text-transform: none;
    font-variant: normal;
    line-height: 1;
}

.swiper-button-prev,
.swiper-container-rtl .swiper-button-next {
    left: 10px;
    right: auto;
}

.swiper-button-prev:after,
.swiper-container-rtl .swiper-button-next:after {
    content: 'prev';
}

.swiper-button-next,
.swiper-container-rtl .swiper-button-prev {
    right: 10px;
    left: auto;
}

.swiper-button-next:after,
.swiper-container-rtl .swiper-button-prev:after {
    content: 'next';
}

.swiper-button-next.swiper-button-white,
.swiper-button-prev.swiper-button-white {
    --swiper-navigation-color: #fff;
}

.swiper-button-next.swiper-button-black,
.swiper-button-prev.swiper-button-black {
    --swiper-navigation-color: #000;
}

.swiper-button-lock {
    display: none;
}

.swiper-pagination {
    position: absolute;
    text-align: center;
    transition: opacity 0.3s;
    transform: translateZ(0);
    z-index: 10;
}

.swiper-pagination.swiper-pagination-hidden {
    opacity: 0;
}

.swiper-container-horizontal > .swiper-pagination-bullets,
.swiper-pagination-custom,
.swiper-pagination-fraction {
    bottom: 10px;
    left: 0;
    width: 100%;
}

.swiper-pagination-bullets-dynamic {
    overflow: hidden;
    font-size: 0;
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet {
    transform: scale(0.33);
    position: relative;
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active,
.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-main {
    transform: scale(1);
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-prev {
    transform: scale(0.66);
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-prev-prev {
    transform: scale(0.33);
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-next {
    transform: scale(0.66);
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-next-next {
    transform: scale(0.33);
}

.swiper-pagination-bullet {
    width: 8px;
    height: 8px;
    display: inline-block;
    border-radius: 100%;
    background: #000;
    opacity: 0.2;
}

button.swiper-pagination-bullet {
    border: none;
    margin: 0;
    padding: 0;
    box-shadow: none;
    -webkit-appearance: none;
    -moz-appearance: none;
    appearance: none;
}

.swiper-pagination-clickable .swiper-pagination-bullet {
    cursor: pointer;
}

.swiper-pagination-bullet-active {
    opacity: 1;
    background: var(--swiper-pagination-color, var(--swiper-theme-color));
}

.swiper-container-vertical > .swiper-pagination-bullets {
    right: 10px;
    top: 50%;
    transform: translate3d(0, -50%, 0);
}

.swiper-container-vertical
    > .swiper-pagination-bullets
    .swiper-pagination-bullet {
    margin: 6px 0;
    display: block;
}

.swiper-container-vertical
    > .swiper-pagination-bullets.swiper-pagination-bullets-dynamic {
    top: 50%;
    transform: translateY(-50%);
    width: 8px;
}

.swiper-container-vertical
    > .swiper-pagination-bullets.swiper-pagination-bullets-dynamic
    .swiper-pagination-bullet {
    display: inline-block;
    transition: transform 0.2s, top 0.2s;
}

.swiper-container-horizontal
    > .swiper-pagination-bullets
    .swiper-pagination-bullet {
    margin: 0 4px;
}

.swiper-container-horizontal
    > .swiper-pagination-bullets.swiper-pagination-bullets-dynamic {
    left: 50%;
    transform: translateX(-50%);
    white-space: nowrap;
}

.swiper-container-horizontal
    > .swiper-pagination-bullets.swiper-pagination-bullets-dynamic
    .swiper-pagination-bullet {
    transition: transform 0.2s, left 0.2s;
}

.swiper-container-horizontal.swiper-container-rtl
    > .swiper-pagination-bullets-dynamic
    .swiper-pagination-bullet {
    transition: transform 0.2s, right 0.2s;
}

.swiper-pagination-progressbar {
    background: rgba(0, 0, 0, 0.25);
    position: absolute;
}

.swiper-pagination-progressbar .swiper-pagination-progressbar-fill {
    background: var(--swiper-pagination-color, var(--swiper-theme-color));
    position: absolute;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    transform: scale(0);
    transform-origin: left top;
}

.swiper-container-rtl
    .swiper-pagination-progressbar
    .swiper-pagination-progressbar-fill {
    transform-origin: right top;
}

.swiper-container-horizontal > .swiper-pagination-progressbar,
.swiper-container-vertical
    > .swiper-pagination-progressbar.swiper-pagination-progressbar-opposite {
    width: 100%;
    height: 4px;
    left: 0;
    top: 0;
}

.swiper-container-horizontal
    > .swiper-pagination-progressbar.swiper-pagination-progressbar-opposite,
.swiper-container-vertical > .swiper-pagination-progressbar {
    width: 4px;
    height: 100%;
    left: 0;
    top: 0;
}

.swiper-pagination-white {
    --swiper-pagination-color: #fff;
}

.swiper-pagination-black {
    --swiper-pagination-color: #000;
}

.swiper-pagination-lock {
    display: none;
}

.swiper-scrollbar {
    border-radius: 10px;
    position: relative;
    -ms-touch-action: none;
    background: rgba(0, 0, 0, 0.1);
}

.swiper-container-horizontal > .swiper-scrollbar {
    position: absolute;
    left: 1%;
    bottom: 3px;
    z-index: 50;
    height: 5px;
    width: 98%;
}

.swiper-container-vertical > .swiper-scrollbar {
    position: absolute;
    right: 3px;
    top: 1%;
    z-index: 50;
    width: 5px;
    height: 98%;
}

.swiper-scrollbar-drag {
    height: 100%;
    width: 100%;
    position: relative;
    background: rgba(0, 0, 0, 0.5);
    border-radius: 10px;
    left: 0;
    top: 0;
}

.swiper-scrollbar-cursor-drag {
    cursor: move;
}

.swiper-scrollbar-lock {
    display: none;
}

.swiper-zoom-container {
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center;
}

.swiper-zoom-container > canvas,
.swiper-zoom-container > img,
.swiper-zoom-container > svg {
    max-width: 100%;
    max-height: 100%;
    object-fit: contain;
}

.swiper-slide-zoomed {
    cursor: move;
}

.swiper-lazy-preloader {
    width: 42px;
    height: 42px;
    position: absolute;
    left: 50%;
    top: 50%;
    margin-left: -21px;
    margin-top: -21px;
    z-index: 10;
    transform-origin: 50%;
    animation: swiper-preloader-spin 1s linear infinite;
    box-sizing: border-box;
    border-radius: 50%;
    border: 4px solid var(--swiper-preloader-color, var(--swiper-theme-color));
    border-top: 4px solid transparent;
}

.swiper-lazy-preloader-white {
    --swiper-preloader-color: #fff;
}

.swiper-lazy-preloader-black {
    --swiper-preloader-color: #000;
}

@keyframes swiper-preloader-spin {
    to {
        transform: rotate(1turn);
    }
}

.swiper-container .swiper-notification {
    position: absolute;
    left: 0;
    top: 0;
    pointer-events: none;
    opacity: 0;
    z-index: -1000;
}

.swiper-container-fade.swiper-container-free-mode .swiper-slide {
    transition-timing-function: ease-out;
}

.swiper-container-fade .swiper-slide {
    pointer-events: none;
    transition-property: opacity;
}

.swiper-container-fade .swiper-slide .swiper-slide {
    pointer-events: none;
}

.swiper-container-fade .swiper-slide-active,
.swiper-container-fade .swiper-slide-active .swiper-slide-active {
    pointer-events: auto;
}

.swiper-container-cube {
    overflow: visible;
}

.swiper-container-cube .swiper-slide {
    pointer-events: none;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
    z-index: 1;
    visibility: hidden;
    transform-origin: 0 0;
    width: 100%;
    height: 100%;
}

.swiper-container-cube .swiper-slide .swiper-slide {
    pointer-events: none;
}

.swiper-container-cube.swiper-container-rtl .swiper-slide {
    transform-origin: 100% 0;
}

.swiper-container-cube .swiper-slide-active,
.swiper-container-cube .swiper-slide-active .swiper-slide-active {
    pointer-events: auto;
}

.swiper-container-cube .swiper-slide-active,
.swiper-container-cube .swiper-slide-next,
.swiper-container-cube .swiper-slide-next + .swiper-slide,
.swiper-container-cube .swiper-slide-prev {
    pointer-events: auto;
    visibility: visible;
}

.swiper-container-cube .swiper-slide-shadow-bottom,
.swiper-container-cube .swiper-slide-shadow-left,
.swiper-container-cube .swiper-slide-shadow-right,
.swiper-container-cube .swiper-slide-shadow-top {
    z-index: 0;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
}

.swiper-container-cube .swiper-cube-shadow {
    position: absolute;
    left: 0;
    bottom: 0;
    width: 100%;
    height: 100%;
    background: #000;
    opacity: 0.6;
    -webkit-filter: blur(50px);
    filter: blur(50px);
    z-index: 0;
}

.swiper-container-flip {
    overflow: visible;
}

.swiper-container-flip .swiper-slide {
    pointer-events: none;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
    z-index: 1;
}

.swiper-container-flip .swiper-slide .swiper-slide {
    pointer-events: none;
}

.swiper-container-flip .swiper-slide-active,
.swiper-container-flip .swiper-slide-active .swiper-slide-active {
    pointer-events: auto;
}

.swiper-container-flip .swiper-slide-shadow-bottom,
.swiper-container-flip .swiper-slide-shadow-left,
.swiper-container-flip .swiper-slide-shadow-right,
.swiper-container-flip .swiper-slide-shadow-top {
    z-index: 0;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
}

.kk-text-field {
    --layout-template-columns: minmax(0, 1fr);
    --input-height: 48px;
    display: grid;
    grid-template-rows: minmax(0, 1fr);
    grid-template-columns: var(--layout-template-columns);
    gap: 8px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    position: relative;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    vertical-align: middle;
    border-radius: 8px;
    border: 1px solid #d5d6db;
    background-color: #fff;
    height: var(--input-height);
    padding: 0 12px;
}

.kk-text-field__leading-icon {
    color: #babbbe;
}

.kk-text-field__native {
    cursor: inherit;
    padding: 0;
    outline: none;
    border: none;
    background: none;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    color: #212121;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
}

.kk-text-field__native::-webkit-input-placeholder {
    color: #babbbe;
}

.kk-text-field__native::-moz-placeholder {
    color: #babbbe;
}

.kk-text-field__native:-ms-input-placeholder {
    color: #babbbe;
}

.kk-text-field__native::-ms-input-placeholder {
    color: #babbbe;
}

.kk-text-field__native::placeholder {
    color: #babbbe;
}

.kk-text-field__native:-moz-placeholder-shown {
    text-overflow: ellipsis;
}

.kk-text-field__native:-ms-input-placeholder {
    text-overflow: ellipsis;
}

.kk-text-field__native:placeholder-shown {
    text-overflow: ellipsis;
}

.kk-text-field__trailing-container {
    display: grid;
    gap: 12px;
    grid-auto-flow: column;
    color: #9c9da0;
}

.kk-text-field__delete-icon {
    padding: 2px;
    cursor: pointer;
}

.kk-text-field__delete-icon:hover {
    color: #727272;
}

.kk-text-field__trailing-icon {
    cursor: pointer;
}

.kk-text-field__trailing-icon:hover {
    color: #212121;
}

@media (pointer: fine) {
    .kk-text-field:not(
            .kk-text-field--disabled,
            .kk-text-field--search,
            .kk-text-field--error
        ):hover {
        border-color: #212121;
        outline: #212121;
    }
}

.kk-text-field:not(
        .kk-text-field--disabled,
        .kk-text-field--search,
        .kk-text-field--error
    ):focus-within {
    border-color: #212121;
    outline: #212121;
}

.kk-text-field--disabled {
    cursor: not-allowed;
    border-color: #e6e9ed;
    background-color: #f1f4f8;
}

.kk-text-field--disabled .kk-text-field__native {
    color: #babbbe;
    -webkit-text-fill-color: #babbbe;
}

.kk-text-field--disabled .kk-text-field__native::-webkit-input-placeholder {
    color: #babbbe;
}

.kk-text-field--disabled .kk-text-field__native::-moz-placeholder {
    color: #babbbe;
}

.kk-text-field--disabled .kk-text-field__native:-ms-input-placeholder {
    color: #babbbe;
}

.kk-text-field--disabled .kk-text-field__native::-ms-input-placeholder {
    color: #babbbe;
}

.kk-text-field--disabled .kk-text-field__native::placeholder {
    color: #babbbe;
}

.kk-text-field--disabled .kk-text-field__trailing-icon {
    color: #babbbe;
}

.kk-text-field--error {
    border-color: #e65f50;
}

.kk-text-field--search {
    --input-height: 40px;
    padding: 0 16px;
    background-color: #f7fafc;
    border-radius: calc(var(--input-height) / 2);
    border: none;
}

.kk-text-field--search .kk-text-field__native::-webkit-search-cancel-button,
.kk-text-field--search .kk-text-field__native::-webkit-search-decoration {
    display: none;
}

.kk-text-field--search .kk-text-field__leading-icon {
    color: #212121;
}

.kk-text-field--trailing {
    --layout-template-columns: minmax(0, 1fr) auto;
}

.kk-text-field--leading {
    --layout-template-columns: auto minmax(0, 1fr);
}

.kk-text-field--leading.kk-text-field--trailing {
    --layout-template-columns: auto minmax(0, 1fr) auto;
}
/*!
 * Cropper.js v1.5.11
 * https://fengyuanchen.github.io/cropperjs
 *
 * Copyright 2015-present Chen Fengyuan
 * Released under the MIT license
 *
 * Date: 2021-02-17T11:53:21.992Z
 */
 .cropper-container {
    direction: ltr;
    font-size: 0;
    line-height: 0;
    position: relative;
    -ms-touch-action: none;
    touch-action: none;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none
}

.cropper-container img {
    display: block;
    height: 100%;
    image-orientation: 0deg;
    max-height: none!important;
    max-width: none!important;
    min-height: 0!important;
    min-width: 0!important;
    width: 100%
}

.cropper-canvas,.cropper-crop-box,.cropper-drag-box,.cropper-modal,.cropper-wrap-box {
    bottom: 0;
    left: 0;
    position: absolute;
    right: 0;
    top: 0
}

.cropper-canvas,.cropper-wrap-box {
    overflow: hidden
}

.cropper-drag-box {
    background-color: #fff;
    opacity: 0
}

.cropper-modal {
    background-color: #000;
    opacity: .5
}

.cropper-view-box {
    display: block;
    height: 100%;
    outline: 1px solid #39f;
    outline-color: rgba(51,153,255,.75);
    overflow: hidden;
    width: 100%
}

.cropper-dashed {
    border: 0 dashed #eee;
    display: block;
    opacity: .5;
    position: absolute
}

.cropper-dashed.dashed-h {
    border-bottom-width: 1px;
    border-top-width: 1px;
    height: 33.33333%;
    left: 0;
    top: 33.33333%;
    width: 100%
}

.cropper-dashed.dashed-v {
    border-left-width: 1px;
    border-right-width: 1px;
    height: 100%;
    left: 33.33333%;
    top: 0;
    width: 33.33333%
}

.cropper-center {
    display: block;
    height: 0;
    left: 50%;
    opacity: .75;
    position: absolute;
    top: 50%;
    width: 0
}

.cropper-center:after,.cropper-center:before {
    background-color: #eee;
    content: " ";
    display: block;
    position: absolute
}

.cropper-center:before {
    height: 1px;
    left: -3px;
    top: 0;
    width: 7px
}

.cropper-center:after {
    height: 7px;
    left: 0;
    top: -3px;
    width: 1px
}

.cropper-face,.cropper-line,.cropper-point {
    display: block;
    height: 100%;
    opacity: .1;
    position: absolute;
    width: 100%
}

.cropper-face {
    background-color: #fff;
    left: 0;
    top: 0
}

.cropper-line {
    background-color: #39f
}

.cropper-line.line-e {
    cursor: ew-resize;
    right: -3px;
    top: 0;
    width: 5px
}

.cropper-line.line-n {
    cursor: ns-resize;
    height: 5px;
    left: 0;
    top: -3px
}

.cropper-line.line-w {
    cursor: ew-resize;
    left: -3px;
    top: 0;
    width: 5px
}

.cropper-line.line-s {
    bottom: -3px;
    cursor: ns-resize;
    height: 5px;
    left: 0
}

.cropper-point {
    background-color: #39f;
    height: 5px;
    opacity: .75;
    width: 5px
}

.cropper-point.point-e {
    cursor: ew-resize;
    margin-top: -3px;
    right: -3px;
    top: 50%
}

.cropper-point.point-n {
    cursor: ns-resize;
    left: 50%;
    margin-left: -3px;
    top: -3px
}

.cropper-point.point-w {
    cursor: ew-resize;
    left: -3px;
    margin-top: -3px;
    top: 50%
}

.cropper-point.point-s {
    bottom: -3px;
    cursor: s-resize;
    left: 50%;
    margin-left: -3px
}

.cropper-point.point-ne {
    cursor: nesw-resize;
    right: -3px;
    top: -3px
}

.cropper-point.point-nw {
    cursor: nwse-resize;
    left: -3px;
    top: -3px
}

.cropper-point.point-sw {
    bottom: -3px;
    cursor: nesw-resize;
    left: -3px
}

.cropper-point.point-se {
    bottom: -3px;
    cursor: nwse-resize;
    height: 20px;
    opacity: 1;
    right: -3px;
    width: 20px
}

@media (min-width: 768px) {
    .cropper-point.point-se {
        height:15px;
        width: 15px
    }
}

@media (min-width: 992px) {
    .cropper-point.point-se {
        height:10px;
        width: 10px
    }
}

@media (min-width: 1200px) {
    .cropper-point.point-se {
        height:5px;
        opacity: .75;
        width: 5px
    }
}

.cropper-point.point-se:before {
    background-color: #39f;
    bottom: -50%;
    content: " ";
    display: block;
    height: 200%;
    opacity: 0;
    position: absolute;
    right: -50%;
    width: 200%
}

.cropper-invisible {
    opacity: 0
}

.cropper-bg {
    background-image: url("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQAQMAAAAlPW0iAAAAA3NCSVQICAjb4U/gAAAABlBMVEXMzMz////TjRV2AAAACXBIWXMAAArrAAAK6wGCiw1aAAAAHHRFWHRTb2Z0d2FyZQBBZG9iZSBGaXJld29ya3MgQ1M26LyyjAAAABFJREFUCJlj+M/AgBVhF/0PAH6/D/HkDxOGAAAAAElFTkSuQmCC")
}

.cropper-hide {
    display: block;
    height: 0;
    position: absolute;
    width: 0
}

.cropper-hidden {
    display: none!important
}

.cropper-move {
    cursor: move
}

.cropper-crop {
    cursor: crosshair
}

.cropper-disabled .cropper-drag-box,.cropper-disabled .cropper-face,.cropper-disabled .cropper-line,.cropper-disabled .cropper-point {
    cursor: not-allowed
}

.owl-carousel,.owl-carousel .owl-item {
    -webkit-tap-highlight-color: transparent;
    position: relative
}

.owl-carousel {
    display: none;
    width: 100%;
    z-index: 1
}

.owl-carousel .owl-stage {
    position: relative;
    -ms-touch-action: pan-Y;
    touch-action: manipulation;
    -moz-backface-visibility: hidden
}

.owl-carousel .owl-stage:after {
    content: ".";
    display: block;
    clear: both;
    visibility: hidden;
    line-height: 0;
    height: 0
}

.owl-carousel .owl-stage-outer {
    position: relative;
    overflow: hidden;
    -webkit-transform: translateZ(0)
}

.owl-carousel .owl-item,.owl-carousel .owl-wrapper {
    -webkit-backface-visibility: hidden;
    -moz-backface-visibility: hidden;
    -ms-backface-visibility: hidden;
    -webkit-transform: translateZ(0);
    -moz-transform: translateZ(0);
    -ms-transform: translateZ(0)
}

.owl-carousel .owl-item {
    min-height: 1px;
    float: left;
    -webkit-backface-visibility: hidden;
    -webkit-touch-callout: none
}

.owl-carousel .owl-item img {
    display: block;
    width: 100%
}

.owl-carousel .owl-dots.disabled,.owl-carousel .owl-nav.disabled {
    display: none
}

.no-js .owl-carousel,.owl-carousel.owl-loaded {
    display: block
}

.owl-carousel .owl-dot,.owl-carousel .owl-nav .owl-next,.owl-carousel .owl-nav .owl-prev {
    cursor: pointer;
    -webkit-user-select: none;
    -khtml-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none
}

.owl-carousel .owl-nav button.owl-next,.owl-carousel .owl-nav button.owl-prev,.owl-carousel button.owl-dot {
    background: 0 0;
    color: inherit;
    border: none;
    padding: 0!important;
    font: inherit
}

.owl-carousel.owl-loading {
    opacity: 0;
    display: block
}

.owl-carousel.owl-hidden {
    opacity: 0
}

.owl-carousel.owl-refresh .owl-item {
    visibility: hidden
}

.owl-carousel.owl-drag .owl-item {
    -ms-touch-action: pan-y;
    touch-action: pan-y;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none
}

.owl-carousel.owl-grab {
    cursor: move;
    cursor: grab
}

.owl-carousel.owl-rtl {
    direction: rtl
}

.owl-carousel.owl-rtl .owl-item {
    float: right
}

.owl-carousel .animated {
    animation-duration: 1s;
    animation-fill-mode: both
}

.owl-carousel .owl-animated-in {
    z-index: 0
}

.owl-carousel .owl-animated-out {
    z-index: 1
}

.owl-carousel .fadeOut {
    animation-name: fadeOut
}

@keyframes fadeOut {
    0% {
        opacity: 1
    }

    to {
        opacity: 0
    }
}

.owl-height {
    transition: height .5s ease-in-out
}

.owl-carousel .owl-item .owl-lazy {
    opacity: 0;
    transition: opacity .4s ease
}

.owl-carousel .owl-item .owl-lazy:not([src]),.owl-carousel .owl-item .owl-lazy[src^=""] {
    max-height: 0
}

.owl-carousel .owl-item img.owl-lazy {
    transform-style: preserve-3d
}

.owl-carousel .owl-video-wrapper {
    position: relative;
    height: 100%;
    background: #000
}

.owl-carousel .owl-video-play-icon {
    position: absolute;
    height: 80px;
    width: 80px;
    left: 50%;
    top: 50%;
    margin-left: -40px;
    margin-top: -40px;
    background: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAMAAAC5zwKfAAADAFBMVEVHcEwAAAAAAAAAAAAAAAAAAAAAAAAGBgYEBAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGBgYAAAAAAAAAAAAAAAAAAAAAAAAFBQUAAAD9/f0AAAAAAAD+/v7////29vYAAAAAAAAAAAD8/PwBAQEAAAD+/v7x8fE4ODj4+Pju7u7////////q6uqKioqYmJgAAAD8/Py1tbX9/f34+Pj9/f2ioqLu7u79/f3l5eX////8/Pzq6ur39/fo6Oj9/f2np6fa2tr7+/v4+Pj////9/f3+/v7+/v5ra2vn5+cAAAAiIiJERETw8PD5+fn+/v77+/vr6+utra3x8fGOjo729vb7+/v5+fnx8fHX19fFxcXb29vi4uJZWVmenp61tbXu7u7n5+fr6+v9/f36+vrR0dHk5OTPz8/39/dcXFz7+/v8/PzKysr+/v63t7fu7u729vb4+Pj8/Pzv7+/z8/P9/f3U1NTw8PBWVlZeXl76+vr29vabm5vw8PD29vb19fW8vLzj4+MkJCTc3Nzg4ODf39/Q0NC+vr709PTz8/PX19fT09PS0tLOzs6YmJjw8PDp6en8/Pzj4+Pj4+PBwcH7+/v6+vqdnZ2Ojo729vbm5ubIyMh1dXUxMTGhoaELCwvT09M3Nzf9/f39/f35+fm+vr78/Py9vb2qqqr39/esrKzm5uaCgoK4uLibm5v5+flxcXH////Q0NDMzMz9/f3t7e3d3d38/Py/v7/m5ub7+/v7+/vs7OzCwsJ9fX309PT09PTk5OT6+vpNTU2xsbHR0dGAgIDg4ODW1takpKTOzs7k5OStra319fXW1tZHR0fj4+Obm5v7+/u/v7/c3NwzMzPm5uazs7PGxsbOzs7CwsKwsLDm5uZPT0+urq63t7d9fX3l5eW8vLxeXl4uLi7a2trDw8P9/f1ERESdnZ319fWHh4f9/f3e3t77+/vHx8dCQkLW1tbz8/PMzMzh4eHi4uL09PRsbGzz8/PDw8Nzc3P////GZWjoAAAA/3RSTlMABwgGBBkLAQIDDQ8THQkVLygSIDIKDiQfNSYQPCv1ESL5/uc4NhjzLBfw4UrbqAT7z21yN6GLv+21e9jLZxZjqB+R6TycQuf9h9L2Wsk0Q04le9uAxoTdY5uv8HmnmrS+DRYrm2qIdtR9m5bhMOprheOOzjXQ9m6y7K8RU1YvG2baXeWRwT+5WnNBM8XBNRpaJByub05SgkviyltCqsI1RyFON61Fz7lUeqeUe+wELGgSdzpgC6uj+dW8TJc72FhQi2Fn38TGPXunFGJQDj57Is1KEkhUjW+JD4ZafnKOTbVHiFhasIA8MphqnCk54FVzZHOgSbK4l8MakU5YjFkmdqVZAAAGrUlEQVRYw71ZdXwTVxy/JJeTeBqtppRK6rqywdC1DCkVpEVbbDjF3SnD3d1hDCgMdwYMnbu7MGfKfLu9310a0t5d7q77fPb+yeXee9/83IJh/++aca5to05RDLdiJl3s3vPCEbLeaK07d2IE1qAJS+l6gE7vOIoRXYNW96UUEvc1E3xVDlihgMzpfrjqDuXZBXviQtm166NPb/ZqMt63lTTAIZfKzr4rDe9m/2yPdBkTDSHcMpi1Rtf221t9mKmrVXIgjz3IHc8s3WMPMxp0JtzPG0nRGofe7N4+tIo70+IVWhJvoA/uaKzXbSBwPgkkrdIlDh/JQaY2lSLyPvZcVWmE16gXPUvSJsPw/Pasba4jgiGeeIDFm5xices1QZWIIHeOYQ8P0Ymz3bIRq9nGsWEGtaS4aWLHlzGsIPViiM1YvDPT7EYdLUN7JO75KiEYYvpjsNshxZuolmmyNPFBQ5ZrYcTusHe2KNKAy3YB0pQ3DG69qROQUFvY+S3C6sEVuCipyquEe+/xdd2ctb4iq4dW5PSkZj3I8c4OVV2FPASviyNDcIVRiVQtb4Oufmag+QZ9OstixhXHOdLUCpgb7KR4DJ8P1WrqEYfJtxaDc32jDny5FwwmItpRV7/75AQ9ehEkifxApr8Hho9HhvNUxWzpJ8OI8AHA4E7CfzIdcsfJUC1fgAwz6YU+kl5IPp2KAHrF+++PQF97FLsIUgCQYV56WSNFJP0MsLjZD9AOfT1lNwtYIBtP2vR/Uco4+wxC54bWILRGXxKmuhyYCCDDPNxUIvpQj4CiXaZ7OeRsoRCBmD/LLXk+uHL6gmM87uF+Fp6zrQQZDJBp0KpvML6pbhD5jKwDjgVq5xoFfSQwFafOVwUh8lUItl4dPP6Inu7aQ0gpQIaZuEic7+c2oAN/sijgJQetBCYNyCSsEzVKcgva/zseieUEeoiaZtTIAWSYcc+KGeUEtHs1Gjn0dPRQtstMywNkYtJEnPFCEtq94cSwJ9Fnb0s4KROQialcYBLie9k4tNnVwFnhKRERYsKl1+KFAkRSE9HOTS0XWnNrbFweINOg/0q+iP5AG+VGDINiobFNpQiQYYb9wMu1PSHiRGPYdfQ5U0TJWJCS85dtdfh+Cr2c58IwqN66anHFgMgZa1ecs0G71v8AWD2ydgr6C717FAFurB9gxuRiS23AGgqhQspWDHgmKyfMXDtIggwrrFxJc1AhYI8DEV4tUcdyOqKNWwgQAtn7yrQ8b5rdFs7zaQCa4/KZj00tH7DsaKzVzPe+dM6gMewS5Pgwh1zAhJ+KLEadgOu1hFz8D/KUEuhIvtDJBLx2vNAVIhi5W0MRPzceww5BovwuRFa0qSqNtcY7hCMd6GRWKIo2JBji5XhcGvD0yWKL0SmWBaCgzvWieIhBSt0qopVAvMwn4lzi3UEziK8pbJBZAaL+XCcBeP/oiEie6QUsiNPJcWb4Pfoier4tnAP8YbpiKjK9YLkejOa8xcnmK7DEMW5VEMAm2TlCphewSkDHV1yc4A4DCZv0opVDQnmRV9D0AtbroOMcn2pp0HNvQXcGvN4FhdEeiYpuRhKrYx9RZFMIR6/pSCHA5Max1kTJ3h2anOQIv9hUkAG7CJGYkZ8SxPTuuR0QeMDioQKrO+YNJ//e2rAwg0q6yN7PEhhgy6pV4NDD+catCidkdFZrgJ45lpB7gqEWwqsP+W0PKaetaDaKbUrcgfTgbwt0Q3IbH3YMkFW7KSGJJeD9nzjqMYNi29jyuDo6pfpBN1SZp1aMOIJri3lNCb6ArTC+1ShEnA29aHKKVU8JN5XD8pQhNs9Al8ZnWQx8I6Z0LdgwtV4J19zY6GPhNpZypsFu1ALZQ7Ip3NBtdI7bJEgErWdpZNJWyhsTjN3LJobcWJvYdInWD+E6kuUy3C19YHtubBRnE59W0c7B3Chv1TapgHCOG+JlFtiNwURE6TZnsgej0pYGgTy0phEXyndHREqMjShTfL6vnpw4/4jwT7ccsdHXpI6OdXmkWCHx8He6+FLJhv5rl9XBTC9p3j3Jt707xe6WMyWjCO3Ispp0l3S924RLY0t+nzJlxuFj+zrub9egZqciK07OEI8jUu9+d1bQIXHG5Kw4q5aQPYWiVB73pqHVYnBlc6YWWrU6XImTUiq91jXz16t8tCa5BTkWm5nAlcYlEjd5tK4bMy9XdJhV1SMhofrOmWu3Sq/MDfXaEvVqul7/CCBMvVlrC4u0WOxoWbxWl1tr0NUTrYZ3XO3QOfXhaOmdhEkjBfYvpX7J0Wnxft0AAAAASUVORK5CYII=) no-repeat;
    cursor: pointer;
    z-index: 1;
    -webkit-backface-visibility: hidden;
    transition: transform .1s ease
}

.owl-carousel .owl-video-play-icon:hover {
    -ms-transform: scale(1.3);
    transform: scale(1.3)
}

.owl-carousel .owl-video-playing .owl-video-play-icon,.owl-carousel .owl-video-playing .owl-video-tn {
    display: none
}

.owl-carousel .owl-video-tn {
    opacity: 0;
    height: 100%;
    background-position: 50%;
    background-repeat: no-repeat;
    background-size: contain;
    transition: opacity .4s ease
}

.owl-carousel .owl-video-frame {
    position: relative;
    z-index: 1;
    height: 100%;
    width: 100%
}

.intl-tel-input {
    position: relative;
    display: inline-block
}

.intl-tel-input * {
    box-sizing: border-box;
    -moz-box-sizing: border-box
}

.intl-tel-input .hide {
    display: none
}

.intl-tel-input .v-hide {
    visibility: hidden
}

.intl-tel-input input,.intl-tel-input input[type=tel],.intl-tel-input input[type=text] {
    position: relative;
    z-index: 0;
    margin-top: 0!important;
    margin-bottom: 0!important;
    padding-right: 36px;
    margin-right: 0
}

.intl-tel-input .flag-container {
    position: absolute;
    top: 0;
    bottom: 0;
    right: 0;
    padding: 1px
}

.intl-tel-input .selected-flag {
    z-index: 1;
    position: relative;
    width: 36px;
    height: 100%;
    padding: 0 0 0 8px
}

.intl-tel-input .selected-flag .iti-flag {
    position: absolute;
    top: 0;
    bottom: 0;
    margin: auto
}

.intl-tel-input .selected-flag .iti-arrow {
    position: absolute;
    top: 50%;
    margin-top: -2px;
    right: 6px;
    width: 0;
    height: 0;
    border-left: 3px solid transparent;
    border-right: 3px solid transparent;
    border-top: 4px solid #555
}

.intl-tel-input .selected-flag .iti-arrow.up {
    border-top: none;
    border-bottom: 4px solid #555
}

.intl-tel-input .country-list {
    position: absolute;
    z-index: 2;
    list-style: none;
    text-align: left;
    padding: 0;
    margin: 0 0 0 -1px;
    box-shadow: 1px 1px 4px rgba(0,0,0,.2);
    background-color: #fff;
    border: 1px solid #ccc;
    white-space: nowrap;
    max-height: 200px;
    overflow-y: scroll
}

.intl-tel-input .country-list.dropup {
    bottom: 100%;
    margin-bottom: -1px
}

.intl-tel-input .country-list .flag-box {
    display: inline-block;
    width: 20px
}

@media (max-width: 500px) {
    .intl-tel-input .country-list {
        white-space:normal
    }
}

.intl-tel-input .country-list .divider {
    padding-bottom: 5px;
    margin-bottom: 5px;
    border-bottom: 1px solid #ccc
}

.intl-tel-input .country-list .country {
    padding: 5px 10px
}

.intl-tel-input .country-list .country .dial-code {
    color: #999
}

.intl-tel-input .country-list .country.highlight {
    background-color: rgba(0,0,0,.05)
}

.intl-tel-input .country-list .country-name,.intl-tel-input .country-list .dial-code,.intl-tel-input .country-list .flag-box {
    vertical-align: middle
}

.intl-tel-input .country-list .country-name,.intl-tel-input .country-list .flag-box {
    margin-right: 6px
}

.intl-tel-input.allow-dropdown input,.intl-tel-input.allow-dropdown input[type=tel],.intl-tel-input.allow-dropdown input[type=text],.intl-tel-input.separate-dial-code input,.intl-tel-input.separate-dial-code input[type=tel],.intl-tel-input.separate-dial-code input[type=text] {
    padding-right: 6px;
    padding-left: 52px;
    margin-left: 0
}

.intl-tel-input.allow-dropdown .flag-container,.intl-tel-input.separate-dial-code .flag-container {
    right: auto;
    left: 0
}

.intl-tel-input.allow-dropdown .selected-flag,.intl-tel-input.separate-dial-code .selected-flag {
    width: 46px
}

.intl-tel-input.allow-dropdown .flag-container:hover {
    cursor: pointer
}

.intl-tel-input.allow-dropdown .flag-container:hover .selected-flag {
    background-color: rgba(0,0,0,.05)
}

.intl-tel-input.allow-dropdown input[disabled]+.flag-container:hover,.intl-tel-input.allow-dropdown input[readonly]+.flag-container:hover {
    cursor: default
}

.intl-tel-input.allow-dropdown input[disabled]+.flag-container:hover .selected-flag,.intl-tel-input.allow-dropdown input[readonly]+.flag-container:hover .selected-flag {
    background-color: transparent
}

.intl-tel-input.separate-dial-code .selected-flag {
    background-color: rgba(0,0,0,.05);
    display: table
}

.intl-tel-input.separate-dial-code .selected-dial-code {
    display: table-cell;
    vertical-align: middle;
    padding-left: 28px
}

.intl-tel-input.separate-dial-code.iti-sdc-2 input,.intl-tel-input.separate-dial-code.iti-sdc-2 input[type=tel],.intl-tel-input.separate-dial-code.iti-sdc-2 input[type=text] {
    padding-left: 66px
}

.intl-tel-input.separate-dial-code.iti-sdc-2 .selected-flag {
    width: 60px
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 input,.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 input[type=tel],.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 input[type=text] {
    padding-left: 76px
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-2 .selected-flag {
    width: 70px
}

.intl-tel-input.separate-dial-code.iti-sdc-3 input,.intl-tel-input.separate-dial-code.iti-sdc-3 input[type=tel],.intl-tel-input.separate-dial-code.iti-sdc-3 input[type=text] {
    padding-left: 74px
}

.intl-tel-input.separate-dial-code.iti-sdc-3 .selected-flag {
    width: 68px
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 input,.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 input[type=tel],.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 input[type=text] {
    padding-left: 84px
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-3 .selected-flag {
    width: 78px
}

.intl-tel-input.separate-dial-code.iti-sdc-4 input,.intl-tel-input.separate-dial-code.iti-sdc-4 input[type=tel],.intl-tel-input.separate-dial-code.iti-sdc-4 input[type=text] {
    padding-left: 82px
}

.intl-tel-input.separate-dial-code.iti-sdc-4 .selected-flag {
    width: 76px
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 input,.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 input[type=tel],.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 input[type=text] {
    padding-left: 92px
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-4 .selected-flag {
    width: 86px
}

.intl-tel-input.separate-dial-code.iti-sdc-5 input,.intl-tel-input.separate-dial-code.iti-sdc-5 input[type=tel],.intl-tel-input.separate-dial-code.iti-sdc-5 input[type=text] {
    padding-left: 90px
}

.intl-tel-input.separate-dial-code.iti-sdc-5 .selected-flag {
    width: 84px
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 input,.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 input[type=tel],.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 input[type=text] {
    padding-left: 100px
}

.intl-tel-input.separate-dial-code.allow-dropdown.iti-sdc-5 .selected-flag {
    width: 94px
}

.intl-tel-input.iti-container {
    position: absolute;
    top: -1000px;
    left: -1000px;
    z-index: 1060;
    padding: 1px
}

.intl-tel-input.iti-container:hover {
    cursor: pointer
}

.iti-mobile .intl-tel-input.iti-container {
    top: 30px;
    bottom: 30px;
    left: 30px;
    right: 30px;
    position: fixed
}

.iti-mobile .intl-tel-input .country-list {
    max-height: 100%;
    width: 100%
}

.iti-mobile .intl-tel-input .country-list .country {
    padding: 10px;
    line-height: 1.5em
}

.iti-flag.be {
    width: 18px
}

.iti-flag.ch {
    width: 15px
}

.iti-flag.mc {
    width: 19px
}

.iti-flag.ne {
    width: 18px
}

.iti-flag.np {
    width: 13px
}

.iti-flag.va {
    width: 15px
}

@media only screen and (-o-min-device-pixel-ratio: 2/1),only screen and (-webkit-min-device-pixel-ratio:2),only screen and (min--moz-device-pixel-ratio:2),only screen and (min-device-pixel-ratio:2),only screen and (min-resolution:2dppx),only screen and (min-resolution:192dpi) {
    .iti-flag {
        background-size:5630px 15px
    }
}

.iti-flag.ac {
    height: 10px;
    background-position: 0 0
}

.iti-flag.ad {
    height: 14px;
    background-position: -22px 0
}

.iti-flag.ae {
    height: 10px;
    background-position: -44px 0
}

.iti-flag.af {
    height: 14px;
    background-position: -66px 0
}

.iti-flag.ag {
    height: 14px;
    background-position: -88px 0
}

.iti-flag.ai {
    height: 10px;
    background-position: -110px 0
}

.iti-flag.al {
    height: 15px;
    background-position: -132px 0
}

.iti-flag.am {
    height: 10px;
    background-position: -154px 0
}

.iti-flag.ao {
    height: 14px;
    background-position: -176px 0
}

.iti-flag.aq {
    height: 14px;
    background-position: -198px 0
}

.iti-flag.ar {
    height: 13px;
    background-position: -220px 0
}

.iti-flag.as {
    height: 10px;
    background-position: -242px 0
}

.iti-flag.at {
    height: 14px;
    background-position: -264px 0
}

.iti-flag.au {
    height: 10px;
    background-position: -286px 0
}

.iti-flag.aw {
    height: 14px;
    background-position: -308px 0
}

.iti-flag.ax {
    height: 13px;
    background-position: -330px 0
}

.iti-flag.az {
    height: 10px;
    background-position: -352px 0
}

.iti-flag.ba {
    height: 10px;
    background-position: -374px 0
}

.iti-flag.bb {
    height: 14px;
    background-position: -396px 0
}

.iti-flag.bd {
    height: 12px;
    background-position: -418px 0
}

.iti-flag.be {
    height: 15px;
    background-position: -440px 0
}

.iti-flag.bf {
    height: 14px;
    background-position: -460px 0
}

.iti-flag.bg {
    height: 12px;
    background-position: -482px 0
}

.iti-flag.bh {
    height: 12px;
    background-position: -504px 0
}

.iti-flag.bi {
    height: 12px;
    background-position: -526px 0
}

.iti-flag.bj {
    height: 14px;
    background-position: -548px 0
}

.iti-flag.bl {
    height: 14px;
    background-position: -570px 0
}

.iti-flag.bm {
    height: 10px;
    background-position: -592px 0
}

.iti-flag.bn {
    height: 10px;
    background-position: -614px 0
}

.iti-flag.bo {
    height: 14px;
    background-position: -636px 0
}

.iti-flag.bq {
    height: 14px;
    background-position: -658px 0
}

.iti-flag.br {
    height: 14px;
    background-position: -680px 0
}

.iti-flag.bs {
    height: 10px;
    background-position: -702px 0
}

.iti-flag.bt {
    height: 14px;
    background-position: -724px 0
}

.iti-flag.bv {
    height: 15px;
    background-position: -746px 0
}

.iti-flag.bw {
    height: 14px;
    background-position: -768px 0
}

.iti-flag.by {
    height: 10px;
    background-position: -790px 0
}

.iti-flag.bz {
    height: 14px;
    background-position: -812px 0
}

.iti-flag.ca {
    height: 10px;
    background-position: -834px 0
}

.iti-flag.cc {
    height: 10px;
    background-position: -856px 0
}

.iti-flag.cd {
    height: 15px;
    background-position: -878px 0
}

.iti-flag.cf {
    height: 14px;
    background-position: -900px 0
}

.iti-flag.cg {
    height: 14px;
    background-position: -922px 0
}

.iti-flag.ch {
    height: 15px;
    background-position: -944px 0
}

.iti-flag.ci {
    height: 14px;
    background-position: -961px 0
}

.iti-flag.ck {
    height: 10px;
    background-position: -983px 0
}

.iti-flag.cl {
    height: 14px;
    background-position: -1005px 0
}

.iti-flag.cm {
    height: 14px;
    background-position: -1027px 0
}

.iti-flag.cn {
    height: 14px;
    background-position: -1049px 0
}

.iti-flag.co {
    height: 14px;
    background-position: -1071px 0
}

.iti-flag.cp {
    height: 14px;
    background-position: -1093px 0
}

.iti-flag.cr {
    height: 12px;
    background-position: -1115px 0
}

.iti-flag.cu {
    height: 10px;
    background-position: -1137px 0
}

.iti-flag.cv {
    height: 12px;
    background-position: -1159px 0
}

.iti-flag.cw {
    height: 14px;
    background-position: -1181px 0
}

.iti-flag.cx {
    height: 10px;
    background-position: -1203px 0
}

.iti-flag.cy {
    height: 13px;
    background-position: -1225px 0
}

.iti-flag.cz {
    height: 14px;
    background-position: -1247px 0
}

.iti-flag.de {
    height: 12px;
    background-position: -1269px 0
}

.iti-flag.dg {
    height: 10px;
    background-position: -1291px 0
}

.iti-flag.dj {
    height: 14px;
    background-position: -1313px 0
}

.iti-flag.dk {
    height: 15px;
    background-position: -1335px 0
}

.iti-flag.dm {
    height: 10px;
    background-position: -1357px 0
}

.iti-flag.do {
    height: 13px;
    background-position: -1379px 0
}

.iti-flag.dz {
    height: 14px;
    background-position: -1401px 0
}

.iti-flag.ea {
    height: 14px;
    background-position: -1423px 0
}

.iti-flag.ec {
    height: 14px;
    background-position: -1445px 0
}

.iti-flag.ee {
    height: 13px;
    background-position: -1467px 0
}

.iti-flag.eg {
    height: 14px;
    background-position: -1489px 0
}

.iti-flag.eh {
    height: 10px;
    background-position: -1511px 0
}

.iti-flag.er {
    height: 10px;
    background-position: -1533px 0
}

.iti-flag.es {
    height: 14px;
    background-position: -1555px 0
}

.iti-flag.et {
    height: 10px;
    background-position: -1577px 0
}

.iti-flag.eu {
    height: 14px;
    background-position: -1599px 0
}

.iti-flag.fi {
    height: 12px;
    background-position: -1621px 0
}

.iti-flag.fj {
    height: 10px;
    background-position: -1643px 0
}

.iti-flag.fk {
    height: 10px;
    background-position: -1665px 0
}

.iti-flag.fm {
    height: 11px;
    background-position: -1687px 0
}

.iti-flag.fo {
    height: 15px;
    background-position: -1709px 0
}

.iti-flag.fr {
    height: 14px;
    background-position: -1731px 0
}

.iti-flag.ga {
    height: 15px;
    background-position: -1753px 0
}

.iti-flag.gb {
    height: 10px;
    background-position: -1775px 0
}

.iti-flag.gd {
    height: 12px;
    background-position: -1797px 0
}

.iti-flag.ge {
    height: 14px;
    background-position: -1819px 0
}

.iti-flag.gf {
    height: 14px;
    background-position: -1841px 0
}

.iti-flag.gg {
    height: 14px;
    background-position: -1863px 0
}

.iti-flag.gh {
    height: 14px;
    background-position: -1885px 0
}

.iti-flag.gi {
    height: 10px;
    background-position: -1907px 0
}

.iti-flag.gl {
    height: 14px;
    background-position: -1929px 0
}

.iti-flag.gm {
    height: 14px;
    background-position: -1951px 0
}

.iti-flag.gn {
    height: 14px;
    background-position: -1973px 0
}

.iti-flag.gp {
    height: 14px;
    background-position: -1995px 0
}

.iti-flag.gq {
    height: 14px;
    background-position: -2017px 0
}

.iti-flag.gr {
    height: 14px;
    background-position: -2039px 0
}

.iti-flag.gs {
    height: 10px;
    background-position: -2061px 0
}

.iti-flag.gt {
    height: 13px;
    background-position: -2083px 0
}

.iti-flag.gu {
    height: 11px;
    background-position: -2105px 0
}

.iti-flag.gw {
    height: 10px;
    background-position: -2127px 0
}

.iti-flag.gy {
    height: 12px;
    background-position: -2149px 0
}

.iti-flag.hk {
    height: 14px;
    background-position: -2171px 0
}

.iti-flag.hm {
    height: 10px;
    background-position: -2193px 0
}

.iti-flag.hn {
    height: 10px;
    background-position: -2215px 0
}

.iti-flag.hr {
    height: 10px;
    background-position: -2237px 0
}

.iti-flag.ht {
    height: 12px;
    background-position: -2259px 0
}

.iti-flag.hu {
    height: 10px;
    background-position: -2281px 0
}

.iti-flag.ic {
    height: 14px;
    background-position: -2303px 0
}

.iti-flag.id {
    height: 14px;
    background-position: -2325px 0
}

.iti-flag.ie {
    height: 10px;
    background-position: -2347px 0
}

.iti-flag.il {
    height: 15px;
    background-position: -2369px 0
}

.iti-flag.im {
    height: 10px;
    background-position: -2391px 0
}

.iti-flag.in {
    height: 14px;
    background-position: -2413px 0
}

.iti-flag.io {
    height: 10px;
    background-position: -2435px 0
}

.iti-flag.iq {
    height: 14px;
    background-position: -2457px 0
}

.iti-flag.ir {
    height: 12px;
    background-position: -2479px 0
}

.iti-flag.is {
    height: 15px;
    background-position: -2501px 0
}

.iti-flag.it {
    height: 14px;
    background-position: -2523px 0
}

.iti-flag.je {
    height: 12px;
    background-position: -2545px 0
}

.iti-flag.jm {
    height: 10px;
    background-position: -2567px 0
}

.iti-flag.jo {
    height: 10px;
    background-position: -2589px 0
}

.iti-flag.jp {
    height: 14px;
    background-position: -2611px 0
}

.iti-flag.ke {
    height: 14px;
    background-position: -2633px 0
}

.iti-flag.kg {
    height: 12px;
    background-position: -2655px 0
}

.iti-flag.kh {
    height: 13px;
    background-position: -2677px 0
}

.iti-flag.ki {
    height: 10px;
    background-position: -2699px 0
}

.iti-flag.km {
    height: 12px;
    background-position: -2721px 0
}

.iti-flag.kn {
    height: 14px;
    background-position: -2743px 0
}

.iti-flag.kp {
    height: 10px;
    background-position: -2765px 0
}

.iti-flag.kr {
    height: 14px;
    background-position: -2787px 0
}

.iti-flag.kw {
    height: 10px;
    background-position: -2809px 0
}

.iti-flag.ky {
    height: 10px;
    background-position: -2831px 0
}

.iti-flag.kz {
    height: 10px;
    background-position: -2853px 0
}

.iti-flag.la {
    height: 14px;
    background-position: -2875px 0
}

.iti-flag.lb {
    height: 14px;
    background-position: -2897px 0
}

.iti-flag.lc {
    height: 10px;
    background-position: -2919px 0
}

.iti-flag.li {
    height: 12px;
    background-position: -2941px 0
}

.iti-flag.lk {
    height: 10px;
    background-position: -2963px 0
}

.iti-flag.lr {
    height: 11px;
    background-position: -2985px 0
}

.iti-flag.ls {
    height: 14px;
    background-position: -3007px 0
}

.iti-flag.lt {
    height: 12px;
    background-position: -3029px 0
}

.iti-flag.lu {
    height: 12px;
    background-position: -3051px 0
}

.iti-flag.lv {
    height: 10px;
    background-position: -3073px 0
}

.iti-flag.ly {
    height: 10px;
    background-position: -3095px 0
}

.iti-flag.ma {
    height: 14px;
    background-position: -3117px 0
}

.iti-flag.mc {
    height: 15px;
    background-position: -3139px 0
}

.iti-flag.md {
    height: 10px;
    background-position: -3160px 0
}

.iti-flag.me {
    height: 10px;
    background-position: -3182px 0
}

.iti-flag.mf {
    height: 14px;
    background-position: -3204px 0
}

.iti-flag.mg {
    height: 14px;
    background-position: -3226px 0
}

.iti-flag.mh {
    height: 11px;
    background-position: -3248px 0
}

.iti-flag.mk {
    height: 10px;
    background-position: -3270px 0
}

.iti-flag.ml {
    height: 14px;
    background-position: -3292px 0
}

.iti-flag.mm {
    height: 14px;
    background-position: -3314px 0
}

.iti-flag.mn {
    height: 10px;
    background-position: -3336px 0
}

.iti-flag.mo {
    height: 14px;
    background-position: -3358px 0
}

.iti-flag.mp {
    height: 10px;
    background-position: -3380px 0
}

.iti-flag.mq {
    height: 14px;
    background-position: -3402px 0
}

.iti-flag.mr {
    height: 14px;
    background-position: -3424px 0
}

.iti-flag.ms {
    height: 10px;
    background-position: -3446px 0
}

.iti-flag.mt {
    height: 14px;
    background-position: -3468px 0
}

.iti-flag.mu {
    height: 14px;
    background-position: -3490px 0
}

.iti-flag.mv {
    height: 14px;
    background-position: -3512px 0
}

.iti-flag.mw {
    height: 14px;
    background-position: -3534px 0
}

.iti-flag.mx {
    height: 12px;
    background-position: -3556px 0
}

.iti-flag.my {
    height: 10px;
    background-position: -3578px 0
}

.iti-flag.mz {
    height: 14px;
    background-position: -3600px 0
}

.iti-flag.na {
    height: 14px;
    background-position: -3622px 0
}

.iti-flag.nc {
    height: 10px;
    background-position: -3644px 0
}

.iti-flag.ne {
    height: 15px;
    background-position: -3666px 0
}

.iti-flag.nf {
    height: 10px;
    background-position: -3686px 0
}

.iti-flag.ng {
    height: 10px;
    background-position: -3708px 0
}

.iti-flag.ni {
    height: 12px;
    background-position: -3730px 0
}

.iti-flag.nl {
    height: 14px;
    background-position: -3752px 0
}

.iti-flag.no {
    height: 15px;
    background-position: -3774px 0
}

.iti-flag.np {
    height: 15px;
    background-position: -3796px 0
}

.iti-flag.nr {
    height: 10px;
    background-position: -3811px 0
}

.iti-flag.nu {
    height: 10px;
    background-position: -3833px 0
}

.iti-flag.nz {
    height: 10px;
    background-position: -3855px 0
}

.iti-flag.om {
    height: 10px;
    background-position: -3877px 0
}

.iti-flag.pa {
    height: 14px;
    background-position: -3899px 0
}

.iti-flag.pe {
    height: 14px;
    background-position: -3921px 0
}

.iti-flag.pf {
    height: 14px;
    background-position: -3943px 0
}

.iti-flag.pg {
    height: 15px;
    background-position: -3965px 0
}

.iti-flag.ph {
    height: 10px;
    background-position: -3987px 0
}

.iti-flag.pk {
    height: 14px;
    background-position: -4009px 0
}

.iti-flag.pl {
    height: 13px;
    background-position: -4031px 0
}

.iti-flag.pm {
    height: 14px;
    background-position: -4053px 0
}

.iti-flag.pn {
    height: 10px;
    background-position: -4075px 0
}

.iti-flag.pr {
    height: 14px;
    background-position: -4097px 0
}

.iti-flag.ps {
    height: 10px;
    background-position: -4119px 0
}

.iti-flag.pt {
    height: 14px;
    background-position: -4141px 0
}

.iti-flag.pw {
    height: 13px;
    background-position: -4163px 0
}

.iti-flag.py {
    height: 11px;
    background-position: -4185px 0
}

.iti-flag.qa {
    height: 8px;
    background-position: -4207px 0
}

.iti-flag.re {
    height: 14px;
    background-position: -4229px 0
}

.iti-flag.ro {
    height: 14px;
    background-position: -4251px 0
}

.iti-flag.rs {
    height: 14px;
    background-position: -4273px 0
}

.iti-flag.ru {
    height: 14px;
    background-position: -4295px 0
}

.iti-flag.rw {
    height: 14px;
    background-position: -4317px 0
}

.iti-flag.sa {
    height: 14px;
    background-position: -4339px 0
}

.iti-flag.sb {
    height: 10px;
    background-position: -4361px 0
}

.iti-flag.sc {
    height: 10px;
    background-position: -4383px 0
}

.iti-flag.sd {
    height: 10px;
    background-position: -4405px 0
}

.iti-flag.se {
    height: 13px;
    background-position: -4427px 0
}

.iti-flag.sg {
    height: 14px;
    background-position: -4449px 0
}

.iti-flag.sh {
    height: 10px;
    background-position: -4471px 0
}

.iti-flag.si {
    height: 10px;
    background-position: -4493px 0
}

.iti-flag.sj {
    height: 15px;
    background-position: -4515px 0
}

.iti-flag.sk {
    height: 14px;
    background-position: -4537px 0
}

.iti-flag.sl {
    height: 14px;
    background-position: -4559px 0
}

.iti-flag.sm {
    height: 15px;
    background-position: -4581px 0
}

.iti-flag.sn {
    height: 14px;
    background-position: -4603px 0
}

.iti-flag.so {
    height: 14px;
    background-position: -4625px 0
}

.iti-flag.sr {
    height: 14px;
    background-position: -4647px 0
}

.iti-flag.ss {
    height: 10px;
    background-position: -4669px 0
}

.iti-flag.st {
    height: 10px;
    background-position: -4691px 0
}

.iti-flag.sv {
    height: 12px;
    background-position: -4713px 0
}

.iti-flag.sx {
    height: 14px;
    background-position: -4735px 0
}

.iti-flag.sy {
    height: 14px;
    background-position: -4757px 0
}

.iti-flag.sz {
    height: 14px;
    background-position: -4779px 0
}

.iti-flag.ta {
    height: 10px;
    background-position: -4801px 0
}

.iti-flag.tc {
    height: 10px;
    background-position: -4823px 0
}

.iti-flag.td {
    height: 14px;
    background-position: -4845px 0
}

.iti-flag.tf {
    height: 14px;
    background-position: -4867px 0
}

.iti-flag.tg {
    height: 13px;
    background-position: -4889px 0
}

.iti-flag.th {
    height: 14px;
    background-position: -4911px 0
}

.iti-flag.tj {
    height: 10px;
    background-position: -4933px 0
}

.iti-flag.tk {
    height: 10px;
    background-position: -4955px 0
}

.iti-flag.tl {
    height: 10px;
    background-position: -4977px 0
}

.iti-flag.tm {
    height: 14px;
    background-position: -4999px 0
}

.iti-flag.tn {
    height: 14px;
    background-position: -5021px 0
}

.iti-flag.to {
    height: 10px;
    background-position: -5043px 0
}

.iti-flag.tr {
    height: 14px;
    background-position: -5065px 0
}

.iti-flag.tt {
    height: 12px;
    background-position: -5087px 0
}

.iti-flag.tv {
    height: 10px;
    background-position: -5109px 0
}

.iti-flag.tw {
    height: 14px;
    background-position: -5131px 0
}

.iti-flag.tz {
    height: 14px;
    background-position: -5153px 0
}

.iti-flag.ua {
    height: 14px;
    background-position: -5175px 0
}

.iti-flag.ug {
    height: 14px;
    background-position: -5197px 0
}

.iti-flag.um {
    height: 11px;
    background-position: -5219px 0
}

.iti-flag.us {
    height: 11px;
    background-position: -5241px 0
}

.iti-flag.uy {
    height: 14px;
    background-position: -5263px 0
}

.iti-flag.uz {
    height: 10px;
    background-position: -5285px 0
}

.iti-flag.va {
    height: 15px;
    background-position: -5307px 0
}

.iti-flag.vc {
    height: 14px;
    background-position: -5324px 0
}

.iti-flag.ve {
    height: 14px;
    background-position: -5346px 0
}

.iti-flag.vg {
    height: 10px;
    background-position: -5368px 0
}

.iti-flag.vi {
    height: 14px;
    background-position: -5390px 0
}

.iti-flag.vn {
    height: 14px;
    background-position: -5412px 0
}

.iti-flag.vu {
    height: 12px;
    background-position: -5434px 0
}

.iti-flag.wf {
    height: 14px;
    background-position: -5456px 0
}

.iti-flag.ws {
    height: 10px;
    background-position: -5478px 0
}

.iti-flag.xk {
    height: 15px;
    background-position: -5500px 0
}

.iti-flag.ye {
    height: 14px;
    background-position: -5522px 0
}

.iti-flag.yt {
    height: 14px;
    background-position: -5544px 0
}

.iti-flag.za {
    height: 14px;
    background-position: -5566px 0
}

.iti-flag.zm {
    height: 14px;
    background-position: -5588px 0
}

.iti-flag.zw {
    height: 10px;
    background-position: -5610px 0
}

.iti-flag {
    width: 20px;
    height: 15px;
    box-shadow: 0 0 1px 0 #888;
    background-image: url(https://cdn.kkday.com/pc-web/pc/dist/img/flags.376404854f9a9419b3b2e5c4a7bee788.png);
    background-repeat: no-repeat;
    background-color: #dbdbdb;
    background-position: 20px 0
}

@media only screen and (-o-min-device-pixel-ratio: 2/1),only screen and (-webkit-min-device-pixel-ratio:2),only screen and (min--moz-device-pixel-ratio:2),only screen and (min-device-pixel-ratio:2),only screen and (min-resolution:2dppx),only screen and (min-resolution:192dpi) {
    .iti-flag {
        background-image:url(https://cdn.kkday.com/pc-web/pc/dist/img/flags@2x.f8537027fd9a8ea127ca2d9eef84f68f.png)
    }
}

.iti-flag.np {
    background-color: transparent
}

.irs {
    -webkit-touch-callout: none;
    -webkit-user-select: none;
    -khtml-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none
}

.irs,.irs-line {
    position: relative;
    display: block
}

.irs-line {
    overflow: hidden;
    outline: none!important
}

.irs-line-left,.irs-line-mid,.irs-line-right {
    position: absolute;
    display: block;
    top: 0
}

.irs-line-left {
    left: 0;
    width: 11%
}

.irs-line-mid {
    left: 9%;
    width: 82%
}

.irs-line-right {
    right: 0;
    width: 11%
}

.irs-bar {
    width: 0
}

.irs-bar,.irs-bar-edge {
    position: absolute;
    display: block;
    left: 0
}

.irs-bar-edge {
    top: 0
}

.irs-shadow {
    position: absolute;
    display: none;
    left: 0;
    width: 0
}

.irs-slider {
    position: absolute;
    display: block;
    cursor: default;
    z-index: 1
}

.irs-slider.type_last {
    z-index: 2
}

.irs-min {
    left: 0
}

.irs-max,.irs-min {
    position: absolute;
    display: block;
    cursor: default
}

.irs-max {
    right: 0
}

.irs-from,.irs-single,.irs-to {
    position: absolute;
    display: block;
    top: 0;
    left: 0;
    cursor: default;
    white-space: nowrap
}

.irs-grid {
    position: absolute;
    display: none;
    bottom: 0;
    left: 0;
    width: 100%;
    height: 20px
}

.irs-with-grid .irs-grid {
    display: block
}

.irs-grid-pol {
    position: absolute;
    top: 0;
    left: 0;
    width: 1px;
    height: 8px;
    background: #000
}

.irs-grid-pol.small {
    height: 4px
}

.irs-grid-text {
    position: absolute;
    bottom: 0;
    left: 0;
    white-space: nowrap;
    text-align: center;
    font-size: 9px;
    line-height: 9px;
    padding: 0 3px;
    color: #000
}

.irs-disable-mask {
    position: absolute;
    display: block;
    top: 0;
    left: -1%;
    width: 102%;
    height: 100%;
    cursor: default;
    background: transparent;
    z-index: 2
}

.lt-ie9 .irs-disable-mask {
    background: #000;
    filter: alpha(opacity=0);
    cursor: not-allowed
}

.irs-disabled {
    opacity: .4
}

.irs-hidden-input {
    position: absolute!important;
    display: block!important;
    top: 0!important;
    left: 0!important;
    width: 0!important;
    height: 0!important;
    font-size: 0!important;
    line-height: 0!important;
    padding: 0!important;
    margin: 0!important;
    overflow: hidden;
    outline: none!important;
    z-index: -9999!important;
    background: none!important;
    border-style: solid!important;
    border-color: transparent!important
}

.irs {
    height: 55px
}

.irs-with-grid {
    height: 75px
}

.irs-line {
    height: 10px;
    top: 33px;
    background: #eee;
    background: linear-gradient(180deg,#ddd -50%,#fff 150%);
    border: 1px solid #ccc;
    border-radius: 16px;
    -moz-border-radius: 16px
}

.irs-line-left,.irs-line-mid,.irs-line-right {
    height: 8px
}

.irs-bar {
    border-top: 1px solid #428bca;
    border-bottom: 1px solid #428bca
}

.irs-bar,.irs-bar-edge {
    height: 10px;
    top: 33px;
    background: #428bca;
    background: linear-gradient(0deg,#428bca 0,#7fc3e8)
}

.irs-bar-edge {
    width: 14px;
    border: 1px solid #428bca;
    border-right: 0;
    border-radius: 16px 0 0 16px;
    -moz-border-radius: 16px 0 0 16px
}

.irs-shadow {
    height: 2px;
    top: 38px;
    background: #000;
    opacity: .3;
    border-radius: 5px;
    -moz-border-radius: 5px
}

.lt-ie9 .irs-shadow {
    filter: alpha(opacity=30)
}

.irs-slider {
    top: 25px;
    width: 27px;
    height: 27px;
    border: 1px solid #aaa;
    background: #ddd;
    background: linear-gradient(180deg,#fff 0,#dcdcdc 20%,#fff);
    border-radius: 27px;
    -moz-border-radius: 27px;
    box-shadow: 1px 1px 3px rgba(0,0,0,.3);
    cursor: pointer
}

.irs-slider.state_hover,.irs-slider:hover {
    background: #fff
}

.irs-max,.irs-min {
    color: #333;
    font-size: 12px;
    line-height: 1.333;
    text-shadow: none;
    top: 0;
    padding: 1px 5px;
    background: rgba(0,0,0,.1);
    border-radius: 3px;
    -moz-border-radius: 3px
}

.lt-ie9 .irs-max,.lt-ie9 .irs-min {
    background: #ccc
}

.irs-from,.irs-single,.irs-to {
    color: #fff;
    font-size: 14px;
    line-height: 1.333;
    text-shadow: none;
    padding: 1px 5px;
    background: #428bca;
    border-radius: 3px;
    -moz-border-radius: 3px
}

.lt-ie9 .irs-from,.lt-ie9 .irs-single,.lt-ie9 .irs-to {
    background: #999
}

.irs-grid {
    height: 27px
}

.irs-grid-pol {
    opacity: .5;
    background: #428bca
}

.irs-grid-pol.small {
    background: #999
}

.irs-grid-text {
    bottom: 5px;
    color: #99a4ac
}

:root {
    --kk-font-size-1: 12px;
    --kk-font-size-2: 14px;
    --kk-font-size-3: 16px;
    --kk-font-size-4: 18px;
    --kk-font-size-5: 22px;
    --kk-font-size-6: 24px;
    --kk-font-size-7: 26px;
    --kk-font-size-8: 28px;
    --kk-font-size-9: 32px;
    --kk-font-weight-light: 300;
    --kk-font-weight-regular: 400;
    --kk-font-weight-medium: 500;
    --kk-font-weight-medium-android: 600;
    --kk-font-weight-bold: 700;
    --kk-text-h4-font-size: 24px;
    --kk-text-h4-line-height: 30px;
    --kk-text-h4-font-weight: 700;
    --kk-text-h5-font-size: 22px;
    --kk-text-h5-line-height: 28px;
    --kk-text-h5-font-weight: 700;
    --kk-text-h6-font-size: 18px;
    --kk-text-h6-line-height: 26px;
    --kk-text-h6-font-weight: 700;
    --kk-text-subtitle-lg-font-size: 16px;
    --kk-text-subtitle-lg-line-height: 24px;
    --kk-text-subtitle-lg-font-weight: 700;
    --kk-text-subtitle-md-font-size: 14px;
    --kk-text-subtitle-md-line-height: 20px;
    --kk-text-subtitle-md-font-weight: 500;
    --kk-text-body-lg-font-size: 16px;
    --kk-text-body-lg-line-height: 24px;
    --kk-text-body-lg-font-weight: 400;
    --kk-text-body-md-font-size: 14px;
    --kk-text-body-md-line-height: 20px;
    --kk-text-body-md-font-weight: 400;
    --kk-text-body-sm-font-size: 12px;
    --kk-text-body-sm-line-height: 16px;
    --kk-text-body-sm-font-weight: 400;
    --kk-text-category-font-size: 12px;
    --kk-text-category-line-height: 16px;
    --kk-text-category-font-weight: 400;
    --kk-color-white: #fff;
    --kk-color-text-lighter: #d5d6db;
    --kk-color-text-light: #babbbe;
    --kk-color-text-medium: #9c9da0;
    --kk-color-text-dark: #727272;
    --kk-color-text-darker: #212121;
    --kk-color-text-primary-lighter: #cef0f3;
    --kk-color-text-primary-light: #ade6eb;
    --kk-color-text-primary-medium: #26bec9;
    --kk-color-text-primary-dark: #13a3b6;
    --kk-color-text-primary-darker: #068b9f;
    --kk-color-text-critical-lighter: #f5a8a4;
    --kk-color-text-critical-light: #f2918a;
    --kk-color-text-critical-medium: #ef7a70;
    --kk-color-text-critical-dark: #e65f50;
    --kk-color-text-critical-darker: #d14330;
    --kk-color-text-info-lighter: #9dd3fa;
    --kk-color-text-info-light: #81c4f7;
    --kk-color-text-info-medium: #64b3f4;
    --kk-color-text-info-dark: #2d84d6;
    --kk-color-text-info-darker: #1565c0;
    --kk-color-text-warning-lighter: #fee269;
    --kk-color-text-warning-light: #facf58;
    --kk-color-text-warning-medium: #f5b53d;
    --kk-color-text-warning-dark: #e78f37;
    --kk-color-text-warning-darker: #de6928;
    --kk-color-text-highlight-lighter: #ffca28;
    --kk-color-text-highlight-light: #ffc128;
    --kk-color-text-highlight-medium: #ffb400;
    --kk-color-text-highlight-dark: #ffa000;
    --kk-color-text-highlight-darker: #ff8f00;
    --kk-color-background-surface-lighter: #f7fafc;
    --kk-color-background-surface-light: #f1f4f8;
    --kk-color-background-surface-medium: #e6e9ed;
    --kk-color-background-surface-dark: #d5d6db;
    --kk-color-background-surface-darker: #9c9da0;
    --kk-color-background-primary-lighter: #f0fafb;
    --kk-color-background-primary-light: #cef0f3;
    --kk-color-background-primary-medium: #26bec9;
    --kk-color-background-primary-dark: #13a3b6;
    --kk-color-background-primary-darker: #03748a;
    --kk-color-background-critical-lighter: #fff2f2;
    --kk-color-background-critical-light: #fac2c0;
    --kk-color-background-critical-medium: #ef7a70;
    --kk-color-background-critical-dark: #e65f50;
    --kk-color-background-critical-darker: #d14330;
    --kk-color-background-info-lighter: #f2faff;
    --kk-color-background-info-light: #b9e0fa;
    --kk-color-background-info-medium: #64b3f4;
    --kk-color-background-info-dark: #2d84d6;
    --kk-color-background-info-darker: #1565c0;
    --kk-color-background-warning-lighter: #fffee0;
    --kk-color-background-warning-light: #fffbc3;
    --kk-color-background-warning-medium: #fee269;
    --kk-color-background-warning-dark: #f5b53d;
    --kk-color-background-warning-darker: #e78f37;
    --kk-color-background-highlight-lighter: #fff8e1;
    --kk-color-background-highlight-light: #ffca28;
    --kk-color-background-highlight-medium: #ffb400;
    --kk-color-background-highlight-dark: #ffa000;
    --kk-color-background-highlight-darker: #ff8f00;
    --kk-color-border-lighter: #e6e9ed;
    --kk-color-border-light: #d5d6db;
    --kk-color-border-medium: #babbbe;
    --kk-color-border-dark: #727272;
    --kk-color-border-darker: #212121;
    --kk-color-border-primary-lighter: #cef0f3;
    --kk-color-border-primary-light: #ade6eb;
    --kk-color-border-primary-medium: #26bec9;
    --kk-color-border-primary-dark: #13a3b6;
    --kk-color-border-primary-darker: #068b9f;
    --kk-color-border-critical-lighter: #f5a8a4;
    --kk-color-border-critical-light: #f2918a;
    --kk-color-border-critical-medium: #ef7a70;
    --kk-color-border-critical-dark: #e65f50;
    --kk-color-border-critical-darker: #d14330;
    --kk-color-border-info-lighter: #9dd3fa;
    --kk-color-border-info-light: #81c4f7;
    --kk-color-border-info-medium: #64b3f4;
    --kk-color-border-info-dark: #499feb;
    --kk-color-border-info-darker: #2d84d6;
    --kk-color-border-warning-lighter: #feed87;
    --kk-color-border-warning-light: #fee269;
    --kk-color-border-warning-medium: #facf58;
    --kk-color-border-warning-dark: #f5b53d;
    --kk-color-border-warning-darker: #e78f37;
    --kk-color-border-highlight-lighter: #ffca28;
    --kk-color-border-highlight-light: #ffc128;
    --kk-color-border-highlight-medium: #ffb400;
    --kk-color-border-highlight-dark: #ffa000;
    --kk-color-border-highlight-darker: #ff8f00;
    --kk-color-line-default: #06c755;
    --kk-color-line-dark: #05b34c;
    --kk-color-kakao-default: #fee500;
    --kk-color-kakao-dark: #f0d700;
    --kk-color-facebook-default: #1877f2;
    --kk-color-facebook-dark: #166fe5;
    --kk-color-apple-default: #000;
    --kk-color-apple-dark: #000;
    --kk-color-naver-default: #19ce60;
    --kk-color-naver-dark: #16b956;
    --kk-color-google-default: #fff;
    --kk-color-google-dark: #f2f3f4;
    --kk-color-wechat-default: #18d271;
    --kk-color-wechat-dark: #16bd66;
    --kk-color-yahoo-jp-default: #f03;
    --kk-color-yahoo-jp-dark: #e5002e;
    --kk-radius-xs: 2px;
    --kk-radius-sm: 4px;
    --kk-radius-md: 8px;
    --kk-radius-lg: 12px;
    --kk-radius-xl: 16px;
    --kk-spacing-1: 2px;
    --kk-spacing-2: 4px;
    --kk-spacing-3: 8px;
    --kk-spacing-4: 12px;
    --kk-spacing-5: 16px;
    --kk-spacing-6: 20px;
    --kk-spacing-7: 24px;
    --kk-spacing-8: 32px;
    --kk-spacing-9: 40px;
    --kk-spacing-10: 48px;
    --kk-elevation-action-offset-x: 0px;
    --kk-elevation-action-offset-y: 1px;
    --kk-elevation-action-blur: 4px;
    --kk-elevation-action-spread: 0px;
    --kk-elevation-action-color: rgba(38,50,56,0.12);
    --kk-elevation-fixed-offset-x: 0px;
    --kk-elevation-fixed-offset-y: 2px;
    --kk-elevation-fixed-blur: 24px;
    --kk-elevation-fixed-spread: 0px;
    --kk-elevation-fixed-color: rgba(38,50,56,0.12);
    --kk-elevation-raised-offset-x: 0px;
    --kk-elevation-raised-offset-y: 8px;
    --kk-elevation-raised-blur: 24px;
    --kk-elevation-raised-spread: 0px;
    --kk-elevation-raised-color: rgba(37,42,49,0.24);
    --kk-dimension-icon-2xs: 14px;
    --kk-dimension-icon-xs: 16px;
    --kk-dimension-icon-sm: 20px;
    --kk-dimension-icon-md: 24px;
    --kk-dimension-icon-lg: 32px;
    --kk-dimension-icon-xl: 48px
}

body,html {
    color: #212121
}

:root {
    --layout-spacing-0: 0;
    --layout-spacing-1: 2px;
    --layout-spacing-2: 4px;
    --layout-spacing-3: 8px;
    --layout-spacing-4: 12px;
    --layout-spacing-5: 16px;
    --layout-spacing-6: 20px;
    --layout-spacing-7: 24px;
    --layout-spacing-8: 32px;
    --layout-spacing-9: 40px;
    --layout-spacing-10: 48px
}

.layout-absolute {
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex
}

.layout-absolute__wrapper {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto;
    display: grid;
    grid-template: 1fr/1fr
}

.layout-absolute__cell {
    grid-column-start: 1;
    grid-column-end: 1;
    grid-row-start: 1;
    grid-row-end: 1
}

.layout-absolute__cell--top-left {
    justify-self: start;
    -ms-flex-item-align: start;
    align-self: start
}

.layout-absolute__cell--top {
    justify-self: center;
    -ms-flex-item-align: start;
    align-self: start
}

.layout-absolute__cell--top-right {
    justify-self: end;
    -ms-flex-item-align: start;
    align-self: start
}

.layout-absolute__cell--right {
    justify-self: end;
    -ms-flex-item-align: center;
    align-self: center
}

.layout-absolute__cell--bottom-right {
    justify-self: end;
    -ms-flex-item-align: end;
    align-self: end
}

.layout-absolute__cell--bottom {
    justify-self: center;
    -ms-flex-item-align: end;
    align-self: end
}

.layout-absolute__cell--bottom-left {
    justify-self: start;
    -ms-flex-item-align: end;
    align-self: end
}

.layout-absolute__cell--left {
    justify-self: start;
    -ms-flex-item-align: center;
    align-self: center
}

.layout-absolute__cell--center {
    justify-self: center;
    -ms-flex-item-align: center;
    align-self: center
}

.layout-u-debug .layout-absolute {
    background-color: rgba(220,20,60,.0784313725);
    cursor: default
}

.layout-u-debug .layout-absolute.layout--debug {
    background: repeating-linear-gradient(45deg,rgba(220,20,60,.2),rgba(220,20,60,.2) 1px,transparent 0,transparent 10px),hsla(0,0%,100%,.5019607843);
    outline: 2px solid rgba(220,20,60,.6);
    outline-offset: -2px
}

.layout-u-debug .layout-absolute.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: "LayoutAbsolute";
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #dc143c;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(220,20,60,.2) inset;
    box-shadow: inset 0 0 100px rgba(220,20,60,.2);
    padding: 12px;
    z-index: 9999
}

.layout-absolute.layout--debug.layout-absolute>.layout-absolute__wrapper>.layout-absolute__cell:not(:empty) {
    background-color: #f8d0d8;
    outline: 2px dashed rgba(220,20,60,.6);
    outline-offset: -2px
}

.layout-align {
    display: grid;
    grid-template-columns: minmax(0,auto)
}

.layout-align--horizontal-align-left {
    -webkit-box-pack: start;
    -ms-flex-pack: start;
    justify-content: start
}

.layout-align--horizontal-align-center {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center
}

.layout-align--horizontal-align-right {
    -webkit-box-pack: end;
    -ms-flex-pack: end;
    justify-content: end
}

.layout-align--horizontal-align-default,.layout-align--horizontal-align-stretch {
    -webkit-box-pack: stretch;
    -ms-flex-pack: stretch;
    justify-content: stretch
}

.layout-align--horizontal-align-default>.layout-align__content,.layout-align--horizontal-align-stretch>.layout-align__content {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    -ms-flex-direction: row;
    flex-direction: row
}

.layout-align--horizontal-align-default>.layout-align__content>*,.layout-align--horizontal-align-stretch>.layout-align__content>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    width: auto
}

.layout-align--vertical-align-default,.layout-align--vertical-align-top {
    -ms-flex-line-pack: start;
    align-content: start
}

.layout-align--vertical-align-center {
    -ms-flex-line-pack: center;
    align-content: center
}

.layout-align--vertical-align-bottom {
    -ms-flex-line-pack: end;
    align-content: end
}

.layout-align--vertical-align-stretch {
    -ms-flex-line-pack: stretch;
    align-content: stretch
}

.layout-align--vertical-align-stretch>.layout-align__content {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column
}

.layout-align--vertical-align-stretch>.layout-align__content>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto
}

.layout-u-debug .layout-align {
    background-color: rgba(255,127,80,.0784313725);
    cursor: default
}

.layout-u-debug .layout-align.layout--debug {
    background: repeating-linear-gradient(45deg,rgba(255,127,80,.2),rgba(255,127,80,.2) 1px,transparent 0,transparent 10px),hsla(0,0%,100%,.5019607843);
    outline: 2px solid rgba(255,127,80,.6);
    outline-offset: -2px
}

.layout-u-debug .layout-align.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: "LayoutAlign";
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid coral;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(255,127,80,.2) inset;
    box-shadow: inset 0 0 100px rgba(255,127,80,.2);
    padding: 12px;
    z-index: 9999
}

.layout-align.layout--debug.layout-align>:not(:empty) {
    background-color: #ffe5dc;
    outline: 2px dashed rgba(255,127,80,.6);
    outline-offset: -2px
}

.layout-columns {
    --layout-columns-gap: 0px;
    --layout-columns-gap-x: var(--layout-columns-gap);
    --layout-columns-gap-y: var(--layout-columns-gap)
}

.layout-columns--flow-direction-row {
    display: grid;
    grid-template-columns: repeat(var(--layout-columns-column-count,auto-fit),minmax(var(--layout-columns-content-min-width,0),1fr));
    gap: var(--layout-columns-gap-y) var(--layout-columns-gap-x);
    -webkit-box-pack: stretch;
    -ms-flex-pack: stretch;
    justify-content: stretch
}

.layout-columns--flow-direction-row.layout-columns--vertical-align-top {
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: start
}

.layout-columns--flow-direction-row.layout-columns--vertical-align-center {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center
}

.layout-columns--flow-direction-row.layout-columns--vertical-align-bottom {
    -webkit-box-align: end;
    -ms-flex-align: end;
    align-items: end
}

.layout-columns--flow-direction-row.layout-columns--vertical-align-default,.layout-columns--flow-direction-row.layout-columns--vertical-align-stretch {
    -webkit-box-align: stretch;
    -ms-flex-align: stretch;
    align-items: stretch
}

.layout-columns--flow-direction-column>.layout-columns__wrapper {
    -moz-columns: var(--layout-columns-content-min-width,auto) var(--layout-columns-column-count,auto);
    -webkit-columns: var(--layout-columns-content-min-width,auto) var(--layout-columns-column-count,auto);
    columns: var(--layout-columns-content-min-width,auto) var(--layout-columns-column-count,auto);
    -moz-column-gap: var(--layout-columns-gap-x);
    -webkit-column-gap: var(--layout-columns-gap-x);
    column-gap: var(--layout-columns-gap-x);
    margin-bottom: calc(var(--layout-columns-gap-y)*-1)
}

.layout-columns--flow-direction-column>.layout-columns__wrapper>.layout-columns__item {
    display: inline-grid;
    width: 100%;
    -moz-column-break-inside: avoid;
    -webkit-column-break-inside: avoid;
    break-inside: avoid;
    margin-bottom: var(--layout-columns-gap-y)
}

.layout-columns--gap-0 {
    --layout-columns-gap: var(--layout-spacing-0)
}

.layout-columns--gap-1 {
    --layout-columns-gap: var(--layout-spacing-1)
}

.layout-columns--gap-2 {
    --layout-columns-gap: var(--layout-spacing-2)
}

.layout-columns--gap-3 {
    --layout-columns-gap: var(--layout-spacing-3)
}

.layout-columns--gap-4 {
    --layout-columns-gap: var(--layout-spacing-4)
}

.layout-columns--gap-5 {
    --layout-columns-gap: var(--layout-spacing-5)
}

.layout-columns--gap-6 {
    --layout-columns-gap: var(--layout-spacing-6)
}

.layout-columns--gap-7 {
    --layout-columns-gap: var(--layout-spacing-7)
}

.layout-columns--gap-8 {
    --layout-columns-gap: var(--layout-spacing-8)
}

.layout-columns--gap-9 {
    --layout-columns-gap: var(--layout-spacing-9)
}

.layout-columns--gap-10 {
    --layout-columns-gap: var(--layout-spacing-10)
}

.layout-columns--gap-x-0 {
    --layout-columns-gap-x: var(--layout-spacing-0)
}

.layout-columns--gap-y-0 {
    --layout-columns-gap-y: var(--layout-spacing-0)
}

.layout-columns--gap-x-1 {
    --layout-columns-gap-x: var(--layout-spacing-1)
}

.layout-columns--gap-y-1 {
    --layout-columns-gap-y: var(--layout-spacing-1)
}

.layout-columns--gap-x-2 {
    --layout-columns-gap-x: var(--layout-spacing-2)
}

.layout-columns--gap-y-2 {
    --layout-columns-gap-y: var(--layout-spacing-2)
}

.layout-columns--gap-x-3 {
    --layout-columns-gap-x: var(--layout-spacing-3)
}

.layout-columns--gap-y-3 {
    --layout-columns-gap-y: var(--layout-spacing-3)
}

.layout-columns--gap-x-4 {
    --layout-columns-gap-x: var(--layout-spacing-4)
}

.layout-columns--gap-y-4 {
    --layout-columns-gap-y: var(--layout-spacing-4)
}

.layout-columns--gap-x-5 {
    --layout-columns-gap-x: var(--layout-spacing-5)
}

.layout-columns--gap-y-5 {
    --layout-columns-gap-y: var(--layout-spacing-5)
}

.layout-columns--gap-x-6 {
    --layout-columns-gap-x: var(--layout-spacing-6)
}

.layout-columns--gap-y-6 {
    --layout-columns-gap-y: var(--layout-spacing-6)
}

.layout-columns--gap-x-7 {
    --layout-columns-gap-x: var(--layout-spacing-7)
}

.layout-columns--gap-y-7 {
    --layout-columns-gap-y: var(--layout-spacing-7)
}

.layout-columns--gap-x-8 {
    --layout-columns-gap-x: var(--layout-spacing-8)
}

.layout-columns--gap-y-8 {
    --layout-columns-gap-y: var(--layout-spacing-8)
}

.layout-columns--gap-x-9 {
    --layout-columns-gap-x: var(--layout-spacing-9)
}

.layout-columns--gap-y-9 {
    --layout-columns-gap-y: var(--layout-spacing-9)
}

.layout-columns--gap-x-10 {
    --layout-columns-gap-x: var(--layout-spacing-10)
}

.layout-columns--gap-y-10 {
    --layout-columns-gap-y: var(--layout-spacing-10)
}

.layout-u-debug .layout-columns {
    background-color: rgba(210,105,30,.0784313725);
    cursor: default
}

.layout-u-debug .layout-columns.layout--debug {
    background: repeating-linear-gradient(45deg,rgba(210,105,30,.2),rgba(210,105,30,.2) 1px,transparent 0,transparent 10px),hsla(0,0%,100%,.5019607843);
    outline: 2px solid rgba(210,105,30,.6);
    outline-offset: -2px
}

.layout-u-debug .layout-columns.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: "LayoutColumns";
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #d2691e;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(210,105,30,.2) inset;
    box-shadow: inset 0 0 100px rgba(210,105,30,.2);
    padding: 12px;
    z-index: 9999
}

.layout-columns.layout--debug.layout-columns--flow-direction-column>.layout-columns__wrapper>.layout-columns__item:not(:empty),.layout-columns.layout--debug.layout-columns--flow-direction-row>:not(:empty) {
    background-color: #f6e1d2;
    outline: 2px dashed rgba(210,105,30,.6);
    outline-offset: -2px
}

.layout-flex-column {
    --layout-flex-column-gap: 0px;
    display: grid;
    grid-template-columns: minmax(0,1fr);
    grid-template-rows: auto minmax(0,1fr) auto;
    gap: var(--layout-flex-column-gap)
}

.layout-flex-column--no-remain {
    grid-template-rows: auto minmax(var(--layout-flex-column-gap),1fr) auto;
    gap: 0
}

.layout-flex-column--no-top {
    grid-template-rows: minmax(0,1fr) auto
}

.layout-flex-column--no-bottom {
    grid-template-rows: auto minmax(0,1fr)
}

.layout-flex-column--no-top.layout-flex-column--no-bottom {
    grid-template-rows: minmax(0,1fr)
}

.layout-flex-column__remain {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column
}

.layout-flex-column__remain>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 0px;
    flex: 1 1 0;
    height: auto
}

.layout-flex-column--horizontal-align-left {
    justify-items: start
}

.layout-flex-column--horizontal-align-center {
    justify-items: center
}

.layout-flex-column--horizontal-align-right {
    justify-items: end
}

.layout-flex-column--horizontal-align-default,.layout-flex-column--horizontal-align-stretch {
    justify-items: stretch
}

.layout-flex-column--gap-0 {
    --layout-flex-column-gap: var(--layout-spacing-0)
}

.layout-flex-column--gap-1 {
    --layout-flex-column-gap: var(--layout-spacing-1)
}

.layout-flex-column--gap-2 {
    --layout-flex-column-gap: var(--layout-spacing-2)
}

.layout-flex-column--gap-3 {
    --layout-flex-column-gap: var(--layout-spacing-3)
}

.layout-flex-column--gap-4 {
    --layout-flex-column-gap: var(--layout-spacing-4)
}

.layout-flex-column--gap-5 {
    --layout-flex-column-gap: var(--layout-spacing-5)
}

.layout-flex-column--gap-6 {
    --layout-flex-column-gap: var(--layout-spacing-6)
}

.layout-flex-column--gap-7 {
    --layout-flex-column-gap: var(--layout-spacing-7)
}

.layout-flex-column--gap-8 {
    --layout-flex-column-gap: var(--layout-spacing-8)
}

.layout-flex-column--gap-9 {
    --layout-flex-column-gap: var(--layout-spacing-9)
}

.layout-flex-column--gap-10 {
    --layout-flex-column-gap: var(--layout-spacing-10)
}

.layout-u-debug .layout-flex-column {
    background-color: rgba(95,158,160,.0784313725);
    cursor: default
}

.layout-u-debug .layout-flex-column.layout--debug {
    background: repeating-linear-gradient(45deg,rgba(95,158,160,.2),rgba(95,158,160,.2) 1px,transparent 0,transparent 10px),hsla(0,0%,100%,.5019607843);
    outline: 2px solid rgba(95,158,160,.6);
    outline-offset: -2px
}

.layout-u-debug .layout-flex-column.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: "LayoutFlexColumn";
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #5f9ea0;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(95,158,160,.2) inset;
    box-shadow: inset 0 0 100px rgba(95,158,160,.2);
    padding: 12px;
    z-index: 9999
}

.layout-flex-column.layout--debug.layout-flex-column>:not(:empty) {
    background-color: #dfecec;
    outline: 2px dashed rgba(95,158,160,.6);
    outline-offset: -2px
}

.layout-flex-row {
    --layout-flex-row-gap: 0px;
    display: grid;
    grid-template-rows: minmax(0,1fr);
    grid-template-columns: auto minmax(0,1fr) auto;
    gap: var(--layout-flex-row-gap)
}

.layout-flex-row--no-remain {
    grid-template-columns: auto minmax(var(--layout-flex-row-gap),1fr) auto;
    gap: 0
}

.layout-flex-row--no-left {
    grid-template-columns: minmax(0,1fr) auto
}

.layout-flex-row--no-right {
    grid-template-columns: auto minmax(0,1fr)
}

.layout-flex-row--no-left.layout-flex-row--no-right {
    grid-template-columns: minmax(0,1fr)
}

.layout-flex-row__remain {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    -ms-flex-direction: row;
    flex-direction: row
}

.layout-flex-row__remain>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 0px;
    flex: 1 1 0;
    width: auto
}

.layout-flex-row--vertical-align-top {
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: start
}

.layout-flex-row--vertical-align-center {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center
}

.layout-flex-row--vertical-align-bottom {
    -webkit-box-align: end;
    -ms-flex-align: end;
    align-items: end
}

.layout-flex-row--vertical-align-default>.layout-flex-row__left,.layout-flex-row--vertical-align-default>.layout-flex-row__remain,.layout-flex-row--vertical-align-default>.layout-flex-row__right,.layout-flex-row--vertical-align-stretch>.layout-flex-row__left,.layout-flex-row--vertical-align-stretch>.layout-flex-row__remain,.layout-flex-row--vertical-align-stretch>.layout-flex-row__right {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column
}

.layout-flex-row--vertical-align-default>.layout-flex-row__left>*,.layout-flex-row--vertical-align-default>.layout-flex-row__remain>*,.layout-flex-row--vertical-align-default>.layout-flex-row__right>*,.layout-flex-row--vertical-align-stretch>.layout-flex-row__left>*,.layout-flex-row--vertical-align-stretch>.layout-flex-row__remain>*,.layout-flex-row--vertical-align-stretch>.layout-flex-row__right>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto
}

.layout-flex-row--gap-0 {
    --layout-flex-row-gap: var(--layout-spacing-0)
}

.layout-flex-row--gap-1 {
    --layout-flex-row-gap: var(--layout-spacing-1)
}

.layout-flex-row--gap-2 {
    --layout-flex-row-gap: var(--layout-spacing-2)
}

.layout-flex-row--gap-3 {
    --layout-flex-row-gap: var(--layout-spacing-3)
}

.layout-flex-row--gap-4 {
    --layout-flex-row-gap: var(--layout-spacing-4)
}

.layout-flex-row--gap-5 {
    --layout-flex-row-gap: var(--layout-spacing-5)
}

.layout-flex-row--gap-6 {
    --layout-flex-row-gap: var(--layout-spacing-6)
}

.layout-flex-row--gap-7 {
    --layout-flex-row-gap: var(--layout-spacing-7)
}

.layout-flex-row--gap-8 {
    --layout-flex-row-gap: var(--layout-spacing-8)
}

.layout-flex-row--gap-9 {
    --layout-flex-row-gap: var(--layout-spacing-9)
}

.layout-flex-row--gap-10 {
    --layout-flex-row-gap: var(--layout-spacing-10)
}

.layout-u-debug .layout-flex-row {
    background-color: rgba(34,139,34,.0784313725);
    cursor: default
}

.layout-u-debug .layout-flex-row.layout--debug {
    background: repeating-linear-gradient(45deg,rgba(34,139,34,.2),rgba(34,139,34,.2) 1px,transparent 0,transparent 10px),hsla(0,0%,100%,.5019607843);
    outline: 2px solid rgba(34,139,34,.6);
    outline-offset: -2px
}

.layout-u-debug .layout-flex-row.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: "LayoutFlexRow";
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #228b22;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(34,139,34,.2) inset;
    box-shadow: inset 0 0 100px rgba(34,139,34,.2);
    padding: 12px;
    z-index: 9999
}

.layout-flex-row.layout--debug.layout-flex-row>:not(:empty) {
    background-color: #d3e8d3;
    outline: 2px dashed rgba(34,139,34,.6);
    outline-offset: -2px
}

.layout-grid {
    --column-count: 12;
    --layout-grid-gap: 0px;
    --layout-grid-gap-x: var(--layout-grid-gap);
    --layout-grid-gap-y: var(--layout-grid-gap);
    display: grid;
    grid-template-columns: repeat(var(--column-count),1fr);
    gap: var(--layout-grid-gap-y) var(--layout-grid-gap-x);
    -webkit-box-align: stretch;
    -ms-flex-align: stretch;
    align-items: stretch
}

.layout-grid--gap-0 {
    --layout-grid-gap: var(--layout-spacing-0)
}

.layout-grid--gap-1 {
    --layout-grid-gap: var(--layout-spacing-1)
}

.layout-grid--gap-2 {
    --layout-grid-gap: var(--layout-spacing-2)
}

.layout-grid--gap-3 {
    --layout-grid-gap: var(--layout-spacing-3)
}

.layout-grid--gap-4 {
    --layout-grid-gap: var(--layout-spacing-4)
}

.layout-grid--gap-5 {
    --layout-grid-gap: var(--layout-spacing-5)
}

.layout-grid--gap-6 {
    --layout-grid-gap: var(--layout-spacing-6)
}

.layout-grid--gap-7 {
    --layout-grid-gap: var(--layout-spacing-7)
}

.layout-grid--gap-8 {
    --layout-grid-gap: var(--layout-spacing-8)
}

.layout-grid--gap-9 {
    --layout-grid-gap: var(--layout-spacing-9)
}

.layout-grid--gap-10 {
    --layout-grid-gap: var(--layout-spacing-10)
}

.layout-grid--gap-x-0 {
    --layout-grid-gap-x: var(--layout-spacing-0)
}

.layout-grid--gap-y-0 {
    --layout-grid-gap-y: var(--layout-spacing-0)
}

.layout-grid--gap-x-1 {
    --layout-grid-gap-x: var(--layout-spacing-1)
}

.layout-grid--gap-y-1 {
    --layout-grid-gap-y: var(--layout-spacing-1)
}

.layout-grid--gap-x-2 {
    --layout-grid-gap-x: var(--layout-spacing-2)
}

.layout-grid--gap-y-2 {
    --layout-grid-gap-y: var(--layout-spacing-2)
}

.layout-grid--gap-x-3 {
    --layout-grid-gap-x: var(--layout-spacing-3)
}

.layout-grid--gap-y-3 {
    --layout-grid-gap-y: var(--layout-spacing-3)
}

.layout-grid--gap-x-4 {
    --layout-grid-gap-x: var(--layout-spacing-4)
}

.layout-grid--gap-y-4 {
    --layout-grid-gap-y: var(--layout-spacing-4)
}

.layout-grid--gap-x-5 {
    --layout-grid-gap-x: var(--layout-spacing-5)
}

.layout-grid--gap-y-5 {
    --layout-grid-gap-y: var(--layout-spacing-5)
}

.layout-grid--gap-x-6 {
    --layout-grid-gap-x: var(--layout-spacing-6)
}

.layout-grid--gap-y-6 {
    --layout-grid-gap-y: var(--layout-spacing-6)
}

.layout-grid--gap-x-7 {
    --layout-grid-gap-x: var(--layout-spacing-7)
}

.layout-grid--gap-y-7 {
    --layout-grid-gap-y: var(--layout-spacing-7)
}

.layout-grid--gap-x-8 {
    --layout-grid-gap-x: var(--layout-spacing-8)
}

.layout-grid--gap-y-8 {
    --layout-grid-gap-y: var(--layout-spacing-8)
}

.layout-grid--gap-x-9 {
    --layout-grid-gap-x: var(--layout-spacing-9)
}

.layout-grid--gap-y-9 {
    --layout-grid-gap-y: var(--layout-spacing-9)
}

.layout-grid--gap-x-10 {
    --layout-grid-gap-x: var(--layout-spacing-10)
}

.layout-grid--gap-y-10 {
    --layout-grid-gap-y: var(--layout-spacing-10)
}

.layout-grid--vertical-align-top {
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: start
}

.layout-grid--vertical-align-center {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center
}

.layout-grid--vertical-align-bottom {
    -webkit-box-align: end;
    -ms-flex-align: end;
    align-items: end
}

.layout-grid--vertical-align-default>.layout-grid__cell,.layout-grid--vertical-align-stretch>.layout-grid__cell {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column
}

.layout-grid--vertical-align-default>.layout-grid__cell>*,.layout-grid--vertical-align-stretch>.layout-grid__cell>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto
}

.layout-grid__cell {
    --span: 1;
    grid-column: auto/span var(--span)
}

.layout-grid__row-break {
    grid-column-end: -1
}

.layout-u-debug .layout-grid {
    background-color: rgba(112,128,144,.0784313725);
    cursor: default
}

.layout-u-debug .layout-grid.layout--debug {
    background: repeating-linear-gradient(45deg,rgba(112,128,144,.2),rgba(112,128,144,.2) 1px,transparent 0,transparent 10px),hsla(0,0%,100%,.5019607843);
    outline: 2px solid rgba(112,128,144,.6);
    outline-offset: -2px
}

.layout-u-debug .layout-grid.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: "LayoutGrid";
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #708090;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(112,128,144,.2) inset;
    box-shadow: inset 0 0 100px rgba(112,128,144,.2);
    padding: 12px;
    z-index: 9999
}

.layout-grid.layout--debug.layout-grid>.layout-grid__cell:not(:empty) {
    background-color: #e2e6e9;
    outline: 2px dashed rgba(112,128,144,.6);
    outline-offset: -2px
}

.layout-list {
    --layout-list-gap: 0px;
    display: grid;
    grid-template-columns: minmax(0,auto);
    gap: var(--layout-list-gap)
}

.layout-list--horizontal-align-left {
    justify-items: start
}

.layout-list--horizontal-align-center {
    justify-items: center
}

.layout-list--horizontal-align-right {
    justify-items: end
}

.layout-list--horizontal-align-default,.layout-list--horizontal-align-stretch {
    justify-items: stretch
}

.layout-list--gap-0 {
    --layout-list-gap: var(--layout-spacing-0)
}

.layout-list--gap-1 {
    --layout-list-gap: var(--layout-spacing-1)
}

.layout-list--gap-2 {
    --layout-list-gap: var(--layout-spacing-2)
}

.layout-list--gap-3 {
    --layout-list-gap: var(--layout-spacing-3)
}

.layout-list--gap-4 {
    --layout-list-gap: var(--layout-spacing-4)
}

.layout-list--gap-5 {
    --layout-list-gap: var(--layout-spacing-5)
}

.layout-list--gap-6 {
    --layout-list-gap: var(--layout-spacing-6)
}

.layout-list--gap-7 {
    --layout-list-gap: var(--layout-spacing-7)
}

.layout-list--gap-8 {
    --layout-list-gap: var(--layout-spacing-8)
}

.layout-list--gap-9 {
    --layout-list-gap: var(--layout-spacing-9)
}

.layout-list--gap-10 {
    --layout-list-gap: var(--layout-spacing-10)
}

.layout-u-debug .layout-list {
    background-color: rgba(0,0,128,.0784313725);
    cursor: default
}

.layout-u-debug .layout-list.layout--debug {
    background: repeating-linear-gradient(45deg,rgba(0,0,128,.2),rgba(0,0,128,.2) 1px,transparent 0,transparent 10px),hsla(0,0%,100%,.5019607843);
    outline: 2px solid rgba(0,0,128,.6);
    outline-offset: -2px
}

.layout-u-debug .layout-list.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: "LayoutList";
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid navy;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(0,0,128,.2) inset;
    box-shadow: inset 0 0 100px rgba(0,0,128,.2);
    padding: 12px;
    z-index: 9999
}

.layout-list.layout--debug.layout-list>:not(:empty) {
    background-color: #cccce6;
    outline: 2px dashed rgba(0,0,128,.6);
    outline-offset: -2px
}

.layout-list-inline {
    display: inline-block
}

.layout-list-inline__wrapper {
    --layout-list-inline-gap: 0px;
    --layout-list-inline-gap-x: var(--layout-list-inline-gap);
    --layout-list-inline-gap-y: var(--layout-list-inline-gap);
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    vertical-align: top;
    -ms-flex-wrap: wrap;
    flex-wrap: wrap;
    margin: calc(var(--layout-list-inline-gap-y)*-0.5) calc(var(--layout-list-inline-gap-x)*-0.5)
}

.layout-list-inline__item {
    margin: calc(var(--layout-list-inline-gap-y)*0.5) calc(var(--layout-list-inline-gap-x)*0.5)
}

.layout-list-inline--nowrap>.layout-list-inline__wrapper {
    -ms-flex-wrap: nowrap;
    flex-wrap: nowrap
}

.layout-list-inline--vertical-align-top>.layout-list-inline__wrapper {
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: flex-start
}

.layout-list-inline--vertical-align-center>.layout-list-inline__wrapper {
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center
}

.layout-list-inline--vertical-align-bottom>.layout-list-inline__wrapper {
    -webkit-box-align: end;
    -ms-flex-align: end;
    align-items: flex-end
}

.layout-list-inline--vertical-align-default>.layout-list-inline__wrapper,.layout-list-inline--vertical-align-stretch>.layout-list-inline__wrapper {
    -webkit-box-align: stretch;
    -ms-flex-align: stretch;
    align-items: stretch
}

.layout-list-inline--vertical-align-default>.layout-list-inline__wrapper>.layout-list-inline__item,.layout-list-inline--vertical-align-stretch>.layout-list-inline__wrapper>.layout-list-inline__item {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column
}

.layout-list-inline--vertical-align-default>.layout-list-inline__wrapper>.layout-list-inline__item>*,.layout-list-inline--vertical-align-stretch>.layout-list-inline__wrapper>.layout-list-inline__item>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    height: auto
}

.layout-list-inline--horizontal-align-default>.layout-list-inline__wrapper,.layout-list-inline--horizontal-align-left>.layout-list-inline__wrapper {
    -webkit-box-pack: start;
    -ms-flex-pack: start;
    justify-content: flex-start
}

.layout-list-inline--horizontal-align-center>.layout-list-inline__wrapper {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center
}

.layout-list-inline--horizontal-align-right>.layout-list-inline__wrapper {
    -webkit-box-pack: end;
    -ms-flex-pack: end;
    justify-content: flex-end
}

.layout-list-inline--gap-0>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-0)
}

.layout-list-inline--gap-1>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-1)
}

.layout-list-inline--gap-2>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-2)
}

.layout-list-inline--gap-3>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-3)
}

.layout-list-inline--gap-4>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-4)
}

.layout-list-inline--gap-5>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-5)
}

.layout-list-inline--gap-6>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-6)
}

.layout-list-inline--gap-7>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-7)
}

.layout-list-inline--gap-8>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-8)
}

.layout-list-inline--gap-9>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-9)
}

.layout-list-inline--gap-10>.layout-list-inline__wrapper {
    --layout-list-inline-gap: var(--layout-spacing-10)
}

.layout-list-inline--gap-x-0>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-0)
}

.layout-list-inline--gap-y-0>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-0)
}

.layout-list-inline--gap-x-1>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-1)
}

.layout-list-inline--gap-y-1>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-1)
}

.layout-list-inline--gap-x-2>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-2)
}

.layout-list-inline--gap-y-2>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-2)
}

.layout-list-inline--gap-x-3>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-3)
}

.layout-list-inline--gap-y-3>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-3)
}

.layout-list-inline--gap-x-4>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-4)
}

.layout-list-inline--gap-y-4>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-4)
}

.layout-list-inline--gap-x-5>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-5)
}

.layout-list-inline--gap-y-5>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-5)
}

.layout-list-inline--gap-x-6>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-6)
}

.layout-list-inline--gap-y-6>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-6)
}

.layout-list-inline--gap-x-7>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-7)
}

.layout-list-inline--gap-y-7>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-7)
}

.layout-list-inline--gap-x-8>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-8)
}

.layout-list-inline--gap-y-8>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-8)
}

.layout-list-inline--gap-x-9>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-9)
}

.layout-list-inline--gap-y-9>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-9)
}

.layout-list-inline--gap-x-10>.layout-list-inline__wrapper {
    --layout-list-inline-gap-x: var(--layout-spacing-10)
}

.layout-list-inline--gap-y-10>.layout-list-inline__wrapper {
    --layout-list-inline-gap-y: var(--layout-spacing-10)
}

.layout-u-debug .layout-list-inline {
    background-color: rgba(138,43,226,.0784313725);
    cursor: default
}

.layout-u-debug .layout-list-inline.layout--debug {
    background: repeating-linear-gradient(45deg,rgba(138,43,226,.2),rgba(138,43,226,.2) 1px,transparent 0,transparent 10px),hsla(0,0%,100%,.5019607843);
    outline: 2px solid rgba(138,43,226,.6);
    outline-offset: -2px
}

.layout-u-debug .layout-list-inline.layout--debug:before {
    display: block;
    position: fixed;
    bottom: 0;
    left: 0;
    right: 0;
    font-weight: 700;
    content: "LayoutListInline";
    font-size: 14px;
    line-height: 1;
    text-align: center;
    color: #333;
    border: 2px solid #8a2be2;
    background-color: #fff;
    -webkit-box-shadow: 0 0 100px rgba(138,43,226,.2) inset;
    box-shadow: inset 0 0 100px rgba(138,43,226,.2);
    padding: 12px;
    z-index: 9999
}

.layout-list-inline.layout--debug.layout-list-inline>.layout-list-inline__wrapper>.layout-list-inline__item:not(:empty) {
    background-color: #e8d5f9;
    outline: 2px dashed rgba(138,43,226,.6);
    outline-offset: -2px
}

.layout-u-m-0 {
    margin: var(--layout-spacing-0)
}

.layout-u-p-0 {
    padding: var(--layout-spacing-0)
}

.layout-u-m-1 {
    margin: var(--layout-spacing-1)
}

.layout-u-p-1 {
    padding: var(--layout-spacing-1)
}

.layout-u-m-2 {
    margin: var(--layout-spacing-2)
}

.layout-u-p-2 {
    padding: var(--layout-spacing-2)
}

.layout-u-m-3 {
    margin: var(--layout-spacing-3)
}

.layout-u-p-3 {
    padding: var(--layout-spacing-3)
}

.layout-u-m-4 {
    margin: var(--layout-spacing-4)
}

.layout-u-p-4 {
    padding: var(--layout-spacing-4)
}

.layout-u-m-5 {
    margin: var(--layout-spacing-5)
}

.layout-u-p-5 {
    padding: var(--layout-spacing-5)
}

.layout-u-m-6 {
    margin: var(--layout-spacing-6)
}

.layout-u-p-6 {
    padding: var(--layout-spacing-6)
}

.layout-u-m-7 {
    margin: var(--layout-spacing-7)
}

.layout-u-p-7 {
    padding: var(--layout-spacing-7)
}

.layout-u-m-8 {
    margin: var(--layout-spacing-8)
}

.layout-u-p-8 {
    padding: var(--layout-spacing-8)
}

.layout-u-m-9 {
    margin: var(--layout-spacing-9)
}

.layout-u-p-9 {
    padding: var(--layout-spacing-9)
}

.layout-u-m-10 {
    margin: var(--layout-spacing-10)
}

.layout-u-p-10 {
    padding: var(--layout-spacing-10)
}

.layout-u-mx-0 {
    margin-left: var(--layout-spacing-0);
    margin-right: var(--layout-spacing-0)
}

.layout-u-my-0 {
    margin-top: var(--layout-spacing-0);
    margin-bottom: var(--layout-spacing-0)
}

.layout-u-px-0 {
    padding-left: var(--layout-spacing-0);
    padding-right: var(--layout-spacing-0)
}

.layout-u-py-0 {
    padding-top: var(--layout-spacing-0);
    padding-bottom: var(--layout-spacing-0)
}

.layout-u-mx-1 {
    margin-left: var(--layout-spacing-1);
    margin-right: var(--layout-spacing-1)
}

.layout-u-my-1 {
    margin-top: var(--layout-spacing-1);
    margin-bottom: var(--layout-spacing-1)
}

.layout-u-px-1 {
    padding-left: var(--layout-spacing-1);
    padding-right: var(--layout-spacing-1)
}

.layout-u-py-1 {
    padding-top: var(--layout-spacing-1);
    padding-bottom: var(--layout-spacing-1)
}

.layout-u-mx-2 {
    margin-left: var(--layout-spacing-2);
    margin-right: var(--layout-spacing-2)
}

.layout-u-my-2 {
    margin-top: var(--layout-spacing-2);
    margin-bottom: var(--layout-spacing-2)
}

.layout-u-px-2 {
    padding-left: var(--layout-spacing-2);
    padding-right: var(--layout-spacing-2)
}

.layout-u-py-2 {
    padding-top: var(--layout-spacing-2);
    padding-bottom: var(--layout-spacing-2)
}

.layout-u-mx-3 {
    margin-left: var(--layout-spacing-3);
    margin-right: var(--layout-spacing-3)
}

.layout-u-my-3 {
    margin-top: var(--layout-spacing-3);
    margin-bottom: var(--layout-spacing-3)
}

.layout-u-px-3 {
    padding-left: var(--layout-spacing-3);
    padding-right: var(--layout-spacing-3)
}

.layout-u-py-3 {
    padding-top: var(--layout-spacing-3);
    padding-bottom: var(--layout-spacing-3)
}

.layout-u-mx-4 {
    margin-left: var(--layout-spacing-4);
    margin-right: var(--layout-spacing-4)
}

.layout-u-my-4 {
    margin-top: var(--layout-spacing-4);
    margin-bottom: var(--layout-spacing-4)
}

.layout-u-px-4 {
    padding-left: var(--layout-spacing-4);
    padding-right: var(--layout-spacing-4)
}

.layout-u-py-4 {
    padding-top: var(--layout-spacing-4);
    padding-bottom: var(--layout-spacing-4)
}

.layout-u-mx-5 {
    margin-left: var(--layout-spacing-5);
    margin-right: var(--layout-spacing-5)
}

.layout-u-my-5 {
    margin-top: var(--layout-spacing-5);
    margin-bottom: var(--layout-spacing-5)
}

.layout-u-px-5 {
    padding-left: var(--layout-spacing-5);
    padding-right: var(--layout-spacing-5)
}

.layout-u-py-5 {
    padding-top: var(--layout-spacing-5);
    padding-bottom: var(--layout-spacing-5)
}

.layout-u-mx-6 {
    margin-left: var(--layout-spacing-6);
    margin-right: var(--layout-spacing-6)
}

.layout-u-my-6 {
    margin-top: var(--layout-spacing-6);
    margin-bottom: var(--layout-spacing-6)
}

.layout-u-px-6 {
    padding-left: var(--layout-spacing-6);
    padding-right: var(--layout-spacing-6)
}

.layout-u-py-6 {
    padding-top: var(--layout-spacing-6);
    padding-bottom: var(--layout-spacing-6)
}

.layout-u-mx-7 {
    margin-left: var(--layout-spacing-7);
    margin-right: var(--layout-spacing-7)
}

.layout-u-my-7 {
    margin-top: var(--layout-spacing-7);
    margin-bottom: var(--layout-spacing-7)
}

.layout-u-px-7 {
    padding-left: var(--layout-spacing-7);
    padding-right: var(--layout-spacing-7)
}

.layout-u-py-7 {
    padding-top: var(--layout-spacing-7);
    padding-bottom: var(--layout-spacing-7)
}

.layout-u-mx-8 {
    margin-left: var(--layout-spacing-8);
    margin-right: var(--layout-spacing-8)
}

.layout-u-my-8 {
    margin-top: var(--layout-spacing-8);
    margin-bottom: var(--layout-spacing-8)
}

.layout-u-px-8 {
    padding-left: var(--layout-spacing-8);
    padding-right: var(--layout-spacing-8)
}

.layout-u-py-8 {
    padding-top: var(--layout-spacing-8);
    padding-bottom: var(--layout-spacing-8)
}

.layout-u-mx-9 {
    margin-left: var(--layout-spacing-9);
    margin-right: var(--layout-spacing-9)
}

.layout-u-my-9 {
    margin-top: var(--layout-spacing-9);
    margin-bottom: var(--layout-spacing-9)
}

.layout-u-px-9 {
    padding-left: var(--layout-spacing-9);
    padding-right: var(--layout-spacing-9)
}

.layout-u-py-9 {
    padding-top: var(--layout-spacing-9);
    padding-bottom: var(--layout-spacing-9)
}

.layout-u-mx-10 {
    margin-left: var(--layout-spacing-10);
    margin-right: var(--layout-spacing-10)
}

.layout-u-my-10 {
    margin-top: var(--layout-spacing-10);
    margin-bottom: var(--layout-spacing-10)
}

.layout-u-px-10 {
    padding-left: var(--layout-spacing-10);
    padding-right: var(--layout-spacing-10)
}

.layout-u-py-10 {
    padding-top: var(--layout-spacing-10);
    padding-bottom: var(--layout-spacing-10)
}

.layout-u-mt-0 {
    margin-top: var(--layout-spacing-0)
}

.layout-u-pt-0 {
    padding-top: var(--layout-spacing-0)
}

.layout-u-mb-0 {
    margin-bottom: var(--layout-spacing-0)
}

.layout-u-pb-0 {
    padding-bottom: var(--layout-spacing-0)
}

.layout-u-ml-0 {
    margin-left: var(--layout-spacing-0)
}

.layout-u-pl-0 {
    padding-left: var(--layout-spacing-0)
}

.layout-u-mr-0 {
    margin-right: var(--layout-spacing-0)
}

.layout-u-pr-0 {
    padding-right: var(--layout-spacing-0)
}

.layout-u-mt-1 {
    margin-top: var(--layout-spacing-1)
}

.layout-u-pt-1 {
    padding-top: var(--layout-spacing-1)
}

.layout-u-mb-1 {
    margin-bottom: var(--layout-spacing-1)
}

.layout-u-pb-1 {
    padding-bottom: var(--layout-spacing-1)
}

.layout-u-ml-1 {
    margin-left: var(--layout-spacing-1)
}

.layout-u-pl-1 {
    padding-left: var(--layout-spacing-1)
}

.layout-u-mr-1 {
    margin-right: var(--layout-spacing-1)
}

.layout-u-pr-1 {
    padding-right: var(--layout-spacing-1)
}

.layout-u-mt-2 {
    margin-top: var(--layout-spacing-2)
}

.layout-u-pt-2 {
    padding-top: var(--layout-spacing-2)
}

.layout-u-mb-2 {
    margin-bottom: var(--layout-spacing-2)
}

.layout-u-pb-2 {
    padding-bottom: var(--layout-spacing-2)
}

.layout-u-ml-2 {
    margin-left: var(--layout-spacing-2)
}

.layout-u-pl-2 {
    padding-left: var(--layout-spacing-2)
}

.layout-u-mr-2 {
    margin-right: var(--layout-spacing-2)
}

.layout-u-pr-2 {
    padding-right: var(--layout-spacing-2)
}

.layout-u-mt-3 {
    margin-top: var(--layout-spacing-3)
}

.layout-u-pt-3 {
    padding-top: var(--layout-spacing-3)
}

.layout-u-mb-3 {
    margin-bottom: var(--layout-spacing-3)
}

.layout-u-pb-3 {
    padding-bottom: var(--layout-spacing-3)
}

.layout-u-ml-3 {
    margin-left: var(--layout-spacing-3)
}

.layout-u-pl-3 {
    padding-left: var(--layout-spacing-3)
}

.layout-u-mr-3 {
    margin-right: var(--layout-spacing-3)
}

.layout-u-pr-3 {
    padding-right: var(--layout-spacing-3)
}

.layout-u-mt-4 {
    margin-top: var(--layout-spacing-4)
}

.layout-u-pt-4 {
    padding-top: var(--layout-spacing-4)
}

.layout-u-mb-4 {
    margin-bottom: var(--layout-spacing-4)
}

.layout-u-pb-4 {
    padding-bottom: var(--layout-spacing-4)
}

.layout-u-ml-4 {
    margin-left: var(--layout-spacing-4)
}

.layout-u-pl-4 {
    padding-left: var(--layout-spacing-4)
}

.layout-u-mr-4 {
    margin-right: var(--layout-spacing-4)
}

.layout-u-pr-4 {
    padding-right: var(--layout-spacing-4)
}

.layout-u-mt-5 {
    margin-top: var(--layout-spacing-5)
}

.layout-u-pt-5 {
    padding-top: var(--layout-spacing-5)
}

.layout-u-mb-5 {
    margin-bottom: var(--layout-spacing-5)
}

.layout-u-pb-5 {
    padding-bottom: var(--layout-spacing-5)
}

.layout-u-ml-5 {
    margin-left: var(--layout-spacing-5)
}

.layout-u-pl-5 {
    padding-left: var(--layout-spacing-5)
}

.layout-u-mr-5 {
    margin-right: var(--layout-spacing-5)
}

.layout-u-pr-5 {
    padding-right: var(--layout-spacing-5)
}

.layout-u-mt-6 {
    margin-top: var(--layout-spacing-6)
}

.layout-u-pt-6 {
    padding-top: var(--layout-spacing-6)
}

.layout-u-mb-6 {
    margin-bottom: var(--layout-spacing-6)
}

.layout-u-pb-6 {
    padding-bottom: var(--layout-spacing-6)
}

.layout-u-ml-6 {
    margin-left: var(--layout-spacing-6)
}

.layout-u-pl-6 {
    padding-left: var(--layout-spacing-6)
}

.layout-u-mr-6 {
    margin-right: var(--layout-spacing-6)
}

.layout-u-pr-6 {
    padding-right: var(--layout-spacing-6)
}

.layout-u-mt-7 {
    margin-top: var(--layout-spacing-7)
}

.layout-u-pt-7 {
    padding-top: var(--layout-spacing-7)
}

.layout-u-mb-7 {
    margin-bottom: var(--layout-spacing-7)
}

.layout-u-pb-7 {
    padding-bottom: var(--layout-spacing-7)
}

.layout-u-ml-7 {
    margin-left: var(--layout-spacing-7)
}

.layout-u-pl-7 {
    padding-left: var(--layout-spacing-7)
}

.layout-u-mr-7 {
    margin-right: var(--layout-spacing-7)
}

.layout-u-pr-7 {
    padding-right: var(--layout-spacing-7)
}

.layout-u-mt-8 {
    margin-top: var(--layout-spacing-8)
}

.layout-u-pt-8 {
    padding-top: var(--layout-spacing-8)
}

.layout-u-mb-8 {
    margin-bottom: var(--layout-spacing-8)
}

.layout-u-pb-8 {
    padding-bottom: var(--layout-spacing-8)
}

.layout-u-ml-8 {
    margin-left: var(--layout-spacing-8)
}

.layout-u-pl-8 {
    padding-left: var(--layout-spacing-8)
}

.layout-u-mr-8 {
    margin-right: var(--layout-spacing-8)
}

.layout-u-pr-8 {
    padding-right: var(--layout-spacing-8)
}

.layout-u-mt-9 {
    margin-top: var(--layout-spacing-9)
}

.layout-u-pt-9 {
    padding-top: var(--layout-spacing-9)
}

.layout-u-mb-9 {
    margin-bottom: var(--layout-spacing-9)
}

.layout-u-pb-9 {
    padding-bottom: var(--layout-spacing-9)
}

.layout-u-ml-9 {
    margin-left: var(--layout-spacing-9)
}

.layout-u-pl-9 {
    padding-left: var(--layout-spacing-9)
}

.layout-u-mr-9 {
    margin-right: var(--layout-spacing-9)
}

.layout-u-pr-9 {
    padding-right: var(--layout-spacing-9)
}

.layout-u-mt-10 {
    margin-top: var(--layout-spacing-10)
}

.layout-u-pt-10 {
    padding-top: var(--layout-spacing-10)
}

.layout-u-mb-10 {
    margin-bottom: var(--layout-spacing-10)
}

.layout-u-pb-10 {
    padding-bottom: var(--layout-spacing-10)
}

.layout-u-ml-10 {
    margin-left: var(--layout-spacing-10)
}

.layout-u-pl-10 {
    padding-left: var(--layout-spacing-10)
}

.layout-u-mr-10 {
    margin-right: var(--layout-spacing-10)
}

.layout-u-pr-10 {
    padding-right: var(--layout-spacing-10)
}

.layout-u-content-fill-height {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column
}

.layout-u-content-fill-height>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 0px;
    flex: 1 1 0;
    height: auto
}

.layout-u-position-relative {
    position: relative
}

.kk-u-position-relative {
    position: relative!important
}

.kk-u-content-fill-height {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column
}

.kk-u-content-fill-height>* {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 0px;
    flex: 1 1 0;
    height: auto
}

.kk-u-m-0 {
    margin: 0!important
}

.kk-u-p-0 {
    padding: 0!important
}

.kk-u-m-1 {
    margin: 2px!important
}

.kk-u-p-1 {
    padding: 2px!important
}

.kk-u-m-2 {
    margin: 4px!important
}

.kk-u-p-2 {
    padding: 4px!important
}

.kk-u-m-3 {
    margin: 8px!important
}

.kk-u-p-3 {
    padding: 8px!important
}

.kk-u-m-4 {
    margin: 12px!important
}

.kk-u-p-4 {
    padding: 12px!important
}

.kk-u-m-5 {
    margin: 16px!important
}

.kk-u-p-5 {
    padding: 16px!important
}

.kk-u-m-6 {
    margin: 20px!important
}

.kk-u-p-6 {
    padding: 20px!important
}

.kk-u-m-7 {
    margin: 24px!important
}

.kk-u-p-7 {
    padding: 24px!important
}

.kk-u-m-8 {
    margin: 32px!important
}

.kk-u-p-8 {
    padding: 32px!important
}

.kk-u-m-9 {
    margin: 40px!important
}

.kk-u-p-9 {
    padding: 40px!important
}

.kk-u-m-10 {
    margin: 48px!important
}

.kk-u-p-10 {
    padding: 48px!important
}

.kk-u-mx-0 {
    margin-left: 0!important;
    margin-right: 0!important
}

.kk-u-my-0 {
    margin-top: 0!important;
    margin-bottom: 0!important
}

.kk-u-px-0 {
    padding-left: 0!important;
    padding-right: 0!important
}

.kk-u-py-0 {
    padding-top: 0!important;
    padding-bottom: 0!important
}

.kk-u-mx-1 {
    margin-left: 2px!important;
    margin-right: 2px!important
}

.kk-u-my-1 {
    margin-top: 2px!important;
    margin-bottom: 2px!important
}

.kk-u-px-1 {
    padding-left: 2px!important;
    padding-right: 2px!important
}

.kk-u-py-1 {
    padding-top: 2px!important;
    padding-bottom: 2px!important
}

.kk-u-mx-2 {
    margin-left: 4px!important;
    margin-right: 4px!important
}

.kk-u-my-2 {
    margin-top: 4px!important;
    margin-bottom: 4px!important
}

.kk-u-px-2 {
    padding-left: 4px!important;
    padding-right: 4px!important
}

.kk-u-py-2 {
    padding-top: 4px!important;
    padding-bottom: 4px!important
}

.kk-u-mx-3 {
    margin-left: 8px!important;
    margin-right: 8px!important
}

.kk-u-my-3 {
    margin-top: 8px!important;
    margin-bottom: 8px!important
}

.kk-u-px-3 {
    padding-left: 8px!important;
    padding-right: 8px!important
}

.kk-u-py-3 {
    padding-top: 8px!important;
    padding-bottom: 8px!important
}

.kk-u-mx-4 {
    margin-left: 12px!important;
    margin-right: 12px!important
}

.kk-u-my-4 {
    margin-top: 12px!important;
    margin-bottom: 12px!important
}

.kk-u-px-4 {
    padding-left: 12px!important;
    padding-right: 12px!important
}

.kk-u-py-4 {
    padding-top: 12px!important;
    padding-bottom: 12px!important
}

.kk-u-mx-5 {
    margin-left: 16px!important;
    margin-right: 16px!important
}

.kk-u-my-5 {
    margin-top: 16px!important;
    margin-bottom: 16px!important
}

.kk-u-px-5 {
    padding-left: 16px!important;
    padding-right: 16px!important
}

.kk-u-py-5 {
    padding-top: 16px!important;
    padding-bottom: 16px!important
}

.kk-u-mx-6 {
    margin-left: 20px!important;
    margin-right: 20px!important
}

.kk-u-my-6 {
    margin-top: 20px!important;
    margin-bottom: 20px!important
}

.kk-u-px-6 {
    padding-left: 20px!important;
    padding-right: 20px!important
}

.kk-u-py-6 {
    padding-top: 20px!important;
    padding-bottom: 20px!important
}

.kk-u-mx-7 {
    margin-left: 24px!important;
    margin-right: 24px!important
}

.kk-u-my-7 {
    margin-top: 24px!important;
    margin-bottom: 24px!important
}

.kk-u-px-7 {
    padding-left: 24px!important;
    padding-right: 24px!important
}

.kk-u-py-7 {
    padding-top: 24px!important;
    padding-bottom: 24px!important
}

.kk-u-mx-8 {
    margin-left: 32px!important;
    margin-right: 32px!important
}

.kk-u-my-8 {
    margin-top: 32px!important;
    margin-bottom: 32px!important
}

.kk-u-px-8 {
    padding-left: 32px!important;
    padding-right: 32px!important
}

.kk-u-py-8 {
    padding-top: 32px!important;
    padding-bottom: 32px!important
}

.kk-u-mx-9 {
    margin-left: 40px!important;
    margin-right: 40px!important
}

.kk-u-my-9 {
    margin-top: 40px!important;
    margin-bottom: 40px!important
}

.kk-u-px-9 {
    padding-left: 40px!important;
    padding-right: 40px!important
}

.kk-u-py-9 {
    padding-top: 40px!important;
    padding-bottom: 40px!important
}

.kk-u-mx-10 {
    margin-left: 48px!important;
    margin-right: 48px!important
}

.kk-u-my-10 {
    margin-top: 48px!important;
    margin-bottom: 48px!important
}

.kk-u-px-10 {
    padding-left: 48px!important;
    padding-right: 48px!important
}

.kk-u-py-10 {
    padding-top: 48px!important;
    padding-bottom: 48px!important
}

.kk-u-mt-0 {
    margin-top: 0!important
}

.kk-u-pt-0 {
    padding-top: 0!important
}

.kk-u-mb-0 {
    margin-bottom: 0!important
}

.kk-u-pb-0 {
    padding-bottom: 0!important
}

.kk-u-ml-0 {
    margin-left: 0!important
}

.kk-u-pl-0 {
    padding-left: 0!important
}

.kk-u-mr-0 {
    margin-right: 0!important
}

.kk-u-pr-0 {
    padding-right: 0!important
}

.kk-u-mt-1 {
    margin-top: 2px!important
}

.kk-u-pt-1 {
    padding-top: 2px!important
}

.kk-u-mb-1 {
    margin-bottom: 2px!important
}

.kk-u-pb-1 {
    padding-bottom: 2px!important
}

.kk-u-ml-1 {
    margin-left: 2px!important
}

.kk-u-pl-1 {
    padding-left: 2px!important
}

.kk-u-mr-1 {
    margin-right: 2px!important
}

.kk-u-pr-1 {
    padding-right: 2px!important
}

.kk-u-mt-2 {
    margin-top: 4px!important
}

.kk-u-pt-2 {
    padding-top: 4px!important
}

.kk-u-mb-2 {
    margin-bottom: 4px!important
}

.kk-u-pb-2 {
    padding-bottom: 4px!important
}

.kk-u-ml-2 {
    margin-left: 4px!important
}

.kk-u-pl-2 {
    padding-left: 4px!important
}

.kk-u-mr-2 {
    margin-right: 4px!important
}

.kk-u-pr-2 {
    padding-right: 4px!important
}

.kk-u-mt-3 {
    margin-top: 8px!important
}

.kk-u-pt-3 {
    padding-top: 8px!important
}

.kk-u-mb-3 {
    margin-bottom: 8px!important
}

.kk-u-pb-3 {
    padding-bottom: 8px!important
}

.kk-u-ml-3 {
    margin-left: 8px!important
}

.kk-u-pl-3 {
    padding-left: 8px!important
}

.kk-u-mr-3 {
    margin-right: 8px!important
}

.kk-u-pr-3 {
    padding-right: 8px!important
}

.kk-u-mt-4 {
    margin-top: 12px!important
}

.kk-u-pt-4 {
    padding-top: 12px!important
}

.kk-u-mb-4 {
    margin-bottom: 12px!important
}

.kk-u-pb-4 {
    padding-bottom: 12px!important
}

.kk-u-ml-4 {
    margin-left: 12px!important
}

.kk-u-pl-4 {
    padding-left: 12px!important
}

.kk-u-mr-4 {
    margin-right: 12px!important
}

.kk-u-pr-4 {
    padding-right: 12px!important
}

.kk-u-mt-5 {
    margin-top: 16px!important
}

.kk-u-pt-5 {
    padding-top: 16px!important
}

.kk-u-mb-5 {
    margin-bottom: 16px!important
}

.kk-u-pb-5 {
    padding-bottom: 16px!important
}

.kk-u-ml-5 {
    margin-left: 16px!important
}

.kk-u-pl-5 {
    padding-left: 16px!important
}

.kk-u-mr-5 {
    margin-right: 16px!important
}

.kk-u-pr-5 {
    padding-right: 16px!important
}

.kk-u-mt-6 {
    margin-top: 20px!important
}

.kk-u-pt-6 {
    padding-top: 20px!important
}

.kk-u-mb-6 {
    margin-bottom: 20px!important
}

.kk-u-pb-6 {
    padding-bottom: 20px!important
}

.kk-u-ml-6 {
    margin-left: 20px!important
}

.kk-u-pl-6 {
    padding-left: 20px!important
}

.kk-u-mr-6 {
    margin-right: 20px!important
}

.kk-u-pr-6 {
    padding-right: 20px!important
}

.kk-u-mt-7 {
    margin-top: 24px!important
}

.kk-u-pt-7 {
    padding-top: 24px!important
}

.kk-u-mb-7 {
    margin-bottom: 24px!important
}

.kk-u-pb-7 {
    padding-bottom: 24px!important
}

.kk-u-ml-7 {
    margin-left: 24px!important
}

.kk-u-pl-7 {
    padding-left: 24px!important
}

.kk-u-mr-7 {
    margin-right: 24px!important
}

.kk-u-pr-7 {
    padding-right: 24px!important
}

.kk-u-mt-8 {
    margin-top: 32px!important
}

.kk-u-pt-8 {
    padding-top: 32px!important
}

.kk-u-mb-8 {
    margin-bottom: 32px!important
}

.kk-u-pb-8 {
    padding-bottom: 32px!important
}

.kk-u-ml-8 {
    margin-left: 32px!important
}

.kk-u-pl-8 {
    padding-left: 32px!important
}

.kk-u-mr-8 {
    margin-right: 32px!important
}

.kk-u-pr-8 {
    padding-right: 32px!important
}

.kk-u-mt-9 {
    margin-top: 40px!important
}

.kk-u-pt-9 {
    padding-top: 40px!important
}

.kk-u-mb-9 {
    margin-bottom: 40px!important
}

.kk-u-pb-9 {
    padding-bottom: 40px!important
}

.kk-u-ml-9 {
    margin-left: 40px!important
}

.kk-u-pl-9 {
    padding-left: 40px!important
}

.kk-u-mr-9 {
    margin-right: 40px!important
}

.kk-u-pr-9 {
    padding-right: 40px!important
}

.kk-u-mt-10 {
    margin-top: 48px!important
}

.kk-u-pt-10 {
    padding-top: 48px!important
}

.kk-u-mb-10 {
    margin-bottom: 48px!important
}

.kk-u-pb-10 {
    padding-bottom: 48px!important
}

.kk-u-ml-10 {
    margin-left: 48px!important
}

.kk-u-pl-10 {
    padding-left: 48px!important
}

.kk-u-mr-10 {
    margin-right: 48px!important
}

.kk-u-pr-10 {
    padding-right: 48px!important
}

.kk-u-text-h4 {
    font-size: 24px;
    line-height: 30px;
    font-weight: 700
}

.kk-u-text-h5 {
    font-size: 22px;
    line-height: 28px;
    font-weight: 700
}

.kk-u-text-h6 {
    font-size: 18px;
    line-height: 26px;
    font-weight: 700
}

.kk-u-text-subtitle-lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 700
}

.kk-u-text-subtitle-md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 500
}

.kk-u-text-body-lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400
}

.kk-u-text-body-md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-u-text-body-sm,.kk-u-text-category {
    font-size: 12px;
    line-height: 16px;
    font-weight: 400
}

.kk-u-text-lighter {
    color: #d5d6db!important
}

.kk-u-text-light {
    color: #babbbe!important
}

.kk-u-text-medium {
    color: #9c9da0!important
}

.kk-u-text-dark {
    color: #727272!important
}

.kk-u-text-darker {
    color: #212121!important
}

.kk-u-text-primary-lighter {
    color: #cef0f3!important
}

.kk-u-text-primary-light {
    color: #ade6eb!important
}

.kk-u-text-primary-medium {
    color: #26bec9!important
}

.kk-u-text-primary-dark {
    color: #13a3b6!important
}

.kk-u-text-primary-darker {
    color: #068b9f!important
}

.kk-u-text-critical-lighter {
    color: #f5a8a4!important
}

.kk-u-text-critical-light {
    color: #f2918a!important
}

.kk-u-text-critical-medium {
    color: #ef7a70!important
}

.kk-u-text-critical-dark {
    color: #e65f50!important
}

.kk-u-text-critical-darker {
    color: #d14330!important
}

.kk-u-text-info-lighter {
    color: #9dd3fa!important
}

.kk-u-text-info-light {
    color: #81c4f7!important
}

.kk-u-text-info-medium {
    color: #64b3f4!important
}

.kk-u-text-info-dark {
    color: #2d84d6!important
}

.kk-u-text-info-darker {
    color: #1565c0!important
}

.kk-u-text-warning-lighter {
    color: #fee269!important
}

.kk-u-text-warning-light {
    color: #facf58!important
}

.kk-u-text-warning-medium {
    color: #f5b53d!important
}

.kk-u-text-warning-dark {
    color: #e78f37!important
}

.kk-u-text-warning-darker {
    color: #de6928!important
}

.kk-u-text-highlight-lighter {
    color: #ffca28!important
}

.kk-u-text-highlight-light {
    color: #ffc128!important
}

.kk-u-text-highlight-medium {
    color: #ffb400!important
}

.kk-u-text-highlight-dark {
    color: #ffa000!important
}

.kk-u-text-highlight-darker {
    color: #ff8f00!important
}

.kk-u-text-align-left {
    text-align: left!important
}

.kk-u-text-align-center {
    text-align: center!important
}

.kk-u-text-align-right {
    text-align: right!important
}

.kk-u-text-ellipsis {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden
}

.kk-u-text-line-clamp-1 {
    -webkit-line-clamp: 1
}

.kk-u-text-line-clamp-1,.kk-u-text-line-clamp-2 {
    display: -webkit-box;
    -webkit-box-orient: vertical;
    overflow: hidden
}

.kk-u-text-line-clamp-2 {
    -webkit-line-clamp: 2
}

.kk-u-text-line-clamp-3 {
    -webkit-line-clamp: 3
}

.kk-u-text-line-clamp-3,.kk-u-text-line-clamp-4 {
    display: -webkit-box;
    -webkit-box-orient: vertical;
    overflow: hidden
}

.kk-u-text-line-clamp-4 {
    -webkit-line-clamp: 4
}

.kk-u-text-line-clamp-5 {
    display: -webkit-box;
    -webkit-line-clamp: 5;
    -webkit-box-orient: vertical;
    overflow: hidden
}

.kk-u-text-preserve-newline {
    white-space: pre-line
}

.accordion-item {
    padding-bottom: 16px;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.accordion-item__header {
    display: grid;
    grid-auto-flow: column;
    grid-template-columns: minmax(0,1fr) auto;
    gap: 16px;
    padding: 12px 0
}

.accordion-item__title {
    font-size: 16px;
    line-height: 24px;
    font-weight: 700
}

.accordion-item__arrow-up {
    -webkit-transition: -webkit-transform .3s ease-in-out;
    transition: -webkit-transform .3s ease-in-out;
    transition: transform .3s ease-in-out;
    transition: transform .3s ease-in-out,-webkit-transform .3s ease-in-out
}

.accordion-item--active .accordion-item__arrow-up {
    -webkit-transform: rotate(-180deg);
    transform: rotate(-180deg)
}

.kk-badge {
    --kk-badge-height: 16px;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    min-width: var(--kk-badge-height);
    max-width: 48px;
    height: var(--kk-badge-height);
    border-radius: calc(var(--kk-badge-height)/2);
    padding: 0 4px;
    overflow: hidden;
    --kk-badge-text-color: #fff;
    --kk-badge-background-color: #e65f50;
    --kk-badge-border-color: #fff;
    --kk-badge-border-width: 1.5px;
    color: var(--kk-badge-text-color);
    background-color: var(--kk-badge-background-color);
    -webkit-box-shadow: 0 0 0 var(--kk-badge-border-width) var(--kk-badge-border-color);
    box-shadow: 0 0 0 var(--kk-badge-border-width) var(--kk-badge-border-color)
}

.kk-badge__text {
    --transform-scale: .5;
    font-size: 20px;
    font-weight: 700;
    line-height: 1;
    white-space: nowrap;
    -webkit-transform: scale(var(--transform-scale));
    transform: scale(var(--transform-scale));
    -webkit-transform-origin: center;
    transform-origin: center
}

.kk-badge--marketing-date {
    --kk-badge-background-color: #f5b53d
}

.kk-badge--marketing-discount {
    --kk-badge-text-color: #e65f50;
    --kk-badge-background-color: #fff;
    --kk-badge-border-color: #ef7a70
}

.kk-badge:empty {
    padding: 0;
    width: var(--kk-badge-height)
}

.kk-badge--md:empty {
    --kk-badge-height: 6px
}

.kk-badge--lg:empty {
    --kk-badge-height: 10px;
    --kk-badge-border-width: 2.5px
}

.kk-badge--xl:empty {
    --kk-badge-height: 12px;
    --kk-badge-border-width: 2.5px
}

.kk-avatar {
    --action-icon-container-size: 24px;
    --action-icon-size: 16px;
    --border-width: 1px;
    --icon-avatar-border: var(--border-width) solid #e6e9ed;
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    text-align: center;
    overflow: visible;
    border-radius: 50%;
    position: relative;
    width: var(--avatar-size);
    height: var(--avatar-size)
}

.kk-avatar,.kk-avatar__content-container {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-sizing: border-box;
    box-sizing: border-box
}

.kk-avatar__content-container {
    border-radius: inherit;
    width: 100%;
    height: 100%;
    overflow: hidden;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex
}

.kk-avatar__content-container--img {
    border: var(--border-width) solid #fff
}

.kk-avatar__content-container--img>img {
    display: block;
    width: 100%;
    height: 100%;
    -o-object-fit: cover;
    object-fit: cover
}

.kk-avatar__content-container--icon {
    background: var(--avatar-background,#f1f4f8);
    color: var(--avatar-color,#9c9da0);
    border: var(--icon-avatar-border)
}

.kk-avatar__content-container--text {
    background: var(--avatar-background,#26bec9);
    color: var(--avatar-color,#fff);
    border: none;
    font-size: var(--text-avatar-font-size);
    font-weight: var(--text-avatar-font-weight);
    line-height: 1
}

.kk-avatar__icon {
    display: block;
    fill: currentColor;
    width: var(--avatar-icon-size);
    height: var(--avatar-icon-size)
}

.kk-avatar--action {
    cursor: pointer
}

.kk-avatar--action:hover .kk-avatar__content-container--img {
    border: var(--border-width) solid #babbbe
}

.kk-avatar__badge {
    position: absolute;
    top: var(--avatar-offset-top);
    right: var(--avatar-offset-right)
}

.kk-avatar--xs {
    --avatar-size: 32px;
    --avatar-icon-size: 16px;
    --avatar-offset-top: 2px;
    --avatar-offset-right: 2px
}

.kk-avatar--xs .kk-avatar__content-container--text {
    --text-avatar-font-size: 12px;
    --text-avatar-font-weight: 700
}

.kk-avatar--sm {
    --avatar-size: 40px;
    --avatar-icon-size: 20px;
    --avatar-offset-top: 0;
    --avatar-offset-right: 0
}

.kk-avatar--sm .kk-avatar__content-container--text {
    --text-avatar-font-size: 16px;
    --text-avatar-font-weight: 400
}

.kk-avatar--md {
    --avatar-size: 48px;
    --avatar-icon-size: 24px;
    --avatar-offset-top: 2px;
    --avatar-offset-right: 2px
}

.kk-avatar--md .kk-avatar__content-container--text {
    --text-avatar-font-size: 20px;
    --text-avatar-font-weight: 700
}

.kk-avatar--lg {
    --avatar-size: 64px;
    --avatar-icon-size: 32px;
    --avatar-offset-top: 4px;
    --avatar-offset-right: 4px
}

.kk-avatar--lg .kk-avatar__content-container--text {
    --text-avatar-font-size: 28px;
    --text-avatar-font-weight: 500
}

.kk-avatar--xl {
    --avatar-size: 80px;
    --avatar-icon-size: 40px;
    --avatar-offset-top: 6px;
    --avatar-offset-right: 6px
}

.kk-avatar--xl .kk-avatar__content-container--text {
    --text-avatar-font-size: 36px;
    --text-avatar-font-weight: 700
}

.kk-avatar--2xl {
    --avatar-size: 96px;
    --avatar-icon-size: 48px;
    --avatar-offset-top: 8px;
    --avatar-offset-right: 8px
}

.kk-avatar--2xl .kk-avatar__content-container--text {
    --text-avatar-font-size: 48px;
    --text-avatar-font-weight: 700
}

.kk-avatar__action-icon-container {
    position: absolute;
    right: 0;
    bottom: 0;
    background: #fff;
    border-radius: 50%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    width: var(--action-icon-container-size);
    height: var(--action-icon-container-size);
    -webkit-box-shadow: 0 1px 4px rgba(38,50,56,.1215686275);
    box-shadow: 0 1px 4px rgba(38,50,56,.1215686275)
}

.kk-avatar__action-icon-container .kk-avatar__action-icon {
    display: block;
    fill: #727272;
    width: var(--action-icon-size);
    height: var(--action-icon-size)
}

.kk-avatar--md .kk-avatar__action-icon-container {
    right: -2px;
    bottom: -2px
}

.kk-avatar--2xl,.kk-avatar--xl {
    --action-icon-container-size: 32px;
    --action-icon-size: 20px
}

.kk-avatar--2xl,.kk-avatar--lg,.kk-avatar--xl {
    --border-width: 2px
}

.kk-avatar--cyan .kk-avatar__content-container--icon,.kk-avatar--cyan .kk-avatar__content-container--text {
    --avatar-background: #26bec9;
    --avatar-color: #fff;
    --icon-avatar-border: none
}

.kk-avatar--blue .kk-avatar__content-container--icon,.kk-avatar--blue .kk-avatar__content-container--text {
    --avatar-background: #64b3f4;
    --avatar-color: #fff;
    --icon-avatar-border: none
}

.kk-avatar--amber .kk-avatar__content-container--icon,.kk-avatar--amber .kk-avatar__content-container--text {
    --avatar-background: #ffb400;
    --avatar-color: #fff;
    --icon-avatar-border: none
}

.kk-avatar--red .kk-avatar__content-container--icon,.kk-avatar--red .kk-avatar__content-container--text {
    --avatar-background: #ef7a70;
    --avatar-color: #fff;
    --icon-avatar-border: none
}

.kk-avatar--neutral .kk-avatar__content-container--icon,.kk-avatar--neutral .kk-avatar__content-container--text {
    --avatar-background: #9c9da0;
    --avatar-color: #fff;
    --icon-avatar-border: none
}

.kk-icon {
    --icon-size: 24px;
    display: block;
    fill: currentColor;
    width: var(--icon-size);
    height: var(--icon-size)
}

.kk-icon--2xs {
    --icon-size: 14px
}

.kk-icon--xs {
    --icon-size: 16px
}

.kk-icon--sm {
    --icon-size: 20px
}

.kk-icon--md {
    --icon-size: 24px
}

.kk-icon--lg {
    --icon-size: 32px
}

.kk-icon--xl {
    --icon-size: 48px
}

.kk-bottom-sheet {
    --open-close-transition-duration: .4s;
    --open-close-transition-duration-after-swipe: .3s;
    --body-border-top-transition-duration: .1s;
    --overlay-opacity: .48;
    --overlay-drag-down-min-opacity: .24;
    --drag-up-stickiness: .3;
    --close-by-swiping-down-threshold-distance: 200px;
    --close-by-swiping-down-threshold-ratio: .33;
    --close-by-swiping-down-threshold-speed: 1000;
    --kk-bottom-sheet-z-index: 1000
}

.kk-bottom-sheet__fixed-wrapper {
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    height: 100%;
    display: grid;
    grid-template-rows: minmax(16px,1fr) auto;
    grid-template-areas: "top-spacer" "sheet";
    visibility: hidden;
    will-change: transform;
    -webkit-transform: translateY(100%);
    transform: translateY(100%);
    -webkit-transition: visibility 0s var(--open-close-transition-duration),-webkit-transform var(--open-close-transition-duration);
    transition: visibility 0s var(--open-close-transition-duration),-webkit-transform var(--open-close-transition-duration);
    transition: transform var(--open-close-transition-duration),visibility 0s var(--open-close-transition-duration);
    transition: transform var(--open-close-transition-duration),visibility 0s var(--open-close-transition-duration),-webkit-transform var(--open-close-transition-duration);
    z-index: calc(var(--kk-bottom-sheet-z-index) + 1)
}

.kk-bottom-sheet__fixed-wrapper:after {
    content: "";
    position: absolute;
    top: 100%;
    left: 0;
    width: 100%;
    height: 500px;
    background-color: #fff
}

.kk-bottom-sheet--full-height .kk-bottom-sheet__fixed-wrapper {
    grid-template-rows: 16px 1fr
}

.kk-bottom-sheet__top-spacer {
    grid-area: top-spacer
}

.kk-bottom-sheet__sheet {
    grid-area: sheet;
    display: grid;
    grid-template-rows: auto auto minmax(0,1fr);
    grid-template-areas: "handle" "header" "content";
    min-height: 240px;
    padding-bottom: env(safe-area-inset-bottom,0);
    border-radius: 16px 16px 0 0;
    background-color: #fff;
    overflow: hidden
}

.kk-bottom-sheet__overlay {
    visibility: hidden;
    position: fixed;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    opacity: 0;
    background-color: #000;
    will-change: opacity;
    -webkit-transition: opacity var(--open-close-transition-duration),visibility 0s var(--open-close-transition-duration);
    transition: opacity var(--open-close-transition-duration),visibility 0s var(--open-close-transition-duration);
    z-index: var(--kk-bottom-sheet-z-index)
}

.kk-bottom-sheet__handle {
    grid-area: handle;
    width: 40px;
    height: 4px;
    border-radius: 2px;
    background-color: #d5d6db;
    margin: 8px auto
}

.kk-bottom-sheet__header {
    grid-area: header;
    color: #212121;
    background-color: #fff
}

.kk-bottom-sheet__title-grid {
    display: grid;
    grid-template-columns: 64px 1fr 64px;
    gap: 8px;
    padding: 12px 24px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center
}

.kk-bottom-sheet__icon-button {
    justify-self: left;
    cursor: pointer;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    -webkit-box-sizing: content-box;
    box-sizing: content-box;
    padding: 4px;
    margin: -4px
}

.kk-bottom-sheet__title {
    font-size: 16px;
    line-height: 24px;
    font-weight: 700;
    text-align: center
}

.kk-bottom-sheet__link,.kk-bottom-sheet__title {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden
}

.kk-bottom-sheet__link {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400;
    cursor: pointer;
    color: #212121;
    text-decoration: underline;
    justify-self: right;
    max-width: 64px
}

.kk-bottom-sheet__content {
    grid-area: content;
    display: grid;
    grid-template-rows: auto minmax(0,1fr) auto auto;
    grid-template-areas: "below-header" "body" "above-footer" "footer";
    background-color: #fff
}

.kk-bottom-sheet__below-header {
    grid-area: below-header
}

.kk-bottom-sheet__body {
    grid-area: body;
    overflow: auto;
    border-top: 1px solid #d5d6db;
    -webkit-transition: border-color var(--body-border-top-transition-duration) ease;
    transition: border-color var(--body-border-top-transition-duration) ease
}

.kk-bottom-sheet__body--scroll-at-top {
    border-top-color: transparent
}

.kk-bottom-sheet__above-footer {
    grid-area: above-footer;
    border-top: 1px solid #d5d6db
}

.kk-bottom-sheet__footer {
    grid-area: footer;
    border-top: 1px solid #d5d6db
}

.kk-bottom-sheet__footer-container {
    padding: 16px 24px
}

.kk-bottom-sheet__above-footer+.kk-bottom-sheet__footer {
    border-top: none
}

.kk-bottom-sheet--open>.kk-bottom-sheet__fixed-wrapper {
    visibility: visible;
    -webkit-transform: translateY(0);
    transform: translateY(0);
    -webkit-transition: visibility 0s,-webkit-transform var(--open-close-transition-duration);
    transition: visibility 0s,-webkit-transform var(--open-close-transition-duration);
    transition: transform var(--open-close-transition-duration),visibility 0s;
    transition: transform var(--open-close-transition-duration),visibility 0s,-webkit-transform var(--open-close-transition-duration)
}

.kk-bottom-sheet--open>.kk-bottom-sheet__overlay {
    opacity: var(--overlay-opacity);
    visibility: visible;
    -webkit-transition: opacity var(--open-close-transition-duration),visibility 0s;
    transition: opacity var(--open-close-transition-duration),visibility 0s
}

.kk-bottom-sheet-with-navigation {
    --navigation-transition-duration: .3s;
    --navigation-transition-duration-after-swipe: .2s;
    --navigation-content-translate-offset: 120px;
    --navigation-content-overlay-opacity: .08;
    --navigation-content-overlay-drag-right-min-opacity: .008;
    --navigation-back-by-swiping-right-threshold: 50px
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__header:last-of-type {
    opacity: 1;
    z-index: 3
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__header:nth-last-of-type(2) {
    z-index: 2
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__header:nth-last-of-type(n+2) {
    opacity: 0
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__header:nth-last-of-type(n+3) {
    z-index: 1
}

.kk-bottom-sheet-with-navigation.kk-bottom-sheet--open .kk-bottom-sheet__header:last-of-type,.kk-bottom-sheet-with-navigation.kk-bottom-sheet--open .kk-bottom-sheet__header:nth-last-of-type(2) {
    will-change: opacity
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet__header,.kk-bottom-sheet-with-navigation--on-pushing .kk-bottom-sheet__header {
    -webkit-transition: opacity var(--navigation-transition-duration) linear;
    transition: opacity var(--navigation-transition-duration) linear
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet__header:last-of-type,.kk-bottom-sheet-with-navigation--on-start-pushing .kk-bottom-sheet__header:last-of-type {
    opacity: 0
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet__header:nth-last-of-type(2),.kk-bottom-sheet-with-navigation--on-start-pushing .kk-bottom-sheet__header:nth-last-of-type(2) {
    opacity: 1
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__content:last-of-type {
    z-index: 4
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__content:nth-last-of-type(2) {
    z-index: 2
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__content:nth-last-of-type(n+2) {
    -webkit-transform: translate(calc(var(--navigation-content-translate-offset)*-1));
    transform: translate(calc(var(--navigation-content-translate-offset)*-1))
}

.kk-bottom-sheet-with-navigation .kk-bottom-sheet__content:nth-last-of-type(n+3) {
    z-index: 1
}

.kk-bottom-sheet-with-navigation.kk-bottom-sheet--open .kk-bottom-sheet__content:last-of-type,.kk-bottom-sheet-with-navigation.kk-bottom-sheet--open .kk-bottom-sheet__content:nth-last-of-type(2) {
    will-change: transform
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet__content,.kk-bottom-sheet-with-navigation--on-pushing .kk-bottom-sheet__content {
    -webkit-transition: -webkit-transform var(--navigation-transition-duration) ease;
    transition: -webkit-transform var(--navigation-transition-duration) ease;
    transition: transform var(--navigation-transition-duration) ease;
    transition: transform var(--navigation-transition-duration) ease,-webkit-transform var(--navigation-transition-duration) ease
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet__content:last-of-type,.kk-bottom-sheet-with-navigation--on-start-pushing .kk-bottom-sheet__content:last-of-type {
    -webkit-transform: translate(100%);
    transform: translate(100%)
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet__content:nth-last-of-type(2),.kk-bottom-sheet-with-navigation--on-start-pushing .kk-bottom-sheet__content:nth-last-of-type(2) {
    -webkit-transform: translate(0);
    transform: translate(0)
}

.kk-bottom-sheet-with-navigation__content-overlay {
    grid-area: content;
    background-color: #000;
    opacity: var(--navigation-content-overlay-opacity);
    z-index: 3
}

.kk-bottom-sheet--open .kk-bottom-sheet-with-navigation__content-overlay {
    will-change: opacity
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet-with-navigation__content-overlay,.kk-bottom-sheet-with-navigation--on-pushing .kk-bottom-sheet-with-navigation__content-overlay {
    -webkit-transition: opacity var(--navigation-transition-duration) linear;
    transition: opacity var(--navigation-transition-duration) linear
}

.kk-bottom-sheet-with-navigation--on-popping .kk-bottom-sheet-with-navigation__content-overlay,.kk-bottom-sheet-with-navigation--on-start-pushing .kk-bottom-sheet-with-navigation__content-overlay {
    opacity: 0
}

.kk-checkbox {
    display: block;
    margin: 0
}

.kk-checkbox__input {
    display: none
}

.kk-checkbox__selector {
    --checkbox-background: #fff;
    --checkbox-border: 1px solid #d5d6db;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 20px;
    height: 20px;
    color: #fff;
    background: var(--checkbox-background);
    border: var(--checkbox-border);
    border-radius: 4px;
    cursor: pointer
}

.kk-checkbox__input:disabled+.kk-checkbox__selector {
    cursor: default;
    --checkbox-border: 1px solid #d5d6db;
    --checkbox-background: #e6e9ed
}

.kk-checkbox__input:checked+.kk-checkbox__selector,.kk-checkbox__input:indeterminate+.kk-checkbox__selector {
    --checkbox-border: none;
    --checkbox-background: #26bec9
}

.kk-checkbox__input:disabled:checked+.kk-checkbox__selector,.kk-checkbox__input:disabled:indeterminate+.kk-checkbox__selector {
    --checkbox-background: #cef0f3
}

@media(hover: hover) {
    .kk-checkbox:hover .kk-checkbox__input:not(:disabled)+.kk-checkbox__selector {
        --checkbox-border:1px solid #babbbe
    }

    .kk-checkbox:hover .kk-checkbox__input:checked+.kk-checkbox__selector,.kk-checkbox:hover .kk-checkbox__input:indeterminate+.kk-checkbox__selector {
        --checkbox-border: none
    }
}

.kk-option-item-icon-layout {
    display: grid;
    grid-template-columns: var(--grid-template-columns);
    grid-template-rows: var(--grid-template-rows)
}

.kk-option-item-icon-layout--left {
    --grid-template-columns: auto 1fr;
    --grid-template-rows: repeat(2,auto);
    --label-grid-column: 2;
    --label-grid-row: 1;
    --description-grid-column: 2;
    --description-grid-row: 2;
    --icon-grid-column: 1;
    --icon-grid-row: 1/3;
    --icon-padding-left: 0;
    --icon-padding-right: 12px
}

.kk-option-item-icon-layout--right {
    --description-grid-column: 1;
    --icon-grid-row: 1/3;
    --icon-padding-left: 12px
}

.kk-option-item-icon-layout--right,.kk-option-item-icon-layout--top-right {
    --grid-template-columns: 1fr auto;
    --grid-template-rows: repeat(2,auto);
    --label-grid-column: 1;
    --label-grid-row: 1;
    --description-grid-row: 2;
    --icon-grid-column: 2;
    --icon-padding-right: 0
}

.kk-option-item-icon-layout--top-right {
    --description-grid-column: 1/3;
    --icon-grid-row: 1;
    --icon-padding-left: 20px
}

.kk-option-item-icon-layout__label {
    grid-column: var(--label-grid-column);
    grid-row: var(--label-grid-row)
}

.kk-option-item-icon-layout__description {
    grid-column: var(--description-grid-column);
    grid-row: var(--description-grid-row);
    padding-top: 2px
}

.kk-option-item-icon-layout__icon {
    grid-column: var(--icon-grid-column);
    grid-row: var(--icon-grid-row);
    padding-left: var(--icon-padding-left);
    padding-right: var(--icon-padding-right)
}

.kk-option-item-icon-layout--left .kk-option-item-icon-layout__icon,.kk-option-item-icon-layout--right .kk-option-item-icon-layout__icon {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center
}

.kk-option-item-layout {
    display: grid;
    grid-template-columns: var(--grid-template-columns);
    grid-template-rows: var(--grid-template-rows)
}

.kk-option-item-layout--left {
    --grid-template-columns: auto 1fr;
    --input-grid-column: 1;
    --input-grid-row: .3333333333;
    --input-label-grid-column: 2;
    --input-label-grid-row: 1;
    --children-grid-column: 2;
    --footer-grid-column: 2
}

.kk-option-item-layout--left,.kk-option-item-layout--right {
    --grid-template-rows: repeat(3,auto);
    --children-grid-row: 2;
    --footer-grid-row: 3
}

.kk-option-item-layout--right {
    --grid-template-columns: 1fr auto;
    --input-grid-column: 2;
    --input-grid-row: 1;
    --input-label-grid-column: 1;
    --input-label-grid-row: 1;
    --children-grid-column: 1/3;
    --footer-grid-column: 1/3
}

.kk-option-item-layout .kk-option-item-layout__input {
    grid-column: var(--input-grid-column);
    grid-row: var(--input-grid-row)
}

.kk-option-item-layout .kk-option-item-layout__input-label {
    grid-column: var(--input-label-grid-column);
    grid-row: var(--input-label-grid-row)
}

.kk-option-item-layout .kk-option-item-layout__children {
    grid-column: var(--children-grid-column);
    grid-row: var(--children-grid-row);
    padding-top: 24px
}

.kk-option-item-layout .kk-option-item-layout__footer {
    grid-column: var(--footer-grid-column);
    grid-row: var(--footer-grid-row);
    padding-top: 4px
}

.kk-option-item-layout--right .kk-option-item-layout__input {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center
}

.kk-option-item-icon__icon {
    color: #212121
}

.kk-option-item-icon__icon--disabled {
    color: #9c9da0
}

.kk-option-item-icon__image {
    min-height: 24px;
    width: auto
}

.kk-option-item-icon__image--disabled {
    opacity: .4
}

.kk-option-item-label {
    color: #212121
}

.kk-option-item-label--disabled {
    color: #9c9da0
}

.kk-option-item-label--md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-option-item-label--lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400
}

.kk-option-item-description {
    color: #9c9da0;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-option-item-description--disabled {
    color: #d5d6db
}

.kk-option-item__label {
    display: block;
    margin: 0
}

.kk-checkbox-item__checkbox {
    display: block
}

.kk-checkbox-item__checkbox--md {
    padding-top: 0;
    padding-bottom: 0
}

.kk-checkbox-item__checkbox--lg {
    padding-top: 2px;
    padding-bottom: 2px
}

.kk-checkbox-item__checkbox--left {
    padding-right: 12px
}

.kk-checkbox-item__checkbox--right {
    padding-left: 20px
}

.kk-chip {
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    gap: 4px;
    padding: 8px 12px;
    color: #212121;
    border-radius: 8px;
    border: 1px solid #d5d6db;
    background: #fff;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    cursor: pointer
}

.kk-chip--md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-chip--lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400
}

.kk-chip--rounded {
    border-radius: 20px
}

.kk-chip--disabled {
    color: #9c9da0;
    background: #f1f4f8;
    cursor: not-allowed
}

.kk-chip--selected {
    color: #26bec9;
    border: 1px solid #26bec9;
    background: #f0fafb
}

.kk-chip--selected.kk-chip--disabled {
    color: #ade6eb;
    border: 1px solid #ade6eb
}

.kk-collapse__content {
    overflow: hidden
}

.kk-collapse--transition-slow .kk-collapse__content {
    -webkit-transition: height .5s ease-out;
    transition: height .5s ease-out
}

.kk-collapse--transition-medium .kk-collapse__content {
    -webkit-transition: height .3s ease-out;
    transition: height .3s ease-out
}

.kk-collapse--transition-fast .kk-collapse__content {
    -webkit-transition: height .1s ease-out;
    transition: height .1s ease-out
}

.kk-divider {
    --gap: 16px;
    --text-color: #727272;
    --line-color: #babbbe;
    --line-thickness: 1px;
    display: grid;
    grid-template-columns: 1fr fit-content(80%) 1fr;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    grid-gap: var(--gap);
    color: var(--text-color);
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none
}

.kk-divider:empty {
    display: block;
    height: var(--line-thickness);
    background: var(--line-color)
}

.kk-divider:empty:after,.kk-divider:empty:before {
    display: none
}

.kk-divider:after,.kk-divider:before {
    content: "";
    background-color: var(--line-color);
    height: var(--line-thickness)
}

.kk-divider__text {
    text-align: center
}

.kk-select-dropdown {
    position: relative;
    border-radius: 8px;
    background: #fff;
    overflow: hidden;
    -webkit-box-shadow: 0 2px 24px rgba(38,50,56,.1215686275);
    box-shadow: 0 2px 24px rgba(38,50,56,.1215686275)
}

.kk-select-dropdown--auto-width {
    min-width: 120px;
    max-width: 600px;
    width: -moz-max-content;
    width: -webkit-max-content;
    width: max-content
}

.kk-select-dropdown:hover .kk-select-dropdown__content::-webkit-scrollbar-thumb {
    border: 2px solid #fff;
    background-clip: padding-box;
    background: #9c9da0;
    border-radius: 9999px
}

.kk-select-dropdown__content {
    overflow-y: auto;
    max-height: 416px;
    padding: 8px
}

.kk-select-dropdown__content::-webkit-scrollbar {
    width: 8px
}

.kk-select-dropdown__content::-webkit-scrollbar-button {
    display: none
}

.kk-select-dropdown__content::-webkit-scrollbar-thumb,.kk-select-dropdown__content::-webkit-scrollbar-track {
    background: transparent
}

.kk-select-dropdown__overlay {
    position: absolute;
    left: 0;
    right: 0;
    height: 30px;
    pointer-events: none;
    z-index: 999
}

.kk-select-dropdown__overlay--top {
    top: 0;
    background: -webkit-gradient(linear,left top,left bottom,from(#fff),to(hsla(0,0%,100%,0)));
    background: linear-gradient(180deg,#fff,hsla(0,0%,100%,0))
}

.kk-select-dropdown__overlay--bottom {
    bottom: 0;
    background: -webkit-gradient(linear,left bottom,left top,from(#fff),to(hsla(0,0%,100%,0)));
    background: linear-gradient(0deg,#fff,hsla(0,0%,100%,0))
}

.kk-header-layout {
    --kk-header-layout-position: sticky;
    --kk-header-layout-transition: none;
    --kk-header-layout-main-height: 56px;
    position: var(--kk-header-layout-position);
    top: 0;
    left: 0;
    z-index: 1000;
    -webkit-transition: var(--kk-header-layout-transition);
    transition: var(--kk-header-layout-transition);
    width: 100%;
    background: #fff
}

.kk-header-layout__main {
    height: var(--kk-header-layout-main-height);
    -webkit-box-sizing: border-box;
    box-sizing: border-box
}

.kk-header-layout__main--transparent-gradient {
    background: -webkit-gradient(linear,left top,left bottom,from(rgba(0,0,0,.4)),to(transparent));
    background: linear-gradient(rgba(0,0,0,.4),transparent)
}

.kk-header-layout__below-header {
    -webkit-transition: var(--kk-header-layout-transition);
    transition: var(--kk-header-layout-transition)
}

.kk-header-layout__below-header--hidden {
    opacity: 0;
    height: 0;
    overflow: hidden
}

.kk-header-layout--transparent {
    background: transparent
}

.kk-header-layout--slide-out {
    -webkit-transform: translateY(-100%);
    transform: translateY(-100%)
}

.kk-header-layout__right {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    gap: 12px;
    -webkit-box-pack: end;
    -ms-flex-pack: end;
    justify-content: flex-end
}

.kk-header-layout--box-shadow {
    -webkit-box-shadow: 0 2px 24px rgba(38,50,56,.1215686275);
    box-shadow: 0 2px 24px rgba(38,50,56,.1215686275)
}

.kk-icon-with-badge {
    display: inline-block;
    position: relative
}

.kk-icon-with-badge__badge {
    position: absolute;
    top: var(--kk-icon-with-badge-offset-top);
    right: var(--kk-icon-with-badge-offset-right)
}

.kk-icon-with-badge--text>.kk-icon-with-badge__badge {
    -webkit-transform: translate(50%);
    transform: translate(50%)
}

.kk-icon-with-badge--text.kk-icon-with-badge--2xs>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -10px;
    --kk-icon-with-badge-offset-right: calc(-10px + var(--kk-badge-height)/2)
}

.kk-icon-with-badge--text.kk-icon-with-badge--xs>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -8px;
    --kk-icon-with-badge-offset-right: calc(-10px + var(--kk-badge-height)/2)
}

.kk-icon-with-badge--text.kk-icon-with-badge--sm>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -6px;
    --kk-icon-with-badge-offset-right: calc(-8px + var(--kk-badge-height)/2)
}

.kk-icon-with-badge--text.kk-icon-with-badge--md>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -4px;
    --kk-icon-with-badge-offset-right: calc(-6px + var(--kk-badge-height)/2)
}

.kk-icon-with-badge--text.kk-icon-with-badge--lg>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -2px;
    --kk-icon-with-badge-offset-right: calc(-4px + var(--kk-badge-height)/2)
}

.kk-icon-with-badge--text.kk-icon-with-badge--xl>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: 0px;
    --kk-icon-with-badge-offset-right: calc(var(--kk-badge-height)/2)
}

.kk-icon-with-badge--dot.kk-icon-with-badge--2xs>.kk-icon-with-badge__badge,.kk-icon-with-badge--dot.kk-icon-with-badge--xs>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -3px;
    --kk-icon-with-badge-offset-right: -3px
}

.kk-icon-with-badge--dot.kk-icon-with-badge--sm>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -2px;
    --kk-icon-with-badge-offset-right: -2px
}

.kk-icon-with-badge--dot.kk-icon-with-badge--md>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: -1px;
    --kk-icon-with-badge-offset-right: -1px
}

.kk-icon-with-badge--dot.kk-icon-with-badge--lg>.kk-icon-with-badge__badge,.kk-icon-with-badge--dot.kk-icon-with-badge--xl>.kk-icon-with-badge__badge {
    --kk-icon-with-badge-offset-top: 2px;
    --kk-icon-with-badge-offset-right: 2px
}

.kk-icon-button {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    height: 32px;
    width: 32px;
    color: #212121;
    background: #fff;
    border-radius: 50%;
    cursor: pointer;
    -webkit-box-shadow: 0 2px 24px rgba(38,50,56,.1215686275);
    box-shadow: 0 2px 24px rgba(38,50,56,.1215686275)
}

.kk-icon-button--transparent {
    background: transparent;
    -webkit-box-shadow: initial;
    box-shadow: none
}

.kk-icon-with-text {
    display: grid;
    gap: var(--icon-with-text-gap);
    grid-template-rows: minmax(0,1fr);
    grid-template-columns: auto minmax(0,1fr);
    -webkit-box-align: start;
    -ms-flex-align: start;
    align-items: start;
    font-size: var(--icon-with-text-font-size);
    line-height: var(--icon-with-text-line-height)
}

.kk-icon-with-text--xs {
    --icon-with-text-gap: 8px;
    --icon-with-text-font-size: 12px;
    --icon-with-text-line-height: 16px
}

.kk-icon-with-text--sm {
    --icon-with-text-gap: 12px;
    --icon-with-text-font-size: 14px;
    --icon-with-text-line-height: 20px
}

.kk-icon-with-text--md {
    --icon-with-text-gap: 16px;
    --icon-with-text-font-size: 16px;
    --icon-with-text-line-height: 24px
}

.kk-inform {
    border-radius: 8px;
    width: auto;
    max-width: 500px;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    --kk-badge-background-color: rgba(64,64,64,0.95);
    background-color: var(--kk-badge-background-color)
}

.kk-inform--snackbar {
    width: calc(100% - 32px)
}

.kk-inform--danger {
    --kk-badge-background-color: #d14330
}

.kk-inform__inform--text {
    margin: 4px 0;
    color: #fff
}

.kk-inform__action {
    cursor: pointer;
    display: grid
}

.kk-inform__icon {
    color: #fff;
    margin: 4px
}

.kk-label {
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    height: var(--kk-label-height);
    font-size: var(--kk-font-size);
    border-radius: var(--kk-label-border-radius);
    padding: 0 var(--kk-label-padding-x);
    color: var(--kk-label-text-color);
    background-color: var(--kk-label-background-color)
}

.kk-label--md {
    --kk-label-height: 28px;
    --kk-label-font-size: 14px;
    --kk-label-border-radius: 4px;
    --kk-label-padding-x: 8px
}

.kk-label--sm {
    --kk-label-height: 20px;
    --kk-label-font-size: 12px;
    --kk-label-border-radius: 2px;
    --kk-label-padding-x: 8px
}

.kk-label--grey {
    --kk-label-background-color: #eee;
    --kk-label-text-color: #333
}

.kk-label--primary {
    --kk-label-background-color: rgba(38,190,201,0.1);
    --kk-label-text-color: #26bec9
}

.kk-label--info {
    --kk-label-background-color: rgba(100,179,244,0.1);
    --kk-label-text-color: #36a1fa
}

.kk-label--warning {
    --kk-label-background-color: #ffb400;
    --kk-label-text-color: #fff
}

.kk-label--critical {
    --kk-label-background-color: #ef7a70;
    --kk-label-text-color: #fff
}

.kk-message {
    display: grid;
    gap: 2px;
    grid-auto-flow: row;
    -webkit-box-pack: var(--text-align);
    -ms-flex-pack: var(--text-align);
    justify-content: var(--text-align);
    text-align: var(--text-align);
    font-size: 12px;
    line-height: 16px;
    font-weight: 400
}

.kk-message--left {
    --text-align: left
}

.kk-message--right {
    --text-align: right
}

.kk-message__figure {
    display: grid;
    gap: 4px;
    grid-auto-flow: column;
    -webkit-box-pack: var(--text-align);
    -ms-flex-pack: var(--text-align);
    justify-content: var(--text-align);
    margin: 0
}

.kk-message__figure--success {
    color: #26bec9
}

.kk-message__figure--warning {
    color: #f5b53d
}

.kk-message__figure--error {
    color: #e65f50
}

.kk-message__icon {
    margin: 1px 0
}

.kk-message__hint {
    color: #727272
}

.kk-progress>* {
    height: inherit
}

.kk-progress--sm {
    --progress-height: 6px;
    --progress-bar-radius: calc(var(--progress-height)/2);
    height: var(--progress-height)
}

.kk-progress--md {
    --progress-height: 15px;
    --progress-bar-radius: 2px;
    height: var(--progress-height)
}

.kk-progress--fragmented {
    display: grid;
    gap: 4px;
    grid-template-columns: repeat(auto-fit,minmax(0,1fr));
    background-color: transparent
}

.kk-progress--fragmented .kk-progress__bar {
    -webkit-transition: none;
    transition: none
}

.kk-progress__progress {
    background-color: #f1f4f8;
    overflow: hidden
}

.kk-progress__progress:first-child {
    border-top-left-radius: var(--progress-bar-radius);
    border-bottom-left-radius: var(--progress-bar-radius)
}

.kk-progress__progress:last-child {
    border-top-right-radius: var(--progress-bar-radius);
    border-bottom-right-radius: var(--progress-bar-radius)
}

.kk-progress__bar {
    height: inherit;
    -webkit-transition-duration: .5s;
    transition-duration: .5s;
    -webkit-transition-property: width;
    transition-property: width;
    -webkit-transition-timing-function: cubic-bezier(1,1.43,.83,.85);
    transition-timing-function: cubic-bezier(1,1.43,.83,.85)
}

.kk-progress--primary .kk-progress__bar {
    background-color: #26bec9
}

.kk-progress--silver .kk-progress__bar {
    background-color: #64b3f4
}

.kk-progress--platinum .kk-progress__bar {
    background-color: #6c56a1
}

.kk-progress--diamond .kk-progress__bar {
    background-color: #3d4854
}

.kk-radio-button {
    --radio-button-cursor: pointer;
    --radio-button-background: #fff;
    --radio-button-border: 1px solid #d5d6db;
    position: relative;
    width: 20px;
    height: 20px
}

.kk-radio-button[type=radio] {
    display: block;
    margin: 0
}

.kk-radio-button:after {
    position: absolute;
    top: 0;
    left: 0;
    content: "";
    display: block;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 100%;
    height: 100%;
    border-radius: 50%;
    cursor: var(--radio-button-cursor);
    background: var(--radio-button-background);
    border: var(--radio-button-border)
}

.kk-radio-button:disabled {
    --radio-button-cursor: default;
    --radio-button-background: #e6e9ed;
    --radio-button-border: 1px solid #d5d6db
}

.kk-radio-button:checked {
    --radio-button-cursor: default;
    --radio-button-border: 6px solid #26bec9
}

.kk-radio-button:disabled:checked {
    --radio-button-background: #fff;
    --radio-button-border: 6px solid #cef0f3
}

@media(hover: hover) {
    .kk-radio-button:hover:not(:disabled):not(:checked) {
        --radio-button-border:1px solid #babbbe
    }
}

.kk-radio-button-group {
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -ms-flex-wrap: wrap;
    flex-wrap: wrap;
    font-size: 0;
    gap: 12px
}

.kk-radio-button-item__radio-button--md {
    padding-top: 0;
    padding-bottom: 0
}

.kk-radio-button-item__radio-button--lg {
    padding-top: 2px;
    padding-bottom: 2px
}

.kk-radio-button-item__radio-button--left {
    padding-right: 12px
}

.kk-radio-button-item__radio-button--right {
    padding-left: 20px
}

.kk-select-leading-image--disabled {
    color: #babbbe
}

.kk-select-leading-image--disabled.kk-select-leading-image--avatar,.kk-select-leading-image--disabled.kk-select-leading-image--image {
    opacity: .4
}

.kk-select {
    --layout-template-columns: minmax(0,1fr);
    display: grid;
    grid-template-rows: minmax(0,1fr);
    grid-template-columns: var(--layout-template-columns);
    gap: 8px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    position: relative;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    vertical-align: middle;
    border-radius: 8px;
    border: 1px solid #d5d6db;
    background-color: #fff;
    height: 48px;
    padding: 12px;
    cursor: pointer
}

.kk-select__leading-image {
    color: #babbbe
}

.kk-select__input,.kk-select__main-content {
    font-family: PingFang TC,sans-serif;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-select__input {
    cursor: inherit;
    padding: 0;
    outline: none;
    border: none;
    background: none;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    color: #212121;
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden
}

.kk-select__input::-moz-placeholder {
    color: #babbbe
}

.kk-select__input::-webkit-input-placeholder {
    color: #babbbe
}

.kk-select__input:-ms-input-placeholder {
    color: #babbbe
}

.kk-select__input::-ms-input-placeholder {
    color: #babbbe
}

.kk-select__input::placeholder {
    color: #babbbe
}

.kk-select__input:-moz-placeholder-shown {
    text-overflow: ellipsis
}

.kk-select__input:-ms-input-placeholder {
    text-overflow: ellipsis
}

.kk-select__input:placeholder-shown {
    text-overflow: ellipsis
}

.kk-select__trailing-icon:hover {
    color: #212121
}

.kk-select__trailing-icon--transition {
    -webkit-transition: -webkit-transform .3s ease-in-out;
    transition: -webkit-transform .3s ease-in-out;
    transition: transform .3s ease-in-out;
    transition: transform .3s ease-in-out,-webkit-transform .3s ease-in-out
}

.kk-select--expanded .kk-select__trailing-icon--transition {
    -webkit-transform: rotate(-180deg);
    transform: rotate(-180deg)
}

@media(pointer: fine) {
    .kk-select:not(.kk-select--disabled,.kk-select--search,.kk-select--error):hover {
        border-color:#212121;
        outline: #212121
    }
}

.kk-select:not(.kk-select--disabled,.kk-select--search,.kk-select--error):focus-within {
    border-color: #212121;
    outline: #212121
}

.kk-select--auto-height {
    height: auto;
    min-height: 48px
}

.kk-select--disabled {
    cursor: not-allowed;
    border-color: #e6e9ed;
    background-color: #f1f4f8
}

.kk-select--disabled .kk-select__input,.kk-select--disabled .kk-select__main-content {
    color: #babbbe;
    -webkit-text-fill-color: #babbbe;
    opacity: 1
}

.kk-select--disabled .kk-select__input::-webkit-input-placeholder,.kk-select--disabled .kk-select__main-content::-webkit-input-placeholder {
    color: #babbbe
}

.kk-select--disabled .kk-select__input::-moz-placeholder,.kk-select--disabled .kk-select__main-content::-moz-placeholder {
    color: #babbbe
}

.kk-select--disabled .kk-select__input:-ms-input-placeholder,.kk-select--disabled .kk-select__main-content:-ms-input-placeholder {
    color: #babbbe
}

.kk-select--disabled .kk-select__input::-ms-input-placeholder,.kk-select--disabled .kk-select__main-content::-ms-input-placeholder {
    color: #babbbe
}

.kk-select--disabled .kk-select__input::placeholder,.kk-select--disabled .kk-select__main-content::placeholder {
    color: #babbbe
}

.kk-select--disabled .kk-select__trailing-icon {
    color: #babbbe
}

.kk-select--error {
    border-color: #e65f50
}

.kk-select--trailing {
    --layout-template-columns: minmax(0,1fr) auto
}

.kk-select--leading {
    --layout-template-columns: auto minmax(0,1fr)
}

.kk-select--leading.kk-select--trailing {
    --layout-template-columns: auto minmax(0,1fr) auto
}

.kk-select-layout {
    --kk-select-layout-menu-z-index: 1000
}

.kk-select-layout__menu {
    z-index: var(--kk-select-layout-menu-z-index)
}

.kk-select-option {
    list-style: none;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: justify;
    -ms-flex-pack: justify;
    justify-content: space-between;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    gap: 8px;
    padding: 8px 12px;
    min-height: 40px;
    color: var(--kk-select-option-color,#212121);
    cursor: pointer
}

.kk-select-option--grouped {
    padding: 8px 20px
}

.kk-select-option--disabled {
    --kk-select-option-color: #babbbe;
    cursor: not-allowed
}

.kk-select-option--selected {
    --kk-select-option-color: #13a3b6
}

.kk-select-option__icon-text {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
    gap: 8px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center
}

.kk-select-option__content {
    -webkit-box-flex: 1;
    -ms-flex: 1;
    flex: 1;
    font-family: PingFang TC,sans-serif;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-select-option:hover {
    border-radius: 8px;
    background: #f1f4f8
}

.kk-select-option-group {
    list-style: none;
    padding: initial
}

.kk-select-option-group__title {
    color: #212121;
    padding: 8px;
    font-size: 14px;
    line-height: 20px;
    font-weight: 500
}

.kk-select-option-group ul {
    padding: initial
}

.kk-select-with-menu__loading {
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center
}

.kk-select-with-menu__empty-text,.kk-select-with-menu__loading {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    min-height: 40px;
    padding: 0 12px
}

.kk-select-with-menu__empty-text {
    color: #9c9da0;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-stepper {
    display: inline-grid;
    grid-template-columns: auto auto auto;
    gap: 4px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    -ms-touch-action: manipulation;
    touch-action: manipulation
}

.kk-stepper:focus {
    outline: none
}

.kk-stepper__btn {
    --kk-stepper-btn-color: var(--kk-stepper-btn-color-default,#26bec9);
    --kk-stepper-btn-border-color: var(--kk-stepper-btn-border-color-default,#26bec9);
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 32px;
    height: 32px;
    border-radius: 50%;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    background: none;
    padding: 0;
    border: 1px solid var(--kk-stepper-btn-border-color);
    color: var(--kk-stepper-btn-color);
    cursor: pointer
}

@media(hover: hover) {
    .kk-stepper__btn:hover {
        --kk-stepper-btn-color:var(--kk-stepper-btn-color-hover,#068b9f);
        --kk-stepper-btn-border-color: var(--kk-stepper-btn-border-color-hover,#068b9f)
    }
}

.kk-stepper__btn:active {
    --kk-stepper-btn-color: var(--kk-stepper-btn-color-active,#068b9f);
    --kk-stepper-btn-border-color: var(--kk-stepper-btn-border-color-active,#068b9f)
}

.kk-stepper__btn:disabled {
    --kk-stepper-btn-color: var(--kk-stepper-btn-color-disabled,#ade6eb);
    --kk-stepper-btn-border-color: var(--kk-stepper-btn-border-color-disabled,#ade6eb);
    cursor: default
}

.kk-stepper__num {
    width: 40px;
    color: var(--kk-stepper-num-color,#212121);
    text-align: center;
    font-size: 16px;
    line-height: 24px;
    font-weight: 400
}

.kk-switch {
    --background-color: #d5d6db;
    --cursor: pointer;
    position: relative;
    display: inline-block;
    width: 44px;
    height: 28px;
    margin: 0
}

.kk-switch__input {
    opacity: 0;
    width: 0;
    height: 0;
    margin: 0
}

.kk-switch__slider {
    cursor: var(--cursor);
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: var(--background-color);
    border-radius: 14px
}

.kk-switch__slider,.kk-switch__slider:before {
    position: absolute;
    -webkit-transition: .1s;
    transition: .1s
}

.kk-switch__slider:before {
    content: "";
    height: 22px;
    width: 22px;
    left: 3px;
    bottom: 3px;
    background-color: #fff;
    border-radius: 50%
}

.kk-switch__input:disabled+.kk-switch__slider {
    --background-color: #e6e9ed;
    --cursor: normal
}

.kk-switch__input:disabled:checked+.kk-switch__slider {
    --background-color: #cef0f3
}

.kk-switch__input:checked+.kk-switch__slider {
    --background-color: #26bec9
}

.kk-switch__input:checked+.kk-switch__slider:before {
    -webkit-transform: translate(16px);
    transform: translate(16px)
}

.kk-tabs {
    --tab-icon-offset-width: 0px;
    --tab-transition-duration: .25s;
    --tab-padding-x: 12px;
    --tab-padding-y: 12px
}

.kk-tabs--show-icon {
    --tab-icon-offset-width: 24px
}

.kk-tabs__header {
    position: relative;
    overflow-x: auto;
    overscroll-behavior-x: contain;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    border-bottom: 1px solid #e6e9ed;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
    scrollbar-width: none;
    -ms-overflow-style: none
}

.kk-tabs__header::-webkit-scrollbar {
    display: none
}

.kk-tabs__header-padding-left,.kk-tabs__header-padding-right {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
    height: 1px
}

.kk-tabs__header-padding-left {
    width: 12px
}

.kk-tabs__header-padding-right {
    width: calc(12px + var(--tab-icon-offset-width))
}

.kk-tabs__tab-list {
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto;
    display: grid;
    grid-auto-flow: column;
    grid-auto-columns: minmax(0,auto);
    -webkit-box-pack: left;
    -ms-flex-pack: left;
    justify-content: left;
    padding: 0
}

.kk-tabs__tab {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400;
    text-decoration: none!important;
    padding: var(--tab-padding-y) var(--tab-padding-x);
    color: #212121;
    cursor: pointer;
    position: relative
}

@media(prefers-reduced-motion:no-preference) {
    .kk-tabs__tab {
        -webkit-transition-property: color,-webkit-transform;
        transition-property: color,-webkit-transform;
        transition-property: transform,color;
        transition-property: transform,color,-webkit-transform;
        -webkit-transition-timing-function: ease-out;
        transition-timing-function: ease-out;
        -webkit-transition-duration: var(--tab-transition-duration);
        transition-duration: var(--tab-transition-duration)
    }
}

.kk-tabs__tab--active {
    font-size: 16px;
    line-height: 24px;
    font-weight: 700;
    color: #13a3b6
}

.kk-tabs--show-icon .kk-tabs__tab--active,.kk-tabs--show-icon .kk-tabs__tab--active~.kk-tabs__tab {
    -webkit-transform: translate(var(--tab-icon-offset-width));
    transform: translate(var(--tab-icon-offset-width))
}

.kk-tabs__tab-icon {
    position: absolute;
    top: 0;
    left: calc(var(--tab-icon-offset-width)*-1);
    height: 100%;
    padding-left: var(--tab-padding-x);
    -webkit-transform-origin: right center;
    transform-origin: right center;
    -webkit-transform: scale(0);
    transform: scale(0)
}

@media(prefers-reduced-motion:no-preference) {
    .kk-tabs__tab-icon {
        -webkit-transition: -webkit-transform var(--tab-transition-duration) ease-out;
        transition: -webkit-transform var(--tab-transition-duration) ease-out;
        transition: transform var(--tab-transition-duration) ease-out;
        transition: transform var(--tab-transition-duration) ease-out,-webkit-transform var(--tab-transition-duration) ease-out
    }
}

.kk-tabs__tab--active>.kk-tabs__tab-icon {
    -webkit-transform: scale(1);
    transform: scale(1)
}

@media(prefers-reduced-motion:no-preference) {
    .kk-tabs__tab--active>.kk-tabs__tab-icon {
        will-change: transform
    }
}

.kk-tabs__tab-text {
    display: inline-grid;
    grid-auto-flow: column;
    gap: 4px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    position: relative
}

.kk-tabs__tab-text--badge-at-corner>.kk-tabs__tab-badge {
    position: absolute;
    top: -1px;
    right: -6px
}

.kk-tabs__indicator {
    height: 2px;
    border-top-left-radius: 2px;
    border-top-right-radius: 2px;
    background-color: #26bec9;
    position: absolute;
    bottom: 0;
    left: 0;
    width: var(--indicator-width,0);
    -webkit-transform: translate(var(--indicator-offset));
    transform: translate(var(--indicator-offset))
}

@media(prefers-reduced-motion:no-preference) {
    .kk-tabs__indicator {
        -webkit-transition-property: width,-webkit-transform;
        transition-property: width,-webkit-transform;
        transition-property: transform,width;
        transition-property: transform,width,-webkit-transform;
        -webkit-transition-duration: var(--tab-transition-duration);
        transition-duration: var(--tab-transition-duration);
        -webkit-transition-timing-function: ease-out;
        transition-timing-function: ease-out;
        will-change: transform,width
    }
}

.kk-tabs--has-content {
    display: grid;
    grid-template-areas: "header" "content";
    grid-template-rows: auto minmax(0,1fr);
    height: 100%
}

.kk-tabs--has-content>.kk-tabs__header {
    grid-area: header
}

.kk-tabs__content {
    grid-area: content;
    overflow-y: auto;
    display: none
}

.kk-tabs__content--active {
    display: block
}

.kk-tag {
    padding: 3px 8px;
    border-radius: .25em;
    vertical-align: middle;
    font-size: 12px
}

.kk-tag a {
    color: inherit
}

.kk-tag a :hover {
    text-decoration: none
}

.kk-tag--yellow {
    background-color: #ffb400
}

.kk-tag--red {
    background-color: #ef7a70
}

.kk-form-label {
    display: block;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-form-label__text {
    color: #212121
}

.kk-form-label__required-star {
    color: #e65f50
}

.kk-form-label__max-count {
    color: #727272
}

.kk-text-link {
    display: inline;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    color: #13a3b6;
    cursor: pointer
}

@media(hover: hover) {
    .kk-text-link:hover {
        color:#068b9f
    }
}

.kk-text-link--standalone {
    display: -webkit-inline-box;
    display: -ms-inline-flexbox;
    display: inline-flex
}

.kk-text-link--secondary,.kk-text-link--secondary:hover {
    color: #212121
}

.kk-text-link__text {
    text-decoration: underline
}

.kk-text-link__icon {
    margin-left: 4px;
    -webkit-box-flex: 0;
    -ms-flex: 0 0 auto;
    flex: 0 0 auto
}

.kk-text-link--sm {
    font-size: 12px;
    line-height: 16px;
    font-weight: 400
}

.kk-text-link--md {
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-text-link--lg {
    font-size: 16px;
    line-height: 24px;
    font-weight: 400
}

.kk-textarea {
    --textarea-inline-padding: 12px;
    display: block;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    overflow: hidden;
    min-height: 48px;
    width: 100%;
    resize: none;
    padding: var(--textarea-inline-padding);
    border-radius: 8px;
    border-color: #d5d6db;
    outline: none;
    color: #212121;
    background-color: #fff;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-textarea::-moz-placeholder {
    color: #babbbe
}

.kk-textarea::-webkit-input-placeholder {
    color: #babbbe
}

.kk-textarea:-ms-input-placeholder {
    color: #babbbe
}

.kk-textarea::-ms-input-placeholder {
    color: #babbbe
}

.kk-textarea::placeholder {
    color: #babbbe
}

@media(pointer: fine) {
    .kk-textarea:not(.kk-textarea--disabled,.kk-textarea--search,.kk-textarea--error):hover {
        border-color:#212121;
        outline: #212121
    }
}

.kk-textarea:not(.kk-textarea--disabled,.kk-textarea--search,.kk-textarea--error):focus-within {
    border-color: #212121;
    outline: #212121
}

.kk-textarea--draggable {
    overflow: auto;
    resize: vertical
}

.kk-textarea--error {
    border-color: #e65f50
}

.kk-textarea--disabled {
    color: #babbbe;
    background-color: #f1f4f8;
    border-color: #e6e9ed;
    cursor: not-allowed
}

.kk-validation-provider {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: var(--flex-direction);
    flex-direction: var(--flex-direction)
}

.kk-validation-provider__message-bottom-left,.kk-validation-provider__message-bottom-right {
    --flex-direction: column;
    --message-padding-bottom: 0
}

.kk-validation-provider__message-bottom-left--gap-0,.kk-validation-provider__message-bottom-right--gap-0 {
    --message-padding-top: 0
}

.kk-validation-provider__message-bottom-left--gap-1,.kk-validation-provider__message-bottom-right--gap-1 {
    --message-padding-top: 2px
}

.kk-validation-provider__message-bottom-left--gap-2,.kk-validation-provider__message-bottom-right--gap-2 {
    --message-padding-top: 4px
}

.kk-validation-provider__message-bottom-left--gap-3,.kk-validation-provider__message-bottom-right--gap-3 {
    --message-padding-top: 8px
}

.kk-validation-provider__message-bottom-left--gap-4,.kk-validation-provider__message-bottom-right--gap-4 {
    --message-padding-top: 12px
}

.kk-validation-provider__message-bottom-left--gap-5,.kk-validation-provider__message-bottom-right--gap-5 {
    --message-padding-top: 16px
}

.kk-validation-provider__message-bottom-left--gap-6,.kk-validation-provider__message-bottom-right--gap-6 {
    --message-padding-top: 20px
}

.kk-validation-provider__message-bottom-left--gap-7,.kk-validation-provider__message-bottom-right--gap-7 {
    --message-padding-top: 24px
}

.kk-validation-provider__message-bottom-left--gap-8,.kk-validation-provider__message-bottom-right--gap-8 {
    --message-padding-top: 32px
}

.kk-validation-provider__message-bottom-left--gap-9,.kk-validation-provider__message-bottom-right--gap-9 {
    --message-padding-top: 40px
}

.kk-validation-provider__message-bottom-left--gap-10,.kk-validation-provider__message-bottom-right--gap-10 {
    --message-padding-top: 48px
}

.kk-validation-provider__message-top-left {
    --flex-direction: column-reverse;
    --message-padding-top: 0
}

.kk-validation-provider__message-top-left--gap-0 {
    --message-padding-bottom: 0
}

.kk-validation-provider__message-top-left--gap-1 {
    --message-padding-bottom: 2px
}

.kk-validation-provider__message-top-left--gap-2 {
    --message-padding-bottom: 4px
}

.kk-validation-provider__message-top-left--gap-3 {
    --message-padding-bottom: 8px
}

.kk-validation-provider__message-top-left--gap-4 {
    --message-padding-bottom: 12px
}

.kk-validation-provider__message-top-left--gap-5 {
    --message-padding-bottom: 16px
}

.kk-validation-provider__message-top-left--gap-6 {
    --message-padding-bottom: 20px
}

.kk-validation-provider__message-top-left--gap-7 {
    --message-padding-bottom: 24px
}

.kk-validation-provider__message-top-left--gap-8 {
    --message-padding-bottom: 32px
}

.kk-validation-provider__message-top-left--gap-9 {
    --message-padding-bottom: 40px
}

.kk-validation-provider__message-top-left--gap-10 {
    --message-padding-bottom: 48px
}

.kk-validation-provider__message {
    padding-top: var(--message-padding-top);
    padding-bottom: var(--message-padding-bottom)
}

.svg-spinner[data-v-51b1945b] {
    -webkit-transition-property: -webkit-transform;
    transition-property: -webkit-transform;
    transition-property: transform;
    transition-property: transform,-webkit-transform;
    -webkit-animation-name: rotate-51b1945b;
    animation-name: rotate-51b1945b;
    -webkit-animation-duration: 2s;
    animation-duration: 2s;
    -webkit-animation-iteration-count: infinite;
    animation-iteration-count: infinite;
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear
}

@-webkit-keyframes rotate-51b1945b {
    0% {
        -webkit-transform: rotate(0);
        transform: rotate(0)
    }

    to {
        -webkit-transform: rotate(1turn);
        transform: rotate(1turn)
    }
}

@keyframes rotate-51b1945b {
    0% {
        -webkit-transform: rotate(0);
        transform: rotate(0)
    }

    to {
        -webkit-transform: rotate(1turn);
        transform: rotate(1turn)
    }
}

._collapseContainer_yg05e_1 {
    display: grid
}

._list_stphf_1 {
    --clamp: 2;
    --clamp-padding: 8px;
    --clamp-margin: 0px;
    --clamp-line-height: 20px;
    --clamp-gap: 8px;
    position: relative;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    -ms-flex-flow: row wrap;
    flex-flow: row wrap;
    gap: var(--kk-spacing-3);
    overflow: hidden;
    padding: 0;
    max-height: calc((var(--clamp-line-height) + var(--clamp-padding)*2 + var(--clamp-margin)*2 + var(--clamp-gap))*var(--clamp));
    -webkit-transition: .3s ease-in-out;
    transition: .3s ease-in-out
}

._expanded_stphf_17 {
    max-height: 100%
}

._expanded_stphf_17 ._listItemClamp_stphf_20 svg {
    -webkit-transform: scale(-1);
    transform: scale(-1)
}

._listItem_stphf_20 {
    display: block;
    list-style: none;
    margin: 0
}

._listItemClamp_stphf_20 {
    list-style: none
}

._listItemClamp_stphf_20~._listItem_stphf_20 {
    display: none
}

.typeform-widget {
    width: 100%;
    height: 100%
}

.typeform-widget iframe {
    width: 100%;
    height: 100%;
    border: none;
    overflow: hidden;
    border-radius: 8px
}

@font-face {
    font-family: swiper-icons;
    src: url("data:application/font-woff;charset=utf-8;base64, d09GRgABAAAAAAZgABAAAAAADAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABGRlRNAAAGRAAAABoAAAAci6qHkUdERUYAAAWgAAAAIwAAACQAYABXR1BPUwAABhQAAAAuAAAANuAY7+xHU1VCAAAFxAAAAFAAAABm2fPczU9TLzIAAAHcAAAASgAAAGBP9V5RY21hcAAAAkQAAACIAAABYt6F0cBjdnQgAAACzAAAAAQAAAAEABEBRGdhc3AAAAWYAAAACAAAAAj//wADZ2x5ZgAAAywAAADMAAAD2MHtryVoZWFkAAABbAAAADAAAAA2E2+eoWhoZWEAAAGcAAAAHwAAACQC9gDzaG10eAAAAigAAAAZAAAArgJkABFsb2NhAAAC0AAAAFoAAABaFQAUGG1heHAAAAG8AAAAHwAAACAAcABAbmFtZQAAA/gAAAE5AAACXvFdBwlwb3N0AAAFNAAAAGIAAACE5s74hXjaY2BkYGAAYpf5Hu/j+W2+MnAzMYDAzaX6QjD6/4//Bxj5GA8AuRwMYGkAPywL13jaY2BkYGA88P8Agx4j+/8fQDYfA1AEBWgDAIB2BOoAeNpjYGRgYNBh4GdgYgABEMnIABJzYNADCQAACWgAsQB42mNgYfzCOIGBlYGB0YcxjYGBwR1Kf2WQZGhhYGBiYGVmgAFGBiQQkOaawtDAoMBQxXjg/wEGPcYDDA4wNUA2CCgwsAAAO4EL6gAAeNpj2M0gyAACqxgGNWBkZ2D4/wMA+xkDdgAAAHjaY2BgYGaAYBkGRgYQiAHyGMF8FgYHIM3DwMHABGQrMOgyWDLEM1T9/w8UBfEMgLzE////P/5//f/V/xv+r4eaAAeMbAxwIUYmIMHEgKYAYjUcsDAwsLKxc3BycfPw8jEQA/gZBASFhEVExcQlJKWkZWTl5BUUlZRVVNXUNTQZBgMAAMR+E+gAEQFEAAAAKgAqACoANAA+AEgAUgBcAGYAcAB6AIQAjgCYAKIArAC2AMAAygDUAN4A6ADyAPwBBgEQARoBJAEuATgBQgFMAVYBYAFqAXQBfgGIAZIBnAGmAbIBzgHsAAB42u2NMQ6CUAyGW568x9AneYYgm4MJbhKFaExIOAVX8ApewSt4Bic4AfeAid3VOBixDxfPYEza5O+Xfi04YADggiUIULCuEJK8VhO4bSvpdnktHI5QCYtdi2sl8ZnXaHlqUrNKzdKcT8cjlq+rwZSvIVczNiezsfnP/uznmfPFBNODM2K7MTQ45YEAZqGP81AmGGcF3iPqOop0r1SPTaTbVkfUe4HXj97wYE+yNwWYxwWu4v1ugWHgo3S1XdZEVqWM7ET0cfnLGxWfkgR42o2PvWrDMBSFj/IHLaF0zKjRgdiVMwScNRAoWUoH78Y2icB/yIY09An6AH2Bdu/UB+yxopYshQiEvnvu0dURgDt8QeC8PDw7Fpji3fEA4z/PEJ6YOB5hKh4dj3EvXhxPqH/SKUY3rJ7srZ4FZnh1PMAtPhwP6fl2PMJMPDgeQ4rY8YT6Gzao0eAEA409DuggmTnFnOcSCiEiLMgxCiTI6Cq5DZUd3Qmp10vO0LaLTd2cjN4fOumlc7lUYbSQcZFkutRG7g6JKZKy0RmdLY680CDnEJ+UMkpFFe1RN7nxdVpXrC4aTtnaurOnYercZg2YVmLN/d/gczfEimrE/fs/bOuq29Zmn8tloORaXgZgGa78yO9/cnXm2BpaGvq25Dv9S4E9+5SIc9PqupJKhYFSSl47+Qcr1mYNAAAAeNptw0cKwkAAAMDZJA8Q7OUJvkLsPfZ6zFVERPy8qHh2YER+3i/BP83vIBLLySsoKimrqKqpa2hp6+jq6RsYGhmbmJqZSy0sraxtbO3sHRydnEMU4uR6yx7JJXveP7WrDycAAAAAAAH//wACeNpjYGRgYOABYhkgZgJCZgZNBkYGLQZtIJsFLMYAAAw3ALgAeNolizEKgDAQBCchRbC2sFER0YD6qVQiBCv/H9ezGI6Z5XBAw8CBK/m5iQQVauVbXLnOrMZv2oLdKFa8Pjuru2hJzGabmOSLzNMzvutpB3N42mNgZGBg4GKQYzBhYMxJLMlj4GBgAYow/P/PAJJhLM6sSoWKfWCAAwDAjgbRAAB42mNgYGBkAIIbCZo5IPrmUn0hGA0AO8EFTQAA") format("woff");
    font-weight: 400;
    font-style: normal
}

:root {
    --swiper-theme-color: #007aff
}

.swiper-container {
    margin-left: auto;
    margin-right: auto;
    position: relative;
    overflow: hidden;
    list-style: none;
    padding: 0;
    z-index: 1
}

.swiper-container-vertical>.swiper-wrapper {
    flex-direction: column
}

.swiper-wrapper {
    position: relative;
    width: 100%;
    height: 100%;
    z-index: 1;
    display: flex;
    transition-property: transform;
    box-sizing: content-box
}

.swiper-container-android .swiper-slide,.swiper-wrapper {
    transform: translateZ(0)
}

.swiper-container-multirow>.swiper-wrapper {
    flex-wrap: wrap
}

.swiper-container-multirow-column>.swiper-wrapper {
    flex-wrap: wrap;
    flex-direction: column
}

.swiper-container-free-mode>.swiper-wrapper {
    transition-timing-function: ease-out;
    margin: 0 auto
}

.swiper-slide {
    flex-shrink: 0;
    width: 100%;
    height: 100%;
    position: relative;
    transition-property: transform
}

.swiper-slide-invisible-blank {
    visibility: hidden
}

.swiper-container-autoheight,.swiper-container-autoheight .swiper-slide {
    height: auto
}

.swiper-container-autoheight .swiper-wrapper {
    align-items: flex-start;
    transition-property: transform,height
}

.swiper-container-3d {
    perspective: 1200px
}

.swiper-container-3d .swiper-cube-shadow,.swiper-container-3d .swiper-slide,.swiper-container-3d .swiper-slide-shadow-bottom,.swiper-container-3d .swiper-slide-shadow-left,.swiper-container-3d .swiper-slide-shadow-right,.swiper-container-3d .swiper-slide-shadow-top,.swiper-container-3d .swiper-wrapper {
    transform-style: preserve-3d
}

.swiper-container-3d .swiper-slide-shadow-bottom,.swiper-container-3d .swiper-slide-shadow-left,.swiper-container-3d .swiper-slide-shadow-right,.swiper-container-3d .swiper-slide-shadow-top {
    position: absolute;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    pointer-events: none;
    z-index: 10
}

.swiper-container-3d .swiper-slide-shadow-left {
    background-image: linear-gradient(270deg,rgba(0,0,0,.5),transparent)
}

.swiper-container-3d .swiper-slide-shadow-right {
    background-image: linear-gradient(90deg,rgba(0,0,0,.5),transparent)
}

.swiper-container-3d .swiper-slide-shadow-top {
    background-image: linear-gradient(0deg,rgba(0,0,0,.5),transparent)
}

.swiper-container-3d .swiper-slide-shadow-bottom {
    background-image: linear-gradient(180deg,rgba(0,0,0,.5),transparent)
}

.swiper-container-css-mode>.swiper-wrapper {
    overflow: auto;
    scrollbar-width: none;
    -ms-overflow-style: none
}

.swiper-container-css-mode>.swiper-wrapper::-webkit-scrollbar {
    display: none
}

.swiper-container-css-mode>.swiper-wrapper>.swiper-slide {
    scroll-snap-align: start start
}

.swiper-container-horizontal.swiper-container-css-mode>.swiper-wrapper {
    scroll-snap-type: x mandatory
}

.swiper-container-vertical.swiper-container-css-mode>.swiper-wrapper {
    scroll-snap-type: y mandatory
}

:root {
    --swiper-navigation-size: 44px
}

.swiper-button-next,.swiper-button-prev {
    position: absolute;
    top: 50%;
    width: calc(var(--swiper-navigation-size)/44*27);
    height: var(--swiper-navigation-size);
    margin-top: calc(var(--swiper-navigation-size)*-1/2);
    z-index: 10;
    cursor: pointer;
    display: flex;
    align-items: center;
    justify-content: center;
    color: var(--swiper-navigation-color,var(--swiper-theme-color))
}

.swiper-button-next.swiper-button-disabled,.swiper-button-prev.swiper-button-disabled {
    opacity: .35;
    cursor: auto;
    pointer-events: none
}

.swiper-button-next:after,.swiper-button-prev:after {
    font-family: swiper-icons;
    font-size: var(--swiper-navigation-size);
    text-transform: none!important;
    letter-spacing: 0;
    text-transform: none;
    font-variant: normal;
    line-height: 1
}

.swiper-button-prev,.swiper-container-rtl .swiper-button-next {
    left: 10px;
    right: auto
}

.swiper-button-prev:after,.swiper-container-rtl .swiper-button-next:after {
    content: "prev"
}

.swiper-button-next,.swiper-container-rtl .swiper-button-prev {
    right: 10px;
    left: auto
}

.swiper-button-next:after,.swiper-container-rtl .swiper-button-prev:after {
    content: "next"
}

.swiper-button-next.swiper-button-white,.swiper-button-prev.swiper-button-white {
    --swiper-navigation-color: #fff
}

.swiper-button-next.swiper-button-black,.swiper-button-prev.swiper-button-black {
    --swiper-navigation-color: #000
}

.swiper-button-lock {
    display: none
}

.swiper-pagination {
    position: absolute;
    text-align: center;
    transition: opacity .3s;
    transform: translateZ(0);
    z-index: 10
}

.swiper-pagination.swiper-pagination-hidden {
    opacity: 0
}

.swiper-container-horizontal>.swiper-pagination-bullets,.swiper-pagination-custom,.swiper-pagination-fraction {
    bottom: 10px;
    left: 0;
    width: 100%
}

.swiper-pagination-bullets-dynamic {
    overflow: hidden;
    font-size: 0
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet {
    transform: scale(.33);
    position: relative
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active,.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-main {
    transform: scale(1)
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-prev {
    transform: scale(.66)
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-prev-prev {
    transform: scale(.33)
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-next {
    transform: scale(.66)
}

.swiper-pagination-bullets-dynamic .swiper-pagination-bullet-active-next-next {
    transform: scale(.33)
}

.swiper-pagination-bullet {
    width: 8px;
    height: 8px;
    display: inline-block;
    border-radius: 100%;
    background: #000;
    opacity: .2
}

button.swiper-pagination-bullet {
    border: none;
    margin: 0;
    padding: 0;
    box-shadow: none;
    -webkit-appearance: none;
    -moz-appearance: none;
    appearance: none
}

.swiper-pagination-clickable .swiper-pagination-bullet {
    cursor: pointer
}

.swiper-pagination-bullet-active {
    opacity: 1;
    background: var(--swiper-pagination-color,var(--swiper-theme-color))
}

.swiper-container-vertical>.swiper-pagination-bullets {
    right: 10px;
    top: 50%;
    transform: translate3d(0,-50%,0)
}

.swiper-container-vertical>.swiper-pagination-bullets .swiper-pagination-bullet {
    margin: 6px 0;
    display: block
}

.swiper-container-vertical>.swiper-pagination-bullets.swiper-pagination-bullets-dynamic {
    top: 50%;
    transform: translateY(-50%);
    width: 8px
}

.swiper-container-vertical>.swiper-pagination-bullets.swiper-pagination-bullets-dynamic .swiper-pagination-bullet {
    display: inline-block;
    transition: transform .2s,top .2s
}

.swiper-container-horizontal>.swiper-pagination-bullets .swiper-pagination-bullet {
    margin: 0 4px
}

.swiper-container-horizontal>.swiper-pagination-bullets.swiper-pagination-bullets-dynamic {
    left: 50%;
    transform: translateX(-50%);
    white-space: nowrap
}

.swiper-container-horizontal>.swiper-pagination-bullets.swiper-pagination-bullets-dynamic .swiper-pagination-bullet {
    transition: transform .2s,left .2s
}

.swiper-container-horizontal.swiper-container-rtl>.swiper-pagination-bullets-dynamic .swiper-pagination-bullet {
    transition: transform .2s,right .2s
}

.swiper-pagination-progressbar {
    background: rgba(0,0,0,.25);
    position: absolute
}

.swiper-pagination-progressbar .swiper-pagination-progressbar-fill {
    background: var(--swiper-pagination-color,var(--swiper-theme-color));
    position: absolute;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    transform: scale(0);
    transform-origin: left top
}

.swiper-container-rtl .swiper-pagination-progressbar .swiper-pagination-progressbar-fill {
    transform-origin: right top
}

.swiper-container-horizontal>.swiper-pagination-progressbar,.swiper-container-vertical>.swiper-pagination-progressbar.swiper-pagination-progressbar-opposite {
    width: 100%;
    height: 4px;
    left: 0;
    top: 0
}

.swiper-container-horizontal>.swiper-pagination-progressbar.swiper-pagination-progressbar-opposite,.swiper-container-vertical>.swiper-pagination-progressbar {
    width: 4px;
    height: 100%;
    left: 0;
    top: 0
}

.swiper-pagination-white {
    --swiper-pagination-color: #fff
}

.swiper-pagination-black {
    --swiper-pagination-color: #000
}

.swiper-pagination-lock {
    display: none
}

.swiper-scrollbar {
    border-radius: 10px;
    position: relative;
    -ms-touch-action: none;
    background: rgba(0,0,0,.1)
}

.swiper-container-horizontal>.swiper-scrollbar {
    position: absolute;
    left: 1%;
    bottom: 3px;
    z-index: 50;
    height: 5px;
    width: 98%
}

.swiper-container-vertical>.swiper-scrollbar {
    position: absolute;
    right: 3px;
    top: 1%;
    z-index: 50;
    width: 5px;
    height: 98%
}

.swiper-scrollbar-drag {
    height: 100%;
    width: 100%;
    position: relative;
    background: rgba(0,0,0,.5);
    border-radius: 10px;
    left: 0;
    top: 0
}

.swiper-scrollbar-cursor-drag {
    cursor: move
}

.swiper-scrollbar-lock {
    display: none
}

.swiper-zoom-container {
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center
}

.swiper-zoom-container>canvas,.swiper-zoom-container>img,.swiper-zoom-container>svg {
    max-width: 100%;
    max-height: 100%;
    object-fit: contain
}

.swiper-slide-zoomed {
    cursor: move
}

.swiper-lazy-preloader {
    width: 42px;
    height: 42px;
    position: absolute;
    left: 50%;
    top: 50%;
    margin-left: -21px;
    margin-top: -21px;
    z-index: 10;
    transform-origin: 50%;
    animation: swiper-preloader-spin 1s linear infinite;
    box-sizing: border-box;
    border-radius: 50%;
    border: 4px solid var(--swiper-preloader-color,var(--swiper-theme-color));
    border-top: 4px solid transparent
}

.swiper-lazy-preloader-white {
    --swiper-preloader-color: #fff
}

.swiper-lazy-preloader-black {
    --swiper-preloader-color: #000
}

@keyframes swiper-preloader-spin {
    to {
        transform: rotate(1turn)
    }
}

.swiper-container .swiper-notification {
    position: absolute;
    left: 0;
    top: 0;
    pointer-events: none;
    opacity: 0;
    z-index: -1000
}

.swiper-container-fade.swiper-container-free-mode .swiper-slide {
    transition-timing-function: ease-out
}

.swiper-container-fade .swiper-slide {
    pointer-events: none;
    transition-property: opacity
}

.swiper-container-fade .swiper-slide .swiper-slide {
    pointer-events: none
}

.swiper-container-fade .swiper-slide-active,.swiper-container-fade .swiper-slide-active .swiper-slide-active {
    pointer-events: auto
}

.swiper-container-cube {
    overflow: visible
}

.swiper-container-cube .swiper-slide {
    pointer-events: none;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
    z-index: 1;
    visibility: hidden;
    transform-origin: 0 0;
    width: 100%;
    height: 100%
}

.swiper-container-cube .swiper-slide .swiper-slide {
    pointer-events: none
}

.swiper-container-cube.swiper-container-rtl .swiper-slide {
    transform-origin: 100% 0
}

.swiper-container-cube .swiper-slide-active,.swiper-container-cube .swiper-slide-active .swiper-slide-active {
    pointer-events: auto
}

.swiper-container-cube .swiper-slide-active,.swiper-container-cube .swiper-slide-next,.swiper-container-cube .swiper-slide-next+.swiper-slide,.swiper-container-cube .swiper-slide-prev {
    pointer-events: auto;
    visibility: visible
}

.swiper-container-cube .swiper-slide-shadow-bottom,.swiper-container-cube .swiper-slide-shadow-left,.swiper-container-cube .swiper-slide-shadow-right,.swiper-container-cube .swiper-slide-shadow-top {
    z-index: 0;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden
}

.swiper-container-cube .swiper-cube-shadow {
    position: absolute;
    left: 0;
    bottom: 0;
    width: 100%;
    height: 100%;
    background: #000;
    opacity: .6;
    -webkit-filter: blur(50px);
    filter: blur(50px);
    z-index: 0
}

.swiper-container-flip {
    overflow: visible
}

.swiper-container-flip .swiper-slide {
    pointer-events: none;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
    z-index: 1
}

.swiper-container-flip .swiper-slide .swiper-slide {
    pointer-events: none
}

.swiper-container-flip .swiper-slide-active,.swiper-container-flip .swiper-slide-active .swiper-slide-active {
    pointer-events: auto
}

.swiper-container-flip .swiper-slide-shadow-bottom,.swiper-container-flip .swiper-slide-shadow-left,.swiper-container-flip .swiper-slide-shadow-right,.swiper-container-flip .swiper-slide-shadow-top {
    z-index: 0;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden
}

.kk-text-field {
    --layout-template-columns: minmax(0,1fr);
    --input-height: 48px;
    display: grid;
    grid-template-rows: minmax(0,1fr);
    grid-template-columns: var(--layout-template-columns);
    gap: 8px;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    position: relative;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    vertical-align: middle;
    border-radius: 8px;
    border: 1px solid #d5d6db;
    background-color: #fff;
    height: var(--input-height);
    padding: 0 12px
}

.kk-text-field__leading-icon {
    color: #babbbe
}

.kk-text-field__native {
    cursor: inherit;
    padding: 0;
    outline: none;
    border: none;
    background: none;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    color: #212121;
    font-size: 14px;
    line-height: 20px;
    font-weight: 400
}

.kk-text-field__native::-webkit-input-placeholder {
    color: #babbbe
}

.kk-text-field__native::-moz-placeholder {
    color: #babbbe
}

.kk-text-field__native:-ms-input-placeholder {
    color: #babbbe
}

.kk-text-field__native::-ms-input-placeholder {
    color: #babbbe
}

.kk-text-field__native::placeholder {
    color: #babbbe
}

.kk-text-field__native:-moz-placeholder-shown {
    text-overflow: ellipsis
}

.kk-text-field__native:-ms-input-placeholder {
    text-overflow: ellipsis
}

.kk-text-field__native:placeholder-shown {
    text-overflow: ellipsis
}

.kk-text-field__trailing-container {
    display: grid;
    gap: 12px;
    grid-auto-flow: column;
    color: #9c9da0
}

.kk-text-field__delete-icon {
    padding: 2px;
    cursor: pointer
}

.kk-text-field__delete-icon:hover {
    color: #727272
}

.kk-text-field__trailing-icon {
    cursor: pointer
}

.kk-text-field__trailing-icon:hover {
    color: #212121
}

@media(pointer: fine) {
    .kk-text-field:not(.kk-text-field--disabled,.kk-text-field--search,.kk-text-field--error):hover {
        border-color:#212121;
        outline: #212121
    }
}

.kk-text-field:not(.kk-text-field--disabled,.kk-text-field--search,.kk-text-field--error):focus-within {
    border-color: #212121;
    outline: #212121
}

.kk-text-field--disabled {
    cursor: not-allowed;
    border-color: #e6e9ed;
    background-color: #f1f4f8
}

.kk-text-field--disabled .kk-text-field__native {
    color: #babbbe;
    -webkit-text-fill-color: #babbbe
}

.kk-text-field--disabled .kk-text-field__native::-webkit-input-placeholder {
    color: #babbbe
}

.kk-text-field--disabled .kk-text-field__native::-moz-placeholder {
    color: #babbbe
}

.kk-text-field--disabled .kk-text-field__native:-ms-input-placeholder {
    color: #babbbe
}

.kk-text-field--disabled .kk-text-field__native::-ms-input-placeholder {
    color: #babbbe
}

.kk-text-field--disabled .kk-text-field__native::placeholder {
    color: #babbbe
}

.kk-text-field--disabled .kk-text-field__trailing-icon {
    color: #babbbe
}

.kk-text-field--error {
    border-color: #e65f50
}

.kk-text-field--search {
    --input-height: 40px;
    padding: 0 16px;
    background-color: #f7fafc;
    border-radius: calc(var(--input-height)/2);
    border: none
}

.kk-text-field--search .kk-text-field__native::-webkit-search-cancel-button,.kk-text-field--search .kk-text-field__native::-webkit-search-decoration {
    display: none
}

.kk-text-field--search .kk-text-field__leading-icon {
    color: #212121
}

.kk-text-field--trailing {
    --layout-template-columns: minmax(0,1fr) auto
}

.kk-text-field--leading {
    --layout-template-columns: auto minmax(0,1fr)
}

.kk-text-field--leading.kk-text-field--trailing {
    --layout-template-columns: auto minmax(0,1fr) auto
}

</style>
