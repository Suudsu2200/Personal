import discord
from discord.ext import commands
from MongoClient import RegisterUser

bot = commands.Bot(command_prefix='HonorBot ')

@bot.event
async def on_ready():
    print("Everything's all ready to go~")

@bot.command(pass_context=True)
async def kill(ctx):
	await client.logout()

@bot.command(pass_context=True)
async def register(ctx):
	args = ctx.message.content.split()
	if (len(args) != 3):
		await ctx.send("Provide a username")
		return
	RegisterUser(ctx.message.author.id, args[2])
	await ctx.send("Registered" + args[2])

bot.run('NTYzOTYxMjY3NTgxMDkxODY5.XKg7-w.FrILw2DF6qF1QCEdo9OqPKRPo3A');