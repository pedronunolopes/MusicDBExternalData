using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;
using System.Data.OleDb;
using OutSystems.HubEdition.RuntimePlatform.Db;

namespace OutSystems.NssMusicDBExternalData {

	public class CssMusicDBExternalData: IssMusicDBExternalData
    {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDataSetId"></param>
		/// <param name="ssVersion"></param>
		/// <param name="ssDataSet"></param>
		public void MssGetDataSet(long ssDataSetId, int ssVersion, out RCt_STDataSetRecord ssDataSet) {
			
            object[][] parameteres;
            IDataReader reader;
            int index = 0;

            // define SQL Stored Procedure
            string strSQLCommand = "dbo.pr_STGetDataSet";

            parameteres = new object[][] {
                new object[]{ "DataSetId", DbType.Int32, ssDataSetId},
                new object[]{ "Version", DbType.Int32, ssVersion},
            };

            // initializes list instance
            ssDataSet = new RCt_STDataSetRecord(null);

            try
            {
                // gets the data from database
                reader = GetRecordByStoredProcedure<RCt_STDataSetRecord>(strSQLCommand, parameteres, ssDataSet);

                if (reader.Read())
                    ssDataSet.Read(reader, ref index);

                reader.Close();
            }
            catch (Exception ex)
            {

                log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, ex.Message, "Error", "MusicDBExternalData", "0");

                throw ex;
            }

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved Data Set from MusicDB External database"), "Info", "MusicDBExternalData", "0");

        } // MssGetDataSet


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssArtistId"></param>
        /// <param name="ssDataSetTypeId"></param>
        /// <param name="ssArtistDataSet"></param>
        public void MssGetLatestDataSetByArtist(int ssArtistId, int ssDataSetTypeId, out RCt_STDataSetRecord ssArtistDataSet) {

            object[][] parameteres;
            IDataReader reader;
            int index = 0;

            // define SQL Stored Procedure
            string strSQLCommand = "dbo.pr_MUGetArtistLatestDataSet";

            parameteres = new object[][] {
                new object[]{"ArtistId", DbType.Int32, ssArtistId},
                new object[]{ "DataSetTypeId", DbType.Int32, ssDataSetTypeId},
            };

            // initializes list instance
            ssArtistDataSet = new RCt_STDataSetRecord(null);

            try
            {
                // gets the data from database
                reader = GetRecordByStoredProcedure<RCt_STDataSetRecord>(strSQLCommand, parameteres, ssArtistDataSet);

                if (reader.Read())
                    ssArtistDataSet.Read(reader, ref index);

                reader.Close();
            }
            catch (Exception ex)
            {

                log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, ex.Message, "Error", "MusicDBExternalData", "0");

                throw ex;
            }

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved Artist Data Set from MusicDB External database"), "Info", "MusicDBExternalData", "0");

        } // MssGetLatestDataSetByArtist

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssDataSetId"></param>
        /// <param name="ssVersion"></param>
        /// <param name="ssDataPoints"></param>
        public void MssGetDataPointsByDataSet(long ssDataSetId, int ssVersion, out RLt_STDataPointRecordList ssDataPoints) {
			
            // define SQL Stored Procedure
            string strSQLCommand = "dbo.pr_STGetDataPointsFromDataSet";

            object[][] parameters = new object[][] {
                new object[]{ "DataSetId", DbType.Int32, ssDataSetId},
                new object[]{ "Version", DbType.Int32, ssVersion }
            };

            ssDataPoints = new RLt_STDataPointRecordList();

            // gets the data from database
            GetRecordListByStoredProcedure<RCt_STDataPointRecord>(strSQLCommand, parameters, ssDataPoints);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssDataPoints.Count, ssDataPoints.GetType()), "Info", "MusicDBExternalData", "0");

        } // MssGetDataPointsByDataSet


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssVenueId"></param>
        /// <param name="ssVenueContacts"></param>
        public void MssGetContactByVenue(long ssVenueId, out RLt_VNVenueContactRecordList ssVenueContacts) {
			
            // define SQL Server Command to retrieve data
            string strSQLCommand = String.Format("SELECT t_VNVenueContact.* " +
                                                 "FROM t_VNVenueContact " +
                                                 "WHERE t_VNVenueContact.VenueId = {0}", ssVenueId);

            // initializes list instance
            ssVenueContacts = new RLt_VNVenueContactRecordList();

            // gets the data from database
            GetRecordList<RCt_VNVenueContactRecord>(strSQLCommand, ssVenueContacts);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssVenueContacts.Count, ssVenueContacts.GetType()), "Info", "MusicDBExternalData", "0");

        } // MssGetContactByVenue


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssFestivalId"></param>
        /// <param name="ssFestivalContacts"></param>
        public void MssGetContactByFestival(int ssFestivalId, out RLt_MGFestivalContactRecordList ssFestivalContacts) {
			
            // define SQL Server Command to retrieve data
            string strSQLCommand = String.Format("SELECT t_MGFestivalContact.* " +
                                                 "FROM t_MGFestivalContact " +
                                                 "WHERE t_MGFestivalContact.FestivalId = {0}", ssFestivalId);

            // initializes list instance
            ssFestivalContacts = new RLt_MGFestivalContactRecordList();

            // gets the data from database
            GetRecordList<RCt_MGFestivalContactRecord>(strSQLCommand, ssFestivalContacts);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssFestivalContacts.Count, ssFestivalContacts.GetType()), "Info", "MusicDBExternalData", "0");


        } // MssGetContactByFestival


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssPromoterId"></param>
        /// <param name="ssPromoterContacts"></param>
        public void MssGetContactByPromoter(int ssPromoterId, out RLt_MGPromoterContactRecordList ssPromoterContacts) {
			
            // define SQL Server Command to retrieve data
            string strSQLCommand = String.Format("SELECT t_MGPromoterContact.* " +
                                                 "FROM t_MGPromoterContact " +
                                                 "WHERE t_MGPromoterContact.PromoterId = {0}", ssPromoterId);

            // initializes list instance
            ssPromoterContacts = new RLt_MGPromoterContactRecordList();

            // gets the data from database
            GetRecordList<RCt_MGPromoterContactRecord>(strSQLCommand, ssPromoterContacts);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssPromoterContacts.Count, ssPromoterContacts.GetType()), "Info", "MusicDBExternalData", "0");

        } // MssGetContactByPromoter


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssArtistId"></param>
        /// <param name="ssSocialMediaId"></param>
        /// <param name="ssArtistSocialMedia"></param>
        public void MssGetSocialMediaByArtist(int ssArtistId, int ssSocialMediaId, out RCt_MUArtistSocialMediaRecord ssArtistSocialMedia) {
			
            object[][] parameteres;
            IDataReader reader;
            int index = 0;

            // define SQL Stored Procedure
            string strSQLCommand = "dbo.pr_MUGetArtistSocialMedia";

            parameteres = new object[][] {

                new object[]{"ArtistId", DbType.Int32, ssArtistId},
                new object[]{"SocialMediaId", DbType.Int32, ssSocialMediaId},
            };

            // initializes list instance
            ssArtistSocialMedia = new RCt_MUArtistSocialMediaRecord(null);

            try
            {
                // gets the data from database
                reader = GetRecordByStoredProcedure<RCt_MUArtistSocialMediaRecord>(strSQLCommand, parameteres, ssArtistSocialMedia);

                if (reader.Read())
                    ssArtistSocialMedia.Read(reader, ref index);

                reader.Close();
            }
            catch (Exception ex)
            {

                log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, ex.Message, "Error", "MusicDBExternalData", "0");

                throw ex;
            }

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved Artist Social Media from MusicDB External database"), "Info", "MusicDBExternalData", "0");



        } // MssGetSocialMediaByArtist


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssArtistId"></param>
        /// <param name="ssArtistCorrelation"></param>
        public void MssGetArtistCorrelation(int ssArtistId, out RLt_MUArtistCorrelationRecordList ssArtistCorrelation) {
			
            // define SQL Stored Procedure
            string strSQLCommand = "dbo.pr_MUGetArtistCorrelation";

            object [][] parameters = new object[][] {
                new object[]{"ArtistId", DbType.Int32, ssArtistId},
            };

            ssArtistCorrelation = new RLt_MUArtistCorrelationRecordList();

            // gets the data from database
            GetRecordListByStoredProcedure<RCt_MUArtistCorrelationRecord>(strSQLCommand, parameters, ssArtistCorrelation);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssArtistCorrelation.Count, ssArtistCorrelation.GetType()), "Info", "MusicDBExternalData", "0");

        } // MssGetArtistCorrelation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssArtistId"></param>
        /// <param name="ssSocialMediaId"></param>
        /// <param name="ssDataPointTypeId"></param>
        /// <param name="ssCountryId"></param>
        /// <param name="ssDataPoint"></param>
        public void MssGetSocialMediaDataPointByArtist(int ssArtistId, int ssSocialMediaId, int ssDataPointTypeId, int ssCountryId, out RCt_SMArtistDataPointRecord ssDataPoint) {

            object[][] parameteres;
            IDataReader reader;
            int index = 0;

            // define SQL Stored Procedure
            string strSQLCommand = "dbo.pr_SMGetLatestSocialMediaDataPoint";

            parameteres = new object[][] {

                new object[]{"ArtistId", DbType.Int32, ssArtistId},
                new object[]{"SocialMediaId", DbType.Int32, ssSocialMediaId},
                new object[]{"DataPointTypeId", DbType.Int32, ssDataPointTypeId},
                new object[]{"CountryId", DbType.Int32, ssCountryId}
            };

            // initializes list instance
            ssDataPoint = new RCt_SMArtistDataPointRecord(null);

            try
            {
                // gets the data from database
                reader = GetRecordByStoredProcedure<RCt_SMArtistDataPointRecord>(strSQLCommand, parameteres, ssDataPoint);

                if (reader.Read()) 
                    ssDataPoint.Read(reader, ref index);

                reader.Close();
            } catch (Exception ex) {

                log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, ex.Message, "Error", "MusicDBExternalData", "0");

                throw ex;
            }

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved Social Media Data Point from MusicDB External database"), "Info", "MusicDBExternalData", "0");

        } // MssGetSocialMediaDataPointByArtist


 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssArtistId"></param>
        /// <param name="ssArtistMusicStyle"></param>
        public void MssGetMusicStyleByArtist(int ssArtistId, out RLt_MDMusicStyleRecordList ssArtistMusicStyle) {

            // define SQL Server Command to retrieve data
            string strSQLCommand = String.Format(   "SELECT t_MDMusicStyle.* " +
                                                    "FROM t_MUArtistMusicStyle " +
                                                    "INNER JOIN t_MDMusicStyle ON t_MDMusicStyle.MusicStyleId = t_MUArtistMusicStyle.MusicStyleId "+
                                                    "WHERE ArtistId = {0}", ssArtistId);

            // initializes list instance
            ssArtistMusicStyle = new RLt_MDMusicStyleRecordList();
            
            // gets the data from database
            GetRecordList<RCt_MDMusicStyleRecord>(strSQLCommand, ssArtistMusicStyle);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssArtistMusicStyle.Count, ssArtistMusicStyle.GetType() ), "Info", "MusicDBExternalData", "0");

        } // MssGetMusicStyleByArtist


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssArtistId"></param>
        /// <param name="ssArtistAlbum"></param>
        public void MssGetAlbumByArtist(int ssArtistId, out RLt_MUAlbumRecordList ssArtistAlbum) {
			
            // define SQL Server Command to retrieve data
            string strSQLCommand = String.Format("SELECT t_MUAlbum.* " +
                                                 "FROM t_MUAlbum " +
                                                 "INNER JOIN t_MUArtistAlbum ON t_MUArtistAlbum.AlbumId = t_MUAlbum.AlbumId " +
                                                 "WHERE t_MUArtistAlbum.ArtistId = {0} ORDER BY t_MUAlbum.ReleaseDate DESC", ssArtistId);

            // initializes list instance
            ssArtistAlbum = new RLt_MUAlbumRecordList();

            // gets the data from database
            GetRecordList<RCt_MUAlbumRecord>(strSQLCommand, ssArtistAlbum);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssArtistAlbum.Count, ssArtistAlbum.GetType()), "Info", "MusicDBExternalData", "0");

        } // MssGetAlbumByArtist

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssArtistId"></param>
        /// <param name="ssArtistSong"></param>
        public void MssGetSongByArtist(int ssArtistId, out RLt_MUSongRecordList ssArtistSong) {
			
            // define SQL Server Command to retrieve data
            string strSQLCommand = String.Format("SELECT DISTINCT t_MUSong.* " +
                                                 "FROM t_MUSong " +
                                                 "INNER JOIN t_MUAlbumSong ON t_MUAlbumSong.SongId = t_MUSong.SongId " +
                                                 "INNER JOIN t_MUAlbum ON t_MUAlbumSong.AlbumId = t_MUAlbum.AlbumId " +
                                                 "INNER JOIN t_MUArtistAlbum ON t_MUArtistAlbum.AlbumId = t_MUAlbum.AlbumId " +
                                                 "WHERE t_MUArtistAlbum.ArtistId = {0}", ssArtistId);

            // initializes list instance
            ssArtistSong = new RLt_MUSongRecordList();

            // gets the data from database
            GetRecordList<RCt_MUSongRecord>(strSQLCommand, ssArtistSong);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssArtistSong.Count, ssArtistSong.GetType()), "Info", "MusicDBExternalData", "0");


        } // MssGetSongByArtist

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssArtistId"></param>
        /// <param name="ssArtistEvent"></param>
        public void MssGetEventByArtist(int ssArtistId, out RLt_MUEventRecordList ssArtistEvent) {

            // define SQL Server Command to retrieve data
            string strSQLCommand = String.Format("SELECT t_MUEvent.* " +
                                                 "FROM t_MUEvent " +
                                                 "INNER JOIN t_MUArtistEvent ON t_MUArtistEvent.EventId = t_MUEvent.EventId " +
                                                 "WHERE t_MUArtistEvent.ArtistId = {0} ORDER BY t_MUEvent.Date DESC", ssArtistId);

            // initializes list instance
            ssArtistEvent = new RLt_MUEventRecordList();

            // gets the data from database
            GetRecordList<RCt_MUEventRecord>(strSQLCommand, ssArtistEvent);

            log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, string.Format("Retrieved {0} of {1} from MusicDB External database", ssArtistEvent.Count, ssArtistEvent.GetType()), "Info", "MusicDBExternalData", "0");

        } // MssGetEventByArtist

        // Retrieve the DatabaseProvider for the external database.
        DatabaseProvider dbaProvider = DatabaseAccess.ForExternalDatabase("MusicDB");
        //DatabaseProvider dbaProvider = null;
        OutSystems.HubEdition.RuntimePlatform.Log.GeneralLog log = new OutSystems.HubEdition.RuntimePlatform.Log.GeneralLog();

        private void GetRecordList<T>(String sqlCommand, OSList<T> list)
        {
            OSList<T> auxList = (OSList<T>)Helper.ReflectionHelper.CreateInstance(list.GetType());

            /*
            OleDbDataReader dataReader;
            string connectionString = "Provider=SQLOLEDB.1;Password=a6Intruder;Persist Security Info=True;User ID=pedrolopes;Initial Catalog=MusicDB;Data Source=musicdb.c0d9wnivbgn8.eu-central-1.rds.amazonaws.com";
            System.Data.OleDb.OleDbConnection oleDbConnection = new System.Data.OleDb.OleDbConnection(connectionString);
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command =new OleDbCommand(sqlCommand, connection);
            connection.Open();
            dataReader = command.ExecuteReader();
            */

            try
            {

                using (CommittableTransaction commitableTransaction = dbaProvider.GetCommittableTransaction())
                {
                    using (Command cmd = commitableTransaction.CreateCommand(sqlCommand))
                    {
                        // Results are read using a standard IDataReader object
                        using (IDataReader dataReader = cmd.ExecuteReader())
                        {

                            auxList.Reader = dataReader;

                            auxList.StartIteration();

                            while (!auxList.Eof)
                            {
                                auxList.Read();

                                list.Data.Add(auxList.CurrentRec);
                                auxList.Advance();
                            }
                            auxList.CloseDataReader();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, ex.Message, "Error", "MusicDBExternalData", "0");

                throw ex;
            }
        }

        private void GetRecordListByStoredProcedure<T>(String storedProcedure, object[][] parameters, OSList<T> list)
        {
            OSList<T> auxList = (OSList<T>)Helper.ReflectionHelper.CreateInstance(list.GetType());

            /*
            OleDbDataReader dataReader;
            string connectionString = "Provider=SQLOLEDB.1;Password=a6Intruder;Persist Security Info=True;User ID=pedrolopes;Initial Catalog=MusicDB;Data Source=musicdb.c0d9wnivbgn8.eu-central-1.rds.amazonaws.com";
            System.Data.OleDb.OleDbConnection oleDbConnection = new System.Data.OleDb.OleDbConnection(connectionString);
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command =new OleDbCommand(sqlCommand, connection);
            connection.Open();
            dataReader = command.ExecuteReader();
            */

            try
            {

                using (CommittableTransaction commitableTransaction = dbaProvider.GetCommittableTransaction())
                {
                    using (Command cmd = commitableTransaction.CreateCommand(storedProcedure))
                    {
                        cmd.GetDriverCommand().CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                        {
                            foreach (object[] parameter in parameters)
                            {
                                /*
                                OleDbParameter parameterInstance = cmd.CreateParameter();
                                parameterInstance.ParameterName = parameter[0].ToString();
                                parameterInstance.OleDbType = (OleDbType)parameter[1];
                                parameterInstance.Value = parameter[2].ToString();
                                cmd.Parameters.Add(parameterInstance);
                                */

                                cmd.CreateParameter(parameter[0].ToString(), (DbType)parameter[1], parameter[2].ToString());

                            }
                        }

                        // Results are read using a standard IDataReader object
                        using (IDataReader dataReader = cmd.ExecuteReader())
                        {

                            auxList.Reader = dataReader;

                            auxList.StartIteration();

                            while (!auxList.Eof)
                            {
                                auxList.Read();

                                list.Data.Add(auxList.CurrentRec);
                                auxList.Advance();
                            }
                            auxList.CloseDataReader();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, ex.Message, "Error", "MusicDBExternalData", "0");

                throw ex;
            }
        }

        private IDataReader GetRecordByStoredProcedure<T>(String storedProcedure, object[][] parameters, T record)
        {
            //T auxList = (T)Helper.ReflectionHelper.CreateInstance(record.GetType());
            //((ITypedRecord<T>)auxList).FillFromOther((ITypedRecord<T>)record);


            //OleDbDataReader dataReader;
            //string connectionString = "Provider=SQLOLEDB.1;Password=a6Intruder;Persist Security Info=True;User ID=pedrolopes;Initial Catalog=MusicDB;Data Source=musicdb.c0d9wnivbgn8.eu-central-1.rds.amazonaws.com";
            //System.Data.OleDb.OleDbConnection oleDbConnection = new System.Data.OleDb.OleDbConnection(connectionString);
            //OleDbConnection connection = new OleDbConnection(connectionString);
            //OleDbCommand cmd =new OleDbCommand(storedProcedure, connection);
            //cmd.CommandType = CommandType.StoredProcedure;

            CommittableTransaction commitableTransaction = dbaProvider.GetCommittableTransaction();
            Command cmd = commitableTransaction.CreateCommand(storedProcedure);
            cmd.GetDriverCommand().CommandType = CommandType.StoredProcedure;

            if (parameters != null)
            {
                foreach (object[] parameter in parameters)
                {
                    /*
                    OleDbParameter parameterInstance = cmd.CreateParameter();
                    parameterInstance.ParameterName = parameter[0].ToString();
                    parameterInstance.OleDbType = (OleDbType)parameter[1];
                    parameterInstance.Value = parameter[2].ToString();
                    cmd.Parameters.Add(parameterInstance);
                    */

                    cmd.CreateParameter(parameter[0].ToString(), (DbType)parameter[1], parameter[2].ToString());

                }
            }

            /*
            connection.Open();
            */

            try
            {
                // Results are read using a standard IDataReader object

                return cmd.ExecuteReader();

                //    using (IDataReader dataReader = cmd.ExecuteReader())
                //    {
                //        if (dataReader.Read())
                //        {
                //    RCt_SMArtistDataPointRecord data = new RCt_SMArtistDataPointRecord();
                //    //int index = 0;
                //    //data.Read(dataReader, ref index);

                //    Helper.ReflectionHelper.ExecuteMethod(data, "Read", new object[] { dataReader, 0 });

                //            //((ITypedRecord<T>)record).dataReader);
                //            //((ITypedRecord<T>)record).InternalRecursiveSave();s
                //            //((ITypedRecord<T>)record).FillFromOther((ITypedRecord<T>)auxList);
                //}
                //    }
                /*}
            }*/
            }
            catch (Exception ex)
            {
                log.Write(System.DateTime.Now, AppInfo.GetAppInfo().OsContext.Session.SessionID, AppInfo.GetAppInfo().eSpaceId, AppInfo.GetAppInfo().Tenant.Id, AppInfo.GetAppInfo().OsContext.Session.UserId, ex.Message, "Error", "MusicDBExternalData", "0");

                throw ex;
            }
        }

    } // CssMusicDBExternalData

} // OutSystems.NssMusicDBExternalData

