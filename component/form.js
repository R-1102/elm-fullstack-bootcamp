document.addEventListener("DOMContentLoaded", function () {
    const formContainer = document.createElement("div");
    formContainer.classList.add("register", "page-inner", "mb-5", "mt-3", "animate__animated", "animate__fadeIn");
    
    formContainer.innerHTML = `
        <h2 class="my-5 d-flex justify-content-center">Registration Form</h2>
        <form id="registrationForm">
            <h4 class="my-5 d-flex justify-content-right">Company Info</h4>
            <div class="form-group">
                <label for="companyName">Company Name</label>
                <input type="text" id="companyName" name="companyName" required>
            </div>
            <div class="form-group">
                <label for="registrationNumber">Commercial Registration Number</label>
                <input type="text" id="registrationNumber" name="registrationNumber" required>
            </div>
            
            <h4 class="my-5 d-flex justify-content-right">Personal Info</h4>
            <div class="form-group">
                <label for="email">Email</label>
                <input type="email" id="email" name="email" required>
            </div>
            <div class="form-group">
                <label for="phone">Phone Number</label>
                <input type="tel" id="phone" name="phone" required>
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <input type="password" id="password" name="password" required>
            </div>
            <div class="form-group">
                <label for="confirmPassword">Confirm Password</label>
                <input type="password" id="confirmPassword" name="confirmPassword" required>
            </div>
            
            <h4 class="my-5 d-flex justify-content-right">Address Info</h4>
            <div class="row">
                <div class="col-md-4 form-group">
                    <label for="city">City</label>
                    <input type="text" id="city" name="city" required>
                </div>
                <div class="col-md-4 form-group">
                    <label for="region">Region</label>
                    <input type="text" id="region" name="region" required>
                </div>
                <div class="col-md-4 form-group">
                    <label for="zipCode">Zip Code</label>
                    <input type="text" id="zipCode" name="zipCode" required>
                </div>
            </div>
            <div class="form-group">
                <label for="businessType">Business Type</label>
                <select id="businessType" name="businessType" required>
                    <option value="">Select Business Type</option>
                    <option value="retail">Retail</option>
                    <option value="service">Service</option>
                    <option value="manufacturing">Manufacturing</option>
                </select>
            </div>
            <div class="flex items-center">
                <input type="checkbox" id="terms" class="mr-2">
                <label for="terms" class="text-sm">I agree to the Terms & Conditions</label>
            </div>
            <button type="submit" class="submit-btn">Register</button>
            <button type="button" class="Cancel-btn">Cancel</button>
            <button id="fetch-data" class="Fetch-btn">Fetch Company Data</button>

        </form>
    `;

    document.body.appendChild(formContainer);
});
