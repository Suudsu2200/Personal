from pymongo import MongoClient
client = MongoClient('localhost:27017')

DB = client['Honor']
UserHonor = DB['UserHonor']

def RegisterUser(username):
	command = { "username" : username }
	User.insert_one(command)

def 