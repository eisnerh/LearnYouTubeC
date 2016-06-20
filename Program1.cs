
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
51
52
53
54
55
56
57
58
59
60
61
62
63
64
65
66
67
68
69
70
71
72
73
74
75
76
77
78
79
80
81
82
83
84
85
86
87
88
89
90
91
92
93
94
95
96
97
98
99
100
101
102
103
104
105
106
107
108
109
110
111
112
113
114
115
116
117
118
119
120
121
122
123
124
125
126
127
128
129
130
131
132
133
134
135
136
137
138
139
140
141
142
143
144
145
146
147
148
149
150
151
152
153
154
155
156
157
158
159
160
161
162
163
164
165
166
167
168
169
170
171
172
173
174
175
176
177
178
179
180
181
182
183
184
185
186
187
188
189
190
191
192
193
194
195
196
197
198
199
200
201
202
203
204
205
206
207
208
209
210
211
212
213
214
215
216
217
218
219
220
221
222
223
224
225
226
227
228
229
230
231
232
233
234
235
236
237
238
239
240
241
242
243
244
245
246
247
248
249
250
251
252
253
254
255
256
257
258
259
260
261
262
263
264
265
266
267
268
269
270
271
272
273
274
275
276
277
278
279
280
281
282
283
284
285
286
287
288
289
290
291
292
293
294
295
296
297
298
299
300
301
302
303
304
305
306
307
308
309
310
311
312
313
314
315
316
317
318
319
320
321
322
323
324
325
326
327
328
329
330
331
332
333
334
335
336
337
338
339
340
341
342
343
344
345
346
347
348
349
350
351
352
353
354
355
356
357
358
359
360
361
362
363
364
365
366
367
368
369
370
371
372
373
374
375
376
377
378
379
380
381
382
383
384
385
386
387
388
389
390
391
392
393
394
395
396
397
398
399
400
401
402
403
404
405
406
407
408
409
410
411
412
413
414
415
416
417
418
419
420
421
422
423
424
425
426
427
428
429
430
431
432
433
434
435
436
437
438
439
440
441
442
443
444
445
446
447
448
449
450
451
452
453
454
455
456
457
458
459
460
461
462
463
464
465
466
467
468
469
470
471
472
473
474
475
476
477
478
479
480
481
482
483
484
485
486
487
488
489
490
491
492
493
494
495
496
497
498
499
500
501
502
503
504
505
506
507
508
509
510
511
512
513
514
515
516
517
518
519
520
521
522
523
524
525
526
527
528
529
530
531
532
533
534
535
536
537
538
539
540
541
542
543
544
545
546
547
548
549
550
551
552
553
554
555
556
557
558
559
560
561
562
563
564
565
566
567
568
// Use using to declare namespaces and functions we wish to use
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalNS;
 
/*
Multiline Comment
*/
 
// Delegates are used to pass methods as arguments to other methods
// A delegate can represent a method with a similar return type and attribute list
delegate double GetSum(double num1, double num2);
 
// ---------- ENUMS ----------
// Enums are unique types with symbolic names and associated values
 
public enum Temperature
{
    Freeze,
    Low,
    Warm,
    Boil
}
 
// ---------- STRUCT ----------
// A struct is a custom type that holds data made up from different data types
struct Customers
{
    private string name;
    private double balance;
    private int id;
 
    public void createCust(string n, double b, int i)
    {
        name = n;
        balance = b;
        id = i;
    }
 
    public void showCust()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Balance : " + balance);
        Console.WriteLine("ID : " + id);
    }
}
 
// Give our code a custom namespace
namespace ConsoleApplication1
{
    class Program
    {
        // Code in the main function is executed
        static void Main(string[] args)
        {
            // Prints string out to the console with a line break (Write = No Line Break)
            Console.WriteLine("What is your name : ");
 
            // Accept input from the user
            string name = Console.ReadLine();
 
            // You can combine Strings with +
            Console.WriteLine("Hello " + name);
 
            // ---------- DATA TYPES ----------
 
            // Booleans are true or false
            bool canVote = true;
 
            // Characters are single 16 bit unicode characters
            char grade = 'A';
 
            // Integer with a max number of 2,147,483,647
            int maxInt = int.MaxValue;
 
            // Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;
 
            // Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            // If you need something bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;
 
            // A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;
 
            // A float is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimals of precision
            double maxDouble = double.MaxValue;
 
            // You can combine strings with other values with +
            Console.WriteLine("Max Int : " + maxDouble);
 
            // The dynamic data type is defined at run time 
            dynamic otherName = "Paul";
            otherName = 1;
 
            // The var data type is defined when compiled and then can't change
            var anotherName = "Tom";
            // ERROR : anotherName = 2;
            Console.WriteLine("Hello " + anotherName);
 
            // How to get the type and how to format strings
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());
 
            // ---------- MATH ----------
 
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));
 
            int i = 0;
 
            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));
 
            Console.WriteLine("i += 3 " + (i += 3));
            Console.WriteLine("i -= 2 " + (i -= 2));
            Console.WriteLine("i *= 2 " + (i *= 2));
            Console.WriteLine("i /= 2 " + (i /= 2));
            Console.WriteLine("i %= 2 " + (i %= 2));
 
            // Casting : If no magnitude is lost casting happens automatically, but otherwise it must be done
            // like this
 
            double pi = 3.14;
            int intPi = (int)pi; // put the data type to convert to between braces
 
            // Math Functions
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
            double number1 = 10.5;
            double number2 = 15;
 
            Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1)));
 
            // Random Numbers
            Random rand = new Random();
            Console.WriteLine("Random Number Between 1 and 10 " + (rand.Next(1,11)));
 
            // ---------- CONDITIONALS ----------
 
            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || ^ !
 
            // If Statement
            int age = 17;
 
            if ((age >= 5) && (age <= 7)) {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13)) {
                Console.WriteLine("Go to middle school");
            }
            else {
                Console.WriteLine("Go to high school");
            }
 
            if ((age < 14) || (age > 67)) {
                Console.WriteLine("You shouldn't work");
            }
 
            Console.WriteLine("! true = " + (! true));
 
            // Ternary Operator
 
            bool canDrive = age >= 16 ? true : false;
 
            // Switch is used when you have limited options
            // Fall through isn't allowed with C# unless there are no statements between cases
            // You can't check multiple values at once
 
            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
 
            // Goto can be used to jump to a label elsewhere in the code
                    goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;
            }
 
            // Lable we can jump to with Goto
            Cute:
            Console.WriteLine("Toddlers are cute");
 
            // ---------- LOOPING ----------
 
            int i = 0;
 
            while (i < 10)
            {
                // If i = 7 then skip the rest of the code and start with i = 8
                if (i == 7)
                {
                    i++;
                    continue; 
                }
 
                // Jump completely out of the loop if i = 9
                if (i == 9)
                {
                    break;
                }
 
                // You can't convert an int into a bool : Print out only odds
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
 
            // The do while loop will go through the loop at least once
            string guess;
            do
            {
                Console.WriteLine("Guess a Number ");
                guess = Console.ReadLine();
            } while (! guess.Equals("15")); // How to check String equality
 
            // Puts all changes to the iterator in one place
            for(int j = 0; j < 10; j++)
            {
                if ((j % 2) > 0)
                {
                    Console.WriteLine(j);
                }
            }
 
            // foreach cycles through every item in an array or collection
            string randStr = "Here are some random characters";
 
            foreach( char c in randStr)
            {
                Console.WriteLine(c);
            }
 
            // ---------- STRINGS ----------
 
            // Escape Sequences : \' \" \\ \b \n \t
 
            string sampString = "A bunch of random words";
 
            // Check if empty
            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("String Length " + sampString.Length);
 
            // Find a string index (Starts with 0)
            Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));
 
            // Get a substring
            Console.WriteLine("2nd Word " + sampString.Substring(2, 6));
 
            string sampString2 = "More random words";
 
            // Are strings equal
            Console.WriteLine("Strings equal " + sampString.Equals(sampString2));
 
            // Compare strings
            Console.WriteLine("Starts with A bunch " + sampString.StartsWith("A bunch"));
            Console.WriteLine("Ends with words " + sampString.EndsWith("words"));
 
            // Trim white space at beginning and end or (TrimEnd / TrimStart)
            sampString = sampString.Trim();
 
            // Replace words or characters
            sampString = sampString.Replace("words", "characters");
            Console.WriteLine(sampString);
 
            // Remove starting at a defined index up to the second index
            sampString = sampString.Remove(0,2);
            Console.WriteLine(sampString);
 
            // Join values in array and save to string
            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine("Name List " + String.Join(", ", names));
 
            // Formatting : Currency, Decimal Places, Before Decimals, Thousands Separator
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);
 
            Console.WriteLine(fmtStr.ToString());
 
            // ---------- STRINGBUILDER ----------
            // Each time you create a string you actually create another string in memory
            // StringBuilders are used when you want to be able to edit a string without creating new ones
 
            StringBuilder sb = new StringBuilder();
 
            // Append a string to the StringBuilder (AppendLine also adds a newline at the end)
            sb.Append("This is the first sentence.");
 
            // Append a formatted string
            sb.AppendFormat("My name is {0} and I live in {1}", "Derek", "Pennsylvania");
 
            // Clear the StringBuilder
            // sb.Clear();
 
            // Replaces every instance of the first with the second
            sb.Replace("a", "e");
 
            // Remove characters starting at the index and then up to the defined index
            sb.Remove(5, 7);
 
            // Out put everything
            Console.WriteLine(sb.ToString());
 
            // ---------- ARRAYS ----------
            // Declare an array
            int[] randNumArray;
 
            // Declare the number of items an array can contain
            int[] randArray = new int[5];
 
            // Declare and initialize an array
            int[] randArray2 = { 1, 2, 3, 4, 5 };
 
            // Get array length
            Console.WriteLine("Array Length " + randArray2.Length);
 
            // Get item at index
            Console.WriteLine("Item 0 " + randArray2[0]);
 
            // Cycle through array
            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, randArray2[i]);
            }
 
            // Cycle with foreach
            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }
 
            // Get the index of an item or -1
            Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));
 
            string[] names = { "Tom", "Paul", "Sally" };
 
            // Join an array into a string
            string nameStr = string.Join(", ", names);
            Console.WriteLine(nameStr);
 
            // Split a string into an array
            string[] nameArray = nameStr.Split(',');
 
            // Create a multidimensional array
            int[,] multArray = new int[5, 3];
 
            // Create and initialize a multidimensional array
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };
 
            // Cycle through multidimensional array
            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }
 
            // Cycle and have access to indexes
            for (int x = 0; x < multArray2.GetLength(0); x += 1)
            {
                for (int y = 0; y < multArray2.GetLength(1); y += 1)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x, y]);
                }
            }
 
            // ---------- LISTS ----------
            // A list unlike an array automatically resizes
 
            // Create a list and add values
            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);
 
            // Add an array to a list
            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray);
 
            // Clear a list
            // numList.Clear();
 
            // Copy an array into a List
            List<int> numList2 = new List<int>(randArray);
 
            // Create a List with array
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });
 
            // Insert in a specific index
            numList.Insert(1, 10);
 
            // Remove a specific value
            numList.Remove(5);
 
            // Remove at an index
            numList.RemoveAt(2);
 
            // Cycle through a List with foreach or
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
 
            // Return the index for a value or -1
            Console.WriteLine("4 is in index " + numList3.IndexOf(4));
 
            // Does the List contain a value
            Console.WriteLine("5 in list " + numList3.Contains(5));
 
            // Search for a value in a string List
            List<string> strList = new List<string>(new string[] { "Tom","Paul" });
            Console.WriteLine("Tom in list " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));
 
            // Sort the List
            strList.Sort();
 
            // ---------- EXCEPTION HANDLING ----------
            // All the exceptions 
            // msdn.microsoft.com/en-us/library/system.systemexception.aspx#inheritanceContinued
 
                try
                {
                    Console.Write("Divide 10 by ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("10 / {0} =  {1}", num, (10/num));
 
                }
 
                // Specifically catches the divide by zero exception
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Can't divide by zero");
 
                    // Get additonal info on the exception
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
 
                    // Throw the exception to the next inline
                    // throw ex;
 
                    // Throw a specific exception
                    throw new InvalidOperationException("Operation Failed", ex);
                }
 
                // Catches any other exception
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
 
            // ---------- CLASSES & OBJECTS ----------
 
            Animal bulldog = new Animal(13, 50, "Spot", "Woof");
 
            Console.WriteLine("{0} says {1}", bulldog.name, bulldog.sound);
 
            // Console.WriteLine("No. of Animals " + Animal.getNumOfAnimals());
 
            // ---------- ENUMS ----------
 
            Temperature micTemp = Temperature.Low;
            Console.Write("What Temp : ");
 
            Console.ReadLine();
 
            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
 
                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;
 
                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;
 
                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }
 
            // ---------- STRUCTS ----------
            Customers bob = new Customers();
 
            bob.createCust("Bob", 15.50, 12345);
 
            bob.showCust();
 
            // ---------- ANONYMOUS METHODS ----------
            // An anonymous method has no name and its return type is defined by the return used in the method
 
            GetSum sum = delegate (double num1, double num2) {
                return num1 + num2;
            };
 
            Console.WriteLine("5 + 10 = " + sum(5, 10));
 
            // ---------- LAMBDA EXPRESSIONS ----------
            // A lambda expression is used to act as an anonymous function or expression tree
 
            // You can assign the lambda expression to a function instance
            Func<int, int, int> getSum = (x, y) => x + y;
            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));
 
            // Get odd numbers from a list
            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };
 
            // With an Expression Lambda the input goes in the left (n) and the statements go on the right
            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();
 
            foreach (int num in oddNums) {
                Console.Write(num + ", ");
            }
 
            // ---------- FILE I/O ----------
            // The StreamReader and StreamWriter allows you to create text files while reading and 
            // writing to them
 
            string[] custs = new string[] { "Tom", "Paul", "Greg" };
 
            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach(string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }
 
            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
 
            Console.Write("Hit Enter to Exit");
            string exitApp = Console.ReadLine();
 
        }
    }
}