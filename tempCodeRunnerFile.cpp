#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int m;
    cin >> m;
    string s=to_string(m);
    string x;
    int br=0;
    for (int i = 0; i < s.length(); i++)
    {
        
        if (s[i]-'0'>=0&&s[i]-'0'<n)
        {
            x=x+s[i];
            br++;
        }
        else
        {
            if (br>0)
            {
                break;
            }
            
        }
    }
 
    
    
        int sum = 0;
        int k = 0;
        m=stoi(x);
        while (m > 0)
        {
            sum = sum + (m % 10) * pow(n, k);
            k++;
            m = m / 10;
        }
        cout << sum << endl;
    

    return 0;
}