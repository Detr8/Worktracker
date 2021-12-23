module Processors

open Commands
open Events

type CommandProcessor=MailboxProcessor<Command>

type CommandAccpetResult=Result<unit, string> //for fire and forget


let getHandler (cmd:Command): Command->Async<Result<DomainEvent list, string>>=
    //mapping commands to their handlers

    fun cmd->async.Return(Error "")
        

let getCmdProcessor (cmd:Command):Command->Async<CommandAccpetResult>=
    fun cmf->
        async.Return(Ok())

