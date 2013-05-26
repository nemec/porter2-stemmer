porter2-stemmer
===============

An implementation of the Porter2 stemming algorithm in C#

http://snowball.tartarus.org/algorithms/english/stemmer.html

A stemmer helps convert similar words into a common form so that they can be accurately compared, regardless of tense/part of speec/etc.

For example:

    friend -> friend  
    friendly -> friend  
    friends -> friend  
    friend's -> friend
