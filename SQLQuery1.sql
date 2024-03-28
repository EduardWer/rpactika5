CREATE TABLE [dbo].[Orders] (
    [Orders_id]   INT          IDENTITY (1, 1) NOT NULL,
    [Cross_named]   varchar(100)     NULL,
    [Col_vo]      INT          NOT NULL,
    [Full_cost]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Orders_id] ASC),
   
   
);
