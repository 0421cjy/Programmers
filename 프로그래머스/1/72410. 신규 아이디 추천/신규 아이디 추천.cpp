#include <string>

using namespace std;

bool IsValidChar(char c)
{
    if ('a' <= c && c <= 'z') return true;
    if ('0' <= c && c <= '9') return true;
    if (c == '-' || c == '_' || c == '.') return true;

    return false;
}

string DeleteDot(string str)
{
    if (str[0] == '.') return str.substr(1, str.length());
    if (str[str.length() - 1] == '.') return str.substr(0, str.length() - 1);

    return str;
}

string solution(string new_id) {
    string nnewid = "";
    char prevChar = new_id[0];

    for (int i = 0; i < new_id.length(); i++)
    {
        // 1 step
        auto t = tolower(new_id[i]);
        // 2 step
        if (IsValidChar(t) == false) continue;

        // 3 step
        if (i != 0)
        {
            if (new_id[i] == '.')
            {
                if (prevChar == '.') continue;

                prevChar = '.';
            }
            else
            {
                prevChar = new_id[i];
            }
        }
        
        nnewid += t;
    }

    // 4 step
    nnewid = DeleteDot(nnewid);

    // 5 step
    if (nnewid.empty())
    {
        nnewid = "a";
    }

    // 6 step
    if (15 < nnewid.length())
    {
        nnewid = nnewid.substr(0, 15);
    }
    
    nnewid = DeleteDot(nnewid);

    // 7 step
    if (nnewid.length() < 3)
    {
        char t = nnewid[nnewid.length() - 1];

        while (nnewid.length() < 3)
        {
            nnewid += t;
        }
    }

    nnewid = DeleteDot(nnewid);
    
    return nnewid;
}