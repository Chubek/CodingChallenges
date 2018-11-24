num_list = [0, 1]
def fibonacci_cached(n):
    if n < len(num_list):
        if (num_list[n] in num_list):
            return num_list[n]
        else:
            fib =  fibonacci_cached(n - 1) + fibonacci_cached(n - 2)
            num_list.append(fib)
            return fib
    else:
        fib = fibonacci_cached(n - 1) + fibonacci_cached(n - 2)
        num_list.append(fib)
        return fib


print(fibonacci_cached(10))
