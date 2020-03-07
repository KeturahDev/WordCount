# Word Counter

#### C# Week Two Friday Project _March 6th 2020_

#### By _**Keturah Howard**_

## Description

Program takes in both a word and a sentence, and returns how many times the user has used the word in that sentence.

This project is being created with the intention of practing spec creation, redgreen workflow and basic MSTesting with C#.

## Specifications:


| Specification | Example Input | Example Output |
| :------------- |:-------------| :-------------------|
| 1. user inputs a word, program holds on to as the word to be checking for | *(string)* user "cow" | program checks for.. KEY: *cow*  |
| 2. program takes in a sentence | *(string)* UserSentence: "this is my cowardly sentence" | program will be checking: *UserSentence*  |
| 3. program seperates the sentence into a list of idividual words by " " | *(string)* UserDentence: "this is my cowardly sentence" | *List* of words: *this, is, my, cowardly, sentence*  |
| 4. "Counting" method compares each word to KEY word and goes up by one with every instance of it in the sentence| *List* of words: *this, is, my, cowardly, sentence* | "Cow" count: *this **(no)**, is**(no)**, my**(no)**, cowardly**(no)**, sentence**(no)*** .. Count = 0 |
| 5. number of repititions is returned to user | user inputs word "hi", sentence "hi there" | "hi" is used: *1 time* |
| 6. sentence cuts out expressions (. , / ! ?) | word: "wow" sentence: "wow! wow, wow? wow." | word count: 4 |


#### Elaborating descriptions for specs by number:
1. program needs to take into account the word the user wants to have checked. Input is one word. Output is information retained.
2. Program needs to recieve the sentence to check from. Input is sentence. Output is information retained.
3. Program needs to only check for whole word true comparisons, not just matching combinations of letters in a bigger word. Input is the sentence string (going into a method), which returns a list.
4. Program needs to be able to compare that sentence to word: Input is the list (returned from a method) into a counting method. Output is the number of repetitions, set to a property.
5. User Interface Based specfication: input is strings, output is interger transformed to readable string- all in Program.cs 
6. Elaboration spec to prepare for specification #3. Input is the sentence string, output is a new sentence string.


## Setup/Installation Requirements

  ### Installing .NET Core

  #### macOS
  * Download a .NET Core SDK from Microsoft Corp
  * Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.

  #### on Windows
  * Download the 64-bit .NET Core SDK from Microsoft Corp.
  * Open the .exe file and follow the steps provided by the installer for your OS.

  ### Installing This Application

  1. Click on the *clone or download* button of this repository. You can download the project file clicking the **"Download Zip"** button, double clicking the file in downloads, and navigating to the index.html file and double clicking that. *Or*, you can copy the link that pops up when you've clicked the *clone or download* button above this README.md file...
  2. Navigate to your terminal, where you have previously installed git (if you have not done this yet, go ahead and do so now).
  3. In terminal, change your directory to desktop, and then type **git clone https://github.com/KeturahDev/WordCount.git**.
  4. When you've pressed enter, my project will be cloned onto your desktop, and now you can change directory into it and type **"code ."** to open the projects files in Visual Studio Code!
  5. You will now be at the root directory for this project in your chosen command promt program. Navigate to *WordCounter.Tests* directory. Enter the command **"dotnet restore"**.
  6. Now navigate back to root directory, and into *WordCount* directory, an input **dotnet run**
  7. Enjoy!

## Technologies Used

* Git
* VS Code
* C#
* .NET 2.2


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at keturah.dev@gmail.com.

## License

This HTML web page is licensed under the MIT license.

## Copyright

Copyright (c) 2020 Keturah Howard.