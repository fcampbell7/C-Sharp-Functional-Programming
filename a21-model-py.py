import sys
#import functools
#import operator
    
def main (): 
    f = sys.stdin
    data = f.read()
    words = data.split()
    try:
        nums = list(map(int, words))
        nums = list(map(lambda n: int32(n), nums))
        nums = list(map(lambda n: n//2 if n%2==0 else n, nums))
        nums = list(set(nums))
        s = sum(nums)
        print (f"%s" % s)
    except Exception as e:
        print(f"*** %s" % e.args)


def int32(n):
    maxsize = (2**31)-1
    minsize = (maxsize * -1) - 1
    if n>maxsize or n< minsize:
        raise Exception("NanInt32")
    else:
        return n
main ()

