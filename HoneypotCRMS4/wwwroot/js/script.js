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
var ctxArea = document.getElementById('areaChart').getContext('2d');
var areaChart = new Chart(ctxArea, {
	type: 'line',
	data: {
		labels: ['January', 'February', 'March', 'April', 'May', 'June'],
		datasets: [{
			label: 'Sales',
			data: [12000, 15000, 17000, 16500, 18000, 20000],
			fill: true,
			borderColor: 'rgb(75, 192, 192)',
			tension: 0.1
		}]
	}
});
var ctxDonut = document.getElementById('donutChart').getContext('2d');
var donutChart = new Chart(ctxDonut, {
	type: 'doughnut',
	data: {
		labels: ['Product A', 'Product B', 'Product C'],
		datasets: [{
			label: 'Sales',
			data: [3000, 5000, 2000],
			backgroundColor: ['rgb(255, 99, 132)', 'rgb(54, 162, 235)', 'rgb(255, 206, 86)']
		}]
	}
});
var ctxLine = document.getElementById('lineChart').getContext('2d');
var lineChart = new Chart(ctxLine, {
	type: 'line',
	data: {
		labels: ['Q1', 'Q2', 'Q3', 'Q4'],
		datasets: [{
			label: 'Quarterly Sales',
			data: [45000, 55000, 60000, 65000],
			fill: false,
			borderColor: 'rgb(75, 192, 192)',
			tension: 0.1
		}]
	}
});