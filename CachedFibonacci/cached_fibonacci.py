num_list = []
def fibonacci_cached(n):
    if n == 0 or n == 1:
        return n
    fib = fibonacci_cached(n-1)+fibonacci_cached(n-2)
    if fib in num_list:
        return fib
    else:
        num_list.append(fib)
        return fib


print(fibonacci_cached(10))
