let cart = [];
let activeCategory = "all";




function showPage(name) {
    document.querySelectorAll(".page").forEach(page => {
        page.classList.remove("active");
    });


    const selectedPage = document.getElementById("page-" + name);


    if (!selectedPage) return;


    selectedPage.classList.add("active");


    document.querySelectorAll("nav ul a").forEach(link => {
        link.classList.remove("active");
    });


    const selectedLink = document.getElementById("link-" + name);


    if (selectedLink) {
        selectedLink.classList.add("active");
    }


    if (name === "payment") {
        updatePayment();
    }


    window.scrollTo({
        top: 0,
        behavior: "smooth"
    });
}




function addToCart(name, price) {


    const existingItem = cart.find(item => item.name === name);


    if (existingItem) {
        existingItem.quantity++;
    } else {
        cart.push({
            name: name,
            price: Number(price),
            quantity: 1
        });
    }


    updatePayment();


    alert(name + " successfully added to your cart! 🌸");
}


function updatePayment() {


    const list = document.getElementById("cartList");


    if (!list) return;


    let subtotal = cart.reduce((sum, item) => {
        return sum + (item.price * item.quantity);
    }, 0);


    let delivery = subtotal === 0 || subtotal >= 1000 ? 0 : 99;


    let total = subtotal + delivery;


    if (cart.length === 0) {


        list.innerHTML = `
            <p class="empty-message">
                Your cart is empty. Visit Shop Flowers
                to choose your bouquet. 🌷
            </p>
        `;


    } else {


        list.innerHTML = cart.map((item, index) => `
            <div class="cart-item">


                <div>
                    <strong>${item.name}</strong>
                    <p>₱${item.price.toLocaleString("en-PH")} × ${item.quantity}</p>


                    <div class="quantity-controls">
                        <button type="button"
                            onclick="changeQuantity(${index}, -1)">−</button>


                        <span>${item.quantity}</span>


                        <button type="button"
                            onclick="changeQuantity(${index}, 1)">+</button>
                    </div>
                </div>


                <div>
                    <strong>
                        ₱${(item.price * item.quantity).toLocaleString("en-PH")}
                    </strong>


                    <button type="button"
                        class="remove-btn"
                        onclick="removeItem(${index})">
                        ✖ Remove
                    </button>
                </div>


            </div>
        `).join("");


    }


    document.getElementById("subtotal").textContent =
        "₱" + subtotal.toLocaleString("en-PH");


    document.getElementById("deliveryFee").textContent =
        delivery === 0 ? "FREE" : "₱99";


    document.getElementById("cartTotal").textContent =
        "₱" + total.toLocaleString("en-PH");


    document.getElementById("cartCount").textContent =
        cart.reduce((sum, item) => sum + item.quantity, 0);
}


function changeQuantity(index, amount) {


    if (!cart[index]) return;


    cart[index].quantity += amount;


    if (cart[index].quantity <= 0) {
        cart.splice(index, 1);
    }


    updatePayment();
}




// REMOVE ITEM
// ========================================


function removeItem(index) {


    if (!cart[index]) return;


    cart.splice(index, 1);


    updatePayment();
}




function filterFlowers(category, button) {


    activeCategory = category;


    document.querySelectorAll(".filter button").forEach(btn => {
        btn.classList.remove("active");
    });


    button.classList.add("active");


    searchFlower();
}




function searchFlower() {


    const searchInput = document.getElementById("searchInput");


    if (!searchInput) return;


    const query = searchInput.value.toLowerCase().trim();


    const cards = document.querySelectorAll("#shopGrid .card");


    let visibleCount = 0;


    cards.forEach(card => {


        const name = (card.dataset.name || "").toLowerCase();


        const category = card.dataset.cat;


        const matchesSearch = name.includes(query);


        const matchesCategory =
            activeCategory === "all" ||
            category === activeCategory;


        if (matchesSearch && matchesCategory) {


            card.style.display = "";
            visibleCount++;


        } else {


            card.style.display = "none";


        }


    });


    document.getElementById("noResults").hidden =
        visibleCount !== 0;
}


function openImage(src) {


    let modal = document.getElementById("imageModal");


    if (!modal) {


        modal = document.createElement("div");


        modal.id = "imageModal";


        modal.innerHTML = `
            <button id="closeImage" aria-label="Close image">✕</button>
            <img id="modalImage" src="" alt="Flower preview">
        `;


        document.body.appendChild(modal);


        modal.addEventListener("click", function(event) {
            if (event.target === modal ||
                event.target.id === "closeImage") {
                closeImage();
            }
        });


        document.getElementById("modalImage").addEventListener(
            "click", event => event.stopPropagation()
        );
    }


    document.getElementById("modalImage").src = src;


    modal.style.display = "flex";
}


function closeImage() {


    const modal = document.getElementById("imageModal");


    if (modal) {
        modal.style.display = "none";
    }
}




document.getElementById("checkoutForm").addEventListener(
    "submit",
    function(event) {


        event.preventDefault();


        if (cart.length === 0) {
            alert("Your cart is empty! Please add flowers first. 🌷");
            return;
        }


        const name =
            document.getElementById("custName").value.trim();


        const phone =
            document.getElementById("custPhone").value.trim();


        const address =
            document.getElementById("custAddress").value.trim();


        const payment = document.querySelector(
            'input[name="paymentMethod"]:checked'
        );


        const deliveryDate =
            document.getElementById("deliveryDate").value;


        if (!name || !phone || !address || !payment || !deliveryDate) {


            alert("Please complete all required information.");
            return;


        }


        if (!/^09\d{9}$/.test(phone)) {


            alert("Please enter a valid 11-digit Philippine mobile number (09XXXXXXXXX).");
            return;


        }


        const today = new Date();
        today.setHours(0, 0, 0, 0);


        const chosenDate = new Date(deliveryDate + "T00:00:00");


        if (chosenDate < today) {
            alert("Please select today or a future delivery date.");
            return;
        }


        const subtotal = cart.reduce((sum, item) => {
            return sum + item.price * item.quantity;
        }, 0);


        const delivery = subtotal === 0 || subtotal >= 1000 ? 0 : 99;


        const total = subtotal + delivery;


        const message =
            document.getElementById("orderMessage").value.trim();


        const orderItems = cart.map(item => {
            return `${item.name} x ${item.quantity}`;
        }).join("\n");


        const orderDetails = `
🌸 CARMINA FLOWER SHOP
ORDER CONFIRMATION


Customer: ${name}
Phone: ${phone}
Address: ${address}


ORDER:
${orderItems}


Subtotal: ₱${subtotal.toLocaleString("en-PH")}
Delivery: ${delivery === 0 ? "FREE" : "₱99"}
TOTAL: ₱${total.toLocaleString("en-PH")}


Payment: ${payment.value}
Delivery Date: ${deliveryDate}


Special Message: ${message || "None"}


Thank you for choosing Carmina! 💐
        `;


        alert(orderDetails);


        alert(
            "Your order has been recorded! 🌷\n\nThank you, " +
            name + "! Please contact the shop to confirm your order."
        );


        cart = [];


        updatePayment();


        this.reset();


        showPage("home");
    }
);




function likeReview(button) {


    if (button.classList.contains("liked")) {
        return;
    }


    button.classList.add("liked");


    const count = button.querySelector("span");


    if (count) {
        count.textContent = Number(count.textContent) + 1;
    }
}




const music = document.getElementById("bgMusic");


const musicBtn = document.getElementById("musicBtn");


function toggleMusic() {
  var music = document.getElementById('bgMusic');
  var btn = document.getElementById('musicBtn');
  if (music.paused) {
    music.play();
    btn.innerHTML = '⏸ Pause Music';
  } else {
    music.pause();
    btn.innerHTML = '🎵 Play Music';
  }
}


updatePayment();


const dateInput = document.getElementById("deliveryDate");


if (dateInput) {


    const today = new Date();


    const localDate =
        today.getFullYear() + "-" +
        String(today.getMonth() + 1).padStart(2, "0") + "-" +
        String(today.getDate()).padStart(2, "0");


    dateInput.min = localDate;
}


/* 🌷 INTERACTIVE FLOWER MESSAGES */


function showFlowerMessage(flower) {


    const messages = {
        rose: {
            icon: "🌹",
            title: "Love & Romance",
            text: "Every rose represents love, affection, and beautiful moments. At Carmina, we create bouquets that help express what words cannot."
        },


        sunflower: {
            icon: "🌻",
            title: "Happiness & Joy",
            text: "Like a sunflower that follows the sunlight, we hope every Carmina bouquet brings happiness and sunshine to someone's day."
        },


        tulip: {
            icon: "🌷",
            title: "Care & Elegance",
            text: "Every tulip reminds us that simple things can be beautiful. We carefully prepare each arrangement with love and attention."
        },


        cherry: {
            icon: "🌸",
            title: "New Beginnings",
            text: "Every blossom represents new beginnings, sweet memories, and fresh opportunities to make someone smile."
        },


        white: {
            icon: "💮",
            title: "Pure & Sincere",
            text: "Flowers are more than gifts. They are thoughtful expressions of kindness, gratitude, and sincere appreciation."
        }
    };


    const selected = messages[flower];
    const messageBox = document.getElementById("gardenMessage");


    if (!selected || !messageBox) return;


    messageBox.innerHTML = `
        <span>${selected.icon}</span>
        <h3>${selected.title}</h3>
        <p>${selected.text}</p>
    `;


    messageBox.animate(
        [
            { opacity: 0, transform: "translate(-50%, -45%) scale(.9)" },
            { opacity: 1, transform: "translate(-50%, -50%) scale(1)" }
        ],
        {
            duration: 400,
            easing: "ease-out"
        }
    );
}


/* ===== REVIEW THANK YOU EFFECT ===== */


let thankyouPetalInterval = null;


function showReviewThanks() {
    const modal = document.getElementById("reviewThankYou");
    const petals = document.getElementById("thankyouPetals");


    if (!modal || !petals) return;


    modal.classList.add("show");


    clearInterval(thankyouPetalInterval);
    petals.innerHTML = "";


    const flowers = ["🌸", "🌷", "🌺", "✿", "✨"];


    function createPetal() {
        const petal = document.createElement("span");


        petal.className = "thankyou-petal";
        petal.textContent =
            flowers[Math.floor(Math.random() * flowers.length)];


        petal.style.left = Math.random() * 100 + "%";
        petal.style.fontSize = (15 + Math.random() * 20) + "px";
        petal.style.animationDuration = (3 + Math.random() * 4) + "s";


        petals.appendChild(petal);


        setTimeout(() => petal.remove(), 7500);
    }


    for (let i = 0; i < 15; i++) {
        setTimeout(createPetal, i * 100);
    }


    thankyouPetalInterval = setInterval(createPetal, 350);
}


function closeReviewThanks() {
    const modal = document.getElementById("reviewThankYou");


    if (!modal) return;


    modal.classList.remove("show");


    clearInterval(thankyouPetalInterval);
    thankyouPetalInterval = null;


    document.getElementById("thankyouPetals").innerHTML = "";
}

