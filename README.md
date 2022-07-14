# WordUsageProject

This project is to acquire the top 100 most used words out of the provided text of "Moby Dick" that are not included in an also included list of words.   

- Functionality of the application: 

The application acquires the stop words in a hashtable to be able to quickly acquire information as to whether or not the words are in the list. 

The tallied list of words from the text are put into a SortedDictionary that allows an OrderBy to be performed on the Values, which are the total tallies of the words.

It acquires the 100 most counted words and includes those in a searchable list. 

The UI element uses Microsoft forms, with a drop-down list of the 100 most used words in numerical order, and will inform you how many times it was used when it is selected.

- Issues

The primary issue I had completing this application was an incorrect understanding of the requirements when I began.  The assignment was different than any I have done, and I began the application to tally the total times the stop words were used.  Rereading the requirements when this portion of the application was complete gave me a correct understanding of the requirements as I also understood the project and functionality of the code I had completed up to this point.  This was one scenario that while I did not accurately understand, I did not have enough comprehension to know I did not accurately understand. 

- Possible additional enhancements

Enhancements to this project would include: the ability to choose a text file to search while in the application rather than having it provided beforehand and the ability to modify the Stop Words on the fly and have it re-tally most used words of the new Stop word list. 
