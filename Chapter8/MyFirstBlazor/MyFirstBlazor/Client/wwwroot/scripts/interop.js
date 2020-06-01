(function () {
  window.blazorLocalStorage = {
    get: (key, defaultValue) => key in localStorage ? JSON.parse(localStorage[key]) : defaultValue,
    set: (key, value) => { localStorage[key] = JSON.stringify(value); },
    delete: key => { delete localStorage[key]; },
    watch: async (instance) => {
      window.addEventListener('storage', (e) => {
        console.log("update");
        instance.invokeMethodAsync('UpdateCounter');
      });
    }
  };
})();
