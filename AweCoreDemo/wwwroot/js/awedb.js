var awedb = function () {
    var id = 1000;
    var categories = [];
    var meals = [];
    var countries = [];
    var chefs = [];
    var dinners = [];
    var lunches = [];

    var cat1 = add(categories, { name: 'Fruits' });
    addMeals(cat1, ['Mango', 'Apple', 'Papaya', 'Banana', 'Cherry']);

    var cat2 = add(categories, { name: 'Legumes' });
    addMeals(cat2, ['Tomato', 'Potato', 'Cucumber', 'Onion', 'Carrot']);

    var cat3 = add(categories, { name: 'Vegetables' });
    addMeals(cat3, ['Celery', 'Broccoli', 'Artichoke', 'Cauliflower', 'Lettuce']);

    var cat4 = add(categories, { name: 'Nuts' });
    addMeals(cat4, ['Hazelnuts', 'Chestnuts', 'Walnuts', 'Almonds', 'Mongongo']);

    var cat5 = add(categories, { name: 'Grains' });
    addMeals(cat5, ['Rice', 'Wheat', 'Buckwheat', 'Oats', 'Barley']);

    var countryNames = [
        "Elwynn Forest", "Stormwind", "Loch Modan", "Westfall",
            "Ironforge", "Orgrimmar", "Feralas", "Darnassus", "Teldrassil",
            "Winterspring", "Goldshire", "Sylvanaar", "Redridge Mountains", "Stone Cutter",
            "Regent", "Piccadilly", "Hatton Garden", "Greville", "Farringdon",
            "Carpana", "Jisina", "Ghidrimesti"
    ];

    loop(countryNames, function(name) {
        add(countries, { name: name });
    });
    
    addChef('Naked', 'Chef');
    addChef('Chef', 'Chef');
    addChef('Athene', 'Broccoli');
    addChef('Omu', 'Man');
    addChef('Pepper', 'Tomato');
    addChef('Deeze', 'Leysen');
    addChef('Jeea', 'Derveaux');
    addChef('Phoebe', 'Phoebes');
    addChef('Sequeiro', 'Olano');
    addChef('Hercules', 'Oat');
    addChef('Joanna', 'Stan');
    addChef('Peter', 'Gibbons');
    addChef('Tom', 'Smykowski');
    addChef('Demeter', 'Harvest');
    addChef('Hyperion', 'Light');
    addChef('Gaia', 'Earth');
    addChef('Chronos', 'Timpus');

    var dinnerNames = ["hot chocolate", "believe in miracles", "out and about", "dinner tonight", "watch tv", "last night",
        "toasty", "great", "a little", "surf and turf", "coffee for me", "dinner with friends",
        "eating at the pub", "cooking in the garden", "ninja dinner", "broccoli power", "eating out", "Awesome dinner",
        "Uber dinner", "Fruity dish", "Nice dish", "Nerds eating", "Pros eating",
        "snacks and movie", "Morning meal", "Morning Tea", "Cookies", "Apples", "Salad"];

    loop(dinnerNames, function(name) {
        addDinner(name);
    });

    var ppl = [
        "Aaron", "James", "Jeremy", "Richard", "Tommy", "Alan", "Charlie", "Jake", "Penny", "Sheldon", "Leonard", "Zazzles", "Amy", "Howard", "Rajesh",
            "Phil", "Scott", "Bernadette", "Russell", "Timmy", "Jeff", "Adam", "Jennifer", "Audrey", "Claudia", "Brenda", "Tracy", "Allison", "Fabiano",
            "Ryu", "Ken", "Irene", "Henry", "Lucas", "Maurice", "Luke", "Lewis", "Tyler", "David", "Patrick", "Evan", "Sam", "Sebastian", "Ben", "Robert",
            "Oliver", "Justin", "Jamie", "Tania", "Chiren", "Reese", "Dean", "Ian", "Paul", "Gabrielle", "Michelle", "Hillary", "Jason", "Joshua", "Benjamin",
            "Gordon", "Morgan", "Harry", "Daniel", "Jacob", "Sophie", "Emily", "Jessica", "Ella", "Mia", "Emma", "Megan", "Caitlin", "Amber", "Fernando",
            "Evelyn", "Lauren", "Nicole", "Paige", "Eve", "Iris", "Gracie", "Sarah", "Holly", "Elizabeth", "Rachel", "Courtney", "Owen",
            "Ruby", "Peter", "Michael", "Samir", "Joanna", "Stan", "Milton", "Tom", "Jerry", "William", "Carter", "Dolores", "Earl", "Francesco",
            "Mario", "Luigi", "Vincenzo", "Jonathan", "Nathan", "John", "Mary", "Maria", "Helena", "Linda", "Lucy", "Sergio",
            "Katarina", "Raquel", "Vanessa", "Miguel", "Pedro", "Carlos"
    ];

    var foods = ["Banana", "Cheesecake", "Hot Beverage", "Apple", "Oat meal", "French toast", "Pizza", "Apple Pie", "Shepherd's pie",
        "Salad", "Soup"];

    var locations = ["Home", "University", "Restaurant", "Visit", "Diner", "Central Perk", "Tavern"];

    var prices = [10, 20, 30, 50, 70, 23, 45, 100, 21, 79, 39, 18];

    for (var i = 0; i < 750; i++) {
        add(lunches,
            {
                date: rndDate(),
                food: rnd(foods),
                person: rnd(ppl),
                location: rnd(locations),
                price: rnd(prices),
                country: rnd(countries),
                chef: rnd(chefs),
                organic: rndNext(10) > 3
            });
    }

    function addDinner(name) {
        add(dinners,
            {
                name: name,
                date: rndDate(),
                country: rnd(countries),
                chef: rnd(chefs),
                meals: rndMeals(),
                bonusMeal: rnd(meals),
                organic: rndNext(10) > 3
            });
    }

    function addChef(fname, lname) {
        add(chefs, { firstName: fname, lastName: lname, country: rnd(countries) });
    }

    function addMeals(cat, namearr) {
        loop(namearr,
            function(name) {
                add(meals, { category: cat, name: name });
            });
    }


    function rndMeals() {
        var count = rndBetw(1, 4);
        var list = [];

        for (var i = 0; i < count; i++) {
            var meal = meals[rndNext(meals.length)];
            var exists = false;
            loop(list, function(m) {
                if (m === meal) exists = true;
            });

            if (!exists) {
                list.push(meal);
            }
        }

        return list;
    }

    function add(arr, val) {
        val.id = id += 2;
        arr.push(val);
        return val;
    }

    function rndDate() {
        var day = rndNext(14) * 2 + 1;
        return new Date(rndBetw(2009, 2015), rndBetw(0, 11), day);
    }

    function rnd(arr) {
        return arr[rndNext(arr.length)];
    }

    function rndNext(max) {
        return rndBetw(0, max);
    }

    // [min, max)
    function rndBetw(min, max) {
        return Math.floor(Math.random() * (max - min)) + min;
    }

    function loop(arr, f) {
        if (arr) {
            for (var i = 0, len = arr.length; i < len; i++) {
                var col = arr[i];
                f(col, i);
            }
        }
    }

    return {
        add: add,
        categories: categories,
        meals: meals,
        chefs: chefs,
        countries: countries,
        dinners: dinners,
        lunches: lunches
    };
}();