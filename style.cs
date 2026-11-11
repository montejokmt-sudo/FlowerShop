* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}


body {
    font-family: Georgia, serif;
    background: #fff7f6;
    color: #453039;
    line-height: 1.6;
}


button, input, textarea, select {
    font-family: inherit;
}


button {
    cursor: pointer;
}


.topbar {
    background: #7b2334;
    color: white;
    text-align: center;
    padding: 10px 15px;
    font-size: 13px;
    letter-spacing: 1px;
}


nav {
    background: white;
    min-height: 85px;
    padding: 15px 5%;
    display: flex;
    align-items: center;
    justify-content: space-between;
    gap: 25px;
    position: sticky;
    top: 0;
    z-index: 99;
    box-shadow: 0 3px 15px #0000000c;
}


.logo {
    font-size: 23px;
    font-weight: bold;
    color: #7b2334;
    text-decoration: none;
    cursor: pointer;
    white-space: nowrap;
}


.logo small {
    display: block;
    font-size: 10px;
    letter-spacing: 2px;
    color: #999;
    font-weight: normal;
}


nav ul {
    list-style: none;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 25px;
    flex-wrap: wrap;
}


nav ul a {
    color: #555;
    text-decoration: none;
    cursor: pointer;
    font-size: 14px;
    padding-bottom: 7px;
}


nav ul a:hover,
nav ul a.active {
    color: #7b2334;
    border-bottom: 2px solid #7b2334;
}


.cart-btn {
    border: none;
    border-radius: 30px;
    padding: 11px 18px;
    color: #7b2334;
    background: #fdecea;
    font-weight: bold;
    white-space: nowrap;
}


.page {
    display: none;
    min-height: 65vh;
}


.page.active {
    display: block;
}


.hero {
    max-width: 1250px;
    margin: auto;
    padding: 75px 40px;
    display: grid;
    grid-template-columns: 1fr 1fr;
    align-items: center;
    gap: 65px;
}


.eyebrow {
    color: #a43a54;
    font-size: 13px;
    letter-spacing: 2px;
    margin-bottom: 15px;
}


.hero h1 {
    font-size: clamp(38px, 5vw, 60px);
    line-height: 1.15;
    color: #4a2230;
}


.hero h1 i {
    color: #a43a54;
}


.description {
    color: #777;
    margin: 22px 0;
    max-width: 500px;
}


.hero-image img {
    width: 100%;
    height: 440px;
    object-fit: cover;
    border-radius: 48% 48% 15px 15px;
    box-shadow: 0 15px 35px #7b233420;
}


.btn, .btn-outline {
    border: none;
    border-radius: 8px;
    padding: 13px 21px;
    font-size: 14px;
    transition: .3s;
}


.btn {
    background: #7b2334;
    color: white;
}


.btn:hover, .btn-full:hover {
    background: #a43a54;
    transform: translateY(-2px);
}


.btn-outline {
    background: white;
    color: #7b2334;
    border: 1px solid #7b2334;
    margin-left: 8px;
}


.btn-outline:hover {
    background: #fdecea;
}


.hero-note {
    color: #a43a54;
    font-size: 12px;
    margin-top: 25px;
}


.features {
    max-width: 1150px;
    margin: 0 auto 55px;
    padding: 0 25px;
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 25px;
}


.feature {
    background: white;
    text-align: center;
    padding: 30px 20px;
    border-radius: 15px;
    box-shadow: 0 5px 20px #00000008;
}


.feature span {
    font-size: 32px;
}


.feature h3 {
    color: #7b2334;
    margin: 8px 0;
}


.feature p {
    color: #888;
    font-size: 13px;
}


.container {
    max-width: 1200px;
    padding: 65px 30px;
    margin: auto;
}


.section-heading {
    text-align: center;
    margin-bottom: 35px;
}


.section-heading h1,
.section-heading h2 {
    color: #4a2230;
    margin-bottom: 8px;
}


.section-heading p {
    color: #888;
}


.grid {
    display: grid;
    grid-template-columns: repeat(3, minmax(0, 1fr));
    gap: 28px;
}


.card {
    background: white;
    padding: 17px;
    border-radius: 15px;
    text-align: center;
    box-shadow: 0 5px 20px #0000000a;
    transition: .3s;
}


.card:hover {
    transform: translateY(-6px);
    box-shadow: 0 12px 28px #7b233420;
}


.card img {
    width: 100%;
    height: 230px;
    object-fit: cover;
    border-radius: 11px;
}


.card h3 {
    margin-top: 15px;
    color: #4a2230;
}


.card p {
    color: #888;
    font-size: 13px;
}


.price {
    color: #7b2334;
    font-size: 20px;
    font-weight: bold;
    margin: 13px 0;
}


.card .btn {
    width: 100%;
}


.filter {
    display: flex;
    justify-content: center;
    gap: 12px;
    flex-wrap: wrap;
    margin: 25px 0;
}


.filter button {
    background: white;
    border: 1px solid #7b2334;
    color: #7b2334;
    padding: 10px 22px;
    border-radius: 30px;
}


.filter button.active,
.filter button:hover {
    background: #7b2334;
    color: white;
}


.search {
    display: block;
    max-width: 450px;
    margin: 0 auto 35px;
    padding: 14px;
    border: 1px solid #e5cbd0;
    border-radius: 8px;
    width: 100%;
    outline-color: #7b2334;
}


.review-card {
    background: white;
    border-radius: 15px;
    padding: 30px 22px;
    text-align: center;
    line-height: 1.8;
    box-shadow: 0 5px 20px #00000008;
}


.review-card p {
    margin: 15px 0;
}


.review-card h3 {
    color: #7b2334;
}


.review-card small {
    color: #999;
}


.about-box, .form-box {
    max-width: 750px;
    margin: 65px auto;
    padding: 45px;
    background: white;
    border-radius: 18px;
    box-shadow: 0 8px 30px #0000000c;
}


.about-box h1 {
    color: #7b2334;
    margin-bottom: 20px;
}


.about-box h3 {
    color: #7b2334;
    margin: 25px 0 10px;
}


.form-box {
    max-width: 650px;
}


.form-box h1 {
    color: #7b2334;
}


.muted {
    color: #888;
    margin: 8px 0 20px;
}


input, select, textarea {
    width: 100%;
    padding: 14px;
    margin: 9px 0;
    border: 1px solid #e4d5d8;
    border-radius: 8px;
    outline-color: #7b2334;
    background: white;
}


textarea {
    min-height: 100px;
    resize: vertical;
}


.cart-list {
    background: #fff1f1;
    padding: 18px;
    border-radius: 10px;
    margin: 20px 0;
}


.cart-item {
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap: 10px;
    padding: 10px 0;
    border-bottom: 1px solid #efd9dd;
}


.remove-btn {
    background: none;
    border: none;
    color: #c03950;
    font-size: 14px;
}


.total-row {
    display: flex;
    justify-content: space-between;
    padding: 10px 0;
}


.grand-total {
    border-top: 1px solid #ddd;
    font-size: 19px;
    color: #7b2334;
    margin-bottom: 15px;
}


.btn-full {
    width: 100%;
    background: #7b2334;
    color: white;
    border: none;
    padding: 15px;
    border-radius: 8px;
    font-size: 16px;
    margin-top: 12px;
}


.order-message {
    color: #7b2334;
    text-align: center;
    font-weight: bold;
    margin-top: 15px;
}


.empty-message {
    text-align: center;
    color: #888;
}


footer {
    background: #4a2230;
    color: white;
    padding: 55px 8%;
    display: grid;
    grid-template-columns: 2fr 1fr 1.5fr;
    gap: 40px;
}


footer h2, footer h3 {
    color: #ffb6c1;
    margin-bottom: 15px;
}


footer p, footer a {
    color: #eee;
    font-size: 14px;
    line-height: 2;
}


footer a {
    display: block;
    text-decoration: none;
    cursor: pointer;
}


footer a:hover {
    color: #ffb6c1;
}


@media (max-width: 900px) {
    nav {
        flex-wrap: wrap;
        justify-content: center;
    }


    .hero {
        gap: 30px;
    }


    .grid {
        grid-template-columns: repeat(2, minmax(0, 1fr));
    }
}


@media (max-width: 600px) {
    .topbar {
        font-size: 10px;
    }


    nav {
        padding: 18px 12px;
        gap: 15px;
    }


    nav ul {
        gap: 13px;
    }


    nav ul a {
        font-size: 12px;
    }


    .hero {
        grid-template-columns: 1fr;
        padding: 45px 22px;
        text-align: center;
    }


    .hero-image img {
        height: 300px;
    }


    .hero h1 {
        font-size: 38px;
    }


    .features {
        grid-template-columns: 1fr;
    }


    .grid {
        grid-template-columns: 1fr;
    }


    .container {
        padding: 40px 18px;
    }


    .about-box, .form-box {
        margin: 30px 15px;
        padding: 25px 18px;
    }


    footer {
        grid-template-columns: 1fr;
        padding: 40px 25px;
        gap: 25px;
    }
}


/* GOOGLE MAPS */


.map-section {
    margin-top: 35px;
    text-align: center;
}


.map-section h2 {
    color: #7b2334;
    margin-bottom: 10px;
}


.map-section p {
    color: #888;
    margin-bottom: 20px;
}


.map-container {
    width: 100%;
    overflow: hidden;
    border-radius: 15px;
    box-shadow: 0 8px 25px rgba(0,0,0,0.12);
}


.map-container iframe {
    display: block;
    width: 100%;
    height: 400px;
}


.map-button {
    display: inline-block;
    margin-top: 20px;
    padding: 12px 22px;
    background: #7b2334;
    color: white;
    text-decoration: none;
    border-radius: 8px;
    transition: .3s;
}


.map-button:hover {
    background: #a43a54;
    transform: translateY(-3px);
}


@media (max-width: 600px) {
    .map-container iframe {
        height: 280px;
    }
}


/* ===== PREMIUM CHECKOUT ===== */


.checkout-heading {
    text-align: center;
    margin: 35px auto;
}


.checkout-heading span {
    color: #a64d69;
    font-size: 12px;
    letter-spacing: 3px;
    font-weight: bold;
}


.checkout-heading h1 {
    color: #852d4b;
    font-size: 38px;
    margin: 10px 0;
}


.checkout-heading p {
    color: #92747c;
}


/* TWO COLUMN LAYOUT */


.checkout-layout {
    max-width: 1150px;
    margin: auto;
    padding: 20px;
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 25px;
    align-items: start;
}


/* CARDS */


.checkout-summary,
.checkout-payment {
    background: #ffffff;
    padding: 28px;
    border-radius: 18px;
    box-shadow: 0 8px 30px rgba(130, 50, 75, 0.09);
    border: 1px solid #f4dce3;
}


.checkout-summary h2,
.checkout-payment h2 {
    color: #852d4b;
    margin-top: 0;
    font-size: 23px;
}


.checkout-subtitle {
    color: #997e85;
    margin-bottom: 25px;
}


/* CART PRODUCT AREA */


#cartList {
    display: flex;
    flex-direction: column;
    gap: 15px;
    min-height: 100px;
}


.summary-breakdown {
    margin-top: 25px;
    border-top: 1px solid #f0dce2;
    padding-top: 18px;
}


.summary-breakdown div {
    display: flex;
    justify-content: space-between;
    margin-bottom: 17px;
    color: #65434d;
}


.grand-total {
    border-top: 1px solid #ead1d9;
    padding-top: 18px;
    font-size: 21px;
    color: #8c294a !important;
    font-weight: bold;
}


/* INPUTS */


.checkout-payment input:not([type="radio"]),
.checkout-payment textarea {
    width: 100%;
    padding: 14px;
    border: 1px solid #e8cbd4;
    border-radius: 10px;
    margin: 9px 0 19px;
    font-family: inherit;
    font-size: 14px;
    box-sizing: border-box;
    outline: none;
}


.checkout-payment input:focus,
.checkout-payment textarea:focus {
    border-color: #b65c79;
    box-shadow: 0 0 0 3px rgba(182, 92, 121, .10);
}


.checkout-payment textarea {
    min-height: 90px;
    resize: vertical;
}


.checkout-payment label {
    color: #714252;
    font-weight: 600;
}


/* PAYMENT OPTIONS */


.payment-options {
    display: grid;
    gap: 10px;
    margin: 12px 0 22px;
}


.payment-card {
    display: flex;
    align-items: center;
    gap: 12px;
    padding: 15px;
    border: 1px solid #ead2da;
    border-radius: 10px;
    cursor: pointer;
    transition: .3s;
}


.payment-card:hover {
    background: #fff1f4;
    border-color: #b65c79;
}


.payment-card input {
    accent-color: #a34362;
}


/* PLACE ORDER */


.place-order-btn {
    width: 100%;
    padding: 17px;
    background: linear-gradient(135deg, #a84968, #76263f);
    border: none;
    border-radius: 12px;
    color: white;
    font-size: 16px;
    font-weight: bold;
    cursor: pointer;
    transition: .3s;
    margin-top: 15px;
}


.place-order-btn:hover {
    transform: translateY(-3px);
    box-shadow: 0 8px 20px rgba(130, 40, 70, .25);
}


/* MOBILE RESPONSIVE */


@media(max-width: 850px) {
    .checkout-layout {
        grid-template-columns: 1fr;
    }


    .checkout-heading h1 {
        font-size: 29px;
    }
}


@media(max-width: 480px) {
    .checkout-summary,
    .checkout-payment {
        padding: 18px;
    }
}


#page-reviews {
    background: #fff7f7;
    padding: 55px 5%;
    box-sizing: border-box;
    width: 100%;
    overflow: hidden;
}


.reviews-header {
    text-align: center;
    margin-bottom: 35px;
}


.reviews-label {
    color: #ad6179;
    font-size: 12px;
    letter-spacing: 3px;
    font-weight: bold;
}


.reviews-header h1 {
    font-size: 38px;
    color: #68283d;
    margin: 12px 0;
}


.reviews-header p {
    color: #92777f;
}


/* RATING SUMMARY */


.rating-summary {
    max-width: 850px;
    margin: 0 auto 40px;
    padding: 30px;
    background: white;
    border-radius: 20px;
    display: grid;
    grid-template-columns: 1fr 2fr;
    gap: 35px;
    box-shadow: 0 8px 30px rgba(100, 40, 60, .07);
}


.rating-main {
    text-align: center;
    border-right: 1px solid #f0dce2;
    padding: 15px;
}


.rating-main h2 {
    font-size: 55px;
    color: #852d4b;
    margin: 0;
}


.rating-main h2 span {
    font-size: 20px;
    color: #997b84;
}


.stars,
.review-stars {
    color: #f2b52c;
    letter-spacing: 3px;
    font-size: 21px;
}


.rating-main p {
    color: #92777f;
    font-size: 13px;
}


/* RATING BARS */


.rating-breakdown {
    display: flex;
    flex-direction: column;
    justify-content: center;
    gap: 12px;
}


.rating-row {
    display: grid;
    grid-template-columns: 35px 1fr 40px;
    gap: 10px;
    align-items: center;
    color: #76545f;
    font-size: 13px;
}


.rating-bar {
    height: 9px;
    background: #f6e6eb;
    border-radius: 20px;
    overflow: hidden;
}


.rating-bar div {
    height: 100%;
    background: linear-gradient(90deg, #d77f9b, #852d4b);
    border-radius: 20px;
}


/* REVIEW GRID */


.reviews-grid {
    max-width: 1200px;
    margin: auto;
    display: grid;
    grid-template-columns: repeat(3, minmax(0, 1fr));
    gap: 24px;
}


/* REVIEW CARD */


.review-card {
    background: white;
    border: 1px solid #f4e3e8;
    border-radius: 18px;
    padding: 25px;
    box-shadow: 0 7px 22px rgba(100, 40, 60, .06);
    transition: .3s ease;
}


.review-card:hover {
    transform: translateY(-6px);
    box-shadow: 0 12px 28px rgba(100, 40, 60, .12);
}


.review-top {
    display: flex;
    align-items: center;
    gap: 12px;
}


.customer-avatar {
    width: 45px;
    height: 45px;
    flex-shrink: 0;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    background: #f8dce5;
    color: #852d4b;
    font-size: 19px;
    font-weight: bold;
}


.review-top h3 {
    margin: 0 0 5px;
    color: #702d43;
    font-size: 17px;
}


.review-top span:not(.review-date) {
    color: #4e9670;
    font-size: 11px;
}


.review-date {
    margin-left: auto;
    font-size: 11px;
    color: #a38d94;
}


.review-stars {
    margin-top: 20px;
}


.review-message {
    color: #65434d;
    font-size: 14px;
    line-height: 1.8;
    min-height: 75px;
    margin: 15px 0;
}


.purchased-product {
    background: #fff3f5;
    border-radius: 9px;
    padding: 11px;
    color: #91445d;
    font-size: 13px;
}


.review-bottom {
    border-top: 1px solid #f3e5e9;
    padding-top: 15px;
    margin-top: 18px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    color: #9b7b85;
    font-size: 12px;
}


.helpful-btn {
    border: 1px solid #f0d4dd;
    background: white;
    color: #a34260;
    border-radius: 20px;
    padding: 7px 13px;
    cursor: pointer;
    transition: .2s;
}


.helpful-btn:hover {
    background: #fff0f4;
}


.helpful-btn.liked {
    background: #f9dce5;
    color: #8c294a;
}


/* RESPONSIVE */


@media(max-width: 900px) {
    .reviews-grid {
        grid-template-columns: repeat(2, minmax(0, 1fr));
    }
}


@media(max-width: 600px) {
    #page-reviews {
        padding: 35px 15px;
    }


    .reviews-header h1 {
        font-size: 29px;
    }


    .rating-summary {
        grid-template-columns: 1fr;
        gap: 15px;
        padding: 20px;
    }


    .rating-main {
        border-right: none;
        border-bottom: 1px solid #f0dce2;
    }


    .reviews-grid {
        grid-template-columns: 1fr;
    }
}


#musicBtn {
    position: fixed;
    bottom: 25px;
    right: 25px;
    background: #d87093;
    color: white;
    border: none;
    padding: 13px 22px;
    border-radius: 30px;
    cursor: pointer;
    font-size: 15px;
    box-shadow: 0 4px 12px rgba(0,0,0,0.2);
    z-index: 999;
}


#musicBtn:hover {
    background: #c05078;
    transform: scale(1.05);
}


.flower-garden-section {
    padding: 85px 20px;
    text-align: center;
    background: linear-gradient(
        180deg,
        #fff8fa,
        #fce4ec,
        #fff1f5
    );
    overflow: hidden;
}


.garden-heading span {
    color: #a43a54;
    letter-spacing: 3px;
    font-size: 13px;
    font-weight: bold;
}


.garden-heading h2 {
    color: #7b2334;
    font-family: Georgia, serif;
    font-size: clamp(27px, 4vw, 42px);
    margin: 15px 0;
}


.garden-heading p {
    color: #79515d;
    max-width: 550px;
    margin: auto;
    line-height: 1.8;
}


.interactive-garden {
    position: relative;
    max-width: 850px;
    min-height: 430px;
    margin: 45px auto 20px;
    border-radius: 30px;
    overflow: hidden;
    background:
        radial-gradient(circle at 50% 20%,
        rgba(255,255,255,.95),
        transparent 55%),
        linear-gradient(180deg, #f9dce8, #f4c6d8);
    box-shadow: 0 15px 40px rgba(123,35,52,.13);
}


.garden-flower {
    position: absolute;
    z-index: 3;
    border: none;
    background: rgba(255,255,255,.35);
    border-radius: 50%;
    width: 100px;
    height: 100px;
    font-size: 48px;
    cursor: pointer;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    gap: 3px;
    transition: .4s;
    animation: gardenFloat 3s ease-in-out infinite;
}


.garden-flower span {
    font-size: 12px;
    color: #7b2334;
    font-weight: bold;
}


.garden-flower:hover {
    transform: scale(1.2) rotate(8deg);
    background: white;
    box-shadow: 0 0 25px #ff9dbd;
}


.rose {
    top: 35px;
    left: 12%;
}


.sunflower {
    top: 145px;
    left: 34%;
    animation-delay: .5s;
}


.tulip {
    top: 35px;
    right: 12%;
    animation-delay: 1s;
}


.cherry {
    bottom: 85px;
    left: 15%;
    animation-delay: .8s;
}


.white {
    bottom: 85px;
    right: 15%;
    animation-delay: 1.2s;
}


@keyframes gardenFloat {
    0%, 100% { margin-top: 0; }
    50% { margin-top: -10px; }
}


.garden-message {
    position: absolute;
    z-index: 4;
    width: min(310px, 75%);
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    padding: 18px;
    border-radius: 20px;
    background: rgba(255,255,255,.85);
    backdrop-filter: blur(8px);
    box-shadow: 0 8px 25px rgba(123,35,52,.12);
    transition: .3s;
}


.garden-message span {
    font-size: 30px;
}


.garden-message h3 {
    color: #7b2334;
    margin: 8px 0;
    font-family: Georgia, serif;
}


.garden-message p {
    color: #79515d;
    line-height: 1.6;
    font-size: 14px;
}


.garden-grass {
    position: absolute;
    bottom: 0;
    height: 30px;
    width: 100%;
    background: linear-gradient(90deg, #a8bd8b, #c1d69e, #91b27c);
}


.garden-sparkles {
    position: absolute;
    top: 15%;
    left: 50%;
    color: white;
    font-size: 35px;
    text-shadow: 0 0 15px white;
    animation: gardenTwinkle 2s infinite alternate;
}


@keyframes gardenTwinkle {
    from { opacity: .2; transform: scale(.7) rotate(0); }
    to { opacity: 1; transform: scale(1.3) rotate(45deg); }
}


.garden-footer {
    color: #9b5268;
    font-family: Georgia, serif;
    font-style: italic;
    margin-top: 20px;
}


@media(max-width: 600px) {
    .interactive-garden {
        min-height: 480px;
    }


    .garden-flower {
        width: 75px;
        height: 75px;
        font-size: 36px;
    }


    .rose { left: 4%; }
    .sunflower { left: 37%; top: 125px; }
    .tulip { right: 4%; }
    .cherry { left: 5%; bottom: 65px; }
    .white { right: 5%; bottom: 65px; }


    .garden-message {
        width: 48%;
        padding: 12px 7px;
    }


    .garden-message h3 {
        font-size: 15px;
    }


    .garden-message p {
        font-size: 11px;
    }
}

.review-thankyou {
    display: none;
    position: fixed;
    inset: 0;
    z-index: 10001;
    background: rgba(67, 25, 43, .78);
    backdrop-filter: blur(7px);
    align-items: center;
    justify-content: center;
    padding: 20px;
    overflow: hidden;
}


.review-thankyou.show {
    display: flex;
    animation: thankyouFade .5s ease;
}


.thankyou-card {
    position: relative;
    z-index: 3;
    width: 100%;
    max-width: 440px;
    padding: 40px 25px;
    text-align: center;
    background: linear-gradient(145deg, #fffafd, #ffe8f0);
    border: 2px solid #f3bfd1;
    border-radius: 28px;
    box-shadow: 0 15px 55px rgba(0,0,0,.25);
    animation: thankyouPop .7s cubic-bezier(.2,.8,.3,1.3);
}


.thankyou-flower {
    font-size: 65px;
    animation: flowerBounce 2s ease-in-out infinite;
}


.thankyou-stars {
    color: #e8a52b;
    font-size: 28px;
    letter-spacing: 5px;
    margin: 12px 0;
    animation: starGlow 1.5s infinite alternate;
}


.thankyou-card h2 {
    color: #922d50;
    font-family: Georgia, serif;
    font-size: 30px;
    margin: 12px 0;
}


.thankyou-subtitle {
    color: #bd6085;
    font-weight: bold;
    font-style: italic;
}


.thankyou-message {
    color: #75515f;
    font-size: 14px;
    line-height: 1.8;
    margin: 20px 0;
}


.thankyou-decoration {
    font-size: 25px;
    margin: 20px 0;
}


.thankyou-card button {
    border: none;
    border-radius: 30px;
    padding: 14px 25px;
    background: linear-gradient(135deg, #a13f66, #df86a7);
    color: white;
    font-weight: bold;
    cursor: pointer;
    transition: .3s;
}


.thankyou-card button:hover {
    transform: translateY(-4px);
    box-shadow: 0 8px 20px #d98aa855;
}


.thankyou-petal {
    position: absolute;
    top: -40px;
    pointer-events: none;
    animation: thankyouFall linear forwards;
}


@keyframes thankyouFade {
    from { opacity: 0; }
    to { opacity: 1; }
}


@keyframes thankyouPop {
    from {
        opacity: 0;
        transform: scale(.65) translateY(40px);
    }
    to {
        opacity: 1;
        transform: scale(1) translateY(0);
    }
}


@keyframes flowerBounce {
    0%, 100% { transform: translateY(0) rotate(-8deg); }
    50% { transform: translateY(-12px) rotate(8deg); }
}


@keyframes starGlow {
    from { text-shadow: 0 0 3px #ffd56b; }
    to { text-shadow: 0 0 15px #e8a52b; }
}


@keyframes thankyouFall {
    0% {
        transform: translateY(-30px) rotate(0);
        opacity: 0;
    }
    15% { opacity: 1; }
    100% {
        transform: translateY(110vh) rotate(360deg);
        opacity: 0;
    }
}


@media(max-width:480px) {
    .thankyou-card {
        padding: 30px 18px;
    }


    .thankyou-card h2 {
        font-size: 25px;
    }
}


@media(prefers-reduced-motion: reduce) {
    .thankyou-card,
    .thankyou-flower,
    .thankyou-stars {
        animation: none;
    }


    .thankyou-petal {
        display: none;
    }
}
.customer-avatar {
    width: 55px;
    height: 55px;
    border-radius: 50%;
    overflow: hidden;
    flex-shrink: 0;
}

.customer-avatar img {
    width: 100%;
    height: 100%;
    object-fit: cover;
    border-radius: 50%;
}


.owner-section {
    padding: 80px 7%;
    background: #fff4f5;
}

.owner-container {
    display: flex;
    align-items: center;
    gap: 50px;
    max-width: 1100px;
    margin: auto;
}

.owner-photo {
    flex: 1;
    height: 420px;
    overflow: hidden;
    border-radius: 25px;
    box-shadow: 0 10px 30px rgba(120, 30, 60, 0.12);
}

.owner-photo img {
    width: 100%;
    height: 100%;
    object-fit: cover;
}

.owner-content {
    flex: 1;
}

.owner-label {
    color: #b33b61;
    font-size: 12px;
    letter-spacing: 3px;
}

.owner-content h2 {
    color: #572536;
    font-size: 42px;
    margin: 15px 0;
}

.owner-content h3 {
    color: #ad4562;
    font-size: 20px;
    margin-bottom: 20px;
}

.owner-content p {
    color: #765d65;
    line-height: 1.9;
    margin-bottom: 15px;
}

.owner-message {
    background: white;
    border-left: 4px solid #c34c70;
    padding: 18px;
    margin-top: 20px;
    color: #85334e;
    font-style: italic;
    line-height: 1.7;
}

.owner-signature {
    display: block;
    margin-top: 20px;
    color: #a52d55;
    font-style: italic;
    font-size: 18px;
}

@media (max-width: 768px) {
    .owner-container {
        flex-direction: column;
    }

    .owner-photo {
        width: 100%;
        height: 350px;
    }

    .owner-content h2 {
        font-size: 32px;
    }
}
.facebook-link {
    color: #ffffff;
    text-decoration: none;
    transition: 0.3s;
}

.facebook-link:hover {
    color: #ff9fbd;
    text-decoration: underline;
}