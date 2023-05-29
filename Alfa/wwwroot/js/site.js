window.addEventListener('DOMContentLoaded', event => {

    // Toggle the side navigation
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
        // Uncomment Below to persist sidebar toggle between refreshes
        // if (localStorage.getItem('sb|sidebar-toggle') === 'true') {
        //     document.body.classList.toggle('sb-sidenav-toggled');
        // }
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            document.body.classList.toggle('sb-sidenav-toggled');
            localStorage.setItem('sb|sidebar-toggle', document.body.classList.contains('sb-sidenav-toggled'));
        });
    }
    $(document).click(function (event) {
        var searchBar = $('#SearchBar');
        if (!searchBar.is(event.target) && searchBar.has(event.target).length === 0) {
            var searchValue = searchBar.val();
            console.log(searchValue);

            if (searchValue.length === 10 && /^\d+$/.test(searchValue)) {
                var firsthalf = searchValue.slice(0, 6);
                var secondhalf = searchValue.slice(6);
                var modifiedValue = firsthalf + 'xxxxxx' + secondhalf;
                searchBar.val(modifiedValue);
            }
        }
    });
});