def calc_degree(dataset):
    lines = dataset.splitlines()
    splits = []

    for line in lines:
        splits.append(line.split(' '))

    nodes = []

    for split in splits:
        nodes.append(split[0])

    ones = [1]*len(nodes)

    nodes_dict = {nodes[i]:ones[i] for i in range(len(nodes))}

    degrees = []

    for split in splits:
        degrees.extend(split[1])

    for i in range(1, len(nodes_dict)):
        nodes_dict[str(i)] = degrees.count(str(i)) + 1

    print(nodes_dict)

