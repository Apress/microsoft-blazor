window.components = (function () {
  return {
    chart: function (id, data, options) {
      var context = document.getElementById(id)
        .getContext('2d');
      var chart = new Chart(context, {
        type: 'line',
        data: data,
        options: options
      });
    }
  };
})();
