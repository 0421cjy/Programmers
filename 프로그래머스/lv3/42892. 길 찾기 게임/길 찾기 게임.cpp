#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class Node
{
private:
    int m_posX;
    int m_value;
    Node* m_left;
    Node* m_right;

public:
    Node(int posX, int value, Node* left, Node* right)
        :m_posX(posX), m_value(value), m_left(left), m_right(right)
    {
    }

    int GetPosX()
    {
        return m_posX;
    }

    int GetValue()
    {
        return m_value;
    }

    Node* GetLeft()
    {
        return m_left;
    }

    Node* GetRight()
    {
        return m_right;
    }

    void AddData(Node* newNode)
    {
        if (m_posX < newNode->GetPosX())
        {
            if (m_right == nullptr)
            {
                m_right = newNode;
            }
            else
            {
                m_right->AddData(newNode);
            }
        }
        else
        {
            if (m_left == nullptr)
            {
                m_left = newNode;
            }
            else
            {
                m_left->AddData(newNode);
            }
        }
    }
};

static void PrintPreOrder(Node* root, vector<int>* vec)
{
    if (root == nullptr) return;

    vec->push_back(root->GetValue());
    PrintPreOrder(root->GetLeft(), vec);
    PrintPreOrder(root->GetRight(), vec);
}

static void PrintPostOrder(Node* root, vector<int>* vec)
{
    if (root == nullptr) return;

    PrintPostOrder(root->GetLeft(), vec);
    PrintPostOrder(root->GetRight(), vec);
    vec->push_back(root->GetValue());
}

bool cmp(vector<int>& first, vector<int>& second)
{
    return first[1] > second[1];
}

vector<vector<int>> solution(vector<vector<int>> nodeinfo) {
    int index = 1;

    for (int i = 0; i < nodeinfo.size(); i++)
    {
        nodeinfo[i].push_back(index++);
    }

    sort(nodeinfo.begin(), nodeinfo.end(), cmp);

    Node* root = new Node(nodeinfo[0][0], nodeinfo[0][2], nullptr, nullptr);

    for (int i = 1; i < nodeinfo.size(); i++)
    {
        root->AddData(new Node(nodeinfo[i][0], nodeinfo[i][2], nullptr, nullptr));
    }

    vector<int> preOrderVec;
    vector<int> postOrderVec;

    PrintPreOrder(root, &preOrderVec);
    PrintPostOrder(root, &postOrderVec);

    vector<vector<int>> answer{ preOrderVec, postOrderVec };
    return answer;
}
