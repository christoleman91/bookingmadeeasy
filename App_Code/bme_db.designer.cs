﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bme_db")]
public partial class bme_dbDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  #endregion
	
	public bme_dbDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HotelsConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public bme_dbDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public bme_dbDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public bme_dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public bme_dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_HotelCategories_ViewAll")]
	public ISingleResult<sp_HotelCategories_ViewAllResult> sp_HotelCategories_ViewAll()
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
		return ((ISingleResult<sp_HotelCategories_ViewAllResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Hotels_ViewAll")]
	public ISingleResult<sp_Hotels_ViewAllResult> sp_Hotels_ViewAll([global::System.Data.Linq.Mapping.ParameterAttribute(Name="HotelCatID", DbType="Int")] System.Nullable<int> hotelCatID)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), hotelCatID);
		return ((ISingleResult<sp_Hotels_ViewAllResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Hotels_SingleRecord")]
	public ISingleResult<sp_Hotels_SingleRecordResult> sp_Hotels_SingleRecord([global::System.Data.Linq.Mapping.ParameterAttribute(Name="HotelID", DbType="Int")] System.Nullable<int> hotelID)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), hotelID);
		return ((ISingleResult<sp_Hotels_SingleRecordResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_HotelImages_Images")]
	public ISingleResult<sp_HotelImages_ImagesResult> sp_HotelImages_Images([global::System.Data.Linq.Mapping.ParameterAttribute(Name="HotelID", DbType="Int")] System.Nullable<int> hotelID)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), hotelID);
		return ((ISingleResult<sp_HotelImages_ImagesResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_HotelReviews_Insert")]
	public int sp_HotelReviews_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="HotelID", DbType="Int")] System.Nullable<int> hotelID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReviewerTitle", DbType="VarChar(150)")] string reviewerTitle, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReviewerName", DbType="VarChar(150)")] string reviewerName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReviewerComment", DbType="VarChar(MAX)")] string reviewerComment, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReviewerRating", DbType="Int")] System.Nullable<int> reviewerRating)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), hotelID, reviewerTitle, reviewerName, reviewerComment, reviewerRating);
		return ((int)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_HotelReviews_ViewAllByID")]
	public ISingleResult<sp_HotelReviews_ViewAllByIDResult> sp_HotelReviews_ViewAllByID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="HotelID", DbType="Int")] System.Nullable<int> hotelID)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), hotelID);
		return ((ISingleResult<sp_HotelReviews_ViewAllByIDResult>)(result.ReturnValue));
	}
}

public partial class sp_HotelCategories_ViewAllResult
{
	
	private int _HotelCatID;
	
	private string _HotelCatTitle;
	
	private string _HotelCatTitleSmall;
	
	private string _HotelCatDesc;
	
	private string _HotelCatImage;
	
	public sp_HotelCategories_ViewAllResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelCatID", DbType="Int NOT NULL")]
	public int HotelCatID
	{
		get
		{
			return this._HotelCatID;
		}
		set
		{
			if ((this._HotelCatID != value))
			{
				this._HotelCatID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelCatTitle", DbType="VarChar(150)")]
	public string HotelCatTitle
	{
		get
		{
			return this._HotelCatTitle;
		}
		set
		{
			if ((this._HotelCatTitle != value))
			{
				this._HotelCatTitle = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelCatTitleSmall", DbType="VarChar(150)")]
	public string HotelCatTitleSmall
	{
		get
		{
			return this._HotelCatTitleSmall;
		}
		set
		{
			if ((this._HotelCatTitleSmall != value))
			{
				this._HotelCatTitleSmall = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelCatDesc", DbType="VarChar(500)")]
	public string HotelCatDesc
	{
		get
		{
			return this._HotelCatDesc;
		}
		set
		{
			if ((this._HotelCatDesc != value))
			{
				this._HotelCatDesc = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelCatImage", DbType="VarChar(500)")]
	public string HotelCatImage
	{
		get
		{
			return this._HotelCatImage;
		}
		set
		{
			if ((this._HotelCatImage != value))
			{
				this._HotelCatImage = value;
			}
		}
	}
}

public partial class sp_Hotels_ViewAllResult
{
	
	private int _HotelID;
	
	private string _HotelDesc;
	
	private System.Nullable<decimal> _HotelPrice;
	
	private System.Nullable<int> _HotelRooms;
	
	private string _HotelInfo;
	
	private string _HotelsShortDesc;
	
	private System.Nullable<int> _HotelCatID;
	
	private string _HotelName;
	
	public sp_Hotels_ViewAllResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelID", DbType="Int NOT NULL")]
	public int HotelID
	{
		get
		{
			return this._HotelID;
		}
		set
		{
			if ((this._HotelID != value))
			{
				this._HotelID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelDesc", DbType="VarChar(500)")]
	public string HotelDesc
	{
		get
		{
			return this._HotelDesc;
		}
		set
		{
			if ((this._HotelDesc != value))
			{
				this._HotelDesc = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelPrice", DbType="Money")]
	public System.Nullable<decimal> HotelPrice
	{
		get
		{
			return this._HotelPrice;
		}
		set
		{
			if ((this._HotelPrice != value))
			{
				this._HotelPrice = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelRooms", DbType="Int")]
	public System.Nullable<int> HotelRooms
	{
		get
		{
			return this._HotelRooms;
		}
		set
		{
			if ((this._HotelRooms != value))
			{
				this._HotelRooms = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelInfo", DbType="VarChar(MAX)")]
	public string HotelInfo
	{
		get
		{
			return this._HotelInfo;
		}
		set
		{
			if ((this._HotelInfo != value))
			{
				this._HotelInfo = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelsShortDesc", DbType="VarChar(150)")]
	public string HotelsShortDesc
	{
		get
		{
			return this._HotelsShortDesc;
		}
		set
		{
			if ((this._HotelsShortDesc != value))
			{
				this._HotelsShortDesc = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelCatID", DbType="Int")]
	public System.Nullable<int> HotelCatID
	{
		get
		{
			return this._HotelCatID;
		}
		set
		{
			if ((this._HotelCatID != value))
			{
				this._HotelCatID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelName", DbType="VarChar(100)")]
	public string HotelName
	{
		get
		{
			return this._HotelName;
		}
		set
		{
			if ((this._HotelName != value))
			{
				this._HotelName = value;
			}
		}
	}
}

public partial class sp_Hotels_SingleRecordResult
{
	
	private int _HotelID;
	
	private string _HotelDesc;
	
	private System.Nullable<int> _HotelRooms;
	
	private System.Nullable<decimal> _HotelPrice;
	
	private string _HotelInfo;
	
	private string _HotelsShortDesc;
	
	private string _HotelName;
	
	private System.Nullable<int> _HotelCatID;
	
	private string _HotelAmenitiesMain;
	
	private string _HotelFacilities;
	
	private string _HotelRoomFacilities;
	
	public sp_Hotels_SingleRecordResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelID", DbType="Int NOT NULL")]
	public int HotelID
	{
		get
		{
			return this._HotelID;
		}
		set
		{
			if ((this._HotelID != value))
			{
				this._HotelID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelDesc", DbType="VarChar(500)")]
	public string HotelDesc
	{
		get
		{
			return this._HotelDesc;
		}
		set
		{
			if ((this._HotelDesc != value))
			{
				this._HotelDesc = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelRooms", DbType="Int")]
	public System.Nullable<int> HotelRooms
	{
		get
		{
			return this._HotelRooms;
		}
		set
		{
			if ((this._HotelRooms != value))
			{
				this._HotelRooms = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelPrice", DbType="Money")]
	public System.Nullable<decimal> HotelPrice
	{
		get
		{
			return this._HotelPrice;
		}
		set
		{
			if ((this._HotelPrice != value))
			{
				this._HotelPrice = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelInfo", DbType="VarChar(MAX)")]
	public string HotelInfo
	{
		get
		{
			return this._HotelInfo;
		}
		set
		{
			if ((this._HotelInfo != value))
			{
				this._HotelInfo = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelsShortDesc", DbType="VarChar(150)")]
	public string HotelsShortDesc
	{
		get
		{
			return this._HotelsShortDesc;
		}
		set
		{
			if ((this._HotelsShortDesc != value))
			{
				this._HotelsShortDesc = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelName", DbType="VarChar(100)")]
	public string HotelName
	{
		get
		{
			return this._HotelName;
		}
		set
		{
			if ((this._HotelName != value))
			{
				this._HotelName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelCatID", DbType="Int")]
	public System.Nullable<int> HotelCatID
	{
		get
		{
			return this._HotelCatID;
		}
		set
		{
			if ((this._HotelCatID != value))
			{
				this._HotelCatID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelAmenitiesMain", DbType="VarChar(MAX)")]
	public string HotelAmenitiesMain
	{
		get
		{
			return this._HotelAmenitiesMain;
		}
		set
		{
			if ((this._HotelAmenitiesMain != value))
			{
				this._HotelAmenitiesMain = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelFacilities", DbType="VarChar(MAX)")]
	public string HotelFacilities
	{
		get
		{
			return this._HotelFacilities;
		}
		set
		{
			if ((this._HotelFacilities != value))
			{
				this._HotelFacilities = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelRoomFacilities", DbType="VarChar(MAX)")]
	public string HotelRoomFacilities
	{
		get
		{
			return this._HotelRoomFacilities;
		}
		set
		{
			if ((this._HotelRoomFacilities != value))
			{
				this._HotelRoomFacilities = value;
			}
		}
	}
}

public partial class sp_HotelImages_ImagesResult
{
	
	private int _ImageID;
	
	private string _ImageLink;
	
	public sp_HotelImages_ImagesResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageID", DbType="Int NOT NULL")]
	public int ImageID
	{
		get
		{
			return this._ImageID;
		}
		set
		{
			if ((this._ImageID != value))
			{
				this._ImageID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageLink", DbType="VarChar(200)")]
	public string ImageLink
	{
		get
		{
			return this._ImageLink;
		}
		set
		{
			if ((this._ImageLink != value))
			{
				this._ImageLink = value;
			}
		}
	}
}

public partial class sp_HotelReviews_ViewAllByIDResult
{
	
	private int _ReviewID;
	
	private string _ReviewerTitle;
	
	private string _ReviewerComment;
	
	private string _ReviewerName;
	
	private string _ReviewerDate;
	
	private System.Nullable<int> _ReviewerRating;
	
	private int _HotelID;
	
	public sp_HotelReviews_ViewAllByIDResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReviewID", DbType="Int NOT NULL")]
	public int ReviewID
	{
		get
		{
			return this._ReviewID;
		}
		set
		{
			if ((this._ReviewID != value))
			{
				this._ReviewID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReviewerTitle", DbType="VarChar(150)")]
	public string ReviewerTitle
	{
		get
		{
			return this._ReviewerTitle;
		}
		set
		{
			if ((this._ReviewerTitle != value))
			{
				this._ReviewerTitle = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReviewerComment", DbType="VarChar(MAX)")]
	public string ReviewerComment
	{
		get
		{
			return this._ReviewerComment;
		}
		set
		{
			if ((this._ReviewerComment != value))
			{
				this._ReviewerComment = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReviewerName", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
	public string ReviewerName
	{
		get
		{
			return this._ReviewerName;
		}
		set
		{
			if ((this._ReviewerName != value))
			{
				this._ReviewerName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReviewerDate", DbType="VarChar(10)")]
	public string ReviewerDate
	{
		get
		{
			return this._ReviewerDate;
		}
		set
		{
			if ((this._ReviewerDate != value))
			{
				this._ReviewerDate = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReviewerRating", DbType="Int")]
	public System.Nullable<int> ReviewerRating
	{
		get
		{
			return this._ReviewerRating;
		}
		set
		{
			if ((this._ReviewerRating != value))
			{
				this._ReviewerRating = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelID", DbType="Int NOT NULL")]
	public int HotelID
	{
		get
		{
			return this._HotelID;
		}
		set
		{
			if ((this._HotelID != value))
			{
				this._HotelID = value;
			}
		}
	}
}
#pragma warning restore 1591
