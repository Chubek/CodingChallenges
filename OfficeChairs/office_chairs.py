def take_chairs(chair_list, need):
    result = []

    for i in range(0, len(chair_list)):
        occur = len(chair_list[i][0])

        free = chair_list[i][1] - occur

        if free == 0:
            result.append(free)
            continue
        else:
          if sum(result) < need:
              result.append(free)

    return result


print(take_chairs( [['XXX', 3], ['XXXXX', 6], ['XXXXXX', 9], ['XXX',4]], 4))
