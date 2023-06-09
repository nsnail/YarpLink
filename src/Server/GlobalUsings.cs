// ReSharper disable RedundantUsingDirective.Global

global using System;
global using System.Collections;
global using System.Collections.Generic;
global using System.Collections.Immutable;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.Data;
global using System.Diagnostics;
global using System.Globalization;
global using System.IO;
global using System.Linq;
global using System.Linq.Expressions;
global using System.Net;
global using System.Reflection;
global using System.Text;
global using System.Text.Encodings.Web;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Text.Json.Serialization.Metadata;
global using System.Text.RegularExpressions;
global using System.Threading.Tasks;
global using FreeSql;
global using FreeSql.Aop;
global using FreeSql.DataAnnotations;
global using FreeSql.Internal.Model;
global using Furion;
global using Furion.Authorization;
global using Furion.ConfigurableOptions;
global using Furion.DataEncryption;
global using Furion.DataValidation;
global using Furion.DependencyInjection;
global using Furion.DynamicApiController;
global using Furion.EventBus;
global using Furion.SpecificationDocument;
global using Furion.UnifyResult;
global using Mapster;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.ActionConstraints;
global using Microsoft.AspNetCore.Mvc.Controllers;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Mvc.Infrastructure;
global using Microsoft.Extensions.Caching.Distributed;
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using NSExt.Attributes;
global using NSExt.Extensions;
global using YarpLink.Infrastructure;
global using YarpLink.Infrastructure.Attributes;
global using YarpLink.Infrastructure.Configuration.Options;
global using YarpLink.Infrastructure.Configuration.Options.SubNodes.Redis;
global using YarpLink.Infrastructure.Configuration.Options.SubNodes.Upload;
global using YarpLink.Infrastructure.Constant;
global using YarpLink.Infrastructure.Enums;
global using YarpLink.Infrastructure.Exceptions;
global using YarpLink.Infrastructure.Exceptions.InvalidInput;
global using YarpLink.Infrastructure.Exceptions.InvalidOperation;
global using YarpLink.Infrastructure.Exceptions.Unexpected;
global using YarpLink.Infrastructure.Extensions;
global using YarpLink.Infrastructure.Languages;
global using YarpLink.Infrastructure.Utils;