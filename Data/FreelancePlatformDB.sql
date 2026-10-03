USE [FreelancePlatformDB];
GO


CREATE TABLE [dbo].[tblUser]
(
    [UserID] INT IDENTITY(1,1) NOT NULL
        CONSTRAINT [PK_tblUser] PRIMARY KEY,

    [Username] VARCHAR(50) NOT NULL
        CONSTRAINT [UQ_tblUser_Username] UNIQUE,

    [Password] VARCHAR(255) NOT NULL,

    [Email] VARCHAR(100) NOT NULL,

    [Role] VARCHAR(20) NOT NULL,

    [CreateDate] DATETIME NOT NULL
        CONSTRAINT [DF_tblUser_CreateDate] DEFAULT GETDATE(),

    [IsActive] BIT NOT NULL
        CONSTRAINT [DF_tblUser_IsActive] DEFAULT 1,

    CONSTRAINT [CK_tblUser_Role]
        CHECK ([Role] IN ('Client', 'Freelancer'))
);
GO


CREATE TABLE [dbo].[tblProfile]
(
    [ProfileID] INT IDENTITY(1,1) NOT NULL
        CONSTRAINT [PK_tblProfile] PRIMARY KEY,

    [FullName] VARCHAR(100) NOT NULL,

    [ContactDetails] VARCHAR(255) NULL,

    [Skills] VARCHAR(500) NULL,

    [Expertise] VARCHAR(500) NULL,

    [Portfolio] VARCHAR(500) NULL,

    [PastWork] VARCHAR(1000) NULL,

    [UserID] INT NOT NULL,

    CONSTRAINT [UQ_tblProfile_UserID]
        UNIQUE ([UserID]),

    CONSTRAINT [FK_tblProfile_tblUser]
        FOREIGN KEY ([UserID])
        REFERENCES [dbo].[tblUser]([UserID])
);
GO



CREATE TABLE [dbo].[tblProject]
(
    [ProjectID] INT IDENTITY(1,1) NOT NULL
        CONSTRAINT [PK_tblProject] PRIMARY KEY,

    [Title] VARCHAR(100) NOT NULL,

    [Description] VARCHAR(2000) NOT NULL,

    [Budget] DECIMAL(18,2) NOT NULL,

    [Deadline] DATETIME NOT NULL,

    [UserID] INT NOT NULL,

    [PostedDate] DATETIME NOT NULL
        CONSTRAINT [DF_tblProject_PostedDate] DEFAULT GETDATE(),

    [Status] VARCHAR(20) NOT NULL
        CONSTRAINT [DF_tblProject_Status] DEFAULT 'Open',

    CONSTRAINT [CK_tblProject_Budget]
        CHECK ([Budget] >= 0),

    CONSTRAINT [CK_tblProject_Status]
        CHECK
        (
            [Status] IN
            (
                'Open',
                'In Progress',
                'Completed',
                'Cancelled'
            )
        ),

    CONSTRAINT [FK_tblProject_tblUser]
        FOREIGN KEY ([UserID])
        REFERENCES [dbo].[tblUser]([UserID])
);
GO


CREATE TABLE [dbo].[tblBid]
(
    [BidID] INT IDENTITY(1,1) NOT NULL
        CONSTRAINT [PK_tblBid] PRIMARY KEY,

    [ProjectID] INT NOT NULL,

    [Proposal] VARCHAR(2000) NOT NULL,

    [Amount] DECIMAL(18,2) NOT NULL,

    [SubmissionDate] DATETIME NOT NULL
        CONSTRAINT [DF_tblBid_SubmissionDate] DEFAULT GETDATE(),

    [UserID] INT NOT NULL,

    [Status] VARCHAR(20) NOT NULL
        CONSTRAINT [DF_tblBid_Status] DEFAULT 'Pending',

    CONSTRAINT [CK_tblBid_Amount]
        CHECK ([Amount] >= 0),

    CONSTRAINT [CK_tblBid_Status]
        CHECK
        (
            [Status] IN
            (
                'Pending',
                'Accepted',
                'Rejected'
            )
        ),

    CONSTRAINT [FK_tblBid_tblProject]
        FOREIGN KEY ([ProjectID])
        REFERENCES [dbo].[tblProject]([ProjectID]),

    CONSTRAINT [FK_tblBid_tblUser]
        FOREIGN KEY ([UserID])
        REFERENCES [dbo].[tblUser]([UserID])
);
GO



CREATE TABLE [dbo].[tblMessage]
(
    [MessageID] INT IDENTITY(1,1) NOT NULL
        CONSTRAINT [PK_tblMessage] PRIMARY KEY,

    [Content] VARCHAR(2000) NOT NULL,

    [SendDate] DATETIME NOT NULL
        CONSTRAINT [DF_tblMessage_SendDate] DEFAULT GETDATE(),

    [SenderID] INT NOT NULL,

    [ReceiverID] INT NOT NULL,

    CONSTRAINT [FK_tblMessage_Sender]
        FOREIGN KEY ([SenderID])
        REFERENCES [dbo].[tblUser]([UserID]),

    CONSTRAINT [FK_tblMessage_Receiver]
        FOREIGN KEY ([ReceiverID])
        REFERENCES [dbo].[tblUser]([UserID]),

    CONSTRAINT [CK_tblMessage_SenderReceiver]
        CHECK ([SenderID] <> [ReceiverID])
);
GO



CREATE TABLE [dbo].[tblReview]
(
    [ReviewID] INT IDENTITY(1,1) NOT NULL
        CONSTRAINT [PK_tblReview] PRIMARY KEY,

    [ProjectID] INT NOT NULL,

    [ReviewerID] INT NOT NULL,

    [FreelancerID] INT NOT NULL,

    [Comment] VARCHAR(2000) NULL,

    [Rating] TINYINT NOT NULL,

    [ReviewDate] DATETIME NOT NULL
        CONSTRAINT [DF_tblReview_ReviewDate] DEFAULT GETDATE(),

    CONSTRAINT [CK_tblReview_Rating]
        CHECK ([Rating] BETWEEN 1 AND 5),

    CONSTRAINT [FK_tblReview_Project]
        FOREIGN KEY ([ProjectID])
        REFERENCES [dbo].[tblProject]([ProjectID]),

    CONSTRAINT [FK_tblReview_Reviewer]
        FOREIGN KEY ([ReviewerID])
        REFERENCES [dbo].[tblUser]([UserID]),

    CONSTRAINT [FK_tblReview_Freelancer]
        FOREIGN KEY ([FreelancerID])
        REFERENCES [dbo].[tblUser]([UserID])
);
GO