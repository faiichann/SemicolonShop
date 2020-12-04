﻿
 $(function () {
     $.ajax({
         type: 'POST',
         dataType: 'json',
         contentType: 'application/json',
         url: '@Url.Action("Piechart")',
         data: '{}',
         success: function (chartsdata) {

             // Callback that creates and populates a data table,    
             // instantiates the pie chart, passes in the data and    
             // draws it.    

             var data = new google.visualization.DataTable();

             data.addColumn('string', 'PlanName');
             data.addColumn('number', 'PaymentAmount');

             for (var i = 0; i < chartsdata.length; i++) {
                 data.addRow([chartsdata[i].PlanName, chartsdata[i].PaymentAmount]);
             }

             // Instantiate and draw our chart, passing in some options    
             var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));

             chart.draw(data,
                 {
                     title: "Show Google Chart in Asp.net",
                     position: "top",
                     fontsize: "14px",
                     chartArea: { width: '50%' },
                 });
         },
         error: function () {
             alert("Error loading data! Please try again.");
         }
     });
 })  