This solution prompts the user for a file path, parses that file into an array with each element containing an id. It checks to see if the 
element also contains a label, and if it does it will parse out the brackets and spaces and just get the ids and sum them together
it then outputs those sums. 

The project also contains a test using a resource file of test input I was given, sends that to the parsing function which calls the summing
function and returns a list of sums, and checks them against the expected result.
 