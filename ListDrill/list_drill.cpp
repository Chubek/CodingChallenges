std::vector<int> drill_list(std::vector<int> list, int a, int b)
{
    list.erase(list.begin()+a, list.begin()+b);
    return list;
}
