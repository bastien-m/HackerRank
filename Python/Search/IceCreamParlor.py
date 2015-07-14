# -*- coding: utf-8 -*-
from AlgorithmAbstract import AlgorithmAbstract

class IceCreamParlor(AlgorithmAbstract):

	def __init__(self, cash_amount, flavors_list):
		self.result = list()
		self.cash_amount = cash_amount
		self.flavors_list = flavors_list

	def resolve(self):
		for i in range(len(self.flavors_list) - 1):
			ci = self.flavors_list[i];
			for j in range(i + 1, len(self.flavors_list)):
				if (ci + self.flavors_list[j] == self.cash_amount):
					self.result = [i + 1,j + 1]
					break
		pass

	def get_result(self):
		return ' '.join([str(x) for x in self.result])