console.log("Welcome to the Community Portal");

window.addEventListener("load", () => {
    console.log("Community Portal Loaded Successfully!");
});

// Smooth Scrolling For Navigation

document.querySelectorAll('a[href^="#"]').forEach(link => {
    link.addEventListener('click', function (e) {
        const target = document.querySelector(this.getAttribute('href'));

        if (target) {
            e.preventDefault();
            target.scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
        }
    });
});

const portalName = "Local Community Event Portal";
const portalLaunchDate = "2026-01-01";
let sampleSeats = 100;
sampleSeats--;
console.log(`${portalName} | Launch: ${portalLaunchDate} | Seats: ${sampleSeats}`);

//Event class
class Event {
    constructor(name, category, date, seats) {
        this.name = name;
        this.category = category;
        this.date = date;
        this.seats = seats;
    }
}

Event.prototype.checkAvailability = function () {
    if (this.seats > 0) {
        console.log(`${this.name} has seats available.`);
    } else {
        console.log(`${this.name} is fully booked.`);
    }
}

const events = [];

function registrationTracker() {
    let totalRegistrations = 0;

    return function () {
        totalRegistrations++;
        console.log(`Total Registrations: ${totalRegistrations}`);
    };
}

const trackRegistrations = registrationTracker();

// Add New Event
function addEvent(name, category, date, seats) {

    const newEvent = new Event(name, category, date, seats);
    events.push(newEvent);

    console.log(`${name} added successfully.`);
}


// Filter Events By Category
function filterEventsByCategory(category, callback) {

    const filteredEvents = events.filter(function (event) {

        return event.category === category;

    });

    callback(filteredEvents);

}


// Display Filtered Events
function displayFilteredEvents(filteredEvents) {

    console.log("Filtered Events:");

    filteredEvents.forEach(function (event) {

        console.log(`
Event: ${event.name}
Category: ${event.category}
Date: ${event.date}
Seats: ${event.seats}
`);

    });

}

// Add Events
addEvent("Coding Bootcamp", "Technology", "2026-09-10", 45);
addEvent("Dance Night", "Music", "2026-10-12", 70);

events[0].block = "blockA";
events[0].location = "Block A (Main Block)";

events[1].block = "blockB";
events[1].location = "Block B (Beside Block A)";

// Filter Music Events
filterEventsByCategory("Music", displayFilteredEvents);


// Create Event Objects
const event1 = new Event(
    "Photography Workshop",
    "Art",
    "2026-11-05",
    25
);

const event2 = new Event(
    "Rock Concert",
    "Music",
    "2026-12-15",
    0
);


// Check Availability
event1.checkAvailability();
event2.checkAvailability();


// Display Object Keys & Values
console.log("Event Details:");

Object.entries(event1).forEach(function ([key, value]) {

    console.log(`${key}: ${value}`);

});


const eventsContainer = document.querySelector("#eventsContainer");

function displayEvents(filteredEvents = events) {

    eventsContainer.innerHTML = "";

    filteredEvents.forEach(function (event, index) {

        const card = document.createElement("div");

        card.classList.add("event-card");

        card.innerHTML = `
    <h3>${event.name}</h3>
    <p><strong>Category:</strong> ${event.category}</p>
    <p><strong>Date:</strong> ${event.date}</p>
    <p><strong>Location:</strong> ${event.location || "Community Hall"}</p>
    <p><strong>Available Seats:</strong> ${event.seats}</p>
    <button onclick="registerForEvent(${index})">
        Register Now
    </button>
`;

        eventsContainer.appendChild(card);

    });
}

function registerForEvent(index) {

    try {

        if (!events[index]) {
            throw new Error("Event not found");
        }

        if (events[index].seats <= 0) {
            throw new Error("No seats available");
        }

        events[index].seats--;

        trackRegistrations();

        console.table(events);

        displayEvents();

        alert(`Successfully registered for ${events[index].name}`);

    } catch (error) {

        console.error("Registration Error:", error.message);
        alert(error.message);

    }
}

// Initial Render
displayEvents();


const loader = document.getElementById("loader");

function fetchEvents() {
    loader.style.display = "block";

    return new Promise(function (resolve, reject) {
        setTimeout(function () {
            const success = true;

            if (success) {

                const fetchedEvents = [
                    new Event(
                        "Gaming Tournament",
                        "Technology",
                        "2026-11-20",
                        80
                    ),

                    new Event(
                        "Classical Music Night",
                        "Music",
                        "2026-12-05",
                        60
                    )
                ];
                fetchedEvents[0].block = "blockC";
                fetchedEvents[0].location = "Block C (Near to Block A)";

                fetchedEvents[1].block = "blockB";
                fetchedEvents[1].location = "Block B (Beside Block A)";
                resolve(fetchedEvents);
            }

            else {
                reject("Failed to fetch events.");
            }
        }, 2000);
    });
}

fetchEvents()
    .then(function (data) {
        loader.style.display = "none";

        console.log("Fetched Events:", data);

        data.forEach(function (event) {
            events.push(event);
        });
        displayEvents();
    })
    .catch(function (error) {
        loader.style.display = "none";
        console.error("Error fetching events:", error);
    });

    async function loadEventsAsync() {
        try {
            loader.style.display = "block";
            const data = await fetchEvents();
            console.log("Async Events:", data);
        } catch (error) {
            loader.style.display = "none";
            console.error("Error fetching events:", error);
        } finally {
            loader.style.display = "none";
        }
    }

loadEventsAsync();

// Default Parameters
function createEvent(
    name = "New Event",
    category = "General",
    date = "2026-01-01",
    seats = 50
) {
    return new Event(name, category, date, seats);
}

const defaultEvent = createEvent();
console.log("Default Event:", defaultEvent);

// Destructuring
const { name, category, date, seats } = event1;
console.log(name, category, date, seats);

// Spread Operator
const clonedEvents = [...events];
console.log("Cloned Events:", clonedEvents);

// Map Example
const eventCardsData = events.map((event) => {
    return `Workshop: ${event.name}`;
});

console.log("Mapped Events:", eventCardsData);

// Arrow Function Example
events.forEach((event) => {
    console.log(event.name);
});

// Event Handling Module
const searchInput = document.querySelector("#searchInput");
const categoryFilter = document.querySelector("#categoryFilter");
const registrationForm = document.querySelector("#registrationForm");
const formMessage = document.querySelector("#formMessage");

if (categoryFilter) {
    categoryFilter.onchange = function () {
        const selectedCategory = categoryFilter.value;

        if (selectedCategory === "All") {
            displayEvents(events);
            return;
        }

        const filteredEvents = events.filter(
            (event) => event.category.toLowerCase() === selectedCategory.toLowerCase()
        );
        displayEvents(filteredEvents);
    };
}

if (searchInput) {
    searchInput.addEventListener("keyup", () => {
        const searchText = searchInput.value.toLowerCase().trim();

        const searchedEvents = events.filter((event) =>
            event.name.toLowerCase().includes(searchText)
        );

        if (searchedEvents.length === 0 && searchText !== "") {
            eventsContainer.innerHTML = "<h3 style='color:white;'>No such event found.</h3>";
            return;
        }

        displayEvents(searchText === "" ? events : searchedEvents);
    });
}

if (registrationForm) {
    registrationForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const username = registrationForm.elements["username"]?.value.trim();
        const email = registrationForm.elements["email"]?.value.trim();
        const phone = registrationForm.elements["phone"]?.value.trim();
        const eventDate = registrationForm.elements["eventDate"]?.value;
        const selectedEvent = registrationForm.elements["eventName"]?.value;

        if (!username || !email || !phone || !eventDate || !selectedEvent) {
            if (formMessage) {
                formMessage.textContent = "Please fill all fields.";
                formMessage.style.color = "red";
            }
            return;
        }

        if (!email.includes("@")) {
            if (formMessage) {
                formMessage.textContent = "Please enter a valid email address.";
                formMessage.style.color = "red";
            }
            return;
        }

        const payload = new FormData(registrationForm);
        console.log("Form Submitted Successfully");
        console.table(Object.fromEntries(payload.entries()));

        try {
            const response = await fetch(registrationForm.action, {
                method: "POST",
                body: payload
            });

            const data = await response.json();
            console.log("Registration Response:", data);

            if (!response.ok || !data.success) {
                throw new Error(data.message || "Registration Failed");
            }

            if (formMessage) {
                formMessage.textContent = data.message;
                formMessage.style.color = "green";
                setTimeout(() => {
                    formMessage.textContent = "";
                }, 4000);
            }

            const confirmation = document.querySelector("#confirmation");
            if (confirmation) {
                confirmation.textContent = `Registration ID: ${data.registrationId}`;
            }

            registrationForm.reset();

        } catch (error) {
            console.error(error);

            if (formMessage) {
                formMessage.textContent = error.message || "Registration Failed";
                formMessage.style.color = "red";
            }
        }
    });
}

// jQuery Module
if (typeof $ !== "undefined") {
    $(document).ready(function () {
        $("#registerBtn").click(function () {
            $(".event-card").fadeToggle();
        });
    });
}

const locationSelect = document.querySelector("#locationSelect");
const nearbyEventsResult = document.querySelector("#nearbyEventsResult");

if (locationSelect && nearbyEventsResult) {
    document.querySelector("#findEventsBtn")?.addEventListener("click", () => {

        const selectedBlock = locationSelect.value;

        const matchedEvents = events.filter(
            (event) => event.block === selectedBlock
        );

        if (matchedEvents.length === 0) {
            nearbyEventsResult.innerHTML = "No events available in this block.";
            return;
        }

        nearbyEventsResult.innerHTML = matchedEvents
            .map(
                (event) => `
<div class="nearby-event-card">
    <strong>${event.name}</strong><br>
    Category: ${event.category}<br>
    Location: ${event.location}<br>
    Date: ${event.date}<br>
    Seats: ${event.seats}
</div>
`
            )
            .join("");
    });
}

function showFee() {
    const eventType = document.querySelector("#eventType");
    const feeDisplay = document.querySelector("#feeDisplay");
    const eventDetails = document.querySelector("#eventDetails");

    if (!eventType || !feeDisplay) {
        return;
    }

    const fees = {
        music: 500,
        food: 300,
        sports: 200,
        workshop: 400,
        volunteer: 0,
        cultural: 350
    };

    const selectedValue = eventType.value;
    const selectedText = eventType.options[eventType.selectedIndex]?.text || "";

    if (!selectedValue) {
        feeDisplay.textContent = "";
        if (eventDetails) {
            eventDetails.textContent = "";
        }
        return;
    }

    feeDisplay.textContent = `Event Fee: Rs. ${fees[selectedValue]}`;

    if (eventDetails) {
        eventDetails.textContent = `Selected event: ${selectedText}`;
    }
}

function countCharacters() {
    const message = document.querySelector("#message");
    const charCount = document.querySelector("#charCount");

    if (message && charCount) {
        charCount.textContent = message.value.length;
    }
}

function clearPreferences() {
    const confirmation = document.querySelector("#confirmation");
    const feeDisplay = document.querySelector("#feeDisplay");
    const eventDetails = document.querySelector("#eventDetails");
    const charCount = document.querySelector("#charCount");

    if (registrationForm) {
        registrationForm.reset();
    }

    if (formMessage) {
        formMessage.textContent = "";
    }

    if (confirmation) {
        confirmation.textContent = "";
    }

    if (feeDisplay) {
        feeDisplay.textContent = "";
    }

    if (eventDetails) {
        eventDetails.textContent = "";
    }

    if (charCount) {
        charCount.textContent = "0";
    }
}

function videoReady() {
    const videoStatus = document.querySelector("#videoStatus");

    if (videoStatus) {
        videoStatus.textContent = "Video ready to play.";
    }
}

function enlargeImage(image) {
    image.classList.toggle("enlargedImage");
}

console.log("All JavaScript Module Exercises Integrated Successfully");
