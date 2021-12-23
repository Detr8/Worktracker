module CommandHandling

open System
open Commands


let private HandleCommand eventStore (cmd:Command)=
    async{
        //let processor= Processors.getCmdProcessor cmd
        
        //find handler
        //handle cmd
            //restore state
            //validate cmd
            //return events

        //save events
    }

    //https://github.com/Arshia001/FSharp.GrpcCodeGenerator

let createCommandHandler (serviceProvider:IServiceProvider)=
    ()