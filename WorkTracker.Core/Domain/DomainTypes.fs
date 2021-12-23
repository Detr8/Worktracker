module DomainTypes

open System

type AggregateType=
    DomainType

type ClientType = Private|Organization

type ClientSource={
    Name:string;
}
type Client={
    FullName:string;
    Type:ClientType;
    Source:ClientSource
}

type File={
    Id:string;
    Path:string;
}

type Document={
    CreationDate:DateTime;
    Title:string;
    File:File;
}

type PaymentInvoice={
    CreationDate:DateTime;
    Document:Document;
}

type WorkTask={
    CreationDate:DateTime;
    DeadLineTo:DateTime option;
    Title:string;
    Descriptino:string option;
}

type WorkStatus=NewDemand|Processing

type Employee={
    FullName:string;

}

type WorkObject={
    Name:string;
    Address:string;

}

type Comment={
    CreationDate:DateTime;
    Text:string;
    Sender:Employee;
}

type WorkItem={
    ClientId:string;
    Title:string;
    WorkArea:string;
    Description:string;
    Aggreement:Document option;
    Tasks:WorkTask list;
    Status:WorkStatus;
    Assignee:Employee;
}