document.addEventListener("DOMContentLoaded", function() {
	const addButton = document.getElementById("createClientButton");
	const customerCountElement = document.querySelector(".box.bg-pink .value");
	addButton.addEventListener("click", function(event) {
		event.preventDefault(); // Prevent form submission
		addClient();
	});

	function addClient() {
		const nameInput = document.getElementById("client-name").value;
		const emailInput = document.getElementById("client-email").value;
		const companyInput = document.getElementById("company-name").value;
		const clientData = {
			name: nameInput,
			email: emailInput,
			company: companyInput,
		};
		// Add the new client to the table
		addClientRow(clientData);
		// Save new data to local storage
		existingData.push(clientData);
		localStorage.setItem("clientData", JSON.stringify(existingData));
		// Update the customer count
		updateCustomerCount();
	}

	function addClientRow(client) {
		const table = document.getElementById("customers");
		const newRow = table.insertRow(); // Create a new row
		// Insert cells into the new row
		const cell1 = newRow.insertCell(0);
		const cell2 = newRow.insertCell(1);
		const cell3 = newRow.insertCell(2);
		// Set cell values
		cell1.textContent = client.name;
		cell2.textContent = client.email;
		cell3.textContent = client.company;
	}

	function updateCustomerCount() {
		// Count the initial hardcoded entries plus the dynamically added entries
		customerCountElement.textContent = initialCount + existingData.length;
	}
	// Load existing data from local storage (if available)
	const existingData = JSON.parse(localStorage.getItem("clientData")) || [];
	existingData.forEach((client) => {
		addClientRow(client);
	});
	// Initialize the customer count on page load
	const initialCount = 4; // Number of hardcoded entries
	updateCustomerCount();
	$(document).ready(function() {
		$('.toggle-btn').click(function() {
			$(this).toggleClass('active').siblings().removeClass('active');
		});
	});
});