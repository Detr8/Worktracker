module Commands

open DomainTypes


type CommandWraper<'Payload>={
    AggregateId:string;
    AggregateType:AggregateType;
    Payload:'Payload;
}


type Command=
    |NewWorkItem
    |CompleteTask
    |AddDocument
    |NewStatus
    |AssignTo
