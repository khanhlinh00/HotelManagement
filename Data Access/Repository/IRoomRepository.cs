using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Data_Access.Repository
{
    public interface IRoomRepository
    {
        RoomObject GetRoomByID(int roomID);
        IEnumerable<RoomObject> GetRooms();
        RoomTypeObject GetRoomTypeByID(int roomTypeID);
        void InsertRoom(RoomObject room);
        void DeleteRoom(int roomID);
        void UpdateRoom(RoomObject room);
    }
}
