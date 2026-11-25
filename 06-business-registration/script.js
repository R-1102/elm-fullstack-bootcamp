document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById("registrationForm");

    if (form) {
        form.addEventListener("submit", (e) => {
            e.preventDefault();
            if (validateForm()) {
                alert("Form submitted successfully!");
            }
        });
    }

    const fetchButton = document.getElementById("fetch-data");
    if (fetchButton) {
        fetchButton.addEventListener("click", fetchCompanyData);
    }
});

const validateForm = () => {
    let isValid = true;

    document.querySelectorAll(".error").forEach(e => e.textContent = "");

    const fields = [
        "companyName", "registrationNumber", "email", "phone", "password",
        "confirmPassword", "city", "region", "zipCode"
    ];

    fields.forEach(field => {
        const input = document.getElementById(field);
        if (!input || !input.value.trim()) {
            showError(field, "This field is required.");
            isValid = false;
        }
    });

    const email = document.getElementById("email")?.value;
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (email && !emailRegex.test(email)) {
        showError("email", "Invalid email format.");
        isValid = false;
    }

    const password = document.getElementById("password")?.value;
    const confirmPassword = document.getElementById("confirmPassword")?.value;

    if (password && password.length < 6) {
        showError("password", "Password must be at least 6 characters.");
        isValid = false;
    }
    if (password !== confirmPassword) {
        showError("confirmPassword", "Passwords do not match.");
        isValid = false;
    }

    return isValid;
};

const showError = (fieldId, message) => {
    let errorElement = document.getElementById(`${fieldId}-error`);
    if (!errorElement) {
        errorElement = document.createElement("span");
        errorElement.id = `${fieldId}-error`;
        errorElement.className = "error text-red-500 text-sm";
        const inputField = document.getElementById(fieldId);
        if (inputField) {
            inputField.insertAdjacentElement("afterend", errorElement);
        }
    }
    errorElement.textContent = message;
};

async function fetchCompanyData() {
    try {
        const response = await fetch("https://jsonplaceholder.typicode.com/users/8");
        if (!response.ok) throw new Error("Failed to fetch data");

        const data = await response.json();

        document.getElementById("companyName").value = data.name;
        document.getElementById("email").value = data.email;
        document.getElementById("phone").value = data.phone;
        document.getElementById("city").value = data.address.city;
        document.getElementById("region").value = data.address.street;
        document.getElementById("zipCode").value = data.address.zipcode;
    } catch (error) {
        alert(error.message);
    }
}
