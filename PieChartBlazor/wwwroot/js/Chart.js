﻿function GeneratePieChart(countryInfos) {
        am4core.useTheme(am4themes_animated);
        // Themes end
        var chart = am4core.create("chartdiv", am4charts.PieChart3D);
        chart.hiddenState.properties.opacity = 0; // this creates initial fade-in
        chart.legend = new am4charts.Legend();

        chart.data = countryInfos;
          
        var series = chart.series.push(new am4charts.PieSeries3D());
    series.dataFields.value = "deathPercentage";      //lowercase
        series.dataFields.category = "name  ";
   // }); // end am4core.ready()
}