#include <iostream>
#include <string>
#include <queue>
#include <unordered_map>
#include <Windows.h>
using namespace std;

struct Node
{
    char ch;
    int freq;
    Node* left, * right;
};

Node* getNode(char ch, int freq, Node* left, Node* right)
{
    Node* node = new Node();

    node->ch = ch;
    node->freq = freq;
    node->left = left;
    node->right = right;

    return node;
}

struct comp
{
    bool operator()(Node* l, Node* r)
    {
        if (l->freq == r->freq) {
            return l->ch < r->ch;  // сравниваем по алфавиту
        }
        return l->freq > r->freq;
        //return l->freq > r->freq;
    }
};

void encode(Node* root, string str,
    unordered_map<char, string>& huffmanCode)
{
    if (root == nullptr)
        return;

    if (!root->left && !root->right) {
        huffmanCode[root->ch] = str;
    }

    encode(root->left, str + "0", huffmanCode);
    encode(root->right, str + "1", huffmanCode);
}



void buildHuffmanTree(string text)
{
    unordered_map<char, int> freq;
    for (char ch : text) {
        freq[ch]++;
    }

    vector<pair<char, int>> vec(freq.begin(), freq.end());

    for (auto value : vec) {
        cout << value.first << " " << value.second << endl;
    }
    priority_queue<Node*, vector<Node*>, comp> pq;
    for (auto pair : freq) {
        pq.push(getNode(pair.first, pair.second, nullptr, nullptr));
    }

    priority_queue<Node*, vector<Node*>, comp> pq_copy(pq);

    cout << "Исходная строка \"" << text << "\"" << endl;
    cout << "Очередь с приоритетом:" << endl;
    while (!pq_copy.empty()) {
        Node* node = pq_copy.top();
        cout << "Символ: " << node->ch << ", Частота: " << node->freq << endl;
        pq_copy.pop();
    }
    while (pq.size() != 1)
    {
        Node* left = pq.top(); pq.pop();
        Node* right = pq.top();    pq.pop();
        int sum = left->freq + right->freq;
        pq.push(getNode('\0', sum, left, right));
    }

    Node* root = pq.top();

    unordered_map<char, string> huffmanCode;
    encode(root, "", huffmanCode);

    cout << "Код Хаффмана для каждого символа:\n" << '\n';
    for (auto pair : huffmanCode) {
        cout << pair.first << " " << pair.second << '\n';
    }
    cout << "\nНачальная строка:\n" << text << '\n';
    string str = "";
    for (char ch : text) {
        str += huffmanCode[ch];
    }
    cout << "\nКодированая строка :\n" << str << '\n';
}

int main()
{
    SetConsoleCP(1251);
    setlocale(LC_ALL, "rus");
    string someText;
    cout << "Введите строку " << endl;
    getline(cin, someText);
    buildHuffmanTree(someText);

    return 0;
}
