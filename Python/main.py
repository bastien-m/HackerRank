import sys
import os

sys.path.append('Search')

from Search.IceCreamParlor import IceCreamParlor

if __name__ == "__main__":

	number_of_test_case = int(input())
	result = list()
	for i in range(number_of_test_case):
		amount = int(input())
		input()
		flavors_list = [int(x) for x in input().split(' ')]

		ice_cream_parlor = IceCreamParlor(amount, flavors_list)
		ice_cream_parlor.resolve()
		result.append(ice_cream_parlor.get_result())

	for res in result:
		print(res)