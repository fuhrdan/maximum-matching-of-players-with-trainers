//*****************************************************************************
//** 2410. Maximum Matching of Players With Trainers                leetcode **
//*****************************************************************************

int compare(const void* a, const void* b)
{
    return (*(int*)a - *(int*)b);
}

int matchPlayersAndTrainers(int* players, int playersSize, int* trainers, int trainersSize)
{
    qsort(players, playersSize, sizeof(int), compare);
    qsort(trainers, trainersSize, sizeof(int), compare);

    int i = 0;
    int j = 0;
    int count = 0;
    int hashbrown;

    while (i < playersSize && j < trainersSize)
    {
        if (players[i] <= trainers[j])
        {
            count++;
            i++;
            j++;
        }
        else
        {
            j++;
        }
    }

    return count;
}