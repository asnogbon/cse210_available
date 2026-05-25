using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture( Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].isHidden())
            {
                
                visibleIndices.Add(i);
            }
        }

        int actualToHide = Math.Min(numberToHide, visibleIndices.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int randomIndex = random.Next(visibleIndices.Count);
            int wordIndexToHide = visibleIndices[randomIndex];
        }
    }
             public string  GetDisplayText()
             { 
                StringBuilder sb = new StringBuilder();
                sb.Append(_reference.GetDisplayText() + " ");

                 foreach (Word word in _words)
                 { 
                    sb.Append(word.GetDisplayText() + " ");
                 }

                 return sb.ToString().TrimEnd();
             }

        public bool IsCompletelyHidden()
        { 
            foreach (Word word in _words)
            { 
                if (!word.isHidden())
                { 
                    return false;
                }
            }
            return true;
        }
    }