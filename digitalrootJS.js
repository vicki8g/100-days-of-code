function digital_root(n) {
 var total = 0;
 if(n.toString().length == 1){
           var num = parseInt(n);
           return num;
     }else{
     
          n.toString().split("").forEach( 
                        function(value){
                            var newValue = parseInt(value);
                            return total += newValue;
                         }
                     );
          return digital_root(total);
     }
}

/* Built-in objects/methods used:
 parseInt() function- parses a string argument and returns an integer of the specified radix (the base in mathematical numeral systems).
              parseInt("20px");       // 20
              parseInt("10100", 2);   // 20 binary
              parseInt("2e1");        // 2 exponent

              // type conversion
              Number("20px");       // NaN
              Number("2e1");        // 20, exponential notation 10^# indicated after the e
 toString() method converts a number to a string
 split() method splits a String object into an array of strings by separating the string into substrings.
 forEach() method executes a provided function once for each array element.
*/
