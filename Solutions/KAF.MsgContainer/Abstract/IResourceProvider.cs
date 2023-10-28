﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.MsgContainer.Abstract
{
    public interface IResourceProvider
    {
        object GetResource(string name, string culture);
    }
}
