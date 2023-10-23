public class TrieNode
{
    public TrieNode[] Children;
    public bool IsEndOfWord;
    public TrieNode() 
    {
        this.Children = new TrieNode[26];
        this.IsEndOfWord = false;
    }
}
public class Trie {
    TrieNode Root = null;
    public Trie() {
        this.Root = new TrieNode();
    }
    public void Insert(string word) 
    {
        TrieNode node = this.Root;
        if(!string.IsNullOrWhiteSpace(word))
        {
            int index = 0;
            for(int i=0; i<word.Length; i++)
            {
                index = word[i] - 'a';
                if(node.Children[index] == null)
                {
                    TrieNode newNode = new TrieNode();
                    node.Children[index] = newNode;
                }
                node = node.Children[index];
            }
            node.IsEndOfWord = true;
        }
    }
    public bool Search(string word) {
        TrieNode node = this.Root;
        if(string.IsNullOrWhiteSpace(word))
        {
            return false;
        }
        int index = 0;
        for(int i=0; i<word.Length; i++)
        {
            index = word[i] - 'a';
            if(node.Children[index] == null)
            {
                return false;
            }
            node = node.Children[index];
        }
        return node.IsEndOfWord;
    }
    public bool StartsWith(string prefix) {
        TrieNode node = this.Root;
        if(string.IsNullOrWhiteSpace(prefix))
        {
            return false;
        }
        int index = 0;
        for(int i=0; i<prefix.Length; i++)
        {
            index = prefix[i] - 'a';
            if(node.Children[index] == null)
            {
                return false;
            }
            node = node.Children[index];
        }
       return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */