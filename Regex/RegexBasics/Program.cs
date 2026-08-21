using RegexBasics;

Console.WriteLine("1. Username:");
new ValidateUsername().Validate("user_123");

Console.WriteLine("2. License plate:");
new ValidateLicensePlateNumber().Validate("AB1234");

Console.WriteLine("3. Hex color:");
new ValidateHexColourCode().Validate("#FFA500");

Console.WriteLine("4. Email addresses:");
new ExtractEmailAddresses().Validate("Contact support@example.com or info@company.org.");

Console.WriteLine("5. Capitalized words:");
new ExtractCapitalizedWords().Validate("The Eiffel Tower is in Paris and the Statue of Liberty is in New York.");
Console.WriteLine();

Console.WriteLine("6. Dates:");
new ExtractDates().Solution("Events: 12/05/2023, 15/08/2024, and 29/02/2020.");

Console.WriteLine("7. Links:");
Console.WriteLine(string.Join(", ", RegexSolutions.ExtractLinks("Visit https://www.google.com and http://example.org.")));

Console.WriteLine("8. Single spaces:");
Console.WriteLine(RegexSolutions.ReplaceMultipleSpaces("This   is an   example with multiple spaces."));

Console.WriteLine("9. Censored sentence:");
Console.WriteLine(RegexSolutions.CensorBadWords("This is a damn bad example with some stupid words.", new[] { "damn", "stupid" }));

Console.WriteLine("10. IP address: " + RegexSolutions.IsValidIpAddress("192.168.1.1"));
Console.WriteLine("11. Credit card: " + RegexSolutions.IsValidCreditCard("4111111111111111"));
Console.WriteLine("12. Languages: " + string.Join(", ", RegexSolutions.ExtractProgrammingLanguages("I love Java, Python, and JavaScript, but I have not tried Go yet.")));
Console.WriteLine("13. Currency values: " + string.Join(", ", RegexSolutions.ExtractCurrencyValues("The price is $45.99, and the discount is $ 10.50.")));
Console.WriteLine("14. Repeating words: " + string.Join(", ", RegexSolutions.FindRepeatingWords("This is is a repeated repeated word test.")));
Console.WriteLine("15. SSN: " + RegexSolutions.IsValidSsn("123-45-6789"));
