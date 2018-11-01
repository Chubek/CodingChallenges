int j_and_s(std::string catal, std::string intevent)
{
    int cnt = 0;

    for (auto i : intevent)
    {
        for (auto c : catal)
        {
            if (i == c)
                ++cnt;
        }
    }

    return cnt;
}
