function remove14(array: any[]) {
    var map = {},
        result = [];
    for (var i = 0; i < array.length; i++) {
        var value = array[i];
        if (map.hasOwnProperty(value)) {
            map[value].qty++;
        }
        else {
            map[value] = {
                value: value,
                qty: 1
            };
        }
    }

    for (var i = 1; i <= 7; i++) {
        if (map.hasOwnProperty(i) && map.hasOwnProperty(14 - i)) {
            var qty = map[i].qty > map[14 - i].qty ? map[14 - i].qty : map[i].qty;
            map[i].qty -= qty;
            map[14 - i].qty -= qty;
        }
    }

    for (var i = 0; i < 14; i++) {
        if (map.hasOwnProperty(i)) {
            var o = map[i];
            while (o.qty > 0) {
                result.push(o.value);
                o.qty--;
            }
        }
    }

    return result;
}