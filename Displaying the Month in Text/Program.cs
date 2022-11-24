/*TASK: 
 *  will write a program that will display the current date with the month presented by
    text rather than by a number (or, generally, in long form),
 */
// Today's date
DateTime today = DateTime.Today;

// Output
Console.WriteLine("Today is " + today.ToLongDateString());

// Waiting for output
Console.ReadLine();


/* DISCUSSION: 
 * Note the following:

•   When you launch some object action in C#, the action name is always
    appended by parentheses (round brackets), even if there is nothing
    between them.
    
•   The parentheses are often not empty but contain a parameter
    (or parameters), which is some action-specific information. For
    example, in the case of the Console.WriteLine action, you specify in
    parentheses what you want to display.

•   The actions you can perform with objects are also called methods.
•   The month name displayed by the ToLongDateString method
    depends on the operating system language setting.
 */ 