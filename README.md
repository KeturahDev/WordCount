# Word Counter.

#### C# Week Two Friday Project _March 6th 2020_

#### By _**Keturah Howard**_

## Description

Program takes in both a word and a sentence, and returns how many times the user has used the word in that sentence.

This project is being created with the intention of practing spec creation, redgreen workflow and basic MSTesting with C#.

## Specifications:


| Specification | Example Input | Example Output |
| :------------- |:-------------| :-------------------|
| 1. user inputs a word, program holds on to as the word to be checking for | user "cow" | program checks for.. KEY: *cow*  |
| 2. program takes in a sentence | UserSentence: "this is my cowardly sentence" | program will be checking: *UserSentence*  |
| 3. program seperates the sentence into a list of idividual words by " " | UserDentence: "this is my cowardly sentence" | List of words: *this, is, my, cowardly, sentence*  |
| 4. "Count" method compares each word to KEY word and goes up by one with every instance of it in the sentence| List of words: *this, is, my, cowardly, sentence* | "Cow" count: *this **(no)**, is**(no)**, my**(no)**, cowardly**(no)**, sentence**(no)*** .. Count = 0 |
| 5. number of repititions is returned to user | user inputs word "hi", sentence "hi there" | "hi" is used: *1 time* |


#### Description Sentences for specs by number:
1. program needs to take into account the word the user wants to have checked. input is one word
2. program needs to recieve the sentence to check from. input is sentence.
3. program needs to only check for whole word true comparisons, not just matching combinations of letters in a bigger word. input is the sentence.. into a method which returns a list.
4. program needs to be able to compare that sentence to word.. input is the list (return from a method) into a RepeatCount method. output is the number of repetitions 
5. DONE WITH UI . not testing.. just spec


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
  3. In terminal, change your directory to desktop, and then type **git clone https://github.com/KeturahDev/**.
  4. When you've pressed enter, my project will be cloned onto your desktop, and now you can change directory into it and type **"code ."** to open the projects files in Visual Studio Code!
  5. At the root directory for this project in your chosen command promt program, enter the command "dotnet build" followed by "dotnet run". You can now begin to play Banana Bakery!

## Technologies Used

* Git
* VS Code
* C#
* .NET


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at keturah.dev@gmail.com.