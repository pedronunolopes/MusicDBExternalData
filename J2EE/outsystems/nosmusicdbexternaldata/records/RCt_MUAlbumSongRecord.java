package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MUAlbumSongRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUAlbumSongRecord> {

	private static final GlobalObjectKey Idt_MUAlbumSong = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*BOWS7SMzLpRtctfzNNJ1jA");

	public static void ensureInitialized() {}
	public ENt_MUAlbumSongEntityRecord ssENt_MUAlbumSong;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUAlbumSongEntityRecord toStructure() {
		return ssENt_MUAlbumSong;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUAlbumSongRecord(ENt_MUAlbumSongEntityRecord r) throws Exception {
		ssENt_MUAlbumSong = (ENt_MUAlbumSongEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUAlbumSong.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUAlbumSong.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUAlbumSongRecord() {
		OptimizedAttributes = null;
		ssENt_MUAlbumSong = new ENt_MUAlbumSongEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(4, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUAlbumSong.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUAlbumSong.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUAlbumSong.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MUAlbumSong.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MUAlbumSongRecord r) throws Exception {
		this.ssENt_MUAlbumSong = (ENt_MUAlbumSongEntityRecord) r.ssENt_MUAlbumSong.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MUAlbumSongRecord)) {
			return false;
		}
		RCt_MUAlbumSongRecord b = (RCt_MUAlbumSongRecord) obj;
		if (!this.ssENt_MUAlbumSong.equals(b.ssENt_MUAlbumSong)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MUAlbumSong.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUAlbumSong.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUAlbumSong.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUAlbumSongRecord duplicate() throws Exception {
		RCt_MUAlbumSongRecord t = new RCt_MUAlbumSongRecord();
		t.ssENt_MUAlbumSong = (ENt_MUAlbumSongEntityRecord) this.ssENt_MUAlbumSong.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MUAlbumSong.toXml(this, recordElem, "t_MUAlbumSong", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mualbumsong")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUAlbumSong")) variable.setValue(ssENt_MUAlbumSong); else variable.setOptimized(true);
			variable.setFieldName("t_mualbumsong");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUAlbumSongRecord t = (RCt_MUAlbumSongRecord) super.clone();
		t.ssENt_MUAlbumSong = (ENt_MUAlbumSongEntityRecord) this.ssENt_MUAlbumSong.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUAlbumSong.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUAlbumSong.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUAlbumSong)) {
			return ssENt_MUAlbumSong;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUAlbumSong.fillFromOther((IRecord) other.attributeGet(Idt_MUAlbumSong));
	}
}
