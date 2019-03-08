using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using System.Web;



namespace DataAccess.DataAccess
{
    public class Event
    {
        GsuEventsDBEntities g = new GsuEventsDBEntities();

        public  List<EventModel> GetEvents(EventModel model)
        {
            var eventObjList = new List<EventModel>();

            try
            {


                var geteventsObject = (from e in g.EventsTables
                                       where e.isDelete == 0
                                       select new

                                       {
                                           e.EventID,
                                           e.EventTitle,
                                           e.EventDate,
                                           e.EventLocation,
                                           e.EventImage,
                                       }).ToList();
                foreach (var item in geteventsObject)
                {
                    var geteventdetailsobject = new EventModel();

                    geteventdetailsobject.EventID = item.EventID;
                    geteventdetailsobject.EventDate = item.EventDate;
                    geteventdetailsobject.EventImage = item.EventImage;
                    geteventdetailsobject.EventLocation = item.EventLocation;
                    geteventdetailsobject.EventTitle = item.EventTitle;

                    eventObjList.Add(geteventdetailsobject);

                }

            }
            catch (Exception ex)
            {
                string d = ex.Message;
            }
            //return Json(new
            //{
            //    list = retval
            //}, JsonRequestBehavior.AllowGet);

            return eventObjList;
        }
        public List<SearchModel> SearchEvents(string query = "")
        {
            var getAllEventsList = new List<SearchModel>();
            try
            {
                #region commented
                //g.Configuration.ProxyCreationEnabled = false;
                //var geteventsObj = (from e in g.EventsTables
                //                    .Where(et => et.EventTitle.Contains(query))
                //                    select new
                //                    {
                //                        e.EventID,
                //                        e.EventTitle
                //                    }).ToList();
                //foreach (var item in geteventsObj)
                //{
                //    var getalleventsobj = new SearchModel();


                //    getalleventsobj.EventTitle = item.EventTitle;
                //    getalleventslist.Add(getalleventsobj);
                //}
                //getalleventslist = String.IsNullOrEmpty(query) ? g.EventsTables.ToList() :
                //g.EventsTables.Where(p => p.EventTitle.Contains(query)).ToList();



                //if (String.IsNullOrEmpty(query))
                //{
                //    getalleventslist = g.EventsTables.Select(t=>t.EventTitle).ToList();

                //}
                //else
                //{
                //    getalleventslist = g.EventsTables.Where(p => p.EventTitle.Contains(query)).Select(t => t.EventTitle).ToList();
                //}
                #endregion

                if (String.IsNullOrEmpty(query))
                {
                    var geteventsObj = (from e in g.EventsTables
                                        select new
                                        {
                                            e.EventID,

                                            e.EventTitle
                                        }).ToList();
                    foreach (var item in geteventsObj)
                    {
                        var searchModelObj = new SearchModel();


                        searchModelObj.EventId = item.EventID;
                        searchModelObj.EventTitle = item.EventTitle;

                        getAllEventsList.Add(searchModelObj);
                    }

                }
                else
                {

                    var geteventsObj = (from e in g.EventsTables
                                                .Where(et => et.EventTitle.Contains(query))
                                        where e.isDelete == 0
                                        select new
                                        {
                                            e.EventID,

                                            e.EventTitle
                                        }).ToList();
                    foreach (var item in geteventsObj)
                    {
                        var searchModelObj = new SearchModel();


                        searchModelObj.EventId = item.EventID;
                        searchModelObj.EventTitle = item.EventTitle;

                        getAllEventsList.Add(searchModelObj);
                    }
                }

            }


            catch (Exception ex)
            {
                string d = ex.Message;
            }
            return getAllEventsList;
        }
        public List<EventModel> SearchResults(string query = "")
        {
            var getAllEventsList = new List<EventModel>();
            try
            {
                #region commented
                //g.Configuration.ProxyCreationEnabled = false;
                //var geteventsObj = (from e in g.EventsTables
                //                    .Where(et => et.EventTitle.Contains(query))
                //                    select new
                //                    {
                //                        e.EventID,
                //                        e.EventTitle
                //                    }).ToList();
                //foreach (var item in geteventsObj)
                //{
                //    var getalleventsobj = new SearchModel();


                //    getalleventsobj.EventTitle = item.EventTitle;
                //    getalleventslist.Add(getalleventsobj);
                //}
                //getalleventslist = String.IsNullOrEmpty(query) ? g.EventsTables.ToList() :
                //g.EventsTables.Where(p => p.EventTitle.Contains(query)).ToList();



                //if (String.IsNullOrEmpty(query))
                //{
                //    getalleventslist = g.EventsTables.Select(t=>t.EventTitle).ToList();

                //}
                //else
                //{
                //    getalleventslist = g.EventsTables.Where(p => p.EventTitle.Contains(query)).Select(t => t.EventTitle).ToList();
                //}
                #endregion

                if (String.IsNullOrEmpty(query))
                {
                    var geteventsObj = (from e in g.EventsTables

                                        select new
                                        {
                                            e.EventImage,
                                            e.EventTitle,
                                            e.EventDate,
                                            e.EventID,
                                            e.EventLocation
                                        }
                             ).ToList();
                    foreach (var item in geteventsObj)
                    {
                        var searchModelObj = new EventModel();


                        searchModelObj.EventID = item.EventID;
                        searchModelObj.EventTitle = item.EventTitle;
                        searchModelObj.EventDate = item.EventDate;
                        searchModelObj.EventLocation = item.EventLocation;
                        searchModelObj.EventImage = item.EventImage;



                        getAllEventsList.Add(searchModelObj);
                    }

                }
                else
                {

                    var geteventsObj = (from e in g.EventsTables

                                                .Where(et => et.EventTitle.Contains(query) || et.EventType.Contains(query))
                                        where e.isDelete == 0
                                        select new
                                        {
                                            e.EventImage,
                                            e.EventTitle,
                                            e.EventDate,
                                            e.EventID,
                                            e.EventLocation
                                        }).ToList();
                    foreach (var item in geteventsObj)
                    {
                        var searchModelObj = new EventModel();


                        searchModelObj.EventID = item.EventID;
                        searchModelObj.EventTitle = item.EventTitle;
                        searchModelObj.EventDate = item.EventDate;
                        searchModelObj.EventLocation = item.EventLocation;
                        searchModelObj.EventImage = item.EventImage;

                        getAllEventsList.Add(searchModelObj);
                    }
                }

            }


            catch (Exception ex)
            {
                string d = ex.Message;
            }
            return getAllEventsList;
        }
        public List<AdminModel> GetEventType(string query = "")
        {
            var getAllEventsList = new List<AdminModel>();
            try
            {


                if (String.IsNullOrEmpty(query))
                {
                    var geteventsObj = (from e in g.EventTypes

                                        select new
                                        {
                                            e.EventTypes,
                                            e.EventTypeID,
                                        }).ToList();
                    foreach (var item in geteventsObj)
                    {
                        var searchModelObj = new AdminModel();


                        searchModelObj.EventType = item.EventTypes;
                        searchModelObj.EventTypeID = item.EventTypeID;



                        getAllEventsList.Add(searchModelObj);
                    }

                }
                else
                {

                    var geteventsObj = (from e in g.EventTypes
                                                .Where(et => et.EventTypes.Contains(query))
                                        select new
                                        {
                                            e.EventTypes,
                                            e.EventTypeID,

                                        }).ToList();
                    foreach (var item in geteventsObj)
                    {
                        var searchModelObj = new AdminModel();


                        searchModelObj.EventType = item.EventTypes;
                        searchModelObj.EventTypeID = item.EventTypeID;



                        getAllEventsList.Add(searchModelObj);
                    }
                }

            }


            catch (Exception ex)
            {
                string d = ex.Message;
            }
            return getAllEventsList;
        }
    }


}
