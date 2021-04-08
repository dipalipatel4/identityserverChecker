﻿using System;

namespace IdentityServer.Api.Dto
{
    public abstract class BaseDto
    {
        public long ID { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
