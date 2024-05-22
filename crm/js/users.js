document.addEventListener("DOMContentLoaded", function() {
	const addButton = document.getElementById("createClientButton");
	const customerCountElement = document.querySelector(".box.bg-pink .value");
	addButton.addEventListener("click", function(event) {
		event.preventDefault(); // Prevent form submission
		addClient();
	});

	function addClient() {
		const nameInput2 = document.getElementById("client-name2").value;
		const emailInput2 = document.getElementById("client-email2").value;
		const companyInput2 = document.getElementById("company-name2").value;
		const clientData2 = {
			name: nameInput2,
			email: emailInput2,
			company: companyInput2,
		};
		// Add the new client to the table
		addClientRow(clientData2);
		// Save new data to local storage
		existingData.push(clientData2);
		localStorage.setItem("clientData2", JSON.stringify(existingData));
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
		const cell4 = newRow.insertCell(3); // New cell for actions
		// Set cell values
		cell1.textContent = client.name;
		cell2.textContent = client.email;
		cell3.textContent = client.company;
		// Create Edit button
		const editButton = document.createElement("button");
		editButton.textContent = "Edit";
		editButton.classList.add("edit-button");
		// Create Delete button
		const deleteButton = document.createElement("button");
		deleteButton.textContent = "Delete";
		deleteButton.classList.add("delete-button");
		// Add event listener to Delete button
		deleteButton.addEventListener("click", function() {
			table.deleteRow(newRow.rowIndex);
			// Remove from local storage and update count here
		});
		// Add buttons to the actions cell
		cell4.appendChild(editButton);
		cell4.appendChild(deleteButton);
	}

	function updateCustomerCount() {
		// Count the initial hardcoded entries plus the dynamically added entries
		customerCountElement.textContent = initialCount + existingData.length;
	}
	// Load existing data from local storage (if available)
	const existingData = JSON.parse(localStorage.getItem("clientData2")) || [];
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
