// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
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