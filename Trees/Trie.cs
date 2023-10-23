// using System.Collections.Generic;

// public class Trie
// {
//     private Dictionary<char, Trie> trie;

//     public Trie()
//     {
//         trie = new Dictionary<char, Trie>();
//     }

//     public void Insert(string word)
//     {
//         var t = trie;
//         foreach (var c in word)
//         {
//             if (!t.ContainsKey(c))
//             {
//                 t[c] = new Trie();
//             }
//             t = t[c].trie;
//         }
//         t['~'] = new Trie();
//     }

//     public bool Search(string word)
//     {
//         var t = trie;
//         foreach (var c in word)
//         {
//             if (!t.ContainsKey(c))
//             {
//                 return false;
//             }
//             t = t[c].trie;
//         }
//         return t.ContainsKey('~');
//     }

//     public bool StartsWith(string prefix)
//     {
//         var t = trie;
//         foreach (var c in prefix)
//         {
//             if (!t.ContainsKey(c))
//             {
//                 return false;
//             }
//             t = t[c].trie;
//         }
//         return true;
//     }
// }